# Garden app

This app is currently being built. See design details below.


## Purpose

Simple app to browse plants and create garden bed layouts.


## Solution design


### MVP Interaction & design

[Wireframe](https://www.figma.com/file/tDk4BRcOShfWNHwuEjyes3/Garden-Planner?node-id=520369%3A448) 

Create crop & pick plants



* Create a crop with a name
* Browse plant varieties & add to your crop

Create plant layout



* Select crop & add a planter
* Configure the planter width, length & spacing
* Add multiple planters
* Drag plant varieties into planters to create new plant of that variety
* Plants can be moved around planter or to a different planter

Plant card



* Name, plant icon, key detail icons (sun, water)
* Click/hover to view details


### App architecture


#### Stack



* React with TypeScript
* Material UI
* ASP.NET Core Web API (minimal APIs)
* EF Core & SQLite


### Data

[Garden Planner database design](https://drive.google.com/file/d/1___WQJpqT3beHAby9FgixBh5axsCkioZ/view?usp=sharing) 

[Garden Planner API routes](https://docs.google.com/spreadsheets/d/1EYl1suNdnGm_1IL6kdZN7sBUdS-EN8I4Rt9J8dTAD74/edit#gid=0) 


### Post MVP



* Add user authentication & authorization for both Client & Backend
* Add tests
* Design update (theme & styles)
* Handle error on state updates
* Routing
* Mobile & tablet layouts

Refs

[https://www.freepik.com/free-vector/vegan-food-icon-set_1229133.htm](https://www.freepik.com/free-vector/vegan-food-icon-set_1229133.htm)
