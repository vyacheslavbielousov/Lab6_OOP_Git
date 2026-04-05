using System;
using System.Collections.Generic;

public class SmartFridge
{
    public delegate void FridgeHandler(string message);
    public event FridgeHandler OnTemperatureChanged;
    public event FridgeHandler OnAlert;

    private IsothermalCabinet cabinet;
    private Components components;

    private List<Product> products;

    private double currentTemperature;
    public double targetTemperature { get; set; } = 4.0; // Default target temperature in Celsius

    public SmartFridge()
    {
        cabinet = new IsothermalCabinet();
        compressor = new Compressor();
        products = new InitialProducts;
        currentTemperature = 4.0; // Initial temperature
    }
    public void OpenFridge()
    {
        cabinet.OpenDoor();
        components.Stop();
    }
    public void CloseFridge()
    {
        cabinet.CloseDoor();
        components.Start();
    }
}