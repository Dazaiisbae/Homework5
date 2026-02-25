using System;
using System.Collections.Generic;
using System.IO;

public class ShapeManager {
    public static List<string> History = new List<string>();

    public void ProcessShape(string type, double val1, double val2, bool saveToFile) {
        double area = 0;


        // Problem 2: Infrastructure logic mixed with Business logic
        string report = $"Shape: {type}, Area: {area}, Date: {DateTime.Now}";
        Console.WriteLine("DEBUG: " + report);
        History.Add(report);

        if (saveToFile) {
            // Hardcoded dependency on File System
            File.AppendAllText("C:\\Temp\\ShapeLog.txt", report + Environment.NewLine);
        }
    }
}