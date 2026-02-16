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
                    case "remove":
                        {
                            int index = int.Parse(cmd[1]);
                            if (index >= 0 && index < nums.Count)
                            {
                                nums.RemoveAt(index);
                            }
                        }
                        break;

                    case "add":
                        {
                            int num1 = int.Parse(cmd[1]);
                            int num2 = int.Parse(cmd[2]);
                            nums.Add(num1 + num2);
                        }
                        break;

                    case "large":
                        {
                            int number = int.Parse(cmd[1]);
                            var result = nums.Where(x => x > number);
                            Console.WriteLine(string.Join(" ", result));
                        }
                        break;
                    case "countl":
                        {
                            int number = int.Parse(cmd[1]);
                            int count = nums.Count(x => x > number);
                            Console.WriteLine(count);
                        }
                        break;

                    case "cut":
                        {
                            int n = int.Parse(cmd[1]);
                            if (n >= nums.Count)
                            {
                                nums.Clear();
                            }
                            else
                            {
                                nums.RemoveRange(0, n);
                            }
                        }
                        break;

                    case "print":
                        {
                            Console.WriteLine(string.Join(" ", nums));
                        }
                        break;

                    default:
                            break;
                    }
                }
            }
        }
    } 
