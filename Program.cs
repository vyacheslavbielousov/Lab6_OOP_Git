using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating products (Agregation)
        var myProducts = new List<Product>
        {
            new Product("Milk", DateTime.Now.AddDays(-1)),
            new Product("Cheese", DateTime.Now.AddDays(5))
        };

        // Initializing fridge
        SmartFridge fridge = new SmartFridge(myProducts);

        // Events initializing
        fridge.OnAlert += (msg) => Console.WriteLine($"[Alert]: {msg}");
        fridge.OnTemperatureChanged += (msg) => Console.WriteLine($"[Telemetry]: {msg}");

        try
        {
            fridge.ExecuteVoiceCommand("Product status?");
            for (int i = 0; i < 5; i++)
            {
                fridge.Work();
            }
        }
        catch (SmartDeviceException ex)
        {
            Console.WriteLine($"Components error ({ex.ErrorTime}): {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"System error: {ex.Message}");
        }

        Console.WriteLine("\nWork with conditioner:");
        SmartAirConditioner ac = new SmartAirConditioner();
        ac.StartCooling();
    }
}