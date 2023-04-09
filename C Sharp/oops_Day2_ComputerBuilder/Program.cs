using System;
using System.Collections.Generic;

// Interface for components
public interface IComponent
{
    void ViewComponent();
  
}

// Interface for users
public interface IUser
{
    void AddComponent(Component component);
    void RemoveComponent(Component component);
    void ViewComputer();
}

// Interface for computers
public interface IComputer
{
    decimal CalculatePrice();
    void ViewComponents();
}

// Class for components
public class Component : IComponent
{
    public string Type { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }

    public void ViewComponent()
    {
        Console.WriteLine($"Type: {Type}, Brand: {Brand}, Model: {Model}, Price: {Price}");
    }

}

// Class for computers
public class Computer : IComputer
{
    public string Name { get; set; }
    public List<Component> Components { get; set; }

    public decimal CalculatePrice()
    {

        throw new NotImplementedException();
    }

    public void ViewComponents()
    {
    
        foreach (var component in Components)
        {
            component.ViewComponent();
        }
    }
}

// Class for users
public class User : IUser
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Computer Computer { get; set; }

    public void AddComponent(Component component)
    {
    
        Computer.Components.Add(component);
    }

    public void RemoveComponent(Component component)
    {
     
        Computer.Components.Remove(component);
    }

    public void ViewComputer()
    {
        // Display the user's computer and its components
        Console.WriteLine($"Computer name: {Computer.Name}");
        Console.WriteLine("Components:");
        Computer.ViewComponents();
    }
}
