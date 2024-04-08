using System;

class Program
{
    static void Main(string[] args)
    {
        Outdoor outdoor = new Outdoor("Sunny","Outdoor","Pickleball","Playing pickleball at the court","April 8, 2024","2pm");
        Address address = new Address("139 West South 4th","Rexburg ","ID","USA");
        outdoor.shortDesc();
        outdoor.standardDesc();
        address.Display();
        Console.WriteLine();
        outdoor.outDesc();
        outdoor.standardDesc();
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------------------");

        Lectures lectures = new Lectures("Russel M Nelson",3000,"Lecture","General Conference","Having many talks given by the general authority in the church of Jesus Christ of Latter-day Saints","April 7, 2024","10am");
        lectures.shortDesc();
        lectures.standardDesc();
        Console.WriteLine();
        lectures.lecDesc();
        lectures.standardDesc();
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------------------");

        Reception reception = new Reception("yutoakatsuka2021@gmail.com","Reception","Concert","BYU vocal Point will be coming","June 15, 2024","5pm");
        reception.shortDesc();
        reception.standardDesc();
        Console.WriteLine();
        reception.recDesc();
        reception.standardDesc();
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------------------");
    }
    
}