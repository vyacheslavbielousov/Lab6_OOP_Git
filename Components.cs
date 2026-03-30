using System;

public class IsothermalCabinet
{
    public bool doorOpen { get; private set; }
    public void OpenDoor()
    {
        doorOpen = true;
    }
    public void CloseDoor()
    {
        doorOpen = false;
    }
}   


public class Components
{
   private bool isRunning { get; private set; }
   public void Start()
   {
       isRunning = true;
   }
   public void Stop()
   {
       isRunning = false;
   }
}