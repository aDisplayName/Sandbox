import { Drone } from './classes/Drone.js';
import { Car } from './classes/car.js';
import {fleet} from './fleet-data.js';

import {FleetDataService} from './services/fleet-data-service.js';

let dataService = new FleetDataService();;

dataService.loadData(fleet);

console.log(dataService.cars);
console.log(dataService.drones);