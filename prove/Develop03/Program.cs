using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<string> scriptures = new List<string>
        {
            "John 3:16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "John 3:17 For God sent not his Son into the world to condemn the world; but that the world through him might be saved.",
            "John 3:18 He that believeth on him is not condemned: but he that believeth not is condemned already, because he hath not believed in the name of the only begotten Son of God.",
            "John 3:19 And this is the condemnation, that light is come into the world, and men loved darkness rather than light, because their deeds were evil.",
            "John 3:20 For every one that doeth evil hateth the light, neither cometh to the light, lest his deeds should be reproved.",
            "John 3:21 But he that doeth truth cometh to the light, that his deeds may be made manifest, that they are wrought in God.",
            "John 3:22 After these things came Jesus and his disciples into the land of Juda; and there he tarried with them, and baptized."
        };

        Program program = new Program();
        program.Displaymenu(scriptures);
        Console.Write("Type the number of scripture that wanting to memorize?");
        int userindex = int.Parse(Console.ReadLine());
        
        Reference reference = new Reference ("John",3,userindex);
        Scripture scripture = new Scripture(scriptures[userindex -1], reference);
        scripture.Display();
        
    }

    public void Displaymenu(List<string>scriptures)
    {
        Console.WriteLine("Scriptures:");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i]}");
        }
    }
    
} 