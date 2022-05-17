using SilkFloAnalytic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilkFloAnalytic.Data
{
    public class MockedDataService : IDataService
    {
        public static List<User> _users { get; set; }
        public static List<Complaint> _complaints { get; set; }
        public MockedDataService()
        {
            BuildMockedUsers();
        }

        private static void BuildMockedUsers()
        {
            #region users data
            _users = new List<User>()
            {
                new User
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    EmailAddress = "johndoe@gmail.com",
                    PhoneNumber = "08192838212",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    StateOfOrigin = "Lagos",
                    UserName = "JohnDoe1",
                    IsActive = true,
                    Gender = Gender.Male
                },
                new User
                {
                    Id = 2,
                    FirstName = "King",
                    LastName = "Doe",
                    EmailAddress = "kingdoe@gmail.com",
                    PhoneNumber = "08192833612",
                    DateCreated = Convert.ToDateTime("5-May-2021"),
                    StateOfOrigin = "Lagos",
                    UserName = "KingDoe1",
                    IsActive = true,
                    Gender = Gender.Male
                },  
                new User
                {
                    Id = 3,
                    FirstName = "Maria",
                    LastName = "Bush",
                    EmailAddress = "mariabush@gmail.com",
                    PhoneNumber = "08192825312",
                    DateCreated = Convert.ToDateTime("1-May-2021"),
                    StateOfOrigin = "Ogun",
                    UserName = "mariabush1",
                    IsActive = true,
                    Gender = Gender.Female
                },  
                new User
                {
                    Id = 4,
                    FirstName = "Kim",
                    LastName = "Doe",
                    EmailAddress = "kimdoe@gmail.com",
                    PhoneNumber = "08192838242",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    StateOfOrigin = "Abuja",
                    UserName = "KimDoe1",
                    IsActive = true,
                    Gender = Gender.Female
                },  
                new User
                {
                    Id = 5,
                    FirstName = "Silver",
                    LastName = "Gold",
                    EmailAddress = "silvergold@gmail.com",
                    PhoneNumber = "08193538212",
                    DateCreated = Convert.ToDateTime("10-April-2020"),
                    StateOfOrigin = "Abuja",
                    UserName = "SilverGold1",
                    IsActive = true,
                    Gender = Gender.Female
                },  
                new User
                {
                    Id = 6,
                    FirstName = "John",
                    LastName = "Stone",
                    EmailAddress = "johnstone@gmail.com",
                    PhoneNumber = "08192824212",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    StateOfOrigin = "Lagos",
                    UserName = "JohnStone1",
                    IsActive = true,
                    Gender = Gender.Male
                },  
                new User
                {
                    Id = 7,
                    FirstName = "Grace",
                    LastName = "Kane",
                    EmailAddress = "gracekane@gmail.com",
                    PhoneNumber = "08192338212",
                    DateCreated = Convert.ToDateTime("10-April-2021"),
                    StateOfOrigin = "Kaduna",
                    UserName = "GraceKane1",
                    IsActive = true,
                    Gender = Gender.Female
                },  
                new User
                {
                    Id = 8,
                    FirstName = "John",
                    LastName = "Mega",
                    EmailAddress = "johnmega@gmail.com",
                    PhoneNumber = "08192348212",
                    DateCreated = Convert.ToDateTime("21-May-2020"),
                    StateOfOrigin = "Lagos",
                    UserName = "JohnMega1",
                    IsActive = false,
                    Gender = Gender.Male
                },  
                new User
                {
                    Id = 9,
                    FirstName = "Amanda",
                    LastName = "Bush",
                    EmailAddress = "amandabush@gmail.com",
                    PhoneNumber = "08199038212",
                    DateCreated = Convert.ToDateTime("10-May-2020"),
                    StateOfOrigin = "Kaduna",
                    UserName = "AmandaBush1",
                    IsActive = false,
                    Gender = Gender.Female
                },  
                new User
                {
                    Id = 10,
                    FirstName = "Smith",
                    LastName = "Jackson",
                    EmailAddress = "smithjackson@gmail.com",
                    PhoneNumber = "08192358212",
                    DateCreated = Convert.ToDateTime("10-May-2020"),
                    StateOfOrigin = "Lagos",
                    UserName = "SmithJackson1",
                    IsActive = false,
                    Gender = Gender.Male
                },  
                new User
                {
                    Id = 11,
                    FirstName = "Diana",
                    LastName = "Dim",
                    EmailAddress = "diandim@gmail.com",
                    PhoneNumber = "08022838212",
                    DateCreated = Convert.ToDateTime("10-Jan-2020"),
                    StateOfOrigin = "Kogi",
                    UserName = "DianaDim1",
                    IsActive = false,
                    Gender = Gender.Female
                },  
                new User
                {
                    Id = 12,
                    FirstName = "Sam",
                    LastName = "Zion",
                    EmailAddress = "samzion@gmail.com",
                    PhoneNumber = "08192238212",
                    DateCreated = Convert.ToDateTime("10-May-2020"),
                    StateOfOrigin = "Kogi",
                    UserName = "SamZion1",
                    IsActive = true,
                    Gender = Gender.Male
                },  
                new User
                {
                    Id = 13,
                    FirstName = "Amara",
                    LastName = "Me",
                    EmailAddress = "amarame@gmail.com",
                    PhoneNumber = "08192838212",
                    DateCreated = Convert.ToDateTime("10-May-2020"),
                    StateOfOrigin = "Kaduna",
                    UserName = "AmaraMe1",
                    IsActive = true,
                    Gender = Gender.Female
                }, 
                new User
                {
                    Id = 14,
                    FirstName = "Amara",
                    LastName = "Badmos",
                    EmailAddress = "amarabadmos@gmail.com",
                    PhoneNumber = "08192833212",
                    DateCreated = Convert.ToDateTime("11-May-2019"),
                    StateOfOrigin = "Ogun",
                    UserName = "AmaraBadmos1",
                    IsActive = true,
                    Gender = Gender.Female
                }, 
                new User
                {
                    Id = 15,
                    FirstName = "George",
                    LastName = "Wells",
                    EmailAddress = "georgewells@gmail.com",
                    PhoneNumber = "08192128212",
                    DateCreated = Convert.ToDateTime("10-May-2019"),
                    StateOfOrigin = "Edo",
                    UserName = "GeorgeWells1",
                    IsActive = true,
                    Gender = Gender.Male
                }, 
                new User
                {
                    Id = 13,
                    FirstName = "Man",
                    LastName = "Ede",
                    EmailAddress = "manede@gmail.com",
                    PhoneNumber = "08012838212",
                    DateCreated = Convert.ToDateTime("09-May-2019"),
                    StateOfOrigin = "Kaduna",
                    UserName = "ManEde1",
                    IsActive = true,
                    Gender = Gender.Male
                },
            };
            #endregion

            #region complaints data 

            _complaints = new List<Complaint>
            {
                new Complaint
                {
                    Id = 1,
                    UserId = 1,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    DateUpdated = Convert.ToDateTime("11-May-2021"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 2,
                    UserId = 1,
                    Description = "Testing the app not working",
                    Subject = "Scam",
                    DateCreated = Convert.ToDateTime("10-May-2022"),
                    DateUpdated = Convert.ToDateTime("11-May-2022"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 3,
                    UserId = 4,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    DateUpdated = Convert.ToDateTime("11-May-2021"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 4,
                    UserId = 1,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("14-May-2021"),
                    DateUpdated = Convert.ToDateTime("15-May-2021"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 5,
                    UserId = 6,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2020"),
                    DateUpdated = Convert.ToDateTime("11-May-2020"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 6,
                    UserId = 1,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2022"),
                    DateUpdated = Convert.ToDateTime("11-May-2022"),
                    IsActive = true
                },
                new Complaint
                {
                    Id = 7,
                    UserId = 8,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("14-May-2022"),
                    DateUpdated = Convert.ToDateTime("14-May-2022"),
                    IsActive = true
                },
                new Complaint
                {
                    Id = 8,
                    UserId = 4,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    DateUpdated = Convert.ToDateTime("15-May-2021"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 9,
                    UserId = 2,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2022"),
                    DateUpdated = Convert.ToDateTime("11-May-2022"),
                    IsActive = true
                },
                new Complaint
                {
                    Id = 10,
                    UserId = 12,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    DateUpdated = Convert.ToDateTime("11-May-2021"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 11,
                    UserId = 11,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("15-May-2021"),
                    DateUpdated = Convert.ToDateTime("20-May-2021"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 12,
                    UserId = 1,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-Jan-2022"),
                    DateUpdated = Convert.ToDateTime("11-Jan-2022"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 13,
                    UserId = 15,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    DateUpdated = Convert.ToDateTime("11-May-2021"),
                    IsActive = true
                },
                new Complaint
                {
                    Id = 14,
                    UserId = 12,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    DateUpdated = Convert.ToDateTime("11-May-2021"),
                    IsActive = true
                },
                new Complaint
                {
                    Id = 15,
                    UserId = 1,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    DateUpdated = Convert.ToDateTime("11-May-2021"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 16,
                    UserId = 1,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    DateUpdated = Convert.ToDateTime("11-May-2021"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 17,
                    UserId = 13,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-Jan-2022"),
                    DateUpdated = Convert.ToDateTime("11-Jan-2022"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 18,
                    UserId = 1,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("15-April-2021"),
                    DateUpdated = Convert.ToDateTime("17-April-2021"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 19,
                    UserId = 11,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2021"),
                    DateUpdated = Convert.ToDateTime("11-May-2021"),
                    IsActive = true
                },
                new Complaint
                {
                    Id = 20,
                    UserId = 1,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2020"),
                    DateUpdated = Convert.ToDateTime("11-May-2020"),
                    IsActive = false
                },
                new Complaint
                {
                    Id = 21,
                    UserId = 1,
                    Description = "Testing the app not working",
                    Subject = "Test",
                    DateCreated = Convert.ToDateTime("10-May-2020"),
                    DateUpdated = Convert.ToDateTime("11-May-2020"),
                    IsActive = true
                },
            };
            #endregion
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            var response = new List<User>();
            response = _users.Select(x => new User
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                EmailAddress = x.EmailAddress,
                PhoneNumber = x.PhoneNumber,
                StateOfOrigin = x.StateOfOrigin,
                DateCreated = x.DateCreated,
                Gender = x.Gender,
                IsActive = x.IsActive,
                UserName = x.UserName
            }).OrderBy(x => x.DateCreated).ToList();
            return response;
        }

        public async Task<IEnumerable<Complaint>> GetComplaints()
        {
            var response = new List<Complaint>();
            response = _complaints.Select(x => new Complaint
            {
                Id = x.Id,
                Subject = x.Subject,
                UserId = x.UserId,
                Description = x.Description,
                IsActive = x.IsActive,
                DateCreated = x.DateCreated,
                DateUpdated = x.DateUpdated
            }).OrderBy(x => x.DateCreated).ToList();

            return response;
        }
    }
}
