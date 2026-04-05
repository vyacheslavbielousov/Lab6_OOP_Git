using System;

public class SmartAirConditioner : SmartFridge
{
    private bool filterCleane { get; set; } = true;
    
    public void StartCooling()
    {
        Console.WriteLine("SmartAirConditioner is cooling...");
        if (!filterCleane)
            throw new SmartDeviceException("Air filter is dirty! Please clean it.");
        
        // Simulate cooling process
        Random random = new Random();
        if (random.Next(0, 10) == 5)
            throw new SmartDeviceException("Critical cooling system error!");
        
        Console.WriteLine("Cooling successful. Current temperature: " + targetTemperature + "°C");
    }
}
