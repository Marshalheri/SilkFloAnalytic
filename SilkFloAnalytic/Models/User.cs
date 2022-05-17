namespace SilkFloAnalytic.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string StateOfOrigin { get; set; }
        public bool IsActive { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Female
    }

    public class DataItem
    {
        public string Year { get; set; }
        public long NumberOfUsers { get; set; }
        public long NumberOfComplaints { get; set; }
    }
}
