using System;

namespace Phase_one_SAD
{
    class Program
    {
        static void Main(string[] args)
        {
            
                schooldatafile school = new schooldatafile();
                Console.WriteLine("Welcome in the Rainbow School System is a system to store, retrieve and update teacher data");
                Console.WriteLine("Enter frist charactor to do select service");
                bool status = true;
                while (status)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" 'N'Add New Data in System \n 'S'Search in The System \n 'U'Update Data \n 'E'Exit");
                    Console.ForegroundColor = ConsoleColor.White;
                    char? chose = null;
                    try
                    {
                        char cho = char.Parse(Console.ReadLine());
                        chose = cho;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please Enter The charctor for Chose");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    switch (chose)
                    {
                        case 'N':

                            try
                            {
                                Console.WriteLine("Please Enter ID");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please Enter Name");
                                string name = Console.ReadLine();
                                Console.WriteLine("Please Class Name");
                                string _class = Console.ReadLine();
                                Console.WriteLine("Please Enter Section Name");
                                string section = Console.ReadLine();
                                school.AddNewItem(id, name, _class, section);

                            }
                            catch (Exception e)
                            {
                            }




                            break;

                        case 'S':
                            Console.WriteLine("Please Enter the ID How wint to search");
                            int search_id = int.Parse(Console.ReadLine());
                            teacher sch = school.GetTeacher(search_id);
                            if (sch != null)
                            {
                                Console.WriteLine($"The ID: {sch.ID}\nThe Name: {sch.Name}\nThe Class: {sch._class}\nThe Section: {sch.section}");
                            }
                            else
                            {
                                Console.WriteLine("Nothig ID in the file");
                            }
                            break;
                        case 'U':
                            Console.WriteLine("Please Enter the ID How wint to search");
                            int id_search = int.Parse(Console.ReadLine());
                            teacher schoo = school.GetTeacher(id_search);
                            if (schoo != null)
                            {
                                Console.WriteLine($"The ID: {schoo.ID}\nTheName: {schoo.Name}\nThe Class: {schoo._class}\nThe Section: {schoo.section}");
                                int old_id = schoo.ID;
                                Console.WriteLine("Please Enter new ID");
                                int new_id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please Enter new Name ");
                                string new_name = Console.ReadLine();
                                Console.WriteLine("Please Enter new Class");
                                string new_class = Console.ReadLine();
                                Console.WriteLine("Please Enter new Section");
                                string new_section = Console.ReadLine();
                                school.update(old_id, new_id, new_name, new_class, new_section);
                            }
                            else
                            {
                                Console.WriteLine("Can not foun any data in this id " + id_search);
                            }
                            break;
                        case 'E':
                            status = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Plase Enter in Upper case");
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;

                    }
                }
            
        }
    }
}