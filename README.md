# Online Candy Store App
This is a clone of a repository from a CSCE 547 class project I worked on with group members. The original repository, if still active, can be found [here](https://github.com/vivianofsouza/CSharpestV2/tree/phase2_submission). 
Through this readme, I may speak in the terms "we" or "our" to represent myself and my group members.

Without further ado, welcome to the delightful online candy store app! 🍭🍬 In this virtual confectionery wonderland, users can explore a wide array of sweet treats, place orders, and satisfy their sweet tooth without leaving the comfort of their homes.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Installation](#installation)
- [Authors](#authors)


## Overview

This online candy store app is built using a robust technology stack to ensure a seamless and enjoyable user experience. The frontend is powered by React, providing a modern and interactive interface for users to navigate through the candy selection.

### Backend Technologies
On the backend, we've harnessed the power of **.NET Core** and **Entity Framework**. .NET Core serves as the backbone of the application, offering a versatile and cross-platform framework for building scalable and high-performance web applications. Entity Framework, a powerful Object-Relational Mapping (ORM) tool, facilitates smooth interactions with the database, ensuring efficient data management for the extensive candy inventory.

### Frontend Technologies
The frontend, developed with **React**, delivers a responsive and dynamic user interface. React's component-based architecture allows for the creation of modular and reusable UI elements, enhancing the overall maintainability and flexibility of our candy store app.

## Features

- **Browsing and Ordering:** Users can effortlessly browse through our extensive candy catalogue, view detailed product information, and place orders with just a few clicks.
- **User Accounts:** You can create an account or log into an account you already created.
- **Responsive Design:** Whether accessed from a desktop, tablet, or mobile device, our candy store app adapts seamlessly to provide an optimal viewing experience.
- **Admin Privileges:** There are two types of users (customers and admins). Administrators can change the stock, add items, remove items, and change certain attributes of items.


## Installation
1. I suggest using [Visual Studio](https://visualstudio.microsoft.com/) as the IDE. We used [Swagger](https://swagger.io/) to test the major endpoints as well. If you'd like to do so, you should be able to once you run the program on Visual Studio

2. Clone this repository using the following code block.
   ```bash
   git clone https://github.com/david-eta/CandyStore.git
   cd CandyStore
   ```

3. Implement our database. You can do so by running the following in your terminal:
   ```bash
    dotnet ef database drop
    dotnet ef database update Changes
    dotnet ef database update seedItemsTable
   ```

4. Install [Node](https://nodejs.org/en/download).

5. To run the app (and interact with the frontend), run the following in your terminal:
   ```bash
    cd CSharpestUI/csharpest-ui
    npm install
    npm run start
   ```  

6. To test the endpoints using Swagger,
   1. Activate the Solution in Visual Studio by double-clicking CSharpestServer.sln
   2. Hit the play button below the toolbar.
   If you have issues with that, try running the following in your terminal.

   ```bash
    dotnet run
   ```
7. I used [SSMS](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) to interact with the database during testing. Once you install it and connect it to the database, you can use SQL queries to get or add to the db.

## Authors
- [Vivian D'Souza](https://github.com/vivianofsouza)
- [Savannah Noblitt](https://github.com/SavannahNoblitt)
- [Patrick Burroughs](https://github.com/Patbu13)
- [David Eta](https://github.com/david-eta)
