using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMobilePhone
{
    class GSMTest
    {
        static void Main()
        {
            MobileDevice phone01 = new MobileDevice("Desire 600", "HTC", 650, "Pesho Ivanov", new Battery("BL1100", 550, 11, BatteryType.LiIon), new Display(4.5, 16000000));
            MobileDevice phone02 = new MobileDevice("8310", "Nokia");
            MobileDevice phone03 = new MobileDevice("6230", "Nokia", 50, "Kiro", null, new Display(null,65000));
            phone02.Price = 10;
            Display display02 = new Display(1.3);
            Battery battery02 = new Battery("BLA0123", 400, 4);
            phone02.GsmDisplay = display02;
            phone02.GsmBattery = battery02;

            // Task 07 - Write a class GSMTest to test the GSM class:
            // - Create an array of few instances of the GSM class.

            MobileDevice[] gsmArray = { phone01, phone02, phone03};

            // - Display the information about the GSMs in the array.

            foreach (var gsm in gsmArray)
            {
                Console.WriteLine(gsm.ToString());
            }

            // - Display the information about the static property IPhone4S.

            Console.WriteLine("---- Mobile device ----\nManufacturer: {0}\nModel: {1}\nPrice: {2}{3}\nOwner: {4}\n\n<--- Battery --->{5}\n<--- Display --->{6}\n---- End ----",
                MobileDevice.IPhone4S.Manufacturer, MobileDevice.IPhone4S.Model, MobileDevice.IPhone4S.Price, 
                MobileDevice.IPhone4S.Price == null ? "" : " lv.", 
                MobileDevice.IPhone4S.Owner,MobileDevice.IPhone4S.GsmBattery, MobileDevice.IPhone4S.GsmDisplay);



            // Task 12 - GSMCallHistoryTest: 
            /* Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
                Create an instance of the GSM class.
                Add few calls.
                Display the information about the calls.
                Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
                Remove the longest call from the history and calculate the total price again.
                Finally clear the call history and print it.
            */

            //Create an instance of the GSM class.
            MobileDevice testPhone = new MobileDevice("Desire V","HTC", 360, "Ivan Ivanov", new Battery("BCL11000", 200, 5, BatteryType.LiIon), new Display(4, 16000000));

            //Add few calls.
            testPhone.AddCall(DateTime.Now, "0877733344", 462);
            testPhone.AddCall(DateTime.Now, "0877234562", 3456);
            testPhone.AddCall(DateTime.Now, "0875354256", 364);
            testPhone.AddCall(DateTime.Now, "0888888888", 15);
            testPhone.AddCall(DateTime.Now, "0899999999", 231);

            //Display the information about the calls.
            Console.WriteLine(testPhone.DisplayCallHistory());

            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine("The total price of the calls is: {0}", testPhone.TotalCallsPrice(0.37));
            Console.WriteLine();

            //Remove the longest call from the history and calculate the total price again.
            testPhone.RemoveLongestCall();
            Console.WriteLine(testPhone.DisplayCallHistory());
            Console.WriteLine("The total price of the calls is: {0}", testPhone.TotalCallsPrice(0.37));
            Console.WriteLine();

            //Finally clear the call history and print it.
            testPhone.ClearCallHistory();
            Console.WriteLine(testPhone.DisplayCallHistory());

        }

    }
}
