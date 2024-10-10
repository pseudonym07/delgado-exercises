namespace codespaces_blank;
using System;


class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        
        // Create a dice roll simulation
        // which takes an int for how many rolls, as well as an int for the goal number
        // return true if you get the goal number within the rolls otherwise return false
        // Show amount of rolls too
    
        Console.WriteLine("How many rolls?");
        String input1 = Console.ReadLine();
        int rolls = Convert.ToInt32(input1);
        
        
        Console.WriteLine("Target?");
        String input2 = Console.ReadLine();
        int target = Convert.ToInt32(input2);
        
        int guess;
        
        int numOfRolls = 0;
    
        
    for (int i = 0 ; i < rolls; i++) {

        numOfRolls++;
        
        guess = rnd.Next(1,6);
        
        if (guess == target ){
            Console.WriteLine("Target hit!"); //True
            Console.WriteLine("Number of performed rolls: " + numOfRolls);
            break;
        }
        else{

            Console.WriteLine("Missed! You got unlucky, Sorry!"); // False
            

        }
        
    }

        
    }
}
