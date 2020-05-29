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
                    "1. Hire dealer\n" +
                    "2. Invite player\n" +
                    "3. Create card\n" +
                    "4. Deal card\n" +
                    "5. Play card\n" +
                    "6. Display hand\n" +
                    "7. Display all\n" +
                    "8. Exit\n" +
                    "Please select one of the menu options: ");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "hire dealer":
                        {
                            currentDealer = HireDealer();
                            PauseAndExcept();
                        }
                        break;
                    case "2":
                    case "invite player":
                        {
                            InvitePlayer(currentDealer);
                            PauseAndExcept();
                        }
                        break;
                    case "3":
                    case "create card":
                        {
                            CreateCard(currentDealer);
                            PauseAndExcept();
                        }
                        break;
                    case "4":
                    case "deal card":
                        {
                            DealCard(currentDealer);
                            PauseAndExcept();
                        }
                        break;
                    case "5":
                    case "play card":
                        {
                            PlayCard(currentDealer);
                            PauseAndExcept();
                        }
                        break;
                    case "6":
                    case "display hand":
                        {
                            DisplayHand(currentDealer);
                            PauseAndExcept();
                        }
                        break;
                    case "7":
                    case "display all":
                        {
                            DisplayAll(currentDealer);
                            PauseAndExcept();
                        }
                        break;
                    case "8":
                    case "Exit":
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
