using GradingSystem;
using System;

class Program {
    static void Main(string[] args) {

        string title = """

            |           GRADING SYSTEM          |


            """;
        Console.WriteLine(title);
        StudentResultProcessor processor = new StudentResultProcessor();

        try
        {
            processor.ReadStudentsFromFile("data.txt");
        }
        catch (Exception ex) { 
            Console.WriteLine(ex.Message);
        }
    }

}