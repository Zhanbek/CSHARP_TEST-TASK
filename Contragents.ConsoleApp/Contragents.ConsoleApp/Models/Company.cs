using System;
using System.Collections.Generic;
using System.Linq;

namespace Contragents.ConsoleApp.Models
{
    public class Company : Contragent
    {
        public string Name { get; set; }
        public Person Director { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int ContactsCount { get; set; }
        public List<Person> Contacts { get; set; }
        
        public Company(string uin, string registrationAddress, string actualAddress, DateTime created, string createdBy,
                       DateTime updated, string updatedBy, string name, Person director, DateTime registrationDate, List<Person> contacts) :
           base(uin, registrationAddress, actualAddress, created, createdBy, updated, updatedBy)
        {
            Name = name;
            Director = director;
            RegistrationDate = registrationDate;
            ContactsCount = contacts.Count;
            Contacts = contacts;           
        }

        public static Company FromTsv(string tsvLine, List<Person> personsList)
        {
            string[] values = tsvLine.Split('\t');
            // Получим ID директора и контактных лиц
            string directorUin = Convert.ToString(values[8]);
            string[] contactsUinList = Convert.ToString(values[11]).Split(';') ;

            // Получим объект директора
            var directorQueryResult = from s in personsList
                                      where s.Uin == directorUin
                                      select s;
            List<Person> director = directorQueryResult.ToList();
            // Получим объекты контактных лиц
            var contactsQueryResult = from s in personsList
                                      where contactsUinList.Contains(s.Uin)
                                      select s;
            List<Person> contactsList = contactsQueryResult.ToList();
          
            Company company = new Company(
              Convert.ToString(values[0]),
              Convert.ToString(values[1]),
              Convert.ToString(values[2]),
              Convert.ToDateTime(values[3]),
              Convert.ToString(values[4]),
              Convert.ToDateTime(values[5]),
              Convert.ToString(values[6]),
              Convert.ToString(values[7]),
              director[0],
              Convert.ToDateTime(values[9]),
              contactsList);
            
            return company;
        }
    }
}
