using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Program
    {
        public static int ChooseOperation()
        {
            int OperationType;
            Console.WriteLine("Library Management System");
            Console.WriteLine();
            Console.Write(" - 1. Enter Data :: ");
            Console.Write(" - 2. View Data :: ");
            Console.Write(" - 3. Delete Data :: ");
            Console.Write(" - 4. Update Data :: ");
            Console.Write(" - 5. Press 5 to exit :: ");
            OperationType = Convert.ToInt32(Console.ReadLine());
            if ( OperationType == 5)
            {
                Environment.Exit(0);
            }
            return OperationType;
        }

        static void Main(string[] args)
        {
            int OperationType;

            // Updating the Console Font Color 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            
            //Choosing operation type - Insert, Update, Delete
            OperationType = ChooseOperation();

            switch (OperationType) {
                case 1:
                    Console.WriteLine("Option Choosed to enter data");
                    var OperationInsertResult = LibraryOperations.InsertData();
                    if (OperationInsertResult)
                    {
                        Console.WriteLine("Inserting data was successfull");
                    }
                    ChooseOperation();
                    break;
                case 2:
                    Console.WriteLine("Option Choosed to view data");
                    var OperationViewResult = LibraryOperations.ViewData();
                    if (OperationViewResult)
                    {
                        Console.WriteLine("View Data Successfull");
                    }
                    ChooseOperation();
                    break;
                default:
                    Console.WriteLine("There is no such option choose again");
                    ChooseOperation();
                    break;
            }
           
            // Keeping console Command palate alive
            Console.ReadLine();
        }

      

    }
}
