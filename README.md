# Garden app

# Purpose:

This app is for planning out garden beds, focusing on editable plants.

- Selecting plant varieties for crops
- Planning garden out the garden
- Maintaining plants during growing season

## MVP Features

### Selecting plants for crop

- Set planned season
  - Suggest start date, but is configurable by user + can be overridden per plant
  - Allow for 'right now' style too (good for new users/beginners)
- Browse different things you can plant
- Highlight good suggestions
  - Configure 'zone' and season of user
- Create 'wishlist' of things that will be planted, for use in next step

### Planning garden space

- Determine planting space(s)
- Set the size of garden bed & light level or add pots
- Drag and drop from this season to your planting spaces
  - Plants will have a recommended spacing & pot size
  - Garden bed is a grid system
- Once in wishlist, allow user to customise data about plants
  - Upload and share data
- Choose if grown from seed or seedlings
- Grow from seed planning
  - Optimal time to sow seeds
  - Seed care (heat, moisture, etc)
  - When to transplant

## Future plans

### Planting

Third step is to plant:

- Create shopping list
  - Pots, soil, plants etc
- Access data for specific planting/seed raising
- Calendar for season crop
  - When to plant, sow seeds etc
  - expected fruiting date etc
- Suggested fertilizer schedule

### Monitoring

- Collect weather data and monitor crop watering
  - I.e. it's been hot this week, water the plants more than usual
  - Or, Temp is going to be over X, consider shading these plants
- Integrated IoT watering
  - Monitoring rain + water from system

### Future UI considerations

- App support
- Notification events for maintenance

# Solution design

## Interaction & design

Create crop & pick plants

- Create a crop (name)
- Browse plant varieties & add - changes will be auto saved

Create plant layout

- Select crop & add planter
- Drag plant varieties to planters
- Input size & spacing for planters
- Multiple planters
- Edits will be manually saved
  - Save original state when editing
  - save -> push to server
  - cancel -> revert to original state

Plant modal

- Click to view details
- In planter, click to delete

## Database

https://drive.google.com/file/d/1___WQJpqT3beHAby9FgixBh5axsCkioZ/view?usp=sharing

## Post MVP

- Add user authentication & authorization
- Add tests
- Handle error on state updates
- Mobile layout

## App architecture

### Stack

- React
  - [React - TypeScript: Documentation](https://www.typescriptlang.org/docs/handbook/react.html)
  - [React DnD](https://react-dnd.github.io/react-dnd/)
  - Global state - ?
- Material UI
- ASP.NET Core Web API (minimal APIs)
  - [Tutorial: Create a minimal web API with ASP.NET Core | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0&tabs=visual-studio)
- [EF Core](https://docs.microsoft.com/en-us/ef/core/) & SQLite
  - [EF Core tools reference (.NET CLI)](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)

## TODO

Refs

[https://www.freepik.com/free-vector/vegan-food-icon-set_1229133.htm](https://www.freepik.com/free-vector/vegan-food-icon-set_1229133.htm)
