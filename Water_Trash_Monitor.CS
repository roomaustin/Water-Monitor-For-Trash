using System;
using System.Threading;

class HazardMonitor
{
    private bool trashDetected;
    private bool bottleDetected;

    public HazardMonitor()
    {
        trashDetected = false;
        bottleDetected = false;
    }

    public void StartMonitoring()
    {
        Console.WriteLine("Monitoring for hazardous materials...");
        while (true)
        {
            // Simulate sensor readings
            trashDetected = DetectTrash();
            bottleDetected = DetectBrokenBottle();

            if (trashDetected)
                HandleTrashDetected();
            if (bottleDetected)
                HandleBrokenBottleDetected();

            Thread.Sleep(1000); // Pause for 1 second before checking again
        }
    }

    private bool DetectTrash()
    {
        // Simulate trash detection logic (replace with actual sensor reading)
        return false;
    }

    private bool DetectBrokenBottle()
    {
        // Simulate broken bottle detection logic (replace with actual sensor reading)
        return false;
    }

    private void HandleTrashDetected()
    {
        Console.WriteLine("Trash detected! Take necessary action.");
    }

    private void HandleBrokenBottleDetected()
    {
        Console.WriteLine("Broken bottle detected! Take necessary action.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HazardMonitor monitor = new HazardMonitor();
        monitor.StartMonitoring();
    }
}
