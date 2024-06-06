2024-05-16
Shivam Dayama
15:04 EST

1331 UDT
Web app created with VS2022 .NET 7, No Authentication
Checked on https://localhost:7228/
working good...
Changed the name from "Welcome" to "MVC Movie" on the home page which is https://localhost:7228/ 
For this change edit "index.cshtml" file which found in "View > Home > index.cshtml"
above changes done and tested...
working good

1340 UDT
Started Part-2
Add controller name "Index" and "Welcome"
For above both controller, 2 public strings are created "Index" and "Welcome"
and those strings contains messages for that particular string.

For "Index" controller, the link is https://localhost:7228/MvcMovie
checked, working good and displays the message as expected which is "This is default controller for MVC Movie controller...."

For "Welcome" controller, link is https://localhost:7228/MvcMovie/Welcome
checked, working good and displays the message as expected which is "This is Bhargav's Welcome Message for MVC Movie controller..."

1429 UDT
Tried to add parameters in Welcome controller "name" and "idno"
It didn't work first time but after several attempts i figure out how to change name in URL
first change name in "programs.cs" file from "default" to "Bhargav"

1502 UDT
after that i change above changes i tried to open link https://localhost:7228/HelloWorld/Welcome/3000?name=Shivam&idno=0850964
it worked and show as expected


1545 
Created image in paint..
saved the image as smile.png and the path of that image is "C:\Users\dayam\source\repos\MvcMovie\wwwroot\img"
First, we have to create "img" folder in "wwwroot" folder

Started part 3: Add view
Created a View file name "Index.cshtml" in the folder View>HelloWorld>Index.cshtml
Made changes on the home page and put view message "First view of the website!" in the "Index.cshtml" file.

2024-05-18
1055 
Made the following changes in the "_Layout.cshtml" to modify the webpage content 

1. changed the meta title from "MVC Movie" to "MvcMovie WebPage"
2. changed the page heading (h1) from "MVC Movie List" to "MvcMovie WebPage"
3. changed the footer content from 2024 to 2022

checked https://localhost:7228/HelloWorld
1145 
Now i passed data from controller to the view ...
to do this edit HelloWorldController.cs file and change the content of the Welcome controller..
in this we passed "name string" and "int idno"
for string name

Started Part 4 : Add a model
11437
Part 4 
1802 UTC
Started adding a model for which I created a file name movie.cs in models folder and in controller Scaffold movie pages.
and created a new item with the name moviescontroller.cs

1820
Migration was done and initial Create is timestamped
20240523190956_initialCreate.cs

1825 UTC
Updated the database for the testing purpose

1850 UTC
Edited the movies name with title genre price and release date

1913 UTC
https://localhost:7228/Movies

1441 UTC


1459 UTC
Updated the database for the testing purpose

1520 UTC
Edited the movies name with title genre price and release date

1641 UTC

Testing and was successful
