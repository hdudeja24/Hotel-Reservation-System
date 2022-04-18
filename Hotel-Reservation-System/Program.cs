using System;
using System.IO;
using System.Data.SqlClient;

namespace Hotel_Reservation_System
{

   
    class Program
    {
        
       
        static void Main(string[] args)
        {
            //here is the login, the user will enter the role they want to login as, must be a guest, employee, or manager
            string login;
            Console.WriteLine("Welcome. Are you signing in as a 'Guest', 'Employee', or 'Manager'?");

            //only allow a login if they enter a valid account type
            while (true)
            {   
                login = Console.ReadLine();
                if((login == "Guest") || (login == "Employee") || (login == "Manager"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Login. Type 'Guest', 'Employee', or 'Manager' to login as your role.");
                }
            }

            //actions that can be performed as a guest:
            //Making a reservation, cancelling a reservation, rescheduling a reservation, or providing credit card info
            if(login == "Guest")
            {
                string GuestAction;
                Console.WriteLine("Would you like to 'Make', 'Cancel', or 'Reschedule' a reservation?");
                Console.WriteLine("Or, if you've already made a 60-Day reservation, Would you like to 'Add' your credit card info?");
                while(true)
                {
                    GuestAction = Console.ReadLine();
                    if((GuestAction == "Make") || (GuestAction == "Cancel") || (GuestAction == "Reschedule") || (GuestAction == "Add"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Action. Enter 'Make', 'Cancel', or 'Reschedule', or 'Add'.");
                    }
                }

                if(GuestAction == "Make") //Making a reservation
                {
                    Reservation.MakeReservation();
                }
                if(GuestAction == "Cancel") //Cancelling a reservation
                {
                    //Reservation.CancelReserve();
                }
                if(GuestAction == "Reschedule") //Rescheduling a reservation
                {
                    //Reservation.RescheduleReserve();
                }
                if(GuestAction == "Add")
                {
                    //Reservation.Add_CC_Info();
                }
            }

            //actions that can be performed as an employee
            //
            if(login == "Employee")
            {

            }
            //actions that can be performed as a manager
            //
            if(login == "Manager")
            {

            }


            
        }
    }

    public class Hotel
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

    public class Report
    {

    }

    public class Reservation
    {

        public static void MakeReservation()
        {
            Console.WriteLine("\nYou are now about to make a reservation.");
            Console.WriteLine("Which type of reservation would you like to make?");
            Console.WriteLine("-'P' for Prepaid  -'S' for 60 Day  -'C' for Conventional    -'I' for Incentive");
            string selectReservation;
            while(true)
            {
                selectReservation = Console.ReadLine();
                if((selectReservation == "P") || (selectReservation == "S") || (selectReservation == "C") || (selectReservation == "I"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid reservation type.");
                     Console.WriteLine("Enter 'P' for Prepaid, 'S' for 60 Day, 'C' for Conventional, or 'I' Incentive");
                }
            }

            if(selectReservation == "P")
            {
                //prepaidReserve();
            }
            if(selectReservation == "S")
            {
                //SixtyDayReserve();
            }
            if(selectReservation == "C")
            {
                //ConvReserve();
            }
            if(selectReservation == "I")
            {
                //IncentReserve();
            }
            Console.WriteLine("Reservation Complete.");
        }

        public static void PrepaidReserve()
        {
            string reserveType = "prepaid";
            string FName, LName, CCNum;
        }

        public static void SixtyDayReserve()
        {
            string reserveType = "sixty";
        }

        public static void ConvReserve()
        {
            string reserveType = "conventional";
            string FName, LName, CCNum;
        }

        public static void IncentReserve()
        {
            string reserveType = "incentive";
            string FName, LName, CCNum;
        }

        //string reserveType will let this function know what days 
        //to let the guest select from
        public static void SelectDays(string reserveType)
        {

        }

        public static void CheckDays()
        {

        }

        public static void CancelReserve()
        {

        }

        public static void RescheduleReserve()
        {

        }

        //get Fname and Lname, check that they have a 60-day reservation
        //and that credit card info is null, if so, update their reservation
        //otherwise give message saying 'no reservation for that name' or
        //'already have credit card info for you'
        public static void Add_CC_Info()
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
