using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PropertyPortfolio.Database;
using PropertyPortfolio.Models;
using PropertyPortfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPortfolio.Controllers
{
    public class FileUploadController : Controller
    {
        private PropertyPortfolioDbContext _dbContext;

        public FileUploadController(PropertyPortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult LoadFile()
        {
            return PartialView();
        }

        public async Task<IActionResult> UploadFileAsync(IFormFile file)
        {
            var viewModel = new UploadFileAsyncViewModel();

            if ((file?.Length ?? 0) > 0)
            {
                using (var stream = new MemoryStream())
                {
                    try
                    {
                        await file.CopyToAsync(stream);
                        var byteArray = stream.ToArray();
                        string jsonString = Encoding.UTF8.GetString(byteArray);

                        var jsonSettings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var propertyOwnersList = JsonConvert.DeserializeObject<IEnumerable<Owner>>(jsonString, jsonSettings);

                        propertyOwnersList.ToList().ForEach(owner =>
                        {
                            _dbContext.Owners.Add(owner);
                            var properties = owner.Properties?.Where(property => property != null);
                            if (properties?.Any() ?? false)
                                _dbContext.Properties.AddRange(properties);

                            return;
                        });

                        await _dbContext.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        viewModel.Message = "There was an error loading your file. Please check your file and try again.";
                        return View(viewModel);
                    }

                    viewModel.Message = "File loaded successfully";
                }
            }
            else
            {
                viewModel.Message = "There was an error loading your file. It appears it was empty. Please try again.";
            }

            return View(viewModel);
        }
    }
}

