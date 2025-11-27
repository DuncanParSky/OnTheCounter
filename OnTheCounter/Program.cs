using System;
using System.Data;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace OnTheCounter
{
    class Program
    {
        static InputSimulator sim = new InputSimulator();

        static void Main(string[] args)
        {
            // welcome message and prompts
            Console.WriteLine("Weclome to OnTheCounter!");
            Console.Write("Enter the starting number: ");
            int startNumber = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("How many times to count?: ");
            int countNumber = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("Would you like to enable slow mode? (Y/N, default is Y): ");
            string slowMode = Console.ReadLine();
            Console.WriteLine("Counting will start in 5 seconds...");
            Thread.Sleep(5000); // wait for 5 secs
            if (slowMode == "Y")
            {
                SlowMode(startNumber, countNumber);
            }

            else if (slowMode == "N")
            {
                NormalMode(startNumber, countNumber);
            }

            else
            {
                Console.WriteLine("Error: Slow mode input invalid");
            }
        }

        static void SlowMode(int startNumber, int countNumber)
        {
            for (int currentNum = startNumber; currentNum < startNumber + countNumber; currentNum++)
            {
                sim.Keyboard.TextEntry(currentNum.ToString());
                Thread.Sleep(500); // small pause to ensure text is sent and to potentially reduce detection
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN); // press enter after each number to send
                Thread.Sleep(1000); // 1 second delay for slow mode
            }
            Console.WriteLine("Complete!");
        }

        static void NormalMode(int startNumber, int countNumber)
        {
            for (int currentNum = startNumber; currentNum < startNumber + countNumber; currentNum++)
            {
                sim.Keyboard.TextEntry(currentNum.ToString());
                Thread.Sleep(500); // smaller pause to just ensure text is sent
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN); // press enter after each number to send
            }
            Console.WriteLine("Complete!");
        }
    }
}