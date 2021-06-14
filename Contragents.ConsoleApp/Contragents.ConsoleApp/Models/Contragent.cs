using System;

namespace Contragents.ConsoleApp.Models
{
    public abstract class Contragent
    {
        public string Uin { get; set; }
        public string RegistrationAddress { get; set; }
        public string ActualAddress { get; set; }
        public DateTime Created { get; }
        public string CreatedBy { get;  }
        public DateTime Updated { get; }
        public string UpdatedBy { get; }
        
        public Contragent(string uin, string registrationAddress, string actualAddress, DateTime created, string createdBy, 
                          DateTime updated, string updatedBy)
        {
            Uin = uin;
            RegistrationAddress = registrationAddress;
            ActualAddress = actualAddress;
            Created = created;
            CreatedBy = createdBy;
            Updated = updated;
        }
    }
}
