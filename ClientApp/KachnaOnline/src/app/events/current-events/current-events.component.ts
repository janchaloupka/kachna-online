import { EventsService } from './../../shared/services/events.service';
import { Component, OnInit } from '@angular/core';
import { EventFormComponent } from "../event-form/event-form.component";

@Component({
  selector: 'app-current-events',
  templateUrl: './current-events.component.html',
  styleUrls: ['./current-events.component.css']
})
export class CurrentEventsComponent implements OnInit {

  constructor(public eventsService: EventsService) { }

  ngOnInit(): void {
    //this.eventsService.getCurrentEvents();
  }

}