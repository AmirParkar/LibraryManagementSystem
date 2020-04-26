using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class LibraryOperations
    {
        public static Boolean InsertData()
        {
            
            DateTime InputBorrowedFromDate = DateTime.Now;
            DateTime InputBorrowedToDate = AlterDateForDays(7);

            Console.WriteLine("Please enter the details");
            String InputBookName = Console.ReadLine();
            String InputIssuedBy = Console.ReadLine();

            using (var db = new LibraryContext())
            {
                db.BorrowerDetails.Add(new BorrowerDetails {
                    BookName = InputBookName,
                    BorrowedFromDate = InputBorrowedFromDate,
                    BorrowedToDate = InputBorrowedToDate,
                    IssuedBy = InputIssuedBy
                });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("Values in the database");
                foreach (var item in db.BorrowerDetails)
                {
                    Console.WriteLine(" - {0}", item.ToString());
                }
            }


            return true;
        }

        public static Boolean ViewData()
        {
            using (var db = new LibraryContext())
            {
                Console.WriteLine("Values in the database");
                foreach (var item in db.BorrowerDetails)
                {
                    Console.WriteLine(" - {0}", item.ToString());
                }
            }
            return true;
        }

        public static Boolean DeleteDate()
        {
            return true;
        }

        public static Boolean UpdateData()
        {
            return true;
        }

        public static DateTime AlterDateForDays(int appendDays)
        {
            var CurrentDate = DateTime.Now;
            CurrentDate = CurrentDate.AddDays(appendDays);
            if (CurrentDate.ToString("ddd") == "Sat")
            {
                return CurrentDate.AddDays(2);
            }
            else if (CurrentDate.ToString("ddd") == "Sun")
            {
                return CurrentDate.AddDays(1);
            }else
            {
                return CurrentDate;
            }
        }
    }
}
