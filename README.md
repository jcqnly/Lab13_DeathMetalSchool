# Lab13 School Enrollment
School enrollment system for the Cradle Of Filth Death Metal School

---
## Objective
Create a ASP.NET Core student enrollment web app.  
[Visit the deployed Site](http://deathmetalschool.azurewebsites.net).

---
## Overview
This app was built using insights from this [tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-2.1&tabs=aspnetcore2x).
The Cradle Of Filth Death Metal School Enrollment app is a loving 
take on a student enrollment system.  Currently, the site displays 
all the courses and a search bar allows a user to search for courses. 
Additionally, one can add courses, update a course info and delete 
a course.

---
## Dependencies
This application runs on .NET Core 2.1, which can be downloaded [here](https://www.microsoft.com/net/download/macos).

---
## Build
To build this app locall, install the [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/macos), and clone this repo onto your machine. 
From a terminal interface, go to where this was cloned and type the following commands:

```
cd Lab13_DeathMetalSchool
dotnet restore
dotnet run
```
Building the app is not necessary because it has been [deployed](http://deathmetalschool.azurewebsites.net).


---
## Walk Through
The [Landing Page](http://useartisanalapi.azurewebsites.net/):

![Landing Page](/Assets/landingPage.png)

Click on "View All Courses" in the nav bar to see all the courses:

![All Courses](/Assets/viewAllCourses.png)

From here, a course can be created:

![Create course](/Assets/createCourse.png)

Courses can be edited.  Let's make this an ode to Marnie Stern:

![Create course](/Assets/editCourse.png)

Courses can also be deleted.  Let's delete the Banshees course:

![Create course](/Assets/deleteCourseBefore.png)

Here's the updated list:

![Delete course](/Assets/deleteCourseAfter.png)

Search functionality is built in, so let's give it a try:

![Search course](/Assets/searchCourse.png)

Here is the result:

![Search course result](/Assets/searchCourseResult.png)

---
## Acknowledgements
- Many thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this awesome README layout.