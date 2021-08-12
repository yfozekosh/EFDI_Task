import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {IDetectionResult} from "./model/IDetectionResult";
import {environment} from "../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class DetectionService {
  constructor(private http:HttpClient) { }

  detect(){
    return this.http.get<IDetectionResult>(environment.api.detect);
  }
}
