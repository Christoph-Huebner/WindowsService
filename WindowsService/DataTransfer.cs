using System.Xml.Serialization;

namespace WindowsService;

public class DataTransfer
{
    public void ProcessData()
    {
        var car = new Car
        {
            Make = "Toyota",
            Model = "Camry",
            Year = 2020
        };

        XmlSerializer serializer = new(typeof(Car));
        using StringWriter writer = new();
        serializer.Serialize(writer, car);
        string xml = writer.ToString();
        Console.WriteLine("Serialized XML:");
        Console.WriteLine(xml);
    }
}

public class Car
{
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Make} {Model}, Year: {Year}");
    }
}
