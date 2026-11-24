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
            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine($"Prices before : {prices[0]}");
            //ApplyDiscount(prices);
            //Console.WriteLine($"Prices after : {prices[0]}");
            //// the effect has been done , because the array is a reference type 

            #endregion

            #region Q07
            //int pages = 400;
            //Console.WriteLine($"pages before : {pages}");
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine($"pages after : {pages}");
            //// the value has been changed because we passed it by reference 

            #endregion

            #region Q08 
            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine($"length of prices (before) : {prices.Length}");
            //ReplaceArray(ref prices);
            //Console.WriteLine($"length of prices (after) : {prices.Length}");

            #endregion

            #region Q09
            double price;
            if(TryGetPrice("Clean Code", out price))
                Console.WriteLine(price);
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

        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        static bool TryGetPrice(string title, out double price)
        {
            if(title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
    }
}
