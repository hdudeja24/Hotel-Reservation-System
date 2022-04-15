using System;
using System.Data.SqlClient;


namespace Hotel_Reservation_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!, This is a test 2");
            Console.WriteLine("Writing another test.");
            Console.WriteLine("Harish made a change!");
        }
    }

    class Hotel
    {

        //This function accepts a string meant to represent a money value
        //it first checks to make sure that the length is at most 16
        //any larger wouldnt fit into the database, it then uses TryParse to 
        //check that the string is a valid double, returns true if so, false if not
        public static bool IsDouble(string price)
        {
            bool isGoodDouble;
            if (price.Length > 16)
            {
                isGoodDouble = false;
                return isGoodDouble;
            }
            else
            {
                isGoodDouble = long.TryParse(price, out _);
                return isGoodDouble;
            }
        }

    }

    class Report
    {

    }

    class Reservation
    {

        public static void MakeReservation()
        {

        }

        public static void PrepaidReserve()
        {

        }

        public static void SixtyDayReserve()
        {

        }

        public static void ConvReserve()
        {

        }

        public static void IncentReserve()
        {

        }

        public static void SelectDays()
        {

        }

        public static void CheckDays()
        {

        }


        //This function accepts a string meant to represent a credit card number
        //It first checks that the string has a length of 16, then it uses the
        //TryParse function to make sure the entire string is numerical
        //If the string is a valid credit card number, the function returns true
        //Otherwise, the function will return false
        public static bool CC_payment(string ccNum)
        {
            bool isGoodNum;
            if (ccNum.Length != 16)
            {
                isGoodNum = false;
                return isGoodNum;
            }
            else
            {
                isGoodNum = long.TryParse(ccNum, out _);
                return isGoodNum;
            }
        }


        //This function is passed a string meant to represent a date in the format yyyy-MM-dd
        //It first checks that the string os of length 10 and that the dashes are in the correct 
        //spots, it then makes sure that all of the other characters are numbers. Then, it takes
        //the month and day values and checks to make sure that they are valid values. If so,
        //the function will return true, otherwise it returns false
        public static bool ValidDate(string Date)
        {
            bool isGoodDate = true;
            if(Date.Length != 10)
            {
                isGoodDate = false;
                return isGoodDate;
            }
            if((Date[4] != '-') || (Date[7] != '-'))
            {
                isGoodDate = false;
                return isGoodDate;
            }
            if(!Char.IsDigit(Date[0]) || !Char.IsDigit(Date[1]) || !Char.IsDigit(Date[2]) || !Char.IsDigit(Date[3]) 
            || !Char.IsDigit(Date[5]) || !Char.IsDigit(Date[6]) || !Char.IsDigit(Date[8]) || !Char.IsDigit(Date[9]))
            {
                isGoodDate = false;
                return isGoodDate;
            }
        
            string monthStr = Date.Substring(5, 2);
            string dayStr = Date.Substring(8, 2);
            int month = int.Parse(monthStr);
            int day = int.Parse(dayStr);

            if((month < 1) || (month > 12))
            {
                isGoodDate = false;
                return isGoodDate;
            }
            if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
            {
                if ((day < 1) || (day > 31))
                {
                    isGoodDate = false;
                    return isGoodDate;
                }
            }
            else if((month == 4) || (month == 6) || (month == 9) || (month == 11))
            {
                if ((day < 1) || (day > 30))
                {
                    isGoodDate = false;
                    return isGoodDate;
                }
            }
            else if(month == 2)
            {
                if ((day < 1) || (day > 28))
                {
                    isGoodDate = false;
                    return isGoodDate;
                }
            }
            return isGoodDate;
        }




    }

}
