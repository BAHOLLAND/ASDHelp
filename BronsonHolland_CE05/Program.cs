using System;

namespace BronsonHolland_CE05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(
                    "1. Otter (trainable)\n" +
                    "2. Shark\n" +
                    "3. Dolphin (trainable)\n" +
                    "4. Alligator\n" +
                    "5. Dog (trainable)\n" +
                    "6. Turrtle\n" +
                    "7. Exit\n" +
                    "Please select one of the options: ");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "otter":
                        {

                        }
                        break;
                    case "2":
                    case "shark":
                        {

                        }
                        break;
                    case "3":
                    case "dolphin":
                        {

                        }
                        break;
                    case "4":
                    case "alligator":
                        {

                        }
                        break;
                    case "5":
                    case "dog":
                        {

                        }
                        break;
                    case "6":
                    case "turtle":
                        {

                        }
                        break;
                    case "7":
                    case "exit":
                        {

                            Exit();
                            return;
                        }
                }
            }
        }
    }
    }
}
