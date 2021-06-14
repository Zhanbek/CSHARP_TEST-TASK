using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Contragents.ConsoleApp.Models;

namespace Contragents.ConsoleApp.Services
{
    public class PersonsFileService : FileService
    {
        public PersonsFileService(string filePath) : base(filePath)
        {
        }

        protected override string GetStringFromContragent(Contragent person_)
        {
            Person person = (Person)person_;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(person.Uin).Append("\t").Append(person.RegistrationAddress).Append("\t").Append(person.ActualAddress).Append("\t")
                         .Append(person.Created.ToString()).Append("\t").Append(person.CreatedBy).Append("\t").Append(person.Updated).Append("\t")
                         .Append(person.UpdatedBy).Append("\t").Append(person.FirstName).Append("\t").Append(person.MiddleName).Append("\t")
                         .Append(person.LastName).Append("\t").Append(person.Gender).Append("\t").Append(person.BirthDate);
            string result = stringBuilder.ToString();
            return result;
        }


        public override bool WriteContragentsToFile(List<Contragent> contragentsList)
        {
            // Delete the file if it exists.
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }

            System.Console.WriteLine("-------------------------------------------------------------");

            using (StreamWriter sw = File.CreateText(FilePath))
            {
                foreach (Contragent person in contragentsList)
                {
                    string str = GetStringFromContragent(person);
                    sw.WriteLine(str);
                    counter++;
                    System.Console.WriteLine($"Добавлена {counter}-ая строка: {System.Environment.NewLine} {str}");
                }
            }

            System.Console.WriteLine("-------------------------------------------------------------");
            System.Console.WriteLine($"Добавлено {counter} строк в файл {FilePath}");

            return true;
        }
    }

}
