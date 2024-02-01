
 LAB 1- CREATING A WEB APPLICATION: BASIC EDITING, ADDING A CONTROLLER AND A VIEW

Date:   2024-01-11
Time:   1300
Task 1: Get Started: Introduction to ASP.NET Core MVC on visual studio
        I downloaded and installed the Visual Studio 2022. The installation was pretty straight 
        forward except for the fact that the process took quite sometime.
        Next, I started the process of creating a web application following the steps in the provided material: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studiohttps://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studio
        Without editing anything in the "solution explorer task pane", I attempted to run the application but I got an error message from the Microsoft "Edge" browser which I forgot to take a snap shot of. 
        So, It was suggested by the professor to use "Google Chrome" browser instead and this time around, it worked.
        Next, I proceeded to edit the View/Home/Index.cshtml file to include an additional paragraphs with text and an image. Then I re-ran the 
        application and It worked showing all the changes that had been made.

Date:   2024-01-13
Time:   1200
Task 2: Adding a controller and a view
        I went ahead to completed the web application Lab 1 by adding a controller and seeing how the  controller handles and responds to user input and interaction, and adding a view by changing views and layout pages
        changing the title, footer, and menu link in the layout file and passing Data from the Controller to the View. By following the steps in the recommended material, the exercise was pretty straight forward. 
        However, during the last portion of the "add view" task, which was to create a loop by replacing the contents of Views/HelloWorld/Welcome.cshtml with the provided code. I typed in the recommended code and when I tried
        to run the application, it will return with a bridge error. So, I sort help from "Chatgpt" and it provided me with an alternative code which I used. I proceeded to re-run the application and this time around, 
        I saw the desired output. 

        Personal observation
        It was interesting to learn how to edit the codes in the different files and even more interesting to see how modification of the codes resulted in different outputs each time the app is re-run. Also exciting
        for me was learning how to add an image to a web page. So far, the steps provided are easy to follow however, I will still need to review the provided material to get more
        indepth understanding of what is going on in the background. 

      
Date:   2024-01-18
Time:   1410
Task 3: Adding a model class
        I followed up my previous exercise with adding a model as instructed by the professor. First, I began by creating a .cs file in the Models folder called "Movie". Next, I went ahead to update the file with 
        codes provided in the "ASP.NET Core MVC app manual. Next, I used the scaffolding tool to produce create, read, update and delete pages for the movie model. I did this by adding a new scaffolded item via 
        the MVC Controller…entity framework. Then , I completed the corresponding dialog box and clicked "Add". Once I clicked "Add", the scaffolding successfully installed 3 NuGet Packages: Ms.EntityFramworkcore.SqlServer, 
        Ms.EntityFramworkcore.Tools and Microsoft.VisualStudio.Web.CodeGeneration.Design. Then, finally, the Movies.Controller.cs file was created. Next, I opened the "Package Manager Console" to enter the command provided 
        in the manual. I typed in the 1st command in the console, it ran successfully but when I typed "Update-Database", It returned with an error saying "The term 'Update-Datebase' is not recognized as the name of 
        a cmdlet, function, script file, or operable program". So, rather than type the two lines of command one after the other, I copied both commands from the manual and this, the update was successful.
        Then, I went ahead to save all changes and I ran the app to "TEST" it as instructed by the manual. When I ran the app, I selected the "MovieApp" Link and I saw the Index which had "Title", "ReleaseDate","Genre" and 
        "Price" listed though all the fields were empty. I went ahead to create a movie, editted it and deleted it and it was a successful process. 

         Personal observation
         From this exercise, I learnt how to update the NuGet Package correctly. Also, It was interesting to see how the scaffold tool was used to add the Create, Read, Update, and Delete (CRUD) pages for the movie model.
         Even more interesting was actualing testing the 4 features (CRUD) and seeing that it actually works. However, I still do not understand the intricacies of how the app is being developed. It is very very complex 
         and I will definitely still need some time to understand all the steps line for line.


Date:   2024-01-24
Time :   1930
Task 4:  Working with a Database
         As instructed by the manual, first, I examined the database by opening the SQL Server Object Explorer (SSOX) and navigating to the "View Designer" under "dbo.Movie" which is under the "WebApplication1" table. 
         I also opened "Viewed Data" under the "dbo.Movie" but I noticed that I had no movies in my database. As a result, I ran the app and added movies under the "MovieApp" Link. Then, I re-opened "View Data" and saw the 
         movies listed. Next, I proceeded to Seed the Database. I created the "SeedData" class in the Models folder and typed the very long code provided. Next, I proceeded to Add the Seed Initializer by editing the code in 
         "Program.cs" content. I proceeded to delete all the movie records in the database and force the app to initialize. Once, I did that, I observed that the app showed the seeded data i.e the movies I created. 

         Personal observation
         This exercise was more interesting that the previous one as this was my first real interaction with SQL Database. It was also interesting to see how the database could be interacted with and modified using the "Models" folders.

Date:   2024-01-25
Time :  1250
Task 5: Editing the movie database
        I had finished the previous task at home (Working with a Database) and put the default movies provided by the ASP.NET. However, when I got to class,
        the professor asked us to edit the database with our new movies which I did. 

        Personal Observation
        I observed from this exercise that there are two ways to edit the database either through the URL link or in the Seed.cs file. I opted to edit the Seed.cs
        file, but before then, I first deleted the  default movies then I edited the seed.cs file with my own movies. I proceeded to test the app and I observed that
        the movies had been added. 
         
        2024-01-29
Time:   1900
Task 6: Controller actions and views
        First, I edited the Models/Movie.cs file. I modified the code to include the correct display for the "Release date" as well as the correct datatype. Then, I browsed to the Movies Controller and observed that the "Release" and "Date" 
        were now seperate. I followed manual and reviewed all the codes in different files. I also tested the functionality of the "Validation Tag Helper" in the Web Application and I noticed the error displays when the ""Release date"" and "price"

        Personal Observation
        This exercise was simple to follow and execute. It only required few code modifications and more of observing how the "Controller" and "View" components of the MVC interact.

        2024-01-29
Time:   1945
Task 7: Add Search
        First, I updated the Index Method found in the Controllers/MoviesController.cs file with the provided code. Once I updated the code, I navigated to the URL using the following link:https://localhost:7137/movies/index?searchString=Inception 
        to test the search filter included in the Index code and the web displayed only the movie "Inception". This confirmed that the search query actually works. Next, I added the filter string using the <form> tag and I also tested the filter on the
        web application and it worked. I followed that up to edit the "MoviesController" and Views/Movies/Index.cshtml" files to include the (HttpPost Index). I also tested this functionality on the web application and it worked. Next, I created 
        the new "MovieGenreViewModel"class in the Models Folder and I adding the provided code to it. I also updated the code in the Index Method in Movies Controller as well as the "Index.cshtml" file in the "Views/Movies. then, I navigated to the web 
        application to test the genre filter and it worked. 

        Personal Observation.
        Again, it was interesting to see how modifying the Index method can allow filtering in the webapplication . Although, I still need to do more study of the ""Lambda expression"" and "LINQ" which were used in the "Index" code.

        2024-01-30
Time:   1900
Task 8: Add a New Field
        First, I added the rating property to the Models/Movie.cs file. Then, I built the app using the (Ctrl+Shift+B). Following this, I updated  (Bind) attribute under the "create" and ""Edit" action methods to include rating.
        Then, I added the rating field /Views/Movies/Create.cshtml and /Views/Movies/Index.cshtml. Next, I updated the SeedData class to provide the value for the new column rating. Then as instructed by the manual, I updated the
        package manager console to update the database. Then I deleted all the content in the DB, initialized and seeded the DB. Then, I ran the app and I observed that the Rating field appeared. 

        Personal Observation
        Overall, it was an fair exercise more difficult than the previous steps. It was difficult because at some point after adding the Rating filed to the SeedData.cs, the R column did not appear. So, I decided to delete the movies 
        in the app, then, I reseeded the database and forced initialization before the Rating field finally appeared. 

        2024-02-01
Time:   1100
Task 9: Add Validation
        First,  I added the validation rules to the movie model to take advantage of the built-in validation attributes Required, StringLength, RegularExpression, Range and the DataType formatting attribute. Next, I ran the app and 
        navigated to the Movies controller.Then, I tried to create a new movie and fill out the form with some invalid values. Once I did that,the form displayed error messages in the different fields. Then, I read through understanding 
        how the validation works. I also went through how to use the data type attribute but I did not effect any changes in my current code.

        Personal Observation
        For me, the validation step was easy to understand except for the part that explained how 