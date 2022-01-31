using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalcW1.App_Code
{
    public class Book
    {
        //Notice that the anems of the fields are almosy fullu self explanatory wihtout my notes... good naming
        //Also... note that these properties/vars all are lowercase.
        private string title;
        private string authorFirst;
        private string authorLast;
        private string email;
        private DateTime datePublished;
        private int pages;
        private double price;

        protected string feedback; //NEW! -PROTECTED... only children see this!.. intented for tracking error msgs

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                //check for bad words...
                if (!ValidationLibrary.GotBadWords(value))
                {
                    title = value; //If values does not hae bad words... store it
                }
                else
                {
                    feedback += "\nERROR: Title has bad word in it.";//Else, leave Error msg
                }
            }
        }

        public string AuthorFirst
        {


            get
            {
                return authorFirst;
            }
            set
            {
                //check for bad words...
                if (!ValidationLibrary.GotBadWords(value))
                {
                    authorFirst = value; //If values does not hae bad words... store it
                }
                else
                {
                    feedback += "\nERROR: Author's First name has a bad word in it."; //Else, leave error msg
                }

            }
        }
        public string AuthorLast
        {


            get
            {
                return authorLast;
            }
            set
            {
                //check for bad words...
                if (!ValidationLibrary.GotBadWords(value))
                {
                    authorLast = value; //If values does not hae bad words... store it
                }
                else
                {
                    feedback += "\nERROR: Author's Last name has a bad word in it."; //Else, leave error msg
                }

            }
        }
        public string Email
        {


            get
            {
                return email;
            }
            set
            {
                //check Email format...
                if (ValidationLibrary.IsValidEmail(value))
                {
                    email = value; //Yup... store it
                }
                else
                {
                    feedback += "\nERROR: invalid email."; //Else, leave error msg
                }

            }
        }

        public DateTime DatePublished
        {
            get
            {
                return datePublished;
            }
            set
            {
                //if the date given is not a future date....
                if (ValidationLibrary.IsAFutureDate(value) == false)
                {
                    datePublished = value; //Past date... store it
                }
                else
                {
                    //future date... give Error msg feedback
                    feedback += "\nERROR: You cannot enter future dates";
                }

            }

        }

        public int Pages
        {
            get
            {
                return pages;
            }

            set
            {
                //if we have the minimum number of pages needed....
                if (ValidationLibrary.IsMinimumAmount(value, 0) == true)
                {
                    pages = value; //store the # of apges
                }
                else
                {
                    //store an error msg in feedback
                    feedback += "\nError: sorry you entered an invalid # of pages.";
                }
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                {
                    price = value;
                }
                else
                {
                    feedback += "\nERROR: Price is not sufficient.";
                }
            }
        }

        //NEW-Allows class to communicate with outside programs
        public string Feedback
        {
            get { return feedback; } //allows outside code to see feedback
            //Notice there is no SET...This is because only the class can change feedback
        }

        //NEW- Default constructor- Runs auto when object instance is created
        public Book()
        {
            //Initialize so that there are no nulls, especially feedback
            title = "";
            authorFirst = "";
            authorLast = "";
            pages = 0;
            datePublished = DateTime.Parse("1/1/1500");
            price = 0.0;
            feedback = "";
        }

    }
}