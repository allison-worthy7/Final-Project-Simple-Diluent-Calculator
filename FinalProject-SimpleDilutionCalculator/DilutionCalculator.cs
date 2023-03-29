using System;
namespace FinalProject_SimpleDilutionCalculator
{
    public class DilutionCalculator
    {
        private double _initialConcentration;
        private string _initialConcentrationUnit;
        private double _initialVolume;
        private string _initialVolumeUnit;
        private double _finalConcentration;
        private string _finalConcentrationUnit;
        private ConversionTool _conversionTool;

        public DilutionCalculator(double initialConcentration, string initialConcentrationUnit, double initialVolume, string initialVolumeUnit, double finalConcentration, string finalConcentrationUnit)
        {   //
            _conversionTool = new ConversionTool();

            // Convert initial concentration and final concentration to mg/mL if necessary
            if (!_conversionTool.IsValidUnit(initialConcentrationUnit))
            {
                throw new ArgumentException("Invalid initial concentration unit");
            }

            if (!_conversionTool.IsValidUnit(finalConcentrationUnit))
            {
                throw new ArgumentException("Invalid final concentration unit");
            }

            _initialConcentration = _conversionTool.ConvertToMgPerMl(initialConcentration, initialConcentrationUnit);
            _initialConcentrationUnit = "mg/mL";

            _finalConcentration = _conversionTool.ConvertToMgPerMl(finalConcentration, finalConcentrationUnit);
            _finalConcentrationUnit = "mg/mL";

            // Convert initial volume to mL if necessary
            if (!_conversionTool.IsValidUnit(initialVolumeUnit))
            {
                throw new ArgumentException("Invalid initial volume unit");
            }

            _initialVolume = _conversionTool.ConvertToMl(initialVolume, initialVolumeUnit);
            _initialVolumeUnit = "mL";
        }

        public double DiluentVolume()
        {
            // Calculate the final volume and diluent volume
            double finalVolumeInMl = ((_initialConcentration * _initialVolume) / _finalConcentration);
            double diluentVolumeInMl = Math.Abs(finalVolumeInMl - _initialVolume);

            return diluentVolumeInMl;
        }
    }
}

