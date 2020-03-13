# _Vendor Tracker!_

#### _A C# web application that trackers vendors and their orders._

#### By _**Alex Skreen**_

## Description
### Vendor Tracker

When the user runs the application, they are able to enter vendors and orders. It will also allow the user to see a list of all their vendors and the orders associated with each vendor.

## Setup/Installation Requirements


### Node install

_Install Git with the following command:_
* ``$ brew install git``

_Next, install Node.js by entering the following command in Terminal:_
* ``$ brew install node``

### .NET and C# install

#### For macOS:
_If .NET and C# are not installed on your computer already, then install using the following steps:_
* download [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)

* Open the file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.

* install and use a REPL called dotnet script.
* run ``dotnet tool install -g dotnet-script`` in the command line
* Download the [MySQL Community Server DMG File](https://dev.mysql.com/downloads/file/?id=484914)
* Click the download icon Use the No thanks, just start my download link.
* Follow along with the Installer
* run ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` in the command line.
* Download the [MySQL Workbench DMG File](https://dev.mysql.com/downloads/file/?id=484391)
* Click the download icon Use the No thanks, just start my download link.


### Setup/install this application

_Clone this repository via Terminal using the following commands:_
* ``$ cd desktop``
* ``$ git clone https://github.com/alexskreen/VendorTracker``
* ``$ cd VendorTracker.Solution``

_Confirm that you have navigated to the Bakery directory (e.g., by entering the command_ ``pwd`` in terminal). 

_Next, build the project and all of its dependencies at the project's root directory via the following command:_
* ``$ dotnet build``

_Open this application via live server using the following command:_
* ``$ dotnet run``

_To view/edit the source code of this application, open the contents of the camping directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._



## Specs
### Behavior Driven Development Spec List

Behavoir | Input | Output
:---------:|:------:|:------:
| The program will take the user to the home splash page| "localhost:5000/" | "Welcome to Alex's Vendor Tracking Application!" |
| The program will give the user two links. The first navigates to an "add vendor" page.| "Add Vendor" click | "Please fill out this form to add vendor" |
| The program will give the user two links. The second navigates to a page showing all vendors.| "View All Vendors" click | "Please fill out this form to add vendor"|
| The Program will display an error message if the vendor list is empty | "View All Vendors" click | "I'm sorry there are curently no Vendors" |
The Program will allow a user to add an order after navigating to each vendor | "View All Vendors -> Vendor A" Click | "Please fill out Order Form" |
| The Program will display all the orders for each vendor | "Vendor A" click | "Numbered list of all orders from this vendor" |


## Support 

_The software is provided as is. If you experience an issue please reach out to me using the contact information provided._

## Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.NET](https://dotnet.microsoft.com/)

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Alex Skreen_**