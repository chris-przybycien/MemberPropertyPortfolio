import { Component } from '@angular/core';

import Owner from './shared/owner';
import ApiPropertyPortfolioService from './shared/api.propertyportfolio.service';
import FormattedOwner from './shared/formattedOwner';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Angular';

  owners: Array<Owner>;
  formattedOwners: Array<FormattedOwner>;

  constructor(private apiPropertyPortfolioService: ApiPropertyPortfolioService) {
  }

  ngOnInit() {
    this.apiPropertyPortfolioService.getAll().subscribe(data => {
      this.owners = data;

      // Format the owners into flat object array
      var newFormattedOwners = new Array<FormattedOwner>();

      this.owners.map(function (owner) {
        owner.properties.map(function (property) {
          var newOwner = new FormattedOwner();
          newOwner.name = owner.name;
          newOwner.age = owner.age;
          newOwner.gender = owner.gender;
          newOwner.propertyName = property.name;
          newOwner.propertyType = property.type;

          newFormattedOwners.push(newOwner);

          return;
        });
      });

      this.formattedOwners = newFormattedOwners;
    });
  }
}
