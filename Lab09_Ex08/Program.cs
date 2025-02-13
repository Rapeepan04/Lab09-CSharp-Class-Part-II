using System;

class Program
{
    static void Main()
    {
        Circle.PrintCircleArea(100);
    }
}

class Circle
{
    const double PI = 3.14159;  // ค่าคงที่ PI

    public static void PrintCircleArea(double radius)
    {
        // ไม่สามารถเปลี่ยนแปลงค่าของ PI ได้
        Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}
