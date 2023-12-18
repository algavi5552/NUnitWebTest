namespace NUnitWebTest
{
    public class UsedFunctions
    {
        public static string DayNightCheck()
        {
            const int dayStart = 8;
            const int dayEnd = 20;

            var currentHour = Convert.ToInt32(DateTime.Now.Hour);

            if (currentHour > dayStart && currentHour < dayEnd)
            {
                return "day";
            }
            return "night";
        }

    }
}
