using System;
using System.Collections.Generic;
using System.Text;

namespace Практика
{
    class Methods
    {
        public static void AddNew()
        {
            ClearScr();
            List<string> Info = new List<string>();
            //=============================================
            Console.WriteLine("*-обязательные поля");
            Console.Write("Фамилия*: ");
            Info.Add(Console.ReadLine());
            Console.Write("Имя*: ");
            Info.Add(Console.ReadLine());
            Console.Write("Отчество: ");
            Info.Add(Console.ReadLine());
            Console.Write("Номер телефона*: ");
            Info.Add(Console.ReadLine());
            Console.Write("Страна*: ");
            Info.Add(Console.ReadLine());
            Console.Write("Дата рождения: ");
            Info.Add(Console.ReadLine());
            Console.Write("Организация: ");
            Info.Add(Console.ReadLine());
            Console.Write("Должность: ");
            Info.Add(Console.ReadLine());
            Console.Write("Прочие заметки: ");
            Info.Add(Console.ReadLine());
            //=============================================
            Program.Notebook.Add(new Person(Info));
            ClearScr();
        }
        public static void Delete()
        {
            ClearScr();
            Console.Write("Введите Фамилию и Имя человека, которого хотите удалить: ");

            while (true) 
            {
                string PersonName = Console.ReadLine();
                Console.WriteLine();
                string[] Person = PersonName.Split(' ');
                List<Person> result = Program.Notebook.FindAll(item => item.SecondName == Person[0] && item.Name == Person[1]);

                if (result.Count == 1)
                {
                    Program.Notebook.Remove(result[0]);
                    break;
                }

                if (result.Count == 0)
                {
                    Console.WriteLine("Такой контакт не найден, попробуйте еще раз...");
                }
                if (result.Count > 1)
                {
                    Console.WriteLine("_____Какой контакт удалить?____");
                    for (int i = 0; i < result.Count; i++)
                    {
                        Console.WriteLine($"_________/{i + 1}/_________\n" + 
                                          $"Фамилия: " + result[i].SecondName + "\n" +
                                          $"Имя: " + result[i].Name + "\n" +
                                          $"Номер телефона: " + result[i].telNamber);
                    }
                    int index = int.Parse(Console.ReadLine());
                    Program.Notebook.Remove(result[index - 1]);
                    break;
                }
            }
            ClearScr();
        }
        public static void Edit()
        {
            ClearScr();
            Console.Write("Введите Фамилию и Имя человека, которого хотите изменить: ");
            int index = 0, index_line = 0;
            List<Person> result;
            
            //Нахождение нужного
            while (true)
            {
                string PersonName = Console.ReadLine();
                Console.WriteLine();
                string[] Person = PersonName.Split(' ');
                result = Program.Notebook.FindAll(item => item.SecondName == Person[0] && item.Name == Person[1]);

                if (result.Count == 0)
                {
                    Console.WriteLine("Такой контакт не найден, попробуйте еще раз...");
                }
                if (result.Count == 1)
                {
                    Console.WriteLine($"1. Фамилия: " + result[0].SecondName + "\n" +
                                      $"2. Имя: " + result[0].Name + "\n" +
                                      $"3. Отчество: " + result[0].Sername + "\n" +
                                      $"4. Номер телефона: " + result[0].telNamber + "\n" +
                                      $"5. Страна: " + result[0].Country + "\n" +
                                      $"6. Дата рождения: " + result[0].BirthDay.ToString("dd MMMM yyyy") + "\n" +
                                      $"7. Организация: " + result[0].Organizaition + "\n" +
                                      $"8. Должность: " + result[0].Position + "\n" +
                                      $"9. Прочие заметки: " + result[0].Notes + "\n");
                    break;
                }
                if (result.Count > 1)
                {
                    Console.WriteLine("________Выберете какой именно контакт?________");
                    Console.WriteLine();
                    for (int i = 0; i < result.Count; i++)
                    {
                        Console.WriteLine($"____________/{i + 1}/____________\n" +
                                          $"Фамилия: " + result[i].SecondName + "\n" +
                                          $"Имя: " + result[i].Name + "\n" +
                                          $"Номер телефона: " + result[i].telNamber + "\n");
                    }
                    index = int.Parse(Console.ReadLine()) - 1;
                    ClearScr();
                    {
                        Console.WriteLine($"1. Фамилия: " + result[index].SecondName + "\n" +
                                      $"2. Имя: " + result[index].Name + "\n" +
                                      $"3. Отчество: " + result[index].Sername + "\n" +
                                      $"4. Номер телефона: " + result[index].telNamber + "\n" +
                                      $"5. Страна: " + result[index].Country + "\n" +
                                      $"6. Дата рождения: " + result[index].BirthDay.ToString("dd MMMM yyyy") + "\n" +
                                      $"7. Организация: " + result[index].Organizaition + "\n" +
                                      $"8. Должность: " + result[index].Position + "\n" +
                                      $"9. Прочие заметки: " + result[index].Notes + "\n");
                        break;
                    }
                    
                }
            }
            
            //Само изменение
            while (true)
            {
                Console.WriteLine();
                Console.Write("Введите номер строки, которую хотите изменить или напишите Exit, если ходите выйти: ");
                if (!int.TryParse(Console.ReadLine(), out index_line))
                {
                    break;
                }
                Console.WriteLine();
                Console.Write("Введите новое значение: ");
                switch (index_line)
                {
                   case 1:
                    {
                        result[index].SecondName = Console.ReadLine();
                    }
                        break;
                    case 2:
                    {
                        result[index].Name = Console.ReadLine();
                    }
                        break;
                    case 3:
                    {
                        result[index].Sername = Console.ReadLine();
                    }
                        break;
                    case 4:
                    {
                        result[index].telNamber = Console.ReadLine();
                    }
                        break;
                    case 5:
                    {
                        result[index].Country = Console.ReadLine();
                    }
                        break;
                    case 6:
                    {
                        result[index].SetBirthDay(Console.ReadLine());
                    }
                        break;
                    case 7:
                    {
                        result[index].Organizaition = Console.ReadLine();
                    }
                        break;
                    case 8:
                    {
                        result[index].Position = Console.ReadLine();
                    }
                        break;
                    case 9:
                    {
                        result[index].Notes = Console.ReadLine();
                    }
                        break;
                    default:
                        break;
                    }
                ClearScr();
                Console.WriteLine($"1. Фамилия: " + result[index].SecondName + "\n" +
                                  $"2. Имя: " + result[index].Name + "\n" +
                                  $"3. Отчество: " + result[index].Sername + "\n" +
                                  $"4. Номер телефона: " + result[index].telNamber + "\n" +
                                  $"5. Страна: " + result[index].Country + "\n" +
                                  $"6. Дата рождения: " + result[index].BirthDay.ToString("dd MMMM yyyy") + "\n" +
                                  $"7. Организация: " + result[index].Organizaition + "\n" +
                                  $"8. Должность: " + result[index].Position + "\n" +
                                  $"9. Прочие заметки: " + result[index].Notes + "\n");
            }

            ClearScr();
        }
        public static void Show()
        {
            ClearScr();
            Console.Write("Введите Фамилию и Имя человека, которого хотите найти: ");

            while (true)
            {
                string PersonName = Console.ReadLine();
                Console.WriteLine();
                string[] Person = PersonName.Split(' ');
                List<Person> result = Program.Notebook.FindAll(item => item.SecondName == Person[0] && item.Name == Person[1]);

                if (result.Count == 0)
                {
                    Console.WriteLine("Такой контакт не найден, попробуйте еще раз...");
                }
                if (result.Count == 1)
                {
                    Console.WriteLine(result[0]);
                    break;
                }
                if (result.Count > 1)
                {
                    Console.WriteLine("_____Выберете какой именно контакт?____");
                    for (int i = 0; i < result.Count; i++)
                    {
                        Console.WriteLine($"____________/{i + 1}/____________\n" +
                                          $"Фамилия: " + result[i].SecondName + "\n" +
                                          $"Имя: " + result[i].Name + "\n" +
                                          $"Номер телефона: " + result[i].telNamber + "\n");
                    }
                    int index = int.Parse(Console.ReadLine());
                    ClearScr();
                    Console.WriteLine(result[index - 1]);
                    break;
                }
            }
            Console.Write("Нажмите кнопку, чтобы скрыть");
            Console.ReadKey();
            ClearScr();
        }
        public static void ShowAll()
        {
            ClearScr();
            for (int i = 0; i < Program.Notebook.Count; i++)
            {
                Console.WriteLine($"____________/{i + 1}/____________\n" +
                                  $"Фамилия: " + Program.Notebook[i].SecondName + "\n" +
                                  $"Имя: " + Program.Notebook[i].Name + "\n" +
                                  $"Номер телефона: " + Program.Notebook[i].telNamber + "\n");
            }
            Console.Write("Нажмите кнопку, чтобы скрыть");
            Console.ReadKey();
            ClearScr();
        }

        public static void ClearScr()
        {
            Console.Clear();
            Console.WriteLine("______________________Ваша записная книжка______________________");
            Console.Write($"Если хотите добавить нового пользователя - введите \"AddNew\":\n" +
                              $"Eсли хотите удалить старый контакт - введите \"Delete\":\n" +
                              $"Если хотите отредактировать контакт - введите \"Edit\":\n" +
                              $"Если хотите посмотреть контак - введите \"Show\":\n" +
                              $"Если хотите просмотреть всех - введите \"ShowAll\":\n" +
                              $"Если ничего - введите \"Exit\"\n" + 
                              "================================================================");
            Console.WriteLine();
        }
    }
}
