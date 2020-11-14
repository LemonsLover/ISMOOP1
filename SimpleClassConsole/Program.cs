using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassConsole
{

    class Product{
        protected string Name;
        protected float Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected float Weight;

        //constructors
        public Product()
        {
            Name = "Unknown";
            Price = 0;
            Currency Cost = new Currency("Unknown", 0);
            Quantity = 0;
            Producer = "Unknown";
            Weight = 0;
        }
        public Product(string name, float price, Currency cost)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = 0;
            Producer = "Unknown";
            Weight = 0;
        }
        public Product(string name, float price, Currency cost, int quantity, string producer,
            float weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = obj.Cost;
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }

        //SET- GET-
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetPrice(float price)
        {
            if (price > 0)
                Price = price;
        }
        public void SetCost(Currency cost)
        {
            if (cost.GetExRate() >= 0)
                Cost = cost;
        }
        public void SetQuantity(int quantity)
        {
            if(quantity >= 0)
                Quantity = quantity;
        }
        public void SetProducer(string producer)
        {
            Producer = producer;
        }
        public void SetWeight(float weight)
        {
            if (weight > 0)
                Weight = weight;
        }
        public string GetName()
        {
            return Name;
        }
        public float GetPrice()
        {
            return Price;
        }
        public Currency GetCost()
        {
            return Cost;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public string GetProducer()
        {
            return Producer;
        }
        public float GetWeight()
        {
            return Weight;
        }

        //methods
        public float GetPriceInUAH()
        {
            return Price * Cost.GetExRate();
        }
        public float GetTotalPriceInUAH()
        {
            return Price * Quantity * Cost.GetExRate();
        }
        public float GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
    class Currency
    {
        protected string Name;
        protected float ExRate;

        //constructors
        public Currency()
        {
            Name = "Unknown";
            ExRate = 0;
        }
        public Currency(string name, float exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(float exRate)
        {
            Name = "Unknown";
            ExRate = exRate;
        }
        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }

        //SET- GET-
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetExRate(float exRate)
        {
            if (exRate >= 0)
                ExRate = exRate;
        }
        public string GetName()
        {
            return Name;
        }
        public float GetExRate()
        {
            return ExRate;
        }
    }
    class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        //constructors
        public Date()
        {
            Year = 2020;
            Month = 11;
            Day = 13;
            Hours = 00;
            Minutes = 00;
        }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year; Month = month; Day = day; Hours = hours; Minutes = minutes;
        }
        public Date(int day, int hours, int minutes)
        {
            Year = 2020; Month = 11; Day = day; Hours = hours; Minutes = minutes;
        }
        public Date(Date obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }

        //SET- GET-
        public void SetYear(int year)
        {
            if(year > 2000 && year < 3000)
            {
                Year = year;
            }
        }
        public void SetMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                Month = month;
            }
        }
        public void SetDay(int day)
        {
            if (day >=1  && day <= 31)
            {
                Day = day;
            }
        }
        public void SetHours(int hours)
        {
            if (hours >= 0 && hours <= 23)
            {
                Hours = hours;
            }
        }
        public void SetMinute(int minutes)
        {
            if (minutes >= 0 && minutes <= 59)
            {
                Minutes = minutes;
            }
        }
        public int GetYear()
        {
            return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public int GetDay()
        {
            return Day;
        }
        public int GetHours()
        {
            return Hours;
        }
        public int GetMinutes()
        {
            return Minutes;
        }
    }
    class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;

        //constructors
        public Airplane()
        {
            StartCity = "Unknown";
            FinishCity = "Unknown";
            Date StartDate = new Date();
            Date FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(Date startDate, Date finishDate)
        {
            StartCity = "Unknown";
            FinishCity = "Unknown";
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(string startCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = "Unknown";
            StartDate = startDate;
            FinishDate = finishDate;
        }

        //SET- GET-
        public void SetStartDate(Date startDate)
        {
            if(startDate.GetDay() >= 1 && startDate.GetDay() <= 31 
                && startDate.GetHours() >= 0 && startDate.GetHours() <= 23 
                && startDate.GetMonth() >= 1 && startDate.GetMonth() <= 12
                && startDate.GetMinutes() >= 1 && startDate.GetMinutes() <= 60)
            StartDate = startDate;
        }
        public void SetFinishDate(Date finishDate)
        {
            if (finishDate.GetDay() >= 1 && finishDate.GetDay() <= 31
                && finishDate.GetHours() >= 0 && finishDate.GetHours() <= 23
                && finishDate.GetMonth() >= 1 && finishDate.GetMonth() <= 12
                && finishDate.GetMinutes() >= 1 && finishDate.GetMinutes() <= 60)
                FinishDate = finishDate;
        }
        public void SetStartCity(string startCity)
        {
            StartCity = startCity;
        }
        public void SetFinishCity(string finishCity)
        {
            FinishCity = finishCity;
        }

        public string GetStartCity()
        {
            return StartCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public Date GetStartDate()
        {
            return StartDate;
        }
        public Date GetFinishDate()
        {
            return FinishDate;
        }

        //methods
        public double GetTotalTime()
        {
            DateTime startDate = new DateTime(StartDate.GetYear(), StartDate.GetMonth()
                , StartDate.GetDay(), StartDate.GetHours(), StartDate.GetMinutes(), 0);
            DateTime finishDate = new DateTime(FinishDate.GetYear(), FinishDate.GetMonth()
                , FinishDate.GetDay(), FinishDate.GetHours(), FinishDate.GetMinutes(), 0);
            return (finishDate - startDate).TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            return StartDate.GetDay() == FinishDate.GetDay()
                && StartDate.GetMonth() == FinishDate.GetMonth()
                && StartDate.GetYear() == FinishDate.GetYear();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Product Apple = new Product("Apple",0.3f,new Currency("$", 29), 50, "Yehor Ovseukov", 0.2f);
            
            Airplane Mriya = new Airplane("Zytomir", "New York", new Date(2019, 6,23, 15, 43), new Date(2020, 12,15, 9, 30));

            Console.WriteLine(Apple.GetProducer() + " sell " + Apple.GetName() + " with " + 
                Apple.GetPriceInUAH() + " price for each !");
            Console.WriteLine($"He fly on airplane form {Mriya.GetStartCity()} to {Mriya.GetFinishCity()}");
            Console.WriteLine(Mriya.GetTotalTime());
            Console.ReadKey();
        }
    }
}
