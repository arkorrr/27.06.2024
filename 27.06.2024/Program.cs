using System.Diagnostics.CodeAnalysis;

namespace _27._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //Описать структуру Client, содержащую поля: код клиента; ФИО; адрес; телефон; количество заказов, осуществленных клиентом; общая сумма заказов клиента.
            //Описать перечисление ClientType, определяющее важность клиента, и добавить соответствующее поле в структуру Client.
            //Включите в структуру конструктор с параметрами и метод Print().
            //Создать экземпляр структуры.
            Client client = new Client(1, "John Doe", "123 Main St", 5, 10, 5000, ClientType.VIP);
            client.Print();

            //Task2
            //Напишите метод, который возвращает сумму чисел в указанном диапазоне. Метод принимает в качестве параметров границы диапазона.
            int startIndex = 1;
            int endIndex = 3;
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Sum in range = {sumInRange(startIndex, endIndex, arr)}");

            //Task3
            //Реализуйте класс «Самолёт». Необходимо хранить в полях класса: название самолёта, название производителя, год выпуска, тип самолёта.
            //Реализуйте конструкторы и методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса.
            Plane myPlane = new Plane("Boeing 747", "Boeing", 1969, "Passenger");
            myPlane.PrintInfo();

            //Task4
            //Создайте класс «Журнал». Необходимо хранить в полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail.
            //Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через свойства класса.
            Journal myJournal = new Journal("Programmer rewiew", 2011, "C++ C#", "+380 09164534343", "editor@Programmer.com");
            myJournal.PrintInfo();
        }
        class Journal
        {
            private string name;
            private int yearFounded;
            private string description;
            private string contactPhone;
            private string contactEmail;
            public Journal(string name, int yearFounded, string description, string contactPhone, string contactEmail)
            {
                this.name = name;
                this.yearFounded = yearFounded;
                this.description = description;
                this.contactPhone = contactPhone;
                this.contactEmail = contactEmail;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int YearFounded
            {
                get { return yearFounded; }
                set { yearFounded = value; }
            }
            public string Description
            {
                get { return description; }
                set { description = value; }
            }
            public string ContactPhone
            {
                get { return contactPhone; }
                set { contactPhone = value; }
            }
            public string ContactEmail
            {
                get { return contactEmail; }
                set { contactEmail = value; }
            }
            public void PrintInfo()
            {
                Console.WriteLine($"Название журнала: {name}");
                Console.WriteLine($"Год основания: {yearFounded}");
                Console.WriteLine($"Описание: {description}");
                Console.WriteLine($"Контактный телефон: {contactPhone}");
                Console.WriteLine($"Контактный e-mail: {contactEmail}");
            }
        }
        class Plane
        {
            private string name;
            private string manufacturer;
            private int yearOfManufacture;
            private string type;
            public Plane(string name, string manufacturer, int yearOfManufacture, string type)
            {
                this.name = name;
                this.manufacturer = manufacturer;
                this.yearOfManufacture = yearOfManufacture;
                this.type = type;
            }
            public void PrintInfo()
            {
                Console.WriteLine($"Название: {name}");
                Console.WriteLine($"Производитель: {manufacturer}");
                Console.WriteLine($"Год выпуска: {yearOfManufacture}");
                Console.WriteLine($"Тип самолёта: {type}");
            }
            public string GetName()
            {
                return name;
            }
            public string GetManufacturer()
            {
                return manufacturer;
            }
            public int GetYearOfManufacture()
            {
                return yearOfManufacture;
            }
            public string GetType()
            {
                return type;
            }
        }
        public static int sumInRange(int startIndex,int endIndex, int[] arr)
        {
            int sumInRange = arr.Skip(startIndex).Take(endIndex - startIndex + 1).Sum();
            return sumInRange;
        }

        public enum ClientType
        {
            Regular,
            VIP,
            Premium
        }
        struct Client
        {
            public int Id;
            public string FullName;
            public string Address;
            public int number;
            public int orders;
            public int SumOfOrders;
            public ClientType Type;
            public Client(int id, string fullname, string address, int num, int ord, int sumOrd, ClientType type)
            {
                Id = id;
                FullName = fullname;
                Address = address;
                number = num;
                orders = ord;
                SumOfOrders = sumOrd;
                Type = type;
            }
            public void Print()
            {
                Console.WriteLine($"ID = {Id}, Name = {FullName}, Address = {Address}, Number = {number}, Orders = {orders}, Sum of orders = {SumOfOrders}, Type = {Type}");
            }
        }
    }
}
