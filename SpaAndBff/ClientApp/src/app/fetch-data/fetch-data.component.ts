import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[] = [];

  public unauthorised: boolean = false;

  constructor(http: HttpClient) {
    http.get<WeatherForecast[]>('/api/weatherforecast/usa').subscribe(result => {
      this.forecasts = result;
    }, error => {
      console.error(error)
      this.unauthorised = (error.status == 401);
    });
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
