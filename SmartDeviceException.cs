using System;

public class SmartDeviceException : Exception
{
    public DateTime ErrorTime { get; }
    public SmartDeviceException(string message) : base(message)
    {
        ErrorTime = DateTime.Now;
    } 
}