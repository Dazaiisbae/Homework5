public class ShapeService
{
    private readonly ILogger _logger;
    private readonly List<string> _history = new List<string>();

    public ShapeService(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessShape(Shape shape)
    {
        double area = shape.CalculateArea();

        string report =
            $"Shape: {shape.GetType().Name}, Area: {area}, Date: {DateTime.Now}";

        _history.Add(report);
        _logger.Log(report);
    }

    public IReadOnlyList<string> GetHistory()
    {
        return _history.AsReadOnly();
    }
}