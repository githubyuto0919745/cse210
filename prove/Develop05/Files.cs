using System.Formats.Asn1;
using System.IO.Enumeration;

public class Files
{
    public void SaveFile(string fileName, List<Goals> goals, int points)
    {
        Console.Write("Enter the filename to save goals: ");
        fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(points);
            foreach (Goals goal in goals)
            {
                writer.WriteLine(goal.DisplayFile());
            }
        }
        
    
    }
    public (List<Goals>, int) LoadFile(string fileName)
    {
        Console.WriteLine("Enter the filename to load goals from: ");
        fileName = Console.ReadLine();
            int totalPoints = 0;
            List<Goals> goals = new();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                bool firstline = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (firstline)
                    {
                        totalPoints = int.Parse(line);
                        firstline = false;
                    }
                    else
                    {
                        string[] data = line.Split(',');
                        if (data[0] == "1")
                        {
                            goals.Add(new Simple(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                        }
                        else if (data[0] == "2")
                        {
                            goals.Add(new Eternal(data[0], data[1], int.Parse(data[2])));
                        }
                        
                        else if (data[0] == "3")
                        {
                            goals.Add(new Checklist(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4])));
                        }
                    }
                }
            }
            
        
        return (goals, totalPoints);
    }

    
}

