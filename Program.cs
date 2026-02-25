using System;

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        ShapeService service = new ShapeService(logger);

        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);
        Shape hex = new Hexagon(3);
        
        service.ProcessShape(hex);
        service.ProcessShape(circle);
        service.ProcessShape(rectangle);
    }
}