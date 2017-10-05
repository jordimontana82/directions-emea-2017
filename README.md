# Welcome to the Directions EMEA 2017 Dynamics 365 Test Automation Session

## Overview

By attending this workshop you'll learn how to design and test enterprise scale solutions for Dynamics 365.

The workshop will cover testing and development of MVC web applications connected to Dynamics 365, plugins, and workflow activities.

To get started, please fork and clone this repo.

## Pre-requisites

This workshop requires Visual Studio 2017 (better if you use Enterprise Edition as it supports Live Unit Testing).

## Repo Structure

This repo contains the following:

- /README.md: what you are reading right now :)
- /Slides.ppt: supporting slides for the session
- /sdk: the CRM SDK binaries needed to generate some early bound entities we'll use throughout the workshop
- /CrmSvcUtilExtensions: some custom filtering service used to filter some entities when running crmsvcutil. This will allow us to only generate the early bound entities we need.
- /DirectionsEmeaTesting.sln: The solution we'll be working on.

## Workshop Context

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
- If all was good, create a new "Vote" record in CRM

### 101.2:  Validate Badge
-------------------------------------

### 101.3:  Validate Vote
-------------------------------------

### 101.4:  Vote registration
-------------------------------------
We'll work on 2 different scenarios when 

## Lab 102: Plugins Unit Testing

## Lab 103: Code Activities Unit Testing




