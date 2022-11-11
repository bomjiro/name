namespace lab2
{
    class adress
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private int _house;
        private int _apartment;
        public int index { get { return _index; } set { _index = value; } }
        public string country { get { return _country; } set { _country = value; } }
        public string city { get { return _city; } set { _city = value; } }
        public string street { get { return _street; } set { _street = value; } }
        public int house { get { return _house; } set { _house = value; } }
        public int apartment { get { return _apartment; } set { _apartment = value; } }
    }
    class program
    {
        public static void Main(params string[] args)
        {
            adress a=new adress();
            a.index=39600;
            a.country = "Ukraine";
            a.city = "Kremenchuk";
            a.street = "Soborna";
            a.house = 34;
            a.apartment = 21;
            Console.WriteLine($"Index: {a.index}\nCountry: {a.country}\nCity: {a.city}\nStreet: {a.street}\nHouse: {a.house}" +
                $"\nApartment: {a.apartment}");
        }

    }
}
