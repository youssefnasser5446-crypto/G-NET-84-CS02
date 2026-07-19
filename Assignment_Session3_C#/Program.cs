namespace Assignment_Session3_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /*
             
            1. Given int pages = 464; and bool isAvailable = true;,
            print "You can borrow this book" only
            if pages is greater than 300 and isAvailable is true.
            Use the && operator.
              
            */

            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}

            #endregion

            #region Question02
            /*
             2. Given string title = "Refactoring";, 
            write a switch statement that prints "Great choice!"
            if the title is "Clean Code", 
            "Nice pick!" if it's "Refactoring",
            and "Never heard of it" for anything else. 
             */
            string title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region Question03

            /*
             3. Given int pages = 464;,
            use the ternary operator to store "Long Book" or "Short Book"
            into a variable sizeLabel (same rule as question 6: long if pages > 300).
             */

            //int pages = 464;

            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);
            #endregion

            #region Question04

            /*
             4. Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };,
            use a for loop to print each book with its position number, like 1. Clean Code.
             */

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i<= books.Length -1 ; i++)
            {
                Console.WriteLine($"{(i+1)+". "+ books[i]}");
            }

            #endregion


        }
    }
}
