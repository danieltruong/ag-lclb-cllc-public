import { Component, OnInit } from '@angular/core';
import { UserDataService } from '../services/user-data.service';
import { User } from '../models/user.model';
import { Router } from '@angular/router';
import { AdoxioApplication } from '../models/adoxio-application.model';
import { DynamicsDataService } from '../services/dynamics-data.service';
import { AdoxioApplicationDataService } from '../services/adoxio-application-data.service';
import { DynamicsAccount } from '../models/dynamics-account.model';
import { Subscription } from 'rxjs';
import { MatSnackBar } from '@angular/material';
import { PaymentDataService } from '../services/payment-data.service';

@Component({
  selector: 'app-dashboard-lite',
  templateUrl: './dashboard-lite.component.html',
  styleUrls: ['./dashboard-lite.component.scss']
})
export class DashboardLiteComponent implements OnInit {
  public currentUser: User;
  applicationId: string;
  submittedApplications = 8;

  contactId: string = null;
  account: DynamicsAccount;
  busy: Subscription;
  isPaid: Boolean;
  orgType = '';

  constructor(private paymentDataService: PaymentDataService,
    private userDataService: UserDataService, private router: Router,
    private dynamicsDataService: DynamicsDataService,
    private applicationDataService: AdoxioApplicationDataService,
    public snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.userDataService.getCurrentUser()
      .subscribe((data) => {
        this.currentUser = data;
        if (this.currentUser.accountid != null) {
          // fetch the account to get the primary contact.
          this.dynamicsDataService.getRecord('account', this.currentUser.accountid)
            .then((result) => {
              this.account = result;
              if (result.primarycontact) {
                this.contactId = result.primarycontact.id;
              }
            });
        }

      });

    this.applicationDataService.getSubmittedApplicationCount()
      .subscribe(value => this.submittedApplications = value);
  }

  verify_payment() {
    const newLicenceApplicationData: AdoxioApplication = new AdoxioApplication();
    newLicenceApplicationData.licenseType = 'Cannabis Retail Store';
    newLicenceApplicationData.applicantType = this.account.businessType;
    newLicenceApplicationData.account = this.account;
    // newLicenceApplicationData. = this.account.businessType;
    this.busy = this.applicationDataService.createApplication(newLicenceApplicationData).subscribe(
      data => {
        this.busy = this.paymentDataService.getPaymentSubmissionUrl(data.id).subscribe(
          res2 => {
            // console.log("applicationVM: ", res.json());
            const jsonUrl = res2.json();
            // window.alert(jsonUrl['url']);
            window.location.href = jsonUrl['url'];
            return jsonUrl['url'];
          },
          err => {
            if (err._body === 'Payment already made') {
              this.snackBar.open('Application payment has already been made.', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
            }
          }
        );

        // this.router.navigate(['./payment-confirmation'], { queryParams: { trnId: '0', SessionKey: data.id } });
      },
      err => {
        this.snackBar.open('Error starting a New Licence Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        console.log('Error starting a New Licence Application');
      }
    );

  }

  startNewLicenceApplication() {
    const newLicenceApplicationData: AdoxioApplication = new AdoxioApplication();
    newLicenceApplicationData.licenseType = 'Cannabis Retail Store';
    newLicenceApplicationData.applicantType = this.account.businessType;
    newLicenceApplicationData.account = this.account;
    // newLicenceApplicationData. = this.account.businessType;
    this.busy = this.applicationDataService.createApplication(newLicenceApplicationData).subscribe(
      data => {
        this.router.navigateByUrl(`/application-lite/${data.id}`);
      },
      err => {
        this.snackBar.open('Error starting a New Licence Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        console.log('Error starting a New Licence Application');
      }
    );
  }
}
