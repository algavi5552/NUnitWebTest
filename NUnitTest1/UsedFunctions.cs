namespace NUnitWebTest
{
    public class UsedFunctions
    {
        public static string DayNightCheck()
            //если текущее время попадает в диапазон понятия "день", то метод выдает слово "day",
            //остальное по аналогии
        {
            const int morningStart = 5;
            const int dayStart = 12;
            const int eveningStart = 18;
            const int nightStart = 23;

            var currentHour = Convert.ToInt32(DateTime.Now.Hour);

            if (currentHour >= morningStart && currentHour < dayStart)
            {
                return "morning";
            }

            if (currentHour >= dayStart && currentHour < eveningStart)
            {
                return "day";
            }

            if (currentHour >= eveningStart && currentHour < nightStart)
            {
                return "evening";
            }

            return "night";
        }

        public static bool TimeCheck(string greetings, string keyWords, string timecheck)
        {
            return greetings.Contains(keyWords) && UsedFunctions.DayNightCheck().Contains(timecheck);
        }
    }
}
