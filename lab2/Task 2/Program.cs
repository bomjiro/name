namespace lab2
{
	class Konverter
	{
		private double _usd;
		private double _euro;
		private double _rub;
		public Konverter(double usd, double euro, double rub)
		{
			_usd = usd;
			_euro = euro;
			_rub = rub;
		}
		public double uanToUsd(double uan) { return uan / _usd; }
		public double uanToEuro(double uan) { return uan / _euro; }
		public double uanToRub(double uan) { return uan / _rub; }
		public double usdToUan(double usd) { return _usd * usd; }
		public double euroToUan(double euro) { return _euro * euro; }
		public double rubToUan(double rub) { return _rub * rub; }

	}
	class Program
		{
			public static void Main(params string[] args)
			{
				Konverter konverter = new Konverter(36, 35, 0.5);
				Console.WriteLine(konverter.uanToUsd(72));
				Console.WriteLine(konverter.uanToEuro(79));
				Console.WriteLine(konverter.uanToRub(89));
				Console.WriteLine(konverter.usdToUan(90));
				Console.WriteLine(konverter.euroToUan(4));
				Console.WriteLine(konverter.rubToUan(12));
			}
		}
	}