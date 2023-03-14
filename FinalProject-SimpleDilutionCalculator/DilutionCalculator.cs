using System;

namespace FinalProject_SimpleDilutionCalculator
{
    public class DilutionCalculator

    {
        private double _initialConcentration;
        private double _initialVolume;
        private double _finalConcentration;
        private string _initialConcentrationUnit;
        private string _initialVolumeUnit;
        private string _finalConcentrationUnit;

        private ConversionTool _conversionTool;

      

        public DilutionCalculator(double initialConcentration, double initialVolume, double finalConcentration, string initialConcentrationUnit, string initialVolumeUnit, string finalConcentrationUnit)
        {
            _initialConcentration = initialConcentration;
            _initialVolume = initialVolume;
            _finalConcentration = finalConcentration;
            _initialConcentrationUnit = initialConcentrationUnit;
            _initialVolumeUnit = initialVolumeUnit;
            _finalConcentrationUnit = finalConcentrationUnit;

            _conversionTool = new ConversionTool();

           

        }

        public double DiluentVolume(string v)
        {
            
            // converts units to mb/mL using ConversionTool instance
            double initialConcentrationInMgPerMl = _conversionTool.ConvertToMgPerMl(_initialConcentration, _initialConcentrationUnit);
            double initialVolumeInMl = _conversionTool.ConvertToMl(_initialVolume, _initialVolumeUnit);
            double finalConcentrationInMgPerMl = _conversionTool.ConvertToMl(_finalConcentration, _finalConcentrationUnit);
            _finalConcentration = finalConcentrationInMgPerMl;
            

            // calculate the final volume and diluent volume
            double finalVolumeInMl = ((initialConcentrationInMgPerMl * initialVolumeInMl) / finalConcentrationInMgPerMl);
            double diluentVolumeInMl = Math.Abs(finalVolumeInMl - initialVolumeInMl);

            return diluentVolumeInMl;

        }
    }
}















//            //Need to create instance of ConversionTool somewhere
//            //_conversionTool = new ConversionTool();

//        public double InitialConcentration
//        {
//            get { return _initialConcentration; }
//            set
//            {
//                if (value <= 0)
//                {
//                    throw new ArgumentException("Initial concentration must be greater than zero.");
//                }
//                _initialConcentration = value;
//            }
//        }

//        public double FinalConcentration
//        {
//            get { return _finalConcentration; }
//            set
//            {
//                if (value <= 0)
//                {
//                    throw new ArgumentException("Final concentration must be greater than zero.");
//                }
//                _finalConcentration = value;
//            }
//        }

//        public double InitialVolume
//        {
//            get { return _initialVolume; }
//            set
//            {
//                if (value <= 0)
//                {
//                    throw new ArgumentException("Initial volume must be greater than zero.");
//                }
//                _initialVolume = value;
//            }
//        }

//        //will rewrite when Conversion Tool finished
//        //need to add new instance to call Conversion Tool methods for DiluentVolume
//        //initialVolume is being set as finalConcentration. May need to get rid of the finalVolumne all together and have user input it in the beginning.

//        public double FinalVolume
//        {
//            get {
//                var part1 = _initialConcentration * _initialVolume;
//                var part2 = part1 / _finalConcentration;
//                return part2;

//                //return (_initialConcentration * _initialVolume) / _finalConcentration; }
//            //(1 * 100) / .8

//            }

//        public double DiluentVolume
//        {
//            get { return Math.Abs(FinalVolume - _initialVolume); }
//            //125-100=25mL
//        }
//    }
//}



