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
  - `Models/Ingredient.cs`: Property 'Name' must contain a non-null value. Consider adding the 'required' modifier or declaring the property as nullable.
  - `Models/BurgerViewModel.cs`: Property 'SelectedIngredients' must contain a non-null value. Consider adding the 'required' modifier or declaring the property as nullable.
- [ ] **TODO-CORE-2: Implement Data Persistence (Database Integration):** Replace hardcoded ingredients with data loaded from a database. Implement saving of orders to the database.
- [ ] **TODO-CORE-3: Implement Order Confirmation and Tracking:** After an order is placed, display a confirmation page with an order ID and allow users to track their order status.
- [ ] **TODO-CORE-4: Implement User Authentication and Authorization:** Add user registration, login, and role-based authorization (e.g., admin users can manage ingredients).
- [ ] **TODO-CORE-5: Implement Ingredient Management (CRUD operations for admin):** Create a section where administrators can add, edit, and delete available ingredients.

### Advanced Features

- [ ] **TODO-ADV-1: Implement Custom Burger Naming:** Allow users to give their custom-built burger a unique name before adding it to the order.
- [ ] **TODO-ADV-2: Implement Discount Codes/Promotions:** Add functionality to apply discount codes to the total order cost.
- [ ] **TODO-ADV-3: Implement Order History for Authenticated Users:** Display a list of past orders for logged-in users.
- [ ] **TODO-ADV-4: Implement a "Build Your Own Burger" Visualizer:** Create a dynamic visual representation of the burger as ingredients are selected.

### User Interface (UI) / User Experience (UX)

- [ ] **TODO-UI-1: Enhance User Interface for a better burger building experience:** Improve the visual appeal and interactivity of the burger customization page.
- [ ] **TODO-UI-2: Add client-side validation for user inputs:** Implement JavaScript-based validation for forms to provide immediate feedback to users.
- [ ] **TODO-UI-3: Improve responsiveness for various screen sizes:** Ensure the application looks and functions well on desktops, tablets, and mobile devices.

### Testing

- [ ] **TODO-TEST-1: Add Unit Tests for core logic:** Write unit tests for functions like price calculation, ingredient validation, and order processing.
- [ ] **TODO-TEST-2: Add Integration Tests for controller actions and database interactions:** Implement tests that cover the full flow of user interactions and data persistence.

### Refactoring / Code Quality

- [ ] **TODO-REF-1: Refactor hardcoded ingredients into a configurable source:** Move the `AvailableIngredients` list to a configuration file or a dedicated service.
- [ ] **TODO-REF-2: Implement proper error logging and handling:** Set up a robust error logging mechanism and display user-friendly error messages.
- [ ] **TODO-REF-3: Optimize performance for large numbers of ingredients/orders:** Review and optimize code for scalability, especially for database queries.