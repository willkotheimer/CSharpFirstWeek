using System;
using System.Text;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all");

            var vowels = new string[] { "a", "e", "i", "o", "u" };

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan"};

            foreach (var animal in animals)
            {
                var counter = 0;
                for (int i = 0; i < animal.Length; i++)
                {
                    for (int j = 0; j < vowels.Length-1; j++)
                    {
                   
                        if (String.Equals(animal[i].ToString(), vowels[j], StringComparison.OrdinalIgnoreCase))
                        {
                            counter++;
                        }
                    }
                }
              
                if (counter > 1) Console.WriteLine(animal);
            }
            
            var Greetings = new string[] { "Howdy Yall", "Dude", "Ohiyo" };

            
            Console.WriteLine($@"
                   Pick a Greeting:
                        1) {Greetings[0]}
                        2) {Greetings[1]}
                        3) {Greetings[2]}
                ");
            var yourGreeting = Console.ReadLine();

            switch (yourGreeting)
            {
                case "Howdy Yall":
                    Console.WriteLine("You're southern aren't you?");
                    break;
                case "Dude":
                    Console.WriteLine("You're Californian aren't you?");
                    break;
                case "Ohiyo":
                    Console.WriteLine("You're Japanese aren't you?");
                    break;
                default:
                    Console.WriteLine("You're southern aren't you?");
                    break;
            }


            Console.WriteLine("What is your favorite color?");
            var favoriteColor = Console.ReadLine();

            Random rand = new Random();
            int index = rand.Next(animals.Length);
            Console.WriteLine($@"Would you like to have a { favoriteColor  } { animals[index] } ?");

            var sb = new StringBuilder();

            Console.WriteLine("Please enter gibberish:");
            var someLetters = Console.ReadLine();

            for (var x=0; x<someLetters.Length; x++)
            {
                sb.Append(Char.ToUpper(someLetters[x]));
                for(var y = 0; y<=x; y++)
                {
                    sb.Append(Char.ToLower(someLetters[x]));
                }
                if (x!=someLetters.Length-1) sb.Append("-");
            }
            Console.WriteLine(sb);


            Console.WriteLine("Calculator:");
            Console.WriteLine("Enter a comma separated list of numbers (i.e. 1,2,3:");
            var myNums = Console.ReadLine();
            var myArr = myNums.Split(",");
            var myNum = 1;
            foreach(var a in myArr)
            {
                myNum *= int.Parse(a);
            }
            Console.WriteLine($"The Product = {myNum}");


        }

    }
}
