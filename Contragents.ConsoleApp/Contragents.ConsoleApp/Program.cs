using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Contragents.ConsoleApp.Services;
using Contragents.ConsoleApp.Models;


namespace Contragents.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация физических и юридических лиц
            InitObjects init = new InitObjects();
         
            // 1. Запись физических лиц в файл
            PersonsFileService personsFile = new PersonsFileService("./Persons.tsv");
            Console.WriteLine($"Сохраняем данные физических лиц в файле {personsFile.FilePath}");
            Console.WriteLine("Для того чтобы продолжить, нажмите любую клавишу.");
            Console.ReadKey();

            bool PersonsAreWritedToFile = personsFile.WriteContragentsToFile((List<Contragent>)init.personsList);
            string messageAboutPersonsFile = (PersonsAreWritedToFile) ? $"Информация о физ. лицах успешно записана в файл {personsFile.FilePath}!" :
                                                                     $"При записи физ. лиц в файл {personsFile.FilePath} произошла ошибка!";
            Console.WriteLine(messageAboutPersonsFile);
            Console.WriteLine("Для того чтобы продолжить, нажмите любую клавишу.");
            Console.ReadKey();

            // 2. Вывод списка физ лиц. упорядоченного по Фамилии, Имени, Отчеству. 
            System.Console.WriteLine();
            Console.WriteLine($"Считываем данные о физических лицах из файла {personsFile.FilePath}");

            List<Person> personsList = File.ReadAllLines(personsFile.FilePath)
                                           .Select(line => Person.FromTsv(line))
                                           .ToList();

            var personsListOrdered = from s in personsList
                                     orderby s.LastName, s.FirstName, s.MiddleName
                                     select s;
            
            System.Console.WriteLine("----------------------------------------------------------------");
            System.Console.WriteLine("   FIO                      |        Uin       | Register Adress|");
            System.Console.WriteLine("----------------------------------------------------------------");

            foreach (Person person in personsListOrdered) {
                Console.WriteLine($"{person.LastName} {person.FirstName} {person.MiddleName} {person.Uin} {person.RegistrationAddress}");
            }

            System.Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Для того чтобы продолжить, нажмите любую клавишу.");
            Console.ReadKey();

            // 3. Запись юридических лиц в файл
            Console.WriteLine();
            CompaniesFileService companiesFile = new CompaniesFileService("./Companies.tsv");
            Console.WriteLine($"Сохраняем данные юридических лиц в файле {companiesFile.FilePath}");

            bool CompaniessAreWritedToFile = companiesFile.WriteContragentsToFile((List<Contragent>)init.companiesList);
            string messageAboutCompaniesFile = (PersonsAreWritedToFile) ? $"Информация о юр. лицах успешно записана в файл {companiesFile.FilePath}!" :
                                                                     $"При записи юр. лиц в файл {companiesFile.FilePath} произошла ошибка!";
            Console.WriteLine(messageAboutCompaniesFile);
            Console.WriteLine("Для того чтобы продолжить, нажмите любую клавишу.");
            Console.ReadKey();

            // 4. Вывод 5 записей из списка юр. лиц упорядоченных по количеству контактных лиц (по убыванию).         
            System.Console.WriteLine();
            Console.WriteLine($"Считываем данные о юридических лицах из файла {companiesFile.FilePath}");

            List<Company> companiesList = File.ReadAllLines(companiesFile.FilePath)
                                              .Select(line => Company.FromTsv(line, personsList))
                                              .ToList();

            var companiesListOrdered = (from s in companiesList
                                       orderby s.ContactsCount descending
                                       select s).Take(5);

            System.Console.WriteLine("-------------------------------------------------------------");
            System.Console.WriteLine("Uin      |     Name  |  Director | Contacts count |");
            System.Console.WriteLine("-------------------------------------------------------------"); 

            foreach (Company company in companiesListOrdered)
            {
                Console.WriteLine($"{company.Uin} | {company.Name} | {company.Director.Uin} | {company.ContactsCount}");
            }
            System.Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Для того чтобы продолжить, нажмите любую клавишу.");
            Console.ReadKey();

        }

    }
}
