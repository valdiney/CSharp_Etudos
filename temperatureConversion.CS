/*
 * Created by SharpDevelop.
 * User: franca
 * Date: 15/11/2016
 * Time: 17:20
 */
using System;

namespace temperatureConversion
{
	class Program
	{
		class TemperatureConversion
		{
			private double temperature;
			
			public void setTemperature(double temperature) {
				this.temperature = temperature;
			}
			
			public double getTemperature() {
				return this.temperature;
			}
			
			public double celsiusToFahreit() {
				return 9.0 * this.temperature / 5 + 32.0;
			}
			
			public double fahreitToCelsius() {
				return 5.0 * (this.temperature - 32) / 9.0;
			}
			
			public double celsiusToKelvin() {
				return this.temperature + 273.15;
			}
			
			public double kelvinToCelsius() {
				return this.temperature - 273.15;
			}
			
			public double celsiusToRankine() {
				return (this.temperature + 273.15) * 1.8;
			}
			
			public double rankineToCelsius() {
				return (this.temperature + 1.8) - 273.15;
			}
		}
		
		public static void Main(string[] args)
		{
			TemperatureConversion conversion = new TemperatureConversion();
			
			conversion.setTemperature(85);
			Console.WriteLine(conversion.celsiusToFahreit());

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}