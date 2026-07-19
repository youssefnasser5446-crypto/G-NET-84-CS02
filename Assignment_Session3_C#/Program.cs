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

            #region Question05

            /*
             5. Using the same books array, use a while loop to print every book title
             */
            Console.WriteLine("while loop ================");
            int j = 0; 
            while (j < books.Length)
            {
                Console.WriteLine(j+1 +". " + books[j]);
                j++;
            }

            #endregion

            #region Question06

            /*
             6. Write a do-while loop that prints "Checking book..." exactly 3 times.
             */
            Console.WriteLine("do_while=================================");
            int k = 0;
            do
            {
                Console.WriteLine("Checking book...");
                k++;
            } while (k < 3);


            #endregion

            #region Question07

            /*
              7. Using the same books array,
            use a foreach loop to print every book title.
             */
            Console.WriteLine("foreach =====================================");
            foreach(string bookTitle in books)
            {
                Console.WriteLine(bookTitle);
            }

            #endregion

            #region Question08

            /*
             8. Using the same books array,
            loop through it and print each title,
            but stop completely (break) once you reach "Refactoring".
             */
            Console.WriteLine("break===========================");
            for (int T = 0; T < books.Length; T++)
            {
                if (books[T] == "Refactoring")
                    break;
                Console.WriteLine(books[T]);
            }

            #endregion

            #region Question09

            /*
             9. Using the same books array
            print every title except 
            "The Pragmatic Programmer" (skip it with continue, don't stop the loop).
             */

            Console.WriteLine("continue===========================");
            for (int T = 0; T < books.Length; T++)
            {
                if (books[T] == "The Pragmatic Programmer")
                    continue;
                Console.WriteLine(books[T]);
            }

            #endregion

            #region Question10

            /*
             10. Write a method PrintFirstBook()
            that prints the first book in the books array.
            If the array is empty,
            use return to exit the method early instead of printing anything.
             */
            Console.WriteLine("function===================================");
            void PrintFirstBook()
            {
                if (books.Length != 0)

                    Console.WriteLine($"the first book is {books[0]}");
                else
                    return;
            }
            PrintFirstBook();
            #endregion
        }
    }
}
