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



        //This function is given a string meant to represent a money value
        //It will first check to make sure that the string has a length of 16
        //anything longer will be too large for our database
        //It then checks that the string can be converted to a double
        //if so, it returns true, if the string is not valid, return false
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

        //This Function accepts a string that will represent a credit card number
        //It will check to make sure the credit card number is 16 digits
        //It will then use the TryParse() function to make sure the string 
        //only contains numbers; returns true if the string is a valid credit card number
        //returns false if it is not
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

        //This function accepts a string made to represent the date in yyyy-MM-dd format
        //It checks that the string has a length of 10, it then checks to make sure the dashes
        //are in the correct position and that every character that is not a dash is a number.
        //It then checks that the numbers for the month and day are valid entries
        //returns false if date is not valid, returns true if date is valid
        public static bool ValidDate(string date)
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
