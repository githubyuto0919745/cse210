using System;

class Program
{
    static void Main(string[] args)
    {
        Bicycles bicycles = new Bicycles("April 10","Bicycles",6,8);
        bicycles.Distance();
        bicycles.Speed();
        bicycles.Pace();
        bicycles.GetSummary();
        Running running = new Running("June 21, 2024","Running", 10, 3);
        running.Distance();
        running.Speed();
        running.Pace();
        running.GetSummary();
        Swimming swimming = new Swimming("July 23, 2024","Swimming",4,7);
        swimming.Distance();
        swimming.Speed();
        swimming.Pace();
        swimming.GetSummary();
    }
}