import { Component, OnInit, Inject } from '@angular/core';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material';
import {
  MatSnackBar,
  MatSnackBarConfig,
  MatSnackBarHorizontalPosition,
  MatSnackBarVerticalPosition,
} from '@angular/material';

export interface DialogData {
  action: '';
}

@Component({
  selector: 'app-accountsummary',
  templateUrl: './accountsummary.component.html',
  styleUrls: ['./accountsummary.component.css']
})

export class AccountsummaryComponent implements OnInit {

  horizontalPosition: MatSnackBarHorizontalPosition = 'center';
  verticalPosition: MatSnackBarVerticalPosition = 'top';

  constructor(public dialog: MatDialog, public snackBar: MatSnackBar) { }

  openDialog(): void {
    const dialogRef = this.dialog.open(DialogDataExampleDialog, {
      data: {
        action: ''
      }
    });

    dialogRef.afterClosed().subscribe(result => {
      if(result == true)
      {
        this.openSnackBar("Traferred $2000 from Chase to Credit Union Savings", "View Details");
      }
    });
    
  }

  openSnackBar(message: string, action: string) {
    var config = this._createConfig();
    this.snackBar.open(message, action, config);
  }
  ngOnInit() {
    setTimeout(() => this.openDialog(), 2000);
  }

    private _createConfig() {
    const config = new MatSnackBarConfig();
    config.verticalPosition = this.verticalPosition;
    config.horizontalPosition = this.horizontalPosition;
    config.duration = 5000;
    return config;
  }
}

@Component({
  selector: 'dialog-data-example-dialog',
  templateUrl: 'dialog-data-example-dialog.html',
})
export class DialogDataExampleDialog {
  constructor(@Inject(MAT_DIALOG_DATA) public data: DialogData) {}
}

