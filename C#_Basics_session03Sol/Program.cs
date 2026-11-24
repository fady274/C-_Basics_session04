namespace C__Basics_session03Sol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01

            //double [] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);

            #endregion

            #region Q02

            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1, 0]);

            #endregion

            #region Q03

            //PrintWelcomeMessage();

            #endregion

            #region Q04

            //PrintBookTitle("Route");

            #endregion

            #region Q05
            //int pages = 400;
            //Console.WriteLine($"pages before : {pages}");
            //AddBonusPages(pages);
            //Console.WriteLine($"pages after : {pages}");
            //// No change because we passed it by value 


            #endregion

            #region Q06
            double[] prices = { 25.5, 40.0 };
            Console.WriteLine($"Prices before : {prices[0]}");
            ApplyDiscount(prices);
            Console.WriteLine($"Prices after : {prices[0]}");
            // the effect has been done , because the array is a reference type 

            #endregion
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title : {title}");
        }

        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
    }
}
