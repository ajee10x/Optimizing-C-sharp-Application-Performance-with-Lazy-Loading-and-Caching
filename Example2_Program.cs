using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        // Use a list to store items
        List<string> items = new List<string>();

        // Use a Stopwatch to measure the time taken to add items
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        stopwatch.Start();

        // Add items to the list
        for (int i = 0; i < 1000000; i++) {
            items.Add("Item " + i.ToString());
        }

        // Stop the stopwatch and output the time taken
        stopwatch.Stop();
        Console.WriteLine("Time taken to add items: " + stopwatch.ElapsedMilliseconds + "ms");

        // Use a HashSet to check if an item is in the list
        HashSet<string> itemSet = new HashSet<string>(items);

        // Use a Stopwatch to measure the time taken to check if an item is in the list
        stopwatch.Reset();
        stopwatch.Start();

        // Check if an item is in the list
        bool containsItem = itemSet.Contains("Item 500000");

        // Stop the stopwatch and output the time taken
        stopwatch.Stop();
        Console.WriteLine("Time taken to check if an item is in the list: " + stopwatch.ElapsedMilliseconds + "ms");
    }
}


// In this example, we use a List to store items and a HashSet to check if an item is in the list. The HashSet provides faster lookups than the List, especially for large collections of data.


// We also use a Stopwatch to measure the time taken to add items to the list and to check if an item is in the list. This allows us to benchmark the performance of the program and compare different techniques.

// This example demonstrates some of the common techniques for optimizing the performance of C# programs, such as using efficient data structures, benchmarking, and profiling. These techniques can be applied to a wide range of programs to improve their efficiency and responsiveness.





