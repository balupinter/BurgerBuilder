# BurgerBuilderApp

This is a simple ASP.NET MVC application for building custom burgers.

## How to Run

To run this application, navigate to the project's root directory in your terminal and execute the following command:

```bash
dotnet run
```

Then, open your web browser and navigate to the URL provided in the console output (usually `https://localhost:7xxx`).

## TODOs

### Core Functionality

- [ ] **TODO-CORE-1: Address Non-Nullable Property Warnings:**
  - **Goal:** Resolve compiler warnings related to non-nullable properties.
  - **Detailed Steps:**
    1.  **Open `Models/Ingredient.cs`:**
        -   Locate the `Name` property. The compiler is warning that it might be null.
        -   You can either make the property nullable by changing `string` to `string?` or initialize it with a default non-null value. For this property, making it required is a good choice.
    2.  **Open `Models/BurgerViewModel.cs`:**
        -   Locate the `SelectedIngredients` property.
        -   Initialize this property with a new `List<string>()` to ensure it's never null.
- [ ] **TODO-CORE-2: Implement Data Persistence (Database Integration):**
  - **Goal:** Replace the hardcoded ingredient list with a database, so that ingredients and orders can be saved.
  - **Detailed Steps:**
    1.  **Set up a database:**
        -   Choose a database provider (e.g., SQLite for simplicity, or SQL Server for a more robust solution).
        -   Add the required NuGet packages for Entity Framework Core (e.g., `Microsoft.EntityFrameworkCore.Sqlite`).
    2.  **Create a `DbContext`:**
        -   Create a new class that inherits from `DbContext`. This class will represent your database session.
        -   Define `DbSet` properties for your models (`Ingredient`, `Order`, etc.).
    3.  **Configure the database connection:**
        -   In `appsettings.json`, add a connection string to your database.
        -   In `Program.cs`, configure the `DbContext` to use your chosen database provider and connection string.
    4.  **Use migrations to create the database schema:**
        -   Run the `dotnet ef migrations add` and `dotnet ef database update` commands to create the database tables based on your models.
    5.  **Replace hardcoded data:**
        -   Update your code to fetch ingredients from the database instead of the hardcoded list.
- [ ] **TODO-CORE-3: Implement Order Confirmation and Tracking:**
  - **Goal:** Provide users with a confirmation of their order and a way to track its status.
  - **Detailed Steps:**
    1.  **Create an `Order` model:**
        -   This model should include properties like `OrderId`, `OrderDate`, `TotalCost`, and a list of `Burger`s in the order.
    2.  **Save the order to the database:**
        -   When a user places an order, create a new `Order` object and save it to the database.
    3.  **Create an `OrderConfirmation` view:**
        -   After saving the order, redirect the user to a new page that displays the order details and a unique `OrderId`.
    4.  **Create an `OrderStatus` page:**
        -   Create a new page where users can enter their `OrderId` to see the current status of their order (e.g., "Preparing", "Out for delivery", "Delivered").
- [ ] **TODO-CORE-4: Implement User Authentication and Authorization:**
  - **Goal:** Allow users to create accounts, log in, and access features based on their roles (e.g., admin).
  - **Detailed Steps:**
    1.  **Set up ASP.NET Core Identity:**
        -   Add the necessary NuGet packages for ASP.NET Core Identity.
        -   Configure Identity in `Program.cs` and your `DbContext`.
    2.  **Create registration and login pages:**
        -   Use the scaffolding tools to generate the default Identity views for registration, login, and user management.
    3.  **Protect endpoints with authorization:**
        -   Use the `[Authorize]` attribute on controllers or action methods to restrict access to authenticated users.
    4.  **Implement role-based authorization:**
        -   Define roles (e.g., "Admin", "User").
        -   Assign roles to users.
        -   Use the `[Authorize(Roles = "Admin")]` attribute to restrict access to admin-only features.
- [ ] **TODO-CORE-5: Implement Ingredient Management (CRUD operations for admin):**
  - **Goal:** Create a section where administrators can manage the available ingredients.
  - **Detailed Steps:**
    1.  **Create an `IngredientsController`:**
        -   This controller will handle the CRUD (Create, Read, Update, Delete) operations for ingredients.
    2.  **Create views for ingredient management:**
        -   `Index.cshtml`: Display a list of all ingredients with options to edit or delete them.
        -   `Create.cshtml`: A form for adding a new ingredient.
        -   `Edit.cshtml`: A form for updating an existing ingredient.
        -   `Delete.cshtml`: A confirmation page for deleting an ingredient.
    3.  **Implement the controller actions:**
        -   Write the C# code in the `IngredientsController` to handle the form submissions and interact with the database.
    4.  **Secure the controller:**
        -   Ensure that only users with the "Admin" role can access these ingredient management pages.

### Advanced Features

- [ ] **TODO-ADV-1: Implement Custom Burger Naming:**
  - **Goal:** Allow users to give their custom-built burger a name.
  - **Detailed Steps:**
    1.  **Update the `Burger` model:**
        -   Add a `Name` property to the `Burger` model.
    2.  **Add a name input field:**
        -   In the burger building view, add a text input field where users can enter a name for their burger.
    3.  **Save the burger name:**
        -   When the user adds the burger to their order, save the custom name along with the other burger details.
- [ ] **TODO-ADV-2: Implement Discount Codes/Promotions:**
  - **Goal:** Allow users to apply discount codes to their orders.
  - **Detailed Steps:**
    1.  **Create a `DiscountCode` model:**
        -   This model should include properties like `Code`, `DiscountPercentage`, and `ExpiryDate`.
    2.  **Add a discount code input:**
        -   In the order summary page, add an input field for users to enter a discount code.
    3.  **Apply the discount:**
        -   When a user applies a code, validate it against the database and, if valid, apply the discount to the total order cost.
- [ ] **TODO-ADV-3: Implement Order History for Authenticated Users:**
  - **Goal:** Allow logged-in users to view their past orders.
  - **Detailed Steps:**
    1.  **Create an `OrderHistory` page:**
        -   This page will display a list of the user's past orders.
    2.  **Fetch the user's orders:**
        -   In the controller, get the current user's ID and query the database for all orders associated with that user.
    3.  **Display the order history:**
        -   Pass the list of orders to the view and display them in a table or list format.
- [ ] **TODO-ADV-4: Implement a "Build Your Own Burger" Visualizer:**
  - **Goal:** Create a more interactive and visual burger building experience.
  - **Detailed Steps:**
    1.  **Find or create images for each ingredient.**
    2.  **Use JavaScript to dynamically update the visualizer:**
        -   When a user selects an ingredient, use JavaScript to add the corresponding image to a "burger preview" area.
        -   Layer the ingredient images on top of each other to create a visual representation of the burger.

### User Interface (UI) / User Experience (UX)

- [ ] **TODO-UI-1: Enhance User Interface for a better burger building experience:**
  - **Goal:** Improve the overall look and feel of the application.
  - **Detailed Steps:**
    1.  **Use a CSS framework:**
        -   Leverage a framework like Bootstrap or Tailwind CSS to create a more modern and professional design.
    2.  **Improve the layout:**
        -   Organize the content in a clear and intuitive way. Use cards, columns, and other layout components to structure the page.
    3.  **Add custom styling:**
        -   Use CSS to customize the colors, fonts, and other visual elements to match your brand.
- [ ] **TODO-UI-2: Add client-side validation for user inputs:**
  - **Goal:** Provide immediate feedback to users as they fill out forms.
  - **Detailed Steps:**
    1.  **Use data annotations:**
        -   Add validation attributes (e.g., `[Required]`, `[StringLength]`) to your view models.
    2.  **Include the validation scripts:**
        -   Ensure that the `_ValidationScriptsPartial.cshtml` partial view is included on pages with forms.
    3.  **Use tag helpers:**
        -   Use the `asp-validation-for` tag helper to display validation messages next to the form fields.
- [ ] **TODO-UI-3: Improve responsiveness for various screen sizes:**
  - **Goal:** Ensure the application is usable on all devices.
  - **Detailed Steps:**
    1.  **Use a responsive CSS framework:**
        -   Frameworks like Bootstrap have built-in responsive grid systems.
    2.  **Use media queries:**
        -   Write custom CSS with media queries to adjust the layout and styling for different screen sizes.
    3.  **Test on different devices:**
        -   Use your browser's developer tools to simulate different screen sizes and ensure that the application looks and functions correctly.

### Testing

- [ ] **TODO-TEST-1: Add Unit Tests for core logic:**
  - **Goal:** Ensure that the core business logic of the application is working correctly.
  - **Detailed Steps:**
    1.  **Create a test project:**
        -   Add a new xUnit or MSTest project to your solution.
    2.  **Write tests for your services:**
        -   Test the methods in your services to ensure they return the expected results.
    3.  **Mock dependencies:**
        -   Use a mocking library (e.g., Moq) to isolate the code you're testing from its dependencies.
- [ ] **TODO-TEST-2: Add Integration Tests for controller actions and database interactions:**
  - **Goal:** Test the application's components together to ensure they work as a whole.
  - **Detailed Steps:**
    1.  **Use the `WebApplicationFactory`:**
        -   This class allows you to create an in-memory version of your application for testing.
    2.  **Write tests for your controllers:**
        -   Make HTTP requests to your controller actions and assert that they return the expected responses.
    3.  **Use a test database:**
        -   Configure your tests to use a separate test database to avoid interfering with your development data.

### Refactoring / Code Quality

- [ ] **TODO-REF-1: Refactor hardcoded ingredients into a configurable source:**
  - **Goal:** Move the hardcoded ingredient list to a more flexible location.
  - **Detailed Steps:**
    1.  **Create a `BurgerData` service:**
        -   This service will be responsible for providing the list of available ingredients.
    2.  **Move the hardcoded list:**
        -   Move the `AvailableIngredients` list from your controller to the `BurgerData` service.
    3.  **Inject the service:**
        -   Inject the `BurgerData` service into your controller and use it to get the list of ingredients.
- [ ] **TODO-REF-2: Implement proper error logging and handling:**
  - **Goal:** Ensure that errors are logged and that users are shown helpful error messages.
  - **Detailed Steps:**
    1.  **Use a logging framework:**
        -   Configure a logging framework like Serilog or NLog to log errors to a file or other destination.
    2.  **Add exception handling middleware:**
        -   Create middleware that catches unhandled exceptions, logs them, and displays a user-friendly error page.
    3.  **Use `try-catch` blocks:**
        -   Use `try-catch` blocks to handle expected exceptions and provide specific error messages to the user.
- [ ] **TODO-REF-3: Optimize performance for large numbers of ingredients/orders:**
  - **Goal:** Ensure the application remains fast and responsive as the amount of data grows.
  - **Detailed Steps:**
    1.  **Use asynchronous database queries:**
        -   Use the `async` and `await` keywords to perform database queries asynchronously, which can improve performance.
    2.  **Use caching:**
        -   Cache frequently accessed data (e.g., the list of ingredients) to reduce the number of database queries.
    3.  **Optimize your database queries:**
        -   Use tools like Entity Framework's logging to inspect the generated SQL queries and identify any performance bottlenecks.

### API Integration

- [ ] **TODO-API-1: Implement "Burger of the Day" Feature:**
    - **Goal:** Fetch a random burger recipe from TheMealDB API and display it on the homepage.
    - **Detailed Steps:**
        1.  **Create a `RecipeViewModel.cs` model:**
            -   In the `Models` folder, create a new C# class named `RecipeViewModel.cs`.
            -   This class will represent the data you get from the API. You'll need properties to store the burger's name, image URL, and instructions.
            -   **Hint:** The API response uses keys like `strMeal`, `strMealThumb`, and `strInstructions`. You can name your properties accordingly.
        2.  **Create a `RecipeService.cs`:**
            -   Create a new folder named `Services` in the project's root directory.
            -   Inside the `Services` folder, create a new C# class named `RecipeService.cs`.
            -   This service will handle the logic for fetching data from TheMealDB API.
            -   **Hint:** You'll need to use the `HttpClient` class to make an HTTP GET request to `https://www.themealdb.com/api/json/v1/1/search.php?s=Burger`. The response will be a JSON string, which you'll need to parse. The `System.Text.Json` library will be helpful here.
        3.  **Register the `RecipeService`:**
            -   In `Program.cs`, you need to register the `RecipeService` so that it can be used in your controllers.
            -   **Hint:** Use `builder.Services.AddHttpClient<RecipeService>();` to register the service and configure the `HttpClient`.
        4.  **Update `HomeController.cs`:**
            -   Inject the `RecipeService` into the `HomeController`'s constructor.
            -   In the `Index` action method, call the `RecipeService` to get a random burger recipe.
            -   Pass the `RecipeViewModel` to the `Index` view.
        5.  **Update `Views/Home/Index.cshtml`:**
            -   At the top of the file, declare that your view now uses the `RecipeViewModel`.
            -   Add a new section to the homepage to display the "Burger of the Day".
            -   Use HTML to display the burger's name, image (using an `<img>` tag), and instructions.
