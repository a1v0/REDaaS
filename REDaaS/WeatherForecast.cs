namespace REDaaS
{
    public class WeatherForecast
    {

        public static int Adder(int num1,int num2)
        {
            return num1 + num2;
        }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}