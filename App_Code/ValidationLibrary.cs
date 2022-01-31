using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebCalcW1.App_Code
{
    class ValidationLibrary
    {
        public static bool State1(string temp)
        {
            bool result = false;

            if (temp.Length == 2)
            {
                result = true;
            }

            return result;
        }
        public static bool Zip1(string temp)
        {
            bool result = false;

            if (temp.Length == 5)
            {
                result = true;
            }

            return result;
        }
        public static bool Phone1(string temp)
        {
            bool result = false;

            if (temp.Length == 12)
            {
                result = true;
            }

            return result;
        }


        public static bool Phone2(string temp)
        {
            bool result = false;

            if (temp.Length == 12)
            {
                result = true;
            }

            return result;
        }



        public static bool GotBadWords(string temp)
        {
            bool result = false;

            string[] strBadWords = { "POOP", "HOMEWORK", "CACA" };

            foreach (string strBW in strBadWords)
                if (temp.Contains(strBW))
                {
                    result = true;
                }

            return result;
        }

        /*
         * 
         * 
         * 
         * 
         * 
         */

        //receives a string and we can let user know if its filled in
        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        }
        //receives a string and we can let user know if its filled in



        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        }

        /////////////////////////////////////////////////////////////////////
        public static bool IsAFutureDate(DateTime temp)
        {
            bool blnResult;

            if (temp <= DateTime.Now)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }
            return blnResult;
        }



        //Receives string and we can let user know if its a semi-valid email format

        public static bool IsValidEmail(string temp)
        {   //assume true, but look for bad stuff to make it false
            bool blnResult = true;

            //look for position of "@"
            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            //temp = scott@neit.ca
            //length = 13
            //position of last period = 10

            //look for position of last period "."
            int periodLocation = temp.LastIndexOf(".");



            //check for minimum length
            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLocation < 2) //if it is -1, not found and needs at least 2 chars infront 
            {
                blnResult = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                blnResult = false;
            }
            return blnResult;
        }
        //////////////////////////////////////////////////////////////////////////










        public static bool IsMinimumAmount(int temp, int min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }
            return blnResult;
        }
        ////////////////////////////////////////////////////////






        public static bool IsMinimumAmount(double temp, double min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }
            return blnResult;
        }

        public static bool IsValidURL(string url)
        {
            bool valid = false;

            //check for valid Insta URL
            Regex urlRegEx = new Regex(@"^instagram[.]com[/][a-zA-Z0-9]");

            if (!url.Contains(" ") && urlRegEx.IsMatch(url))
            {
                valid = true;
            }

            return valid;
        }

        public static bool IsValidState(string state)
        {
            bool valid = false;
            //checks for 2 letter state abreviation 
            Regex stateRegEx = new Regex(@"[a-zA-Z]{2}");

            //checks for match & length
            if(state.Length == 2 && stateRegEx.IsMatch(state))
            {
                valid = true;
            }
            return valid;
        }




    }
}
