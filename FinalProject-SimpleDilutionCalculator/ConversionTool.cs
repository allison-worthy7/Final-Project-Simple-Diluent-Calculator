using System;
namespace FinalProject_SimpleDilutionCalculator
{
	public class ConversionTool
	{
		private Dictionary<string, double> conversionFactors;

		//Feature 2: Dictionary

		public ConversionTool()
		{
			//Contains conversion factors between different units
			conversionFactors = new Dictionary<string, double>();

			//Conversion factors for ug 
			conversionFactors.Add("ug/uL", 1000);
			conversionFactors.Add("ug/mL", 1);
			conversionFactors.Add("ug/L", 0.001);

			//Conversion factors for ng 
			conversionFactors.Add("ng/uL", 1000000);
			conversionFactors.Add("ng/mL", 1000);
			conversionFactors.Add("ng/L", 1);

			//conversion factors for mg
			conversionFactors.Add("mg/uL", 1000);
			conversionFactors.Add("mg/mL", 1);
			conversionFactors.Add("mg/L", 0.001);

			//conversion factors for g (not necessary to do uL)
			conversionFactors.Add("g/mL", 1000);
			conversionFactors.Add("g/L", 1000);

//			public double ConvertToMgPerMl(double value, string fromUnit)

//			{
//				if (!conversionFactors.ContainsKey(fromUnit))
//				{
//					throw new ArgumentException($"Unknown unit '{fromUnit}'");
//				}

//				double factor = conversionFactors[fromUnit];
//				return value / factor;
//			}

//			public double ConvertToMl(double value, string fromUnit)
//			{
//				if (!conversionFactors.ContainsKey(fromUnit))
//				{
//					throw new ArgumentException($"Unknown unit '{fromUnit}'");
//				}

//				double factor = conversionFactors[fromUnit];

//				return value / factor;
//			}

//		}
//	}
//}


