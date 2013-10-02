using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMobilePhone
{
    // Task 1
    // Define a class that holds information about a mobile phone device: model, manufacturer, price, owner,
    // battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
    // Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

    public class MobileDevice
    {
        // Fields
        private string model;
        private string manufacturer;
        private decimal? price; // phone price in BGN
        

        // Automatic Properties
        public string Owner { get; set; }
        public Battery GsmBattery { get; set;}
        public Display GsmDisplay { get; set;}

        // Static field - task  6
        // Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

        static private MobileDevice iPhone4S = new MobileDevice("iPhone 4S", "Apple", 900, null, new Battery("cs-231", 200, 10, BatteryType.LiIon), new Display(3.5, 16000000));


        // Constructors - task 2
        // Define several constructors for the defined classes that take different sets of arguments
        // (the full information for the class or part of it). Assume that model and manufacturer are mandatory
        // (the others are optional). All unknown data fill with null.

        // Constructors
        public MobileDevice(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {
            
        }

        public MobileDevice(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null, null, null)
        {

        }

        public MobileDevice(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {
 
        }

        public MobileDevice(string model, string manufacturer, decimal? price, string owner, Battery gsmBattery, Display gsmDisplay)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.GsmBattery = gsmBattery;
            this.GsmDisplay = gsmDisplay;
        }

        // Properties - Task 5
        // Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        // Ensure all fields hold correct data at any given time.

        public string Model
        {
            get { return this.model; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Invalid phone model. Model should be at least 3 symbols.");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Invalid phone manufacturer. Manufacturer name should be at least 3 symbols.");
                }

                this.manufacturer = value; 
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid phone price. Phone price cannot be negative.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public static MobileDevice IPhone4S
        {
            get {return iPhone4S; }
        }

        // Task 09 - Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.

        public List<Call> CallHistory = new List<Call>();


        // Metods - 4 task
        // Add a method in the GSM class for displaying all information about it. Try to override ToString().

        public override string ToString()
        {
            StringBuilder gsmAllInformation = new StringBuilder();

            gsmAllInformation.AppendLine("---- Mobile device ----");
            gsmAllInformation.AppendLine("Manufacturer: " + this.Manufacturer);
            gsmAllInformation.AppendLine("Model: " + this.Model);
            gsmAllInformation.AppendFormat("Price: {0}{1}\n", this.Price, this.Price == null ? "": " lv.");
            gsmAllInformation.AppendLine("Owner: " + this.Owner);
            gsmAllInformation.AppendLine("\n<--- Battery --->" + this.GsmBattery);
            gsmAllInformation.AppendLine("<--- Display --->" + this.GsmDisplay);
            gsmAllInformation.AppendLine("---- End ----");

            string result = gsmAllInformation.ToString();
            return result;
        }

        // Task 10 - Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
        
        public void AddCall(DateTime dateAndTime, string dialedPhoneNumber, int callDuration)
        {
            Call call = new Call(dateAndTime, dialedPhoneNumber, callDuration);
            CallHistory.Add(call);
        }

        public void DeleteCall(DateTime dateAndTime, string dialedPhoneNumber, int callDuration)
        {
            Call call = new Call(dateAndTime, dialedPhoneNumber, callDuration);
            CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        // Task 11 - Add a method that calculates the total price of the calls in the call history. 
        // Assume the price per minute is fixed and is provided as a parameter.

        public double TotalCallsPrice(double pricePerMinute)
        {
            int callHistoryCounter = CallHistory.Count;
            double result = 0;
            double allDurationInSeconds = 0;

            for (int i = 0; i < callHistoryCounter; i++)
            {
                allDurationInSeconds += CallHistory[i].Duration;
            }

            result = (Math.Ceiling(allDurationInSeconds / 60)) * pricePerMinute;
            return result;
        }

        // Task 12 - point: Display Call History

        public string DisplayCallHistory()
        {
            StringBuilder callHistoryDisplay = new StringBuilder();

            callHistoryDisplay.AppendLine("<--- Call History --->");
            callHistoryDisplay.AppendFormat("{0, -23}{1, -15}{2, 8}\n", "Date and Time", "Dialed Number", "Call Duration");
            foreach (var call in this.CallHistory)
            {
                callHistoryDisplay.AppendFormat("{0, -23}{1, -15}{2, 8}\n", call.DateAndTime, call.DialedPhoneNumber, call.Duration);
            }
            callHistoryDisplay.AppendLine("<--- End OF Call History --->");
            return callHistoryDisplay.ToString();
        }

        // Task 12 - point: Remove the longest call from the history

        public void RemoveLongestCall()
        {
            int longestDuration = int.MinValue;

            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                if (longestDuration < this.CallHistory[i].Duration)
                {
                    longestDuration = this.CallHistory[i].Duration;
                }
            }

            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                if (this.CallHistory[i].Duration == longestDuration)
                {
                    this.CallHistory.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
