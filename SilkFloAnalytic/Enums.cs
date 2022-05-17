using System.ComponentModel;

namespace SilkFloAnalytic
{
    public class Enums
    {
    }
    public enum CardTitle
    {
        [Description("Active Users")]
        ActiveUsers = 1,
        [Description("Inactive Users")]
        InActiveUsers,
        [Description("Active Complaints")]
        ActiveComplaints,
        [Description("Inactive Complaints")]
        InActiveComplaints
    }
}
