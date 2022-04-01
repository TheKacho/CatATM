# CatATM

This is the README for the CatATM!

This program is for the Code Louisville Capstone Project for Jan 2022 cohort.
I have created this program with the idea in mind to create a simple ATM teller program,
but with the behavior of a cat!
-------------------------------------------------------

Project Requisites / System Requirements 


If you have visibilty issues on light mode while running the app, please switch the console to dark mode to properly see the app.



Prior to running the CatATM app, it requires .NET 5.0 installed to PC/MAC to properly work.


If your PC does not have .NET 5.0 installed, please select one of the following links to install .NET 5.0 on your system of choice.

Windows:

x86
https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.406-windows-x86-installer

x64
https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.406-windows-x64-installer

Arm64
https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.406-windows-arm64-installer



Apple/MAC:

https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.406-macos-x64-installer




-------------------------------------------------------

Project requirements for what I am targeting:

Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program

Read data from an external file, such as text, JSON, CSV, etc and use that data in your application

Create an additional class which inherits one or more properties from its parent

Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program

Analyze text and display information about it (ex: how many words in a paragraph)



---------------------------------------------
Notes and instructions: 
I have created several test accounts before logging in:

User Account 1: 123456
Pin Number: 1234

User Account 2: 246810
Pin Number: 1357

*User Account 3: 135790
Pin Number: 2468

*For demonstration purposes: if you log in as User Account 3, 
*the program will give you a lock out error message*

*The program will allow three attempts per each account (minus the third account)*
*If your third and last login is unsuccessful, then the app will lock you out and the program will flag the account as "locked"*

-------------------------------------------------------


After logging in successfully you are given several choices:

Pet the cat, feed the cat, play with the cat, find information about the app, or log out of the program.

To choose, your commands to type in are (I have added alternate commands for more accessibility):

  pet cat, pet, 1

  feed cat, feed, 2

  play cat, play, 3
  
  about, 4

  log out, 5  
