using System;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([\@|\#|\$|\^]{6,})[\w]*\1";

            Dictionary<string, string> validTickets = new Dictionary<string, string>();
            string[] tickets = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string leftSide = "";
            string rightSide = "";
            for (int i = 0; i < tickets.Length; i++)
            {
                string currentTicket = tickets[i].Trim();
                if (Regex.IsMatch(currentTicket, pattern))
                {
                    foreach (Match match in Regex.Matches(currentTicket, pattern))
                    {
                        for (int j = 0; j < currentTicket.Length /2; j++)
                        {
                            if ((currentTicket[j] == '$' || currentTicket[j] == '@' || currentTicket[j] == '#' || currentTicket[j] == '^'))
                            {
                                leftSide += currentTicket[j];
                            }
                        }

                        for (int k = (currentTicket.Length / 2); k < currentTicket.Length; k++)
                        {
                            if ((currentTicket[k] == '$' || currentTicket[k] == '@' || currentTicket[k] == '#' || currentTicket[k] == '^'))
                            {
                                rightSide += currentTicket[k];
                            }
                        }

                        if (currentTicket.Length == 20 && leftSide.Length >= 6 &&  rightSide.Length >= 6)
                        {
                            if (leftSide.Length < rightSide.Length)
                            {
                                validTickets.Add(currentTicket, leftSide);
                            }
                            else
                            {
                                validTickets.Add(currentTicket, rightSide);
                            }

                            
                            leftSide = "";
                            rightSide = "";
                        }
                        
                    }

                }
                else if (currentTicket.Length == 20 && leftSide.Length == 0)
                {
                    validTickets.Add(currentTicket, "no match");
                }
                else if(currentTicket.Length != 20)
                {
                    validTickets.Add("invalid ticket", "");
                }
            }

            foreach (var ticket in validTickets)
            {
                if (ticket.Value != "")
                {
                    if (ticket.Value == "no match")
                    {
                        Console.WriteLine($"ticket \"{ticket.Key}\" - no match");
                    }
                    else if (ticket.Value.Length >= 6 && ticket.Value.Length <= 9)
                    {
                        Console.WriteLine($"ticket \"{ticket.Key}\" - {ticket.Value.Length}{ticket.Value[1]}");
                    }
                    else if (ticket.Value.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket.Key}\" - {ticket.Value.Length}{ticket.Value[0]} Jackpot!");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
