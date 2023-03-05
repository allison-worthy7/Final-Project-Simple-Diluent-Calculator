using System;

namespace FinalProject_SimpleDilutionCalculator
{
    public class DilutionCalculator
    {
        private double _initialConcentration;
        private double _finalConcentration;
        private double _initialVolume;

        public DilutionCalculator(double initialConcentration, double initialVolume, double finalConcentration)
        {
            InitialConcentration = initialConcentration;
            FinalConcentration = finalConcentration;
            InitialVolume = initialVolume;
        }

            //Need to create instance of ConversionTool somewhere
            //_conversionTool = new ConversionTool();

        public double InitialConcentration
        {
            get { return _initialConcentration; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Initial concentration must be greater than zero.");
                }
                _initialConcentration = value;
            }
        }

        public double FinalConcentration
        {
            get { return _finalConcentration; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Final concentration must be greater than zero.");
                }
                _finalConcentration = value;
            }
        }

        public double InitialVolume
        {
            get { return _initialVolume; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Initial volume must be greater than zero.");
                }
                _initialVolume = value;
            }
        }

        //will rewrite when Conversion Tool finished
        //need to add new instance to call Conversion Tool methods for DiluentVolume
        //initialVolume is being set as finalConcentration. May need to get rid of the finalVolumne all together and have user input it in the beginning.

        public double FinalVolume
        {
            get {
                var part1 = _initialConcentration * _initialVolume;
                var part2 = part1 / _finalConcentration;
                result part2;

                return (_initialConcentration * _initialVolume) / _finalConcentration; }
            //(1 * 100) / .8

        }

        public double DiluentVolume
        {
            get { return Math.Abs(FinalVolume - _initialVolume); }
            //125-100=25mL
        }
    }
}



