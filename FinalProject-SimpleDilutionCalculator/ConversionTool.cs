using System;
namespace FinalProject_SimpleDilutionCalculator

{
    public class ConversionTool
    {
        private readonly Dictionary<string, double> _conversionFactors;

        public ConversionTool()
        {
            //Feature 2: Dictionary

            //Contains conversion factors between different units
            _conversionFactors = new Dictionary<string, double>();

            //Conversion factors for ug 
            _conversionFactors.Add("ug/uL", 1000);
            _conversionFactors.Add("ug/mL", 1);
            _conversionFactors.Add("ug/L", 0.001);

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

            //Feature 3: Conversion Tool
        public double ConvertToMgPerMl(double value, string fromUnit)
        {
            if (!_conversionFactors.ContainsKey(fromUnit))
            {
                return double.NaN;
            }

            double factor = _conversionFactors[fromUnit];

            if (fromUnit.EndsWith("g/L"))
            {
                // Convert from g/L to mg/mL
                factor = _conversionFactors["mg/mL"] / _conversionFactors[fromUnit];
            }
            else if (fromUnit.EndsWith("mg/mL"))
            {
                // Convert from mg/mL to mg/mL
                factor = 1;
            }
            else if (fromUnit.EndsWith("ug/uL"))
            {
                // Convert from ug/uL to mg/mL
                factor = _conversionFactors["mg/mL"] / _conversionFactors["ug/uL"];
            }
            else if (fromUnit.EndsWith("ug/mL"))
            {
                // Convert from ug/mL to mg/mL
                factor = _conversionFactors["mg/mL"] / _conversionFactors["ug/mL"];
            }
            else if (fromUnit.EndsWith("ug/L"))
            {
                // Convert from ug/L to mg/mL
                factor = _conversionFactors["mg/mL"] / _conversionFactors["ug/L"];
            }
            else if (fromUnit.EndsWith("mg/uL"))
            {
                // Convert from mg/uL to mg/mL
                factor = _conversionFactors["mg/mL"] / _conversionFactors["mg/uL"];
            }
            else if (fromUnit.EndsWith("g/mL"))
            {
                // Convert from g/mL to mg/mL
                factor = _conversionFactors["g/mL"] / _conversionFactors["mg/mL"];
            }
            else
            {
                // Convert from unknown unit to mg/mL
                factor = factor / _conversionFactors["mg/mL"];
            }

            // Convert to mg/mL
            value *= factor;

            // Convert to mL if necessary
            if (!fromUnit.EndsWith("/mL"))
            {
                value = ConvertToMl(value, fromUnit);
            }

            return value;
        }

        public double ConvertToMl(double value, string fromUnit)
        {
            if (!_conversionFactors.ContainsKey(fromUnit))
            {
                return double.NaN;
            }

            double factor = _conversionFactors[fromUnit];

            if (fromUnit == "mL")
            {
                // Unit is already in mL
                return value;
            }

            if (fromUnit.EndsWith("uL"))
            {
                // Convert from uL to mL
                factor *= _conversionFactors["mL"];
            }
            else
            {
                // Convert from mL, L to mL
                factor *= _conversionFactors["mL"];
            }

            // Convert to mL
            value *= factor;

            return value;
        }

        public bool IsValidUnit(string unit)
        {
            return _conversionFactors.ContainsKey(unit);
        }
    }
}








