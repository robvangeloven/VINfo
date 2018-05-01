using VINfo.Interfaces;

namespace VINfo.Visitors
{
    internal class ValidationVisitor : IValidationVisitor
    {
        private static int Transliterate(char c)
        {
            return "0123456789.ABCDEFGH..JKLMN.P.R..STUVWXYZ".IndexOf(c) % 10;
        }

        private static char GetCheckDigit(string vin)
        {
            string map = "0123456789X";
            int[] weights = { 8, 7, 6, 5, 4, 3, 2, 10, 0, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum = 0;

            for (int i = 0; i < 17; ++i)
            {
                sum += Transliterate(vin[i]) * weights[i];
            }

            return map[sum % 11];
        }

        private static bool IsValid(string vin)
        {
            if (vin?.Length != 17) return false;

            return GetCheckDigit(vin) == vin[8];
        }

        public void Visit(VINData vinData)
        {
            //if (!IsValid(vin)) throw new ArgumentException($"VIN '{vin}' is not a valid VIN", nameof(vin));

            vinData.HasValidCheckDigit = IsValid(vinData.OriginalVIN);

            //if (vinData.IsValidVin) new RegionVisitor().Visit();

        }

        public void Visit(string vin)
        {
            throw new System.NotImplementedException();
        }
    }
}
