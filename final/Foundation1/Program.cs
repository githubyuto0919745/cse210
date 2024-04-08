using System;

class Program
{
    static void Main(string[] args)
    {

        bool  quit = false;

        while (!quit)
        {      
            System.Console.WriteLine("Welcome to YouTube ");
            System.Console.WriteLine("1. BYU Vocal Points");
            System.Console.WriteLine("2.  One piece ");
            System.Console.WriteLine("3. Cooking ");
            System.Console.WriteLine("3. quit ");

            System.Console.WriteLine("Please select a YouTube video ");
            int choice = int.Parse(Console.ReadLine());
          
            switch (choice)
            {
                case 1:
                Video video1 = new Video("Drag Me Down + As Long As You Love Me MASHUP","BYU Vocal Point",214);
                Comment comment1 = new Comment("Nicholas","Anyone still constantly listeining to them 5 years later tdy");
                Comment comment2 = new Comment("Xtremis", "Anyone in 2020, for this great mashup of tewo iconic songs?");
                Comment comment3 = new Comment("Faitharco", "That beat boxer tho, You guys are fantastic!");
                video1.Getcomment(comment1);
                video1.Getcomment(comment2);
                video1.Getcomment(comment3);
                video1.Display();
                System.Console.WriteLine(video1.CommentAmount());
                video1.DisplayComments();
                break;

                case 2:
                Video video2 = new Video("One piece season2","Eiichiro Oda",102);
                Comment comment1a = new Comment("XenoZath","It's clips from the pirates of the Caribbean and one piece ");
                Comment comment2a = new Comment("Jarrea", "What an adhd kind of a guy who makes a vid from previous series");
                Comment comment3a = new Comment("Neo", "Is this made with AI (voices)?, well job in any case");
                video2.Getcomment(comment1a);
                video2.Getcomment(comment2a);
                video2.Getcomment(comment3a);
                video2.Display();
                System.Console.WriteLine(video2.CommentAmount());
                video2.DisplayComments();
                break;


                case 3:
                Video video3 = new Video("Quick & Easy Recipes","Gordon Ramsay",102);
                Comment comment1b = new Comment("Armvieri","Gordon’s regular phrases ; “Delicious”, “Stunning”, “Beautiful”, “Amazing”, “Look at that” ");
                Comment comment2b = new Comment("Treescorer", "This guy loves to cook, you can see how happy he is while he is cooking. Truly cooking from the heart.");
                Comment comment3b = new Comment("Ajbuckets", "This is what I love about Gordon he just chuck stuff in there without any measurements and it’s so much easier that way");
                video3.Getcomment(comment1b);
                video3.Getcomment(comment2b);
                video3.Getcomment(comment3b);
                video3.Display();
                System.Console.WriteLine(video3.CommentAmount());
                video3.DisplayComments();
                break;

                case 4:
                Environment.Exit(0);
                break;


            } 

        }    
    }
}