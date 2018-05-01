using System.Collections.Generic;
using VINfo;
using Xunit;

namespace UnitTests
{
    public class VINTests
    {
        public static IEnumerable<object[]> ValidVINS =>
            new List<object[]>
        {
        //        new object[] { "KMHNM83CPYU000001" },
        //        new object[] { "JMZMA18P200411817" },
                new object[] { "KNACC81CGH5021844" },
                new object[] { "1ZVHT82H485113456" },
                new object[] { "11111111111111111" }
        };

        public static IEnumerable<object[]> InvalidVINS =>
            new List<object[]>
        {
                new object[] { null },
                new object[] { "" },
                new object[] { "IZVHT82H485113456" },
                new object[] { "OZVHT82H485113456" },
                new object[] { "QZVHT82H485113456" },
                new object[] { "1ZVHT82H485113456X" },
                new object[] { "1ZVHT82H48511345" }
        };

        [Theory]
        [MemberData(nameof(ValidVINS))]
        public void Valid_VIN_Validates(string vin)
        {
            Assert.True(VINData.IsValid(vin));
        }

        [Theory]
        [MemberData(nameof(InvalidVINS))]
        public void Invalid_VIN_Does_Not_Validate(string vin)
        {
            Assert.False(VINData.IsValid(vin));
        }
    }
}
