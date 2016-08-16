using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    // <summary>
    // The container for the number that is displayed
    // in counterBox. Has methods for handling the button
    // inputs.
    // </summary>
    public class CounterNumber
    {
        private Int64 counter;

        // Constructor, defaults to 0
        public CounterNumber(Int64 initialNumber = 0)
        {
            counter = initialNumber;
        }

        private bool checkForOverflow(Int64 difference)
        {
            Int64 dummyCounter = counter;
            try
            {
                dummyCounter = checked(dummyCounter + difference);
            }
            catch(System.OverflowException error)
            {
                Console.WriteLine("Caught: " + error.ToString());
                return true;
            }
            return false;
        }

        public void modifyCounter(long inc_number)
        {
            // Account for and ensure theres no overflow.
            if(counter < Int64.MaxValue)
            {
                if(checkForOverflow(inc_number))
                {
                    counter = Int64.MaxValue;
                }
                else
                {
                    counter += inc_number;
                }
            }
        }
        public void resetCounter()
        {
            counter = 0;
        }

        public Int64 getCounter()
        {
            //Int64 returnCounter = counter;
            return counter;
        }

    }

    static class CounterMainProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
