using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Практика
{
    public class Person
    {
        public string SecondName { get; set; }
        public string Name { get; set; }
        public string Sername { get; set; }
        public string telNamber { get; set; }
        public string Country { get; set; }
        public DateTime BirthDay { get; set; }
        public string Organizaition { get; set; }
        public string Position { get; set; }
        public string Notes { get; set; }

        public void SetBirthDay(string data)
        {
            if (data != "")
            {
                
                this.BirthDay = Convert.ToDateTime(data);
            }
            else
            {
                this.BirthDay = DateTime.MinValue;
            }
        }

        public Person(ref string[] Info)
        {
            this.SecondName = Info[0];
            this.Name = Info[1];
            this.Sername = Info[2];
            this.telNamber = Info[3];
            this.Country = Info[4];
            SetBirthDay(Info[5]);
            this.Organizaition = Info[6];
            this.Position = Info[7];
            this.Notes = Info[8];
        }

        public override string ToString()
        {
            string result = $"Фамилия: {SecondName}\n" +
                            $"Имя: {Name}\n";

            if (Sername != "")
            {
                result += $"Отчество : {Sername}\n";
            }

            result += $"Номер телефона: {telNamber}\n" + 
                      $"Страна: {Country}\n";

            if (BirthDay != DateTime.MinValue)
            {
                result += $"День рождения : {BirthDay.ToString("dd MMMM yyyy")}\n";
            }

            if (Organizaition != "")
            {
                result += $"Организация : {Organizaition}\n";
            }

            if (Position != "")
            {
                result += $"Должность : {Position}\n";
            }

            if (Notes != "")
            {
                result += $"Прочие заметки: {Notes}\n";
            }

            return result;
        }
    }
}
