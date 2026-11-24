using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region question1
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            //#endregion

            //#region question2
            //int[,] shelfCopies = {
            //{ 3,5},
            //{1,4 }
            //};
            //Console.WriteLine(shelfCopies[1,0]);
            //#endregion

            //#region question3

            //PrintWelcomeMessage();
            //#endregion

            //# region question4

            //PrintBookTitle("Clean Code");

            //#endregion
            //#region question5
            ////call by value 
            //int pages = 400;
            //Console.WriteLine($"before calling pages are: {pages}");
            //AddBonusPages(pages);
            //Console.WriteLine($"after calling pages are: {pages}");
            //#endregion

            //#region question6
            //passing by value for refernce type
            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine($"before calling price[0]is : {prices[0]}");
            //ApplyDiscount(prices);
            //Console.WriteLine($"after calling price[0]is : {prices[0]}");
            //#endregion

            //    #region question7 
            //    //call by reference
            //    int pages = 400;
            //    Console.WriteLine($"before calling pages are: {pages}");
            //    AddBonusPages(ref pages);
            //    Console.WriteLine($"after calling pages are: {pages}");
            //    #endregion

            //#region question8
            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine($"before calling array : {prices}");
            //Console.WriteLine($"before calling length  : {prices.Length}");
            //ReplaceArray(ref prices);
            //Console.WriteLine($"after calling  : {prices}");
            //Console.WriteLine($"after calling length  : {prices.Length}");
            //#endregion

            //#region question9
            //Console.WriteLine("in case of cleancode");
            //Console.WriteLine(TryGetPrice("CleanCode", out double clean_price));
            //Console.WriteLine("=============================");
            //Console.WriteLine("another title");
            //Console.WriteLine(TryGetPrice("iii", out double ano_title));
            //#endregion

            //#region question10
            //PrintBookInfo("CleanCode");
            //PrintBookInfo("cleancode", 350);
            //#endregion

            #region question11
            //passing by name
            PrintBookInfo(pages:350, title: "cleancode");
            #endregion

        }
        //*****************************methods*********************************//
        //#region question3
        //public static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        //#endregion

        //#region question4
        //public static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine($"Booktitle is: {title}");
        //}
        //#endregion

        //    #region question5
        //    public static int AddBonusPages(int pages)
        //    {
        //        return(pages += 50);
        //    }
        //    #endregion

        //#region question6
        //public static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}
        //#endregion

        //#region question7
        //public static int AddBonusPages( ref int pages)
        //   {
        //       return(pages += 50);
        //  }
        // #endregion

        //#region question8
        //public static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //}
        //    #endregion


        // #region question9
        //public static bool TryGetPrice(string title, out double price)
        // {
        //     if (title.Equals("CleanCode"))
        //     {
        //         price = 25.5;
        //         return true;
        //     }
        //     else
        //     {
        //         price =0;
        //         return false;
        //     }
        // }
        // #endregion

        #region question10&11
        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"title is: {title} \n pages are:{pages} ");
        }
        #endregion
    }

}
