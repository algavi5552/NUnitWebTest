namespace NUnitWebTest
{
    public class UsedFunctions
    {
        public static string DayNightCheck()
            //если текущее время попадает в диапазон понятия "день", то метод выдает слово "day"
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
