using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Contragents.ConsoleApp.Models;

namespace Contragents.ConsoleApp.Services
{
    public class CompaniesFileService : FileService
    {
        public CompaniesFileService(string filePath) : base(filePath)
        {
        }

        protected override string GetStringFromContragent(Contragent company_)
        {
            Company company = (Company)company_;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(company.Uin).Append("\t").Append(company.RegistrationAddress).Append("\t")
                         .Append(company.ActualAddress).Append("\t").Append(company.Created.ToString()).Append("\t")
                         .Append(company.CreatedBy).Append("\t").Append(company.Updated).Append("\t")
                         .Append(company.UpdatedBy).Append("\t").Append(company.Name).Append("\t")
                         .Append(company.Director.Uin).Append("\t").Append(company.RegistrationDate).Append("\t")
                         .Append(company.ContactsCount).Append("\t");
            for (int i = 0; i < company.ContactsCount - 1; i++)
            {
                stringBuilder.Append(company.Contacts[i].Uin).Append(";");
            }
            stringBuilder.Append(company.Contacts[company.ContactsCount - 1].Uin).Append("\t");
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
                foreach (Company company in contragentsList)
                {
                    string str = GetStringFromContragent(company);
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
