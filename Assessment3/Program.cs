using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Assessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string path = @"D:\Praveen Bhatt's\Assessment3\";
            string myDetails = qwerty();
            DirectoryInfo di = Directory.CreateDirectory(path);
            try
            {
                do
                {
                    Console.WriteLine();//Console.Clear();
                    Console.WriteLine("What operation do you want to perform : ");
                    Console.WriteLine("Enter Your Choice : "); Console.WriteLine();
                    Console.WriteLine("1. Create Json File:");
                    Console.WriteLine("2. Read Json File : ");
                    Console.WriteLine("3. Update: "); Console.WriteLine("4. Delete : ");
                    Console.WriteLine("5. List of Persons :");
                    Console.WriteLine("6. Exit : ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    flag = Switch(flag, path, myDetails, i);
                } while (flag);
            }
            catch (Exception e)
            { Console.WriteLine(e); }

        }

        private static bool Switch(bool flag, string path, string myDetails, int i)
        {
            switch (i)
            {
                case 1:
                    {
                        Console.Clear();
                        System.IO.File.WriteAllText(path + "output.json", myDetails);
                        Console.WriteLine("Json File Created Successfully");
                        Console.WriteLine("Check in D:drive -> Praveen Bhatt's -> Assessement3 folder for Output.JSON ");
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        var readData = System.IO.File.ReadAllText(@"D:\Praveen Bhatt's\Assessment3\output.json");
                        if (readData == "")
                        {
                            Console.WriteLine("No File Exists.Please Create a JSON file First");
                        }
                        else
                        {
                            var res = JsonConvert.DeserializeObject(readData);
                            JArray empArray = JArray.Parse(readData);
                            Console.WriteLine(res);
                            Console.WriteLine();
                        }
                    }
                    break;

                case 3://Update
                    {
                        Console.Clear();
                        //read------
                        string json = File.ReadAllText(@"D:\Praveen Bhatt's\Assessment3\output.json");
                        var NewList = JsonConvert.DeserializeObject<List<collect>>(json);
                        //read------

                        //id input
                        Console.Write("Enter the Id to update :    ");
                        int idUpdate = Convert.ToInt32(Console.ReadLine());

                        //goto that id
                        var empUpdate = NewList.FirstOrDefault(a => a.Id == idUpdate);

                        //update entry
                        Console.Write("Enter the New Name:    ");
                        empUpdate.Name = Console.ReadLine();
                        Console.Write("Enter the New Email:    ");
                        empUpdate.Email = Console.ReadLine();
                        Console.Write("Enter the New Age:    ");
                        empUpdate.Age = Convert.ToInt32(Console.ReadLine());

                        //write file
                        string NewUpdate = JsonConvert.SerializeObject(NewList.ToArray(), Formatting.Indented);
                        System.IO.File.WriteAllText(@"D:\Praveen Bhatt's\Assessment3\output.json", NewUpdate);
                        Console.WriteLine(); Console.WriteLine("Record Updated..."); Console.WriteLine();
                    }
                    break;
                case 4://Delete
                    {
                        Console.Clear();
                        var json = System.IO.File.ReadAllText(@"D:\Praveen Bhatt's\Assessment3\output.json");
                        Console.WriteLine("Enter the Id to delete the Record of : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var NewList = JsonConvert.DeserializeObject<List<collect>>(json);

                        var update = NewList.RemoveAll(a => a.Id == id);
                        string NewUpdate = JsonConvert.SerializeObject(NewList.ToArray(), Formatting.Indented);
                        System.IO.File.WriteAllText(@"D:\Praveen Bhatt's\Assessment3\output.json", NewUpdate);
                        Console.WriteLine("Record deleted.. press 2 to check");
                        Console.WriteLine();

                    }
                    break;

                case 5://list of Persons
                    {
                        Console.Clear();
                        var json = System.IO.File.ReadAllText(@"D:\Praveen Bhatt's\Assessment3\output.json");
                        var NewList = JsonConvert.DeserializeObject<List<collect>>(json);
                        foreach (var item in NewList)
                        {
                            Console.WriteLine("Name : " + item.Name); Console.WriteLine();
                        }

                    }
                    break;
                case 6:
                    flag = false;
                    break;
                default:
                    flag = false;
                    break;
            }

            return flag;
        }

        private static string qwerty()
        {
            return JsonConvert.SerializeObject(new collectDatabase(), Formatting.Indented);
        }
    }
}