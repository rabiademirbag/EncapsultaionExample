using EncapsultaionExample;

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.Brand = "Land Rover";
        car.Model = "Range Rover Velar";
        car.Color = "Batumi Gold";
        car.NumberOfDoor = 1;

        car.CarInfo();
    } 
}
