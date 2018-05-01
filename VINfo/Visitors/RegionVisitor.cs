using VINfo.Interfaces;

namespace VINfo.Visitors
{
    internal class RegionVisitor : IRegionVisitor
    {
        public void Visit(VINData vinData)
        {
            switch (vinData.OriginalVIN[0])
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                    vinData.Region = Region.Africa;
                    //new AfricaVisitor().Visit(vinData);
                    break;

                case 'J':
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'P':
                    vinData.Region = Region.Asia;
                    break;

                case 'S':
                case 'T':
                case 'U':
                case 'V':
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    vinData.Region = Region.Europe;
                    break;

                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    vinData.Region = Region.NorthAmerica;
                    break;

                case '6':
                case '7':
                    vinData.Region = Region.Oceania;
                    break;

                case '8':
                case '9':
                case '0':
                    vinData.Region = Region.SouthAmerica;
                    break;

                default:
                    vinData.Region = Region.Unknown;
                    break;
            }
        }
    }
}
