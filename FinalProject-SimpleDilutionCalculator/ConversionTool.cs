using System;
namespace FinalProject_SimpleDilutionCalculator
{
	public class ConversionTool
	{
		private Dictionary<string, double> conversionFactors;

		public ConversionTool()
		{
			//Contains conversion factors between different units
			conversionFactors = new Dictionary<string, double>();
		}
	}
}

