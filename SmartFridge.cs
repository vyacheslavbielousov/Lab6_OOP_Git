public class SmartFridge
{
    private IsothermalCabinet cabinet;
    private Components components;
    public SmartFridge()
    {
        cabinet = new IsothermalCabinet();
        components = new Components();
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