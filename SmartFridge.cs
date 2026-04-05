using System;
using System.Collections.Generic;

public class SmartFridge
{
    public delegate void FridgeHandler(string message);
    public event FridgeHandler OnTemperatureChanged;
    public event FridgeHandler OnAlert;

    private IsothermalCabinet cabinet;
    private Compressor compressor;

    private List<Product> products;

    private double currentTemperature;
    public double targetTemperature { get; set; } = 4.0; // Default target temperature in Celsius

    public SmartFridge()
    {
        cabinet = new IsothermalCabinet();
        compressor = new Compressor();
        products = new InitialProducts;
        currentTemperature = 10.0; // Initial temperature
    }

    public void Work()
    {
        Console.WriteLine("SmartFridge is working...");

        // Simulate random compressor failure
        Random random = new Random();
        if (random.Next(0, 10) == 7)
            throw new SmartDeviceException("Critical compressor error!");

        CheckProducts();
        RegulateTemperature();
    }

    private void CheckProducts()
    {
        foreach (var product in products)
        {
            if (product.ExpirationDate < DateTime.Now)
            {
                OnAlert?.Invoke($"Product {product.Name} has expired!");
            }
        }
    }

    private void RegulateTemperature()
    {
        if (currentTemperature > targetTemperature)
        {
            compressor.Start();
            currentTemperature -= 0.5; // Simulate cooling
            OnTemperatureChanged?.Invoke($"Current temperature: {currentTemperature}°C");
        }
        else
        {
            compressor.Stop();
            OnTemperatureChanged?.Invoke($"Current temperature: {currentTemperature}°C");
        }
    }
}