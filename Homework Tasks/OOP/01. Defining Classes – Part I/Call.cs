using System;
using System.Linq;

namespace ClassMobilePhone
{
    public class Call
    {
        // Task 08 - Create a class Call to hold a call performed through a GSM. It should contain date, time, 
        // dialed phone number and duration (in seconds). 

        public DateTime DateAndTime {get; set;}
        private string dialedPhoneNumber; 
        private int duration; 

        public Call(DateTime dateAndTime, string dialedPhoneNumber, int duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value) || value.Length < 10)
                {
                    throw new ArgumentException("Invalid phone number. Dialed phone number should be at least 10 digits.");
                }
                this.dialedPhoneNumber = value;
            }
        }

        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid call duration. Call duration must be a positive integer");
                }
                this.duration = value;
            }
        }
    }
}
