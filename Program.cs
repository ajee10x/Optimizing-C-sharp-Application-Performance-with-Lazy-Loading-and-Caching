using System;
using System.Collections;

public class Program {
    private static Hashtable cache = new Hashtable();

    public static void Main() {
        // Get data from database (assume this is an expensive operation)
        string[] data = GetDataFromDatabase();

        // Cache the data
        cache["data"] = data;

        // Lazy loading: Get the data from the cache only when needed
        string[] cachedData = (string[]) cache["data"];

        // Do something with the data (e.g. display it)
        DisplayData(cachedData);
    }

    private static string[] GetDataFromDatabase() {
        // Assume this is an expensive database query
        return new string[] {"data1", "data2", "data3"};
    }

    private static void DisplayData(string[] data) {
        foreach (string item in data) {
            Console.WriteLine(item);
        }
    }
}
