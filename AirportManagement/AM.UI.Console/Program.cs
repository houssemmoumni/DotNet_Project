using AM.ApplicationCore.Domain;

class Program
{
    static void Main(string[] args)
    {
        Plane plane = new Plane
        {
            PlaneType = PlaneType.Airbus,
            Capacity = 200,
            ManufactureDate = new DateTime(2018, 11, 10)
        };

        Console.WriteLine(plane.ToString()); 
    }
}



