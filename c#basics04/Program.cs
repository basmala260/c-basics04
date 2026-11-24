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

            #region question7 
            ////call by reference
            int pages = 400;
            Console.WriteLine($"before calling pages are: {pages}");
            AddBonusPages(ref pages);
            Console.WriteLine($"after calling pages are: {pages}");
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

        #region question7
        public static int AddBonusPages( ref int pages)
           {
               return(pages += 50);
          }
         #endregion
    }
}
