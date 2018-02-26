using System;
using Concepts;

namespace Domain.StaffUser.AddStaffUser
{
    public class AddDataOwner : BaseStaffUser
    {   
        public Location Location { get; set; }
        public int YearOfBirth { get; set; }
        public Sex Sex { get; set; }
        public Guid NationalSociety { get; set; }
        public Language PreferredLanguage { get; set; }

        public string Position { get; set; }
        public string DutyStation { get; set; }
    }
}