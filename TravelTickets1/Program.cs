using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<City>
            {
                new City("Москва", "Россия", new List<string> { "Бефстроганов", "Щи" }, new List<string> { "Красная площадь", "ГУМ" }),
                new City("Санкт-Петербург", "Россия", new List<string> { "Пышки", "Борщ" }, new List<string> { "Эрмитаж", "Дворцовая площадь" }),
                new City("Казань", "Россия", new List<string> { "Эчпочмак", "Кумыс" }, new List<string> { "Казанский кремль", "Кул-Шариф" }),
                new City("Новосибирск", "Россия", new List<string> { "Пельмени", "Морс" }, new List<string> { "Оперный театр", "Центральный парк" }),
                new City("Екатеринбург", "Россия", new List<string> { "Уральские пирожки", "Квас" }, new List<string> { "Храм-на-Крови", "Плотинка" }),
                new City("Сочи", "Россия", new List<string> { "Шашлык", "Чай" }, new List<string> { "Роза Хутор", "Олимпийский парк" }),
                new City("Владивосток", "Россия", new List<string> { "Крабы", "Водка" }, new List<string> { "Русский мост", "Корабельная набережная" }),
                new City("Минск", "Беларусь", new List<string> { "Драники", "Квас" }, new List<string> { "Троицкое предместье", "Национальная библиотека" }),
                new City("Брест", "Беларусь", new List<string> { "Солянка", "Медовуха" }, new List<string> { "Брестская крепость", "Улица Советская" }),
                new City("Гродно", "Беларусь", new List<string> { "Мачанка", "Кисель" }, new List<string> { "Фарный костел", "Замковая гора" }),
                new City("Витебск", "Беларусь", new List<string> { "Клёцки", "Кефир" }, new List<string> { "Усадьба Репина", "Музей Марка Шагала" }),
                new City("Гомель", "Беларусь", new List<string> { "Печеня", "Компот" }, new List<string> { "Дворцово-парковый ансамбль", "Ратуша" }),
                new City("Могилёв", "Беларусь", new List<string> { "Торт Наполеон", "Чай" }, new List<string> { "Площадь Звезды", "Печерский лесопарк" }),
                new City("Полоцк", "Беларусь", new List<string> { "Кислые щи", "Морс" }, new List<string> { "Софийский собор", "Борисов камень" }),
                new City("Торонто", "Канада", new List<string> { "Путин", "Кленовый сироп" }, new List<string> { "CN Tower", "Ripley's Aquarium" }),
                new City("Монреаль", "Канада", new List<string> { "Смокт мясо", "Багель" }, new List<string> { "Старый Монреаль", "Базилика Нотр-Дам" }),
                new City("Ванкувер", "Канада", new List<string> { "Лосось", "Эгг-ног" }, new List<string> { "Stanley Park", "Гастон" }),
                new City("Квебек", "Канада", new List<string> { "Туртиер", "Кленовый чай" }, new List<string> { "Château Frontenac", "Старый город" }),
                new City("Калгари", "Канада", new List<string> { "Стейк", "Кофе" }, new List<string> { "Калгари Стампид", "Башня Калгари" }),
                new City("Оттава", "Канада", new List<string> { "Бобовый суп", "Эгг-ног" }, new List<string> { "Parliament Hill", "Rideau Canal" }),
                new City("Виннипег", "Канада", new List<string> { "Баннок", "Мед" }, new List<string> { "The Forks", "Assiniboine Park" }),
                new City("Пекин", "Китай", new List<string> { "Утка по-пекински", "Зеленый чай" }, new List<string> { "Великая Китайская стена", "Запретный город" }),
                new City("Шанхай", "Китай", new List<string> { "Димсам", "Чай Улун" }, new List<string> { "Шанхайская башня", "Набережная Вайтань" }),
                new City("Гуанчжоу", "Китай", new List<string> { "Димсам", "Суп с лапшой" }, new List<string> { "Кантонская башня", "Храм шести баньяновых деревьев" }),
                new City("Чэнду", "Китай", new List<string> { "Хот-пот", "Чай пуэр" }, new List<string> { "Центр гигантских панд", "Храм Ухоу" }),
                new City("Сиань", "Китай", new List<string> { "Бараньи шашлыки", "Чай" }, new List<string> { "Терракотовая армия", "Старый город" }),
                new City("Ханчжоу", "Китай", new List<string> { "Курица с лонганом", "Чай Драконов колодец" }, new List<string> { "Западное озеро", "Храм Линьинь" }),
                new City("Гонконг", "Китай", new List<string> { "Дан-Тат", "Молочный чай" }, new List<string> { "Пик Виктории", "Алея звезд" }),
                new City("Алматы", "Казахстан", new List<string> { "Бешбармак", "Кумыс" }, new List<string> { "Медео", "Кок-Тобе" }),
                new City("Астана", "Казахстан", new List<string> { "Куырдак", "Айран" }, new List<string> { "Байтерек", "Дворец мира и согласия" }),
                new City("Шымкент", "Казахстан", new List<string> { "Плов", "Шубат" }, new List<string> { "Кокжайлау", "Этноаул" }),
                new City("Караганда", "Казахстан", new List<string> { "Манты", "Чай" }, new List<string> { "Парк культуры", "Музей КарЛАГ" }),
                new City("Тараз", "Казахстан", new List<string> { "Казы", "Кумыс" }, new List<string> { "Мавзолей Айша-биби", "Крепость Тараз" }),
                new City("Уральск", "Казахстан", new List<string> { "Лагман", "Компот" }, new List<string> { "Исторический музей", "Набережная Урала" }),
                new City("Павлодар", "Казахстан", new List<string> { "Шашлык", "Морс" }, new List<string> { "Мечеть Машхур Жусупа", "Парк Металлургов" }),
                // Добавьте остальные города здесь
            };

            var routes = new List<Route>
            {
               // Россия: маршруты внутри страны
            new Route("Москва", "Санкт-Петербург", "Поезд", new List<string>()),
            new Route("Москва", "Казань", "Самолёт", new List<string>()),
            new Route("Москва", "Новосибирск", "Самолёт", new List<string>()),
            new Route("Москва", "Екатеринбург", "Самолёт", new List<string>()),
            new Route("Москва", "Сочи", "Самолёт", new List<string>()),
            new Route("Москва", "Владивосток", "Самолёт", new List<string> { "Новосибирск" }),
            new Route("Санкт-Петербург", "Екатеринбург", "Самолёт", new List<string>()),
            new Route("Казань", "Новосибирск", "Самолёт", new List<string>()),
            new Route("Новосибирск", "Владивосток", "Самолёт", new List<string>()),

            // Беларусь: маршруты внутри страны
            new Route("Минск", "Брест", "Поезд", new List<string>()),
            new Route("Минск", "Гродно", "Поезд", new List<string>()),
            new Route("Минск", "Витебск", "Поезд", new List<string>()),
            new Route("Минск", "Гомель", "Поезд", new List<string>()),
            new Route("Минск", "Могилёв", "Поезд", new List<string>()),
            new Route("Минск", "Полоцк", "Поезд", new List<string> { "Витебск" }),
            new Route("Гродно", "Брест", "Поезд", new List<string>()),
            new Route("Гомель", "Могилёв", "Поезд", new List<string>()),

            // Канада: маршруты внутри страны
            new Route("Торонто", "Монреаль", "Самолёт", new List<string>()),
            new Route("Торонто", "Ванкувер", "Самолёт", new List<string>()),
            new Route("Торонто", "Квебек", "Самолёт", new List<string>()),
            new Route("Торонто", "Калгари", "Самолёт", new List<string>()),
            new Route("Торонто", "Оттава", "Самолёт", new List<string>()),
            new Route("Торонто", "Виннипег", "Самолёт", new List<string> { "Калгари" }),
            new Route("Монреаль", "Квебек", "Самолёт", new List<string>()),
            new Route("Ванкувер", "Калгари", "Самолёт", new List<string>()),

            // Китай: маршруты внутри страны
            new Route("Пекин", "Шанхай", "Самолёт", new List<string>()),
            new Route("Пекин", "Гуанчжоу", "Самолёт", new List<string>()),
            new Route("Пекин", "Чэнду", "Самолёт", new List<string>()),
            new Route("Пекин", "Сиань", "Самолёт", new List<string>()),
            new Route("Пекин", "Ханчжоу", "Самолёт", new List<string>()),
            new Route("Пекин", "Гонконг", "Самолёт", new List<string> { "Шанхай" }),
            new Route("Шанхай", "Гуанчжоу", "Самолёт", new List<string>()),
            new Route("Гуанчжоу", "Чэнду", "Самолёт", new List<string>()),

            // Казахстан: маршруты внутри страны
            new Route("Алматы", "Астана", "Поезд", new List<string>()),
            new Route("Алматы", "Шымкент", "Поезд", new List<string>()),
            new Route("Алматы", "Караганда", "Самолёт", new List<string>()),
            new Route("Алматы", "Тараз", "Поезд", new List<string>()),
            new Route("Алматы", "Уральск", "Самолёт", new List<string>()),
            new Route("Алматы", "Павлодар", "Самолёт", new List<string>()),
            new Route("Астана", "Шымкент", "Самолёт", new List<string>()),
            new Route("Шымкент", "Караганда", "Самолёт", new List<string>()),

            // Международные маршруты
            new Route("Москва", "Минск", "Самолёт", new List<string>()),
            new Route("Москва", "Торонто", "Самолёт", new List<string>()),
            new Route("Москва", "Пекин", "Самолёт", new List<string>()),
            new Route("Москва", "Алматы", "Самолёт", new List<string>()),
            new Route("Минск", "Пекин", "Самолёт", new List<string> { "Москва" }),
            new Route("Минск", "Алматы", "Самолёт", new List<string> { "Москва" }),
            new Route("Минск", "Торонто", "Самолёт", new List<string> { "Москва" }),
            new Route("Торонто", "Пекин", "Самолёт", new List<string> { "Москва" }),
            new Route("Торонто", "Алматы", "Самолёт", new List<string> { "Москва" }),
            new Route("Пекин", "Алматы", "Самолёт", new List<string>()),
            };

            Console.WriteLine("Добро пожаловать в систему поиска маршрутов!");
            Console.Write("Введите город отправления: ");
            string departure = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Введите город назначения: ");
            string destination = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(departure) || string.IsNullOrWhiteSpace(destination))
            {
                Console.WriteLine("Ошибка: Необходимо ввести оба города!");
                return;
            }

            var route = FindRoute(routes, departure, destination);
            if (route != null)
            {
                var destinationCity = cities.FirstOrDefault(c => c.Name.Equals(destination, StringComparison.OrdinalIgnoreCase));
                if (destinationCity != null)
                {
                    Console.WriteLine($"\nБилет: {route.Transport} из {route.From} в {route.To}.\n" +
                                      $"Места: {string.Join(", ", destinationCity.Places)}.\n" +
                                      $"Попробуйте: {string.Join(", ", destinationCity.Food)}.");
                }
                else
                {
                    Console.WriteLine("\nГород назначения не найден.");
                }
            }
            else
            {
                Console.WriteLine("\nМаршрут не найден.");
            }
        }

        private static Route? FindRoute(List<Route> routes, string from, string to)
        {
            return routes.FirstOrDefault(route =>
                route.From.Equals(from, StringComparison.OrdinalIgnoreCase) &&
                route.To.Equals(to, StringComparison.OrdinalIgnoreCase));
        }
    }

    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public List<string> Food { get; set; }
        public List<string> Places { get; set; }

        public City(string name, string country, List<string> food, List<string> places)
        {
            Name = name;
            Country = country;
            Food = food;
            Places = places;
        }
    }

    public class Route
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Transport { get; set; }
        public List<string> Connections { get; set; }

        public Route(string from, string to, string transport, List<string> connections)
        {
            From = from;
            To = to;
            Transport = transport;
            Connections = connections;
        }
    }
}
