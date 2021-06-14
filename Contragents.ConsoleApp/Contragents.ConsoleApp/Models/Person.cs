using System;

namespace Contragents.ConsoleApp.Models
{
    public class Person : Contragent
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; }
        public DateTime BirthDate { get; set; }
        
        public Person(string uin, string registrationAddress, string actualAddress, DateTime created, string createdBy,
                       DateTime updated, string updatedBy, string firstName, string lastName, string middleName, string gender, 
                       DateTime birthDate) : base(uin, registrationAddress, actualAddress, created, createdBy, updated, updatedBy)
        {
            FirstName  = firstName;
            LastName   = lastName;
            MiddleName = middleName;
            Gender = gender;
            BirthDate  = birthDate;
        }

        public static Person FromTsv(string tsvLine)
        {
            string[] values = tsvLine.Split('\t');
            Person person = new Person(
              Convert.ToString(values[0]),
              Convert.ToString(values[1]),
              Convert.ToString(values[2]),
              Convert.ToDateTime(values[3]),
              Convert.ToString(values[4]),
              Convert.ToDateTime(values[5]),
              Convert.ToString(values[6]),
              Convert.ToString(values[7]),
              Convert.ToString(values[8]),
              Convert.ToString(values[9]),
              Convert.ToString(values[10]),
              Convert.ToDateTime(values[11]));
              
            return person;
        }
    }
}
