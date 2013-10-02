using System;
using System.Linq;
using System.Text;

namespace ClassMobilePhone
{
    public class Battery
    {
        // Fields
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;

        // Automatic Property
        public BatteryType? Type;

        // Constructors - task 2
        // Define several constructors for the defined classes that take different sets of arguments
        // (the full information for the class or part of it). Assume that model and manufacturer are mandatory
        // (the others are optional). All unknown data fill with null.

        // Constructors
        public Battery(string model): this(model, null, null, null)
        { 
        }

        public Battery(string model, int? hoursIdle) :
            this(model, hoursIdle, null, null)
        {

        }

        public Battery(string model, int? hoursIdle, int? hoursTalk) :
            this(model, hoursIdle, hoursTalk, null)
        {
 
        }

        public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryType? type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
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
                    throw new ArgumentNullException("Invalid battery model! Battery model should be at least 3 symblos.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid idle hours. Idle hours must be a positive integer.");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid talk hours. Talk hours must be a positive integer.");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder fullBatteryInfo = new StringBuilder();

            fullBatteryInfo.AppendLine("\nModel: " + this.Model);
            fullBatteryInfo.AppendFormat("Type: {0}\n", this.Type);
            fullBatteryInfo.AppendFormat("Hours idle: {0}\n", this.HoursIdle);
            fullBatteryInfo.AppendFormat("Hours talk: {0}\n", this.HoursTalk);            

            return fullBatteryInfo.ToString();
        }
    }
}
