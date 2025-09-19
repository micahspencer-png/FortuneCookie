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
            string[] fortunes = [""] ;
            
            fortunes[0] = "Fortune 1";
            fortunes[1] = "Fortune 2";
            fortunes[2] = "Fortune 3";
            fortunes[3] = "Fortune 4";
            fortunes[4] = "Fortune 5";
            fortunes[5] = "Fortune 6";

            Console.WriteLine(fortunes[0]);

            Console.WriteLine("Press Enter to Quit");
            Console.Read();
        }
    }
}
