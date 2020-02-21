Running the WebApp
==================
Install latest version of Node.js
Run the following command in Powershell/Command Prompt
	npm install -g @angular/cli
Navigate to the PropertyPortfolio folder
Rename Angular.App to Angular
In Powershell/Command Prompt, navigate to PropertyPortfolio/Angular folder and run the following commands
	npm install
	ng build
	ng serve --liveReload=false

Open Visual Studio (solution created in V2017)
Load the solution file OwnerPropertyPortfolio.sln
In Solution Explorer, Click Show All Files
Find the Angular Folder in the PropertyPortfolio project, right click and include in project
Go to Debug -> Run without debugging (Note, if the build fails, run this step again.
The web app should open in a browser.

Using the WebApp
================
There are 2 pages, One for loading files where you are able to select a file and then 
load it into the webapp and the other page is for displaying the owner properties list


Things I would have done differently
====================================
Unfortunately I was not able to complete this task to the standard I would have liked it to have been.
I ran out of time so I didnt complete the filtering of the results. I also didnt have enough time to
style the pages to make them responsive and visually appealing.

If i could go back and do it again, I would make it a single page application rather than multi-page
for ease of use. I would also write unit tests to test all of my methods and go through and clean up any 
unrequired code out of the solution. Finally I would also split out any database operations into a
service class rather than having them in the controller. Having a log in would also have been a nice to
have as this would likely be a secured data portal in the real world.