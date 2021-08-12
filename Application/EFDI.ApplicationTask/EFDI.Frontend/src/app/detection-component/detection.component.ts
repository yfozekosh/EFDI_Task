import {Component, OnInit} from '@angular/core';
import {DetectionService} from "../../services/detection.service";
import {Observable} from "rxjs";
import {IDetectionResult} from "../../services/model/IDetectionResult";
import {tap} from "rxjs/operators";

@Component({
  selector: 'app-detection',
  templateUrl: './detection.component.html',
  styleUrls: ['./detection.component.scss']
})
export class DetectionComponent{

  constructor(private detectionService: DetectionService) {
  }

  isLoading = false;
  isDetectedAlready = false;
  result$: Observable<IDetectionResult>|null = null;

  startDetection(){
    this.isLoading = true;
    this.result$ = this.detectionService.detect().pipe(
      tap(()=>this.isLoading = false),
      tap(()=>this.isDetectedAlready = true)
    );
  }
}
