import { Component, OnInit } from '@angular/core';
import { AdminService } from 'src/app/_services/admin.service';

@Component({
  selector: 'app-traningplans-management',
  templateUrl: './traningplans-management.component.html',
  styleUrls: ['./traningplans-management.component.css']
})
export class TraningPlansManagementComponent implements OnInit {
  //plans: Photo[];

  constructor(private adminService: AdminService) { }

  ngOnInit(): void {
    this.getPhotosForApproval();
  }

  getPhotosForApproval() {
    // this.adminService.getPhotosForApproval().subscribe(photos => {
    //   this.photos = photos;
    // })
  }

  approvePhoto(photoId) {
  //   this.adminService.approvePhoto(photoId).subscribe(() => {
  //     this.photos.splice(this.photos.findIndex(p => p.id === photoId), 1);
  //   })
  }

  rejectPhoto(photoId) {
    // this.adminService.rejectPhoto(photoId).subscribe(() => {
    //   this.photos.splice(this.photos.findIndex(p => p.id === photoId), 1);
    // })
    return;
  }
}
