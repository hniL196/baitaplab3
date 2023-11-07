using System.Collections;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        List<Car> cars = new()
        {
            new Car("Toyota Camry","Red"),
            new Car("Ford Mustang","Blue"),
            new Car("Honda Civic","Blue"),
            new Car("Chevrolet Silverado","Gray"),
            new Car("Nissan Altima","Blue"),
            new Car("Volkswagen Golf","Red"),
            new Car("Hyundai Elantra","Blue"),
            new Car("BMW 3 Series","Black"),
            new Car("Audi Q5","Blue"),
            new Car("Mercedes-Benz E-Class","Red"),
        };
        
        RemoveCarRedColor(cars);
        ShowCar(cars);
        
    }
    static void RemoveCarRedColor(List<Car> cars)
    {
        Console.WriteLine("Mau muon xoa:");
        string colorchoose = Console.ReadLine();

        for(int i = cars.Count -1 ; i > 0; i--)
        {
            if(cars[i].Color.Equals(colorchoose))
                cars.RemoveAt(i);
        }
    }

    static void ShowCar(List<Car> cars)
    {
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }
}

class Car
{
    public string Name;
    public string Color { get; set; }
    public Car(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public override string ToString()
    {
        return $"Name: {Name} - Color: {Color}";
    }
}
