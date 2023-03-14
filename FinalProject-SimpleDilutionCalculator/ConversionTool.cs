using System;
using System.Collections.Generic;

namespace FinalProject_SimpleDilutionCalculator
{
    public class ConversionTool
    {
        private readonly Dictionary<string, double> _conversionFactors;

        public ConversionTool()
        {
            //Contains conversion factors between different units
            _conversionFactors = new Dictionary<string, double>();

            //Conversion factors for ug 
            _conversionFactors.Add("ug/uL", 1000);
            _conversionFactors.Add("ug/mL", 1);
            _conversionFactors.Add("ug/L", 0.001);

            //Conversion factors for ng 
            _conversionFactors.Add("ng/uL", 1000000);
            _conversionFactors.Add("ng/mL", 1000);
            _conversionFactors.Add("ng/L", 1);

            //conversion factors for mg
            _conversionFactors.Add("mg/uL", 1000);
            _conversionFactors.Add("mg/mL", 1);
            _conversionFactors.Add("mg/L", 0.001);

            //conversion factors for g (not necessary to do uL)
            _conversionFactors.Add("g/mL", 1000);
            _conversionFactors.Add("g/L", 1000);

            //conversion factors for units of volume
            _conversionFactors.Add("mL", 1.0);
            _conversionFactors.Add("L", 1000.0);
            _conversionFactors.Add("uL", 0.001);
        }

        public double ConvertToMgPerMl(double value, string fromUnit)
        {
            if (!_conversionFactors.ContainsKey(fromUnit))
            {
                return double.NaN;
            }

            double factor = _conversionFactors[fromUnit];

            if (factor == 1 && !fromUnit.EndsWith("mg/mL"))
            {
                return double.NaN;
            }

            return value / factor;
        }

        public double ConvertToMl(double value, string fromUnit)
        {
            if (!_conversionFactors.ContainsKey(fromUnit))
            {
                return double.NaN;
            }

            double factor = _conversionFactors[fromUnit];

            if (fromUnit.EndsWith("L"))
            {
                factor *= 1000.0;
            }
            else if (fromUnit.EndsWith("/uL"))
            {
                factor /= 1000.0;
            }
            else if (fromUnit.EndsWith("mg/mL"))
            {
                factor = 1.0 / _conversionFactors["mg/mL"];
            }

            return value * factor;
        }
    }
}













//using System;
//namespace FinalProject_SimpleDilutionCalculator
//{
//	public class ConversionTool
//	{
//		private Dictionary<string, double> conversionFactors;

//		//Feature 2: Dictionary

//		public ConversionTool()
//		{










//	//Contains conversion factors between different units
//	conversionFactors = new Dictionary<string, double>();

//	//Conversion factors for ug 
//	conversionFactors.Add("ug/uL", 1000);
//	conversionFactors.Add("ug/mL", 1);
//	conversionFactors.Add("ug/L", 0.001);

//	//Conversion factors for ng 
//	conversionFactors.Add("ng/uL", 1000000);
//	conversionFactors.Add("ng/mL", 1000);
//	conversionFactors.Add("ng/L", 1);

//	//conversion factors for mg
//	conversionFactors.Add("mg/uL", 1000);
//	conversionFactors.Add("mg/mL", 1);
//	conversionFactors.Add("mg/L", 0.001);

//	//conversion factors for g (not necessary to do uL)
//	conversionFactors.Add("g/mL", 1000);
//	conversionFactors.Add("g/L", 1000);

//	//conversion factors for units of volume
//	conversionFactors.Add("mL", 1.0);
//	conversionFactors.Add("L", 1000.0);
//	conversionFactors.Add("uL", 0.001);

//}

//public double ConvertToMgPerMl(double value,  string fromUnit)

//{	//may need to get rid of this 
//	if (!conversionFactors.ContainsKey(fromUnit))
//	{
//		throw new ArgumentException($"Unknown unit '{fromUnit}'");
//	}

//	double factor = conversionFactors[fromUnit];
//	return value / factor;
//}

//public double ConvertToMl(double value, string fromUnit)
//{
//	if (!conversionFactors.ContainsKey(fromUnit))
//	{
//		throw new ArgumentException($"Unknown unit '{fromUnit}'");
//	}

//	double factor = conversionFactors[fromUnit];

//	if (fromUnit.EndsWith("L"))
//	{
//		factor *= 1000.0;
//	}
//	else if (fromUnit.EndsWith("/uL"))
//	{
//		factor /= 1000.0;
//	}

//return value * factor;
//		}

//	}
//}


