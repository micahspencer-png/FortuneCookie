namespace FortuneCookie
{
    //Micah Spencer
    //RCET2265
    //Fall 2025
    //Fortune Cookie Program
    //https://github.com/micahspencer-png/FortuneCookie.git

    internal class Program
    {
        static void Main(string[] args)
        {
            //sets up an array
            string[] fortunes = ["0","1","2","3","4","5"] ;
            
            //determines what is in the array
            fortunes[0] = "There is No Wisdom Greater than Kindness.";
            fortunes[1] = "Stay True to Your Values; They Define You.";
            fortunes[2] = "You Discover Treasures Where Others See Nothing.";
            fortunes[3] = "Your Potential Knows No Bounds.";
            fortunes[4] = "Your Determination is Your Greatest Asset.";
            fortunes[5] = "Good Friends are Worth More than Gold.";

            //sets up a random number
            Random Roll = new Random();
            
            //converts random number into an integer
            int roll = Roll.Next(0, 6);

            //writes the line that is determined by the number
            Console.WriteLine(fortunes[roll]);
            
            //prompts the user to exit program
            Console.WriteLine("Press Enter to Quit");

            //creates a pause
            Console.Read();
        }
    }
}
