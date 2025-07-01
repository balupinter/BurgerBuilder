using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BurgerBuilderApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BurgerBuilderApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // TODO-REF-1: Refactor hardcoded ingredients into a configurable source (e.g., database, JSON file).
    // Hardcoded ingredients for demonstration purposes
    private static readonly List<Ingredient> AvailableIngredients = new List<Ingredient>
    {
        new Ingredient { Name = "Bun", Price = 0.50m },
        new Ingredient { Name = "Beef Patty", Price = 2.00m },
        new Ingredient { Name = "Cheese", Price = 0.75m },
        new Ingredient { Name = "Lettuce", Price = 0.25m },
        new Ingredient { Name = "Tomato", Price = 0.30m },
        new Ingredient { Name = "Onion", Price = 0.20m },
        new Ingredient { Name = "Bacon", Price = 1.50m }
    };

    // TODO-CORE-5: Implement Ingredient Management (CRUD operations for admin).
    // This action method would display a list of ingredients for admin to manage.
    public IActionResult ManageIngredients()
    {
        // TODO-CORE-4: Implement authorization to ensure only admin users can access this page.
        // For now, just return the view with available ingredients.
        return View(AvailableIngredients);
    }

    // TODO-CORE-5: Implement adding a new ingredient.
    [HttpPost]
    public IActionResult AddIngredient(Ingredient newIngredient)
    {
        // TODO-CORE-4: Implement authorization.
        // TODO-CORE-2: Save new ingredient to database instead of in-memory list.
        // AvailableIngredients.Add(newIngredient);
        return RedirectToAction(nameof(ManageIngredients));
    }

    // TODO-CORE-5: Implement editing an existing ingredient.
    [HttpPost]
    public IActionResult EditIngredient(Ingredient updatedIngredient)
    {
        // TODO-CORE-4: Implement authorization.
        // TODO-CORE-2: Update ingredient in database.
        // var existingIngredient = AvailableIngredients.FirstOrDefault(i => i.Name == updatedIngredient.Name);
        // if (existingIngredient != null) { existingIngredient.Price = updatedIngredient.Price; }
        return RedirectToAction(nameof(ManageIngredients));
    }

    // TODO-CORE-5: Implement deleting an ingredient.
    [HttpPost]
    public IActionResult DeleteIngredient(string name)
    {
        // TODO-CORE-4: Implement authorization.
        // TODO-CORE-2: Delete ingredient from database.
        // AvailableIngredients.RemoveAll(i => i.Name == name);
        return RedirectToAction(nameof(ManageIngredients));
    }

    // TODO-ADV-3: Implement Order History for Authenticated Users.
    // This action method would display a list of past orders for the current user.
    public IActionResult OrderHistory()
    {
        // TODO-CORE-4: Implement authentication to get current user's orders.
        // TODO-CORE-2: Retrieve orders from database.
        var userOrders = new List<BurgerViewModel>(); // Placeholder for user's past orders
        return View(userOrders);
    }

    // TODO-ADV-1: Implement Custom Burger Naming.
    // This action method would handle the naming of a custom burger.
    [HttpPost]
    public IActionResult NameBurger(List<string> selectedIngredientNames, string burgerName)
    {
        // TODO-UI-2: Add server-side validation for burgerName (e.g., not empty, unique).
        // This is a placeholder for processing the burger name.
        // The actual order logic would then proceed, possibly storing the name with the order.
        return RedirectToAction(nameof(Order), new { selectedIngredientNames = selectedIngredientNames });
    }

    // TODO-ADV-2: Implement Discount Codes/Promotions.
    // This action method would apply a discount code to an order.
    [HttpPost]
    public IActionResult ApplyDiscount(string discountCode, decimal currentTotal)
    {
        decimal newTotal = currentTotal;
        // TODO-ADV-2: Implement logic to validate discount code and apply discount.
        // Example: if (discountCode == "SAVE10") { newTotal *= 0.90m; }
        ViewBag.NewTotal = newTotal;
        return View("Order"); // Return to the order view, possibly with updated total
    }

    // TODO-CORE-3: Implement Order Confirmation and Tracking.
    // This action method would display a confirmation page after an order is placed.
    public IActionResult OrderConfirmation(string orderId)
    {
        // TODO-CORE-2: Retrieve order details from database using orderId.
        // TODO-CORE-3: Display order summary and tracking information.
        ViewBag.OrderId = orderId;
        return View();
    }

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Ingredients = AvailableIngredients;
        return View();
    }

    [HttpPost]
    public IActionResult Order(List<string> selectedIngredientNames)
    {
        var selectedIngredients = new List<Ingredient>();
        decimal totalCost = 0;

        if (selectedIngredientNames != null)
        {
            foreach (var name in selectedIngredientNames)
            {
                var ingredient = AvailableIngredients.FirstOrDefault(i => i.Name == name);
                if (ingredient != null)
                {
                    selectedIngredients.Add(ingredient);
                    totalCost += ingredient.Price;
                }
            }
        }

        var viewModel = new BurgerViewModel
        {
            SelectedIngredients = selectedIngredients,
            TotalCost = totalCost
        };

        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
