## Table of contents

- [WebApp Link](#webapp-link)
- [WebApp Overview](#webapp-overview)
- [Stretch Tasks](#stretch-tasks) 
- [How to use the WebApp](#how-to-use-the-webapp) 
- [References](#references) 

## WebApp Link
The webapp can be accessed on Azure with the following link:\
https://cmpg323-project3-webapp.azurewebsites.net/

## WebApp Overview
The Web Application was created as, and makes use of the following core features:  
- Created as an ASP.NET Core Web Application, using .NET 6.0 
- Makes use of a SQL Server Database, hosted on Azure
- Follows the repository design pattern
- Includes a servide layer
- The design pattern layers are implemented between projects

## Stretch Tasks
The implementation of the repository layer and its classes worked well to seperate the data access logic out of the controllers, and to leave them with only one specialized purpose.  However, in order to improve the access to data pulled by a single controller from more than one repository, a service layer was implemented between the controller layer and the repository layer.\
This service layer made it easier to access and assemble the data that needed to be sent to the presentation layer, particularly when working with the Order model which also contains information from the Customer model.\
The service layer further abstracts the data access logic away from the controllers so that the repository classes can now be reworked/replaced without any code needing to be updated in the controller classes.\
Since the service layer is located in its own project, it also provides better reusability.

## How to use the WebApp
Here follows a list of all the operations of the web application available to the user.  Each operation can be navigated to by clicking on the respective link.\
Whenever ID numbers (e.g., Customer ID, Product ID, Order ID) need to be provided as input when creating new records, make sure to provide a value that is not already in use in use.  When receiving an error whilst trying to create new records, firdt try to use a different ID value.\
Before being able to use the web application, the user must first log in.  If the user is already registered, they can proceed directly to login; otherwise registration is first required before being able to to so.

- Logging in
    - [Registration](#registration)
    - [Logging in](#logging-in)
    - [Logging out](#logging-out)

- Customers
    - [See all Customers](#see-all-customers)
    - [Create new Customer](#create-new-customer)
    - [Details of Customer](#details-of-customer)
    - [Edit Customer](#edit-customer)
    - [Delete Customer](#delete-customer)

- Orders
    - [See all Orders](#see-all-orders)
    - [Create new Order](#create-new-order)
    - [Details of Order](#details-of-order)
    - [Edit Order](#edit-order)
    - [Delete Order](#delete-order)

- Products
   - [See all Products](#see-all-products)
   - [Create new Product](#create-new-product)
   - [Details of Product](#details-of-product)
   - [Edit Product](#edit-product)
   - [Delete Product](#delete-product)

## Registration
   * Click on "Register" in the top right corner of the home page.
   * Enter a valid email address.
   * Enter a password of your choosing.  Then re-enter it under "Confirm Password".
   * Be sure to remember/record your details for future use, and then click on "Register".
   * No email confirmation is required.
   * If the registration was successful, you'll be taken back to the home page with a welcome message that includes your email address in the top right corner.

## Logging in
   * Click on "Login" in the top right corner of the home page.
   * Enter your email address and password.
   * Click on "Log in".
   * If the login was successful, you'll be taken back to the home page with a welcome message that includes your email address in the top right corner.
   * Note that if you forgot your password, click on the "Forgot your password" link below the log in button.
   * Enter your email address, click on "Reset Password" and follow the instructions from there.

## Logging out

   * To log out, click on "Logout" in the top right corner.
   * Your email address at the top right should dissapear, making the login option available again.
  
## See all Customers
   * Click on "Customers" in the top left.
   * You'll be taken to the Customer Index page , which displays all the customers.

## Create new Customer
   * While in the Customer Index page, click on "Create New" at the top left.
   * You'll be taken to the Create Customer page.
   * Enter the Customer ID, Customer Title, Customer Name, Customer Surname, and Customer Cellphone.
   * Once all the information have been entered, click on the "Create button".
   * If the customer is created successfully, you'll be taken back to the Customer Index page, where you'll be able to see the new customer in the list.
   * Note, if you'd like to return to the Customer Index page without creating a new customer, click on "Back to List" instead.

## Details of Customer
   * To view the details of a specific customer, while in the Customer Index page, click on "Details" in the same line as the customer.
   * This will take you to the Details Customer page, where the customer's details will be displayed.
   * If you would like to edit the details, click on "Edit".
   * Otherwise, to go back to the Customer Index page, click on "Back to List".

## Edit Customer
   * To edit the details of a specific customer, while in the Customer Index page, click on "Edit" in the same line as the customer.
   * This will take you to the Edit Customer page, where the customer's details will be displayed.
   * You can edit the values that you wish to change.
   * Once you are done entering in the new values, click on "Save".
   * If the customer is edited successfully, you'll be taken back to the Customer Index page.
   * Note, if you'd like to return to the Customer Index page without editing the customer, click on "Back to List" instead.

## Delete Customer
   * To delete a customer, while in the Customer Index page, click on "Delete" in the same line as the customer.
   * This will take you to the Delete Customer page, where the customer's details will be displayed.
   * If you would like to delete the customer, click on "Delete".
   * If the customer is deleted successfully, you'll be taken back to the Customer Index page.
   * If a customer is associated with any orders in the system, you won't be able to delete it and will receive an error message instead.
   * Note, if you'd like to return to the Customer Index page without deleting the customer, click on "Back to List" instead.

## See all Orders
   * Click on "Orders" in the top left.
   * You'll be taken to the Order Index page , which displays all the orders.

## Create new Order
   * While in the Order Index page, click on "Create New" at the top left.
   * You'll be taken to the Create Order page.
   * Enter the Order ID, select a date (from the calender), and Customer ID (from the list), and enter a Delivery Address.
   * Once all the information have been entered, click on the "Create button".
   * If the order is created successfully, you'll be taken back to the Order Index page, where you'll be able to see the new order in the list.
   * Note, if you'd like to return to the Order Index page without creating a new order, click on "Back to List" instead.

## Details of Order
   * To view the details of a specific order, while in the Order Index page, click on "Details" in the same line as the order.
   * This will take you to the Details Order page, where the order's details will be displayed.
   * If you would like to edit the details, click on "Edit".
   * Otherwise, to go back to the Order Index page, click on "Back to List".

## Edit Order
   * To edit the details of a specific order, while in the Order Index page, click on "Edit" in the same line as the order.
   * This will take you to the Edit Order page, where the order's details will be displayed.
   * You can edit the values that you wish to change.
   * Once you are done entering in the new values, click on "Save".
   * If the order is edited successfully, you'll be taken back to the Order Index page.
   * Note, if you'd like to return to the Order Index page without editing the order, click on "Back to List" instead.

## Delete Order
   * To delete an order, while in the Order Index page, click on "Delete" in the same line as the order.
   * This will take you to the Delete Order page, where the order's details will be displayed.
   * If you would like to delete the order, click on "Delete".
   * If the order is deleted successfully, you'll be taken back to the Order Index page.
   * Note, if you'd like to return to the Order Index page without deleting the order, click on "Back to List" instead.

## See all Products
   * Click on "Products" in the top left.
   * You'll be taken to the Product Index page , which displays all the products.

## Create new Product
   * While in the Order Index page, click on "Create New" at the top left.
   * You'll be taken to the Create Product page.
   * Enter the Product ID, Product Name, Product Description, and Units in Stock.
   * Once all the information have been entered, click on the "Create button".
   * If the product is created successfully, you'll be taken back to the Product Index page, where you'll be able to see the new product in the list.
   * Note, if you'd like to return to the Product Index page without creating a new product, click on "Back to List" instead.

## Details of Product
   * To view the details of a specific product, while in the Product Index page, click on "Details" in the same line as the product.
   * This will take you to the Details Product page, where the product's details will be displayed.
   * If you would like to edit the details, click on "Edit".
   * Otherwise, to go back to the Product Index page, click on "Back to List".

## Edit Product
   * To edit the details of a specific product, while in the Product Index page, click on "Edit" in the same line as the product.
   * This will take you to the Edit Product page, where the product's details will be displayed.
   * You can edit the values that you wish to change.
   * Once you are done entering in the new values, click on "Save".
   * If the product is edited successfully, you'll be taken back to the Product Index page.
   * Note, if you'd like to return to the Product Index page without editing the product, click on "Back to List" instead.

## Delete Product
   * To delete a product, while in the Product Index page, click on "Delete" in the same line as the product.
   * This will take you to the Delete Product page, where the product's details will be displayed.
   * If you would like to delete the product, click on "Delete".
   * If the product is deleted successfully, you'll be taken back to the Product Index page.
   * Note, if you'd like to return to the Product Index page without deleting the product, click on "Back to List" instead.

## References
Rick-Anderson (2023b) ASP.NET MVC Overview. https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/overview/asp-net-mvc-overview. (Accessed: 07 September 2023).

Naik, K. (no date) Design Patterns In C# .NET (2023). https://www.c-sharpcorner.com/UploadFile/bd5be5/design-patterns-in-net/. (Accessed: 08 September 2023).

Tdykstra (2023b) Tutorial: Get started with EF Core in an ASP.NET MVC web app. https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-3.1. (Accessed: 08 September 2023).

Murugan, M. (2021) 'Repository pattern in ASP.NET Core - Ultimate Guide,' Code With Mukesh, 24 April. https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/. (Accessed: 10 September 2023).

Santos, R. (2021) .'NET Core — Using Entity Framework Core in a separate Project,' Medium, 9 December. https://medium.com/oppr/net-core-using-entity-framework-core-in-a-separate-project-e8636f9dc9e5. (Accessed: 10 September 2023).

Sanjay (2023) 'Solid Principles with C# .NET Core with Practical Examples & Interview Questions | Pro Code Guide,' Pro Code Guide, 8 May. https://procodeguide.com/design/solid-principles-with-csharp-net-core/. (Accessed: 15 September 2023).

Vivas, T. (no date) SOLID with .Net Core. https://www.c-sharpcorner.com/article/solid-with-net-core/. (Accessed: 16 September 2023).

Kexugit (2019) Design Patterns: Solidify Your C# Application Architecture with Design Patterns. https://learn.microsoft.com/en-us/archive/msdn-magazine/2001/july/design-patterns-solidify-your-csharp-application-architecture-with-design-patterns. (Accessed: 16 September 2023).

Various Contributors (no date) Learn Design Patterns in C Course Online For Free With Certificate. https://www.mindluster.com/certificate/5908. (Accessed: 06 September 2023).

Various Contributors (no date) Learn Design Patterns and Best Practices Course Online For Free With Certificate. https://www.mindluster.com/certificate/6957. (Accessed: 09 September 2023).

Various Contributors (no date) Learn Design Patterns in Java Course Online For Free With Certificate. https://www.mindluster.com/certificate/4051. (Accessed: 19 September 2023).

