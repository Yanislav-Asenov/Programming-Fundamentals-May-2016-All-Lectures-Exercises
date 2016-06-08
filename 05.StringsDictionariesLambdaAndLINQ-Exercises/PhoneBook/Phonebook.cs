using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class Phonebook
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                string[] commandArgs = command.Split();
                string commandType = commandArgs[0];

                if (commandType == "A")
                {
                    string person = commandArgs[1];
                    string phoneNumber = commandArgs[2];
                    if (phonebook.ContainsKey(person))
                    {
                        phonebook[person] = phoneNumber;
                    }
                    else
                    {
                        phonebook.Add(person, phoneNumber);
                    }
                }
                else if (commandType == "S")
                {
                    string person = commandArgs[1];
                    if (phonebook.ContainsKey(person))
                    {
                        string output = string.Format($"{person} -> {phonebook[person]}");
                        Console.WriteLine(output);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {person} does not exist.");
                    }
                }
                else if (commandType == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
                command = Console.ReadLine();
            }

        }
    }
}
