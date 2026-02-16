using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                { }
               

                    if (command.ToLower() == "finish")
                    {
                        break;
                    }

                    switch (command)
                    {
                        case "ins":
                            {
                                int index = int.Parse(cmd[1]);
                                int value = int.Parse(cmd[2]);
                                if (index >= 0 && index <= nums.Count)
                                {
                                    nums.Insert(index, value);
                                }
                            }
                            break;

                        case "del":
                            {
                                int index = int.Parse(cmd[1]);
                                if (index >= 0 && index < nums.Count)
                                {
                                    nums.RemoveAt(index);
                                }
                            }
                            break;

                        case "contains":
                            {
                                int value = int.Parse(cmd[1]);
                                Console.WriteLine(nums.Contains(value) ? "Yes" : "No");
                            }
                            break;

                            //TODO
                            break;
                        case "remove":
                            //TODO
                            break;
                        //TODO

                        default:
                            break;
                    }
                }
            }
        }
    } 
