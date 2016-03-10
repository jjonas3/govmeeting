# govmeeting
Software to inform us of issues discussed at local government meetings

## Features

Shortly after a meeting, you can:
* Go online and see what issues were discussed and exactly what was said and by whom.
* Receive, on your phone or via email, a summary of issues discussed. 
* Receive a phone alert or email whenever a specific issue is discussed. You would sign up prior for alerts.

At any time, you can go online and see:
* See all issues discussed in past meetings.
* See all that was said in the past on any specific issue.
* See exactly what any specific official said on any specific issue. This is especially helpful at election time.

![Mr. T](http://govmeeting.org/attachments/download/4/mr-t-mrt-36834265-320-254-24kb.png)
“Enough with the jibber-jabber, fool!
Show me how it works!”

Well, the code isn’t written yet. But here is a [SMALL DEMO](http://demo.govmeeting.org) of one possible feature.  It show what was discussed at a past meeting of the Boothbay Harbor Selectmen in Maine, USA. The final version will have many more features.

## Design

The software consists of two separate systems:
* A Public System that anyone can use to access information.
* A Volunteer System that community volunteers use to process meeting transcripts.

#### Public System
* A front-end using Typescript and AngularJS.
* A WEB API implemented in NodeJS or ASP.NET/C# or in both.
* An SQL database which could be MySql, SQL Server or another. 
* Object-Relational mapping using C# and Entity Framework.

#### Volunteer System
* A crowd-sourcing app for creating or processing existing transcripts – in Typescript and AngularJS.
* An existing content management system, the Drupal CMS, for volunteer workflow coordination.
* Utility modules for audio processing of meeting recordings.
* Utility scripts to preprocess existing written transcripts. 

## Goals

We can attend government meetings or watch them on TV. But how many times have we ever done this? How many people in a town of 50,000 people do this? Maybe 500. Democracy can’t work well if only one percent are fully informed.

People throughout the world deal with the same problems. This software will be designed to be used anywhere, wherever there is democracy and public access to government meetings.

The first goal is to get the software fully working at the local government level. Then we will expand the software to include state and federal government bodies.


