using FinalProject_SimpleDilutionCalculator;
using Xunit;

namespace FinalProject_SimpleDilutionCalculator
{
    public class ConversionToolTest
    {
        [Theory]
        [InlineData(1000, "ug/uL", 1)]
        [InlineData(1, "ug/mL", 1)]
        [InlineData(1000, "ng/uL", 1)]
        [InlineData(0.001, "ng/L", 1)]
        [InlineData(1000, "mg/uL", 1)]
        [InlineData(1, "mg/mL", 1)]
        [InlineData(0.001, "mg/L", 1)]
        [InlineData(1, "g/mL", 1000)]
        [InlineData(1, "g/L", 1)]
        [InlineData(1, "mL", 1000)]
        [InlineData(0.001, "L", 1)]
        [InlineData(0.001, "uL", 1)]
        public void ConvertToMgPerMlTest(double value, string fromUnit, double expectedOutput)
        {
            ConversionTool tool = new ConversionTool();
            double result = tool.ConvertToMgPerMl(value, fromUnit);

            Assert.Equal(expectedOutput, result);
        }
    }
}
