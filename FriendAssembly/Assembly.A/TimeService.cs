using System.Runtime.CompilerServices;

// see: https://learn.microsoft.com/en-us/dotnet/standard/assembly/friend
[assembly: InternalsVisibleTo("Assembly.B")]

namespace Assembly.A
{
    internal class TimeService
    {
        public string GetDescription(DateTime dt)
        {
            if (dt.Hour >= 6 && dt.Hour < 12) return "Morning";
            else if (dt.Hour >= 12 && dt.Hour < 18) return "Afternoon";
            else if (dt.Hour >= 18 && dt.Hour < 20) return "Evening";
            else return "Night";
        }
    }
}