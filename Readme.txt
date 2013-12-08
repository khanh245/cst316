# KASK Blog
A blog application prototype for CST 316.
Created by: Khanh, Khanh2, Smahane, and Andy

## Technologies Used:
* ASP.NET MVC4
* Entity Framework 4
* Microsoft SQL Server 2012
* Twitter Bootstrap 3
* Visual Studio 2012

## Build Notes:
* In order to run this application, it is necessary to manually create a database named "KASKBlogDatabase" and import the database structure using the included KASKBlog-database-schema.sql file.
* When the SQL Server "KASKBlogDatabase" has been created (with schema updated,) open up the KASKBlog solution up in Visual Studio (2012 or later,) and run solution.
* Note: if project does not run, consider checking the database connectionString(s) in the ~KASKBlog/Web.config file.

## Code Notes:
* Database is created manually (via the included KASKBlog-database-schema.sql file.)
* Database data can also be imported if desired (via the included KASKBlog-database-data.sql file.)
* We connect to the KASKBlogDatabase by using a connection string in the ~KASKBlog/Web.config file.
* We also have to set up a "context" so that related application models can know how to deal with Entity Framework-related object/database mapping.
* Database is locally hosted, so we use "localhost" for the Data Source parameter in the database Connection String in the ~KASKBlog/Web.config file.
* Route information is detailed in the ~KASKBlog/Global.aspx file (see comments in code for more information.)
* Our Post model contains attributes such as [Key] and [Required] which mean that an item is a primary key or is a required field (when creating/editing/updating a Post-related object.)
* Controller details are described in comments above each major application "action" in the ~KASKBlog/Controllers/PostController.cs file.
* Finally, the root route for our application is configured in the ~KASKBlog/App_Start/RouteConfig.cs file.