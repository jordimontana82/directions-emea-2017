# Welcome to the Directions EMEA 2017 Dynamics 365 Test Automation Session

## Overview

By attending this workshop you'll learn how to design, develop and test enterprise scale solutions for Dynamics 365.

The workshop will cover testing and development of MVC web applications connected to Dynamics 365, plugins, and workflow activities.

To get started, please fork and clone this repo.

## Pre-requisites

This workshop requires:

- Visual Studio 2017 (better if you use Enterprise Edition as it supports Live Unit Testing).
- .NET Framework 4.6.2 (as we are targetting Dynamics 365 9.0)

## Repo Structure

This repo contains the following:

- /README.md: what you are reading right now :)
- /Slides.ppt: supporting slides for the session
- /sdk: the CRM SDK binaries needed to generate some early bound entities we'll use throughout the workshop
- /CrmSvcUtilExtensions: some custom filtering service used to filter some entities when running crmsvcutil. This will allow us to only generate the early bound entities we need.
- /DirectionsEmeaTesting.sln: The solution we'll be working on.

## Workshop Context: 'The Free Pint Referendum'

The goal of this workshop is to implement a voting system, in the form of a referendum, which answers to the following question:

"Would you like to have a free pint at the end of this session? :)"

Yes / No

The system will use Dynamics 365 as the backend to store all the information related to polling stations, votes, and Directions EMEA voters, who will be represented as contacts in CRM.

Sitting in front of Dynamics, there will be a custom MVC web application to help officers manage the voting process so that:

- We allow people to vote at any polling station (kind of universally distributed census)
- We make sure no single person can vote 2 or more times.

Some details about the data model

- Voters will be modelled as contacts in CRM
- Voters can be uniquely identified using a custom Badge ID field (dir_badgeid)
- There can be many polling stations (dir_pollingstation)
- A vote (dir_vote) is represented as an intersect entity between a contact and a polling station
- A contact can vote only once (of course!)
- Not all the contacts can vote (only the ones with a badge id populated)


## Lab 101: MVC Backend Unit Testing

We'll implement a voting system to keep track of  how many directions EMEA attendees voted at the 'Free Pint Referendum', when did they vote, and who  were they.

Whenever someone wants to vote, he'll present his Badge to the officer at the polling station, which will be used to verify if that person can actually vote, and if so, the vote will be registered.

### 101.1:  Overview
-------------------------------------
We'll go through the basic structure of the DirectionsEmea.sln. 
Build & Run the solution to make sure there aren't any errors, and go to /Vote/Index.

The voting process will go through the following steps:

- Validate Badge is correct
- Validate that person didn't vote previously
- If all good, create a new "Vote" record in CRM

We'll break down the above process into smaller pieces of logic that can be easily unit tested in isolation from each other. Then at the end, we'll do some integration testing of all the steps put together.

### 101.2:  Unit tests: Validate Badge
-------------------------------------
Two different scenarios in this case:

- If we couldn´t find a contact with certain Badge Id, we return an error.
- If the badge Id is valid though, we continue on.

This about implementing the 2 unit tests (and corresponding logic) at:

/DirectionsEmea.Web.Tests/ReadModels/ReadModelBadgeIsValidTests.cs

### 101.3:  Unit tests: Validate Vote
-------------------------------------

One person can vote only if he didn´t vote previously. Again 2 different scenarios to implement: with / without having voted previously.

Implement the 2 unit tests at:

/DirectionsEmea.Web.Tests/ReadModels/ReadModelCheckContactDidntVoteTests.cs

### 101.4:  Unit tests: Create Vote Record
-------------------------------------

This unit test will make sure that a Vote record is created in CRM for a given contact and polling station. So after its execution, a vote (dir_vote) record should exist in CRM linked to the contact and polling station.

/DirectionsEmea.Web.Tests/Commands/CommandCreateVoteTests.cs

### 101.5:  Interaction Testing: Save Vote Process
-------------------------------------

Finally, whenever we have unit tested each step, it's time to put them all together and do some integration testing.

## Lab 102: Plugins Unit Testing

### 102.1:  VoteCreatedPlugin
-------------------------------------

Now, let's say we want to capture the date when somebody voted. There is a custom date field Vote Date, which should be populated with the current date whenever the Vote record is created. Although it could be easily done in a workflow, this will be implemented in a plugin for training purposes.

So please start from the DirectionsEmea.Plugins and DirectionsEmea.Plugins.Tests to add new tests and the implementation for that.

### 102.2:  Custom Fake Messages
-------------------------------------

Now we were requested to count the number of votes per polling station. Again, many options here, but we'll implement it as a Rollup field (dir_votecount) at the Polling Station entity. We need an immediate re-calculation every time someone votes, so we'll need to trigger the CalculateRollupFieldRequest message.

Please add the necessary unit tests & implement this scenario.

## Lab 103: Code Activities Unit Testing

### 103.1:  Process Referendum Results
-------------------------------------

At the end of the day, we'll need to collect the referendum results, counting the number of votes, and if Yes wins, we'll invite everybody to one pint.

We have outsourced that service actually so there is an external 3rd party web service we need to consume to order them.

That web servie is located at /DirectionsEmea.WebService/OrderPintsForEveryoneService.svc

From a unit testing perspective, we don't really care about its implementation, only that it should return true if order was creted successfully, or false otherwise.

- From the codeactivity, add a new web service reference to OrderPintsForEveryoneService.svc

Scenarios to test would be:
- Count number of votes
- If Yes wins, call the web service to create an order for 2000 people, and create a notification email to some manager.
. If No wins, the webservice shouldn't be called.
