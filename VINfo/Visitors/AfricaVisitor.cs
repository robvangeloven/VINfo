using VINfo.Resources;

namespace VINfo.Visitors
{
    internal class AfricaVisitor
    {
        //    private static int Transliterate(char c)
        //    {
        //        return "ABCDEFGH.JKLMN.P.RSTUVWXYZ1234567890".IndexOf(c);
        //    }

        public static void Visit(VINData vinData)
        {
            switch (vinData.OriginalVIN[0])
            {
                case 'A':
                    vinData.Region = Region.Africa;

                    if ('A' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'H')
                    {
                        vinData.Country = Countries.SouthAfrica;
                        break;
                    }


                    if ('I' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'N')
                    {
                        vinData.Country = Countries.IvoryCoast;
                        break;
                    }
                    break;

                case 'B':
                    vinData.Region = Region.Africa;

                    if ('A' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'E')
                    {
                        vinData.Country = Countries.Angola;
                        break;
                    }

                    if ('F' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'K')
                    {
                        vinData.Country = Countries.Kenya;
                    }

                    if ('L' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'R')
                    {
                        vinData.Country = Countries.Tanzania;
                    }
                    break;

                case 'C':
                    vinData.Region = Region.Africa;

                    if ('A' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'E')
                    {
                        vinData.Country = Countries.Benin;
                        break;
                    }

                    if ('F' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'K')
                    {
                        vinData.Country = Countries.Madagascar;
                    }

                    if ('L' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'R')
                    {
                        vinData.Country = Countries.Tunisia;
                    }
                    break;

                case 'D':
                    vinData.Region = Region.Africa;

                    if ('A' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'E')
                    {
                        vinData.Country = Countries.Egypt;
                        break;
                    }

                    if ('F' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'K')
                    {
                        vinData.Country = Countries.Morocco;
                    }

                    if ('L' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'R')
                    {
                        vinData.Country = Countries.Zambia;
                    }
                    break;

                case 'E':
                    vinData.Region = Region.Africa;

                    if ('A' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'E')
                    {
                        vinData.Country = Countries.Ethiopia;
                        break;
                    }

                    if ('F' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'K')
                    {
                        vinData.Country = Countries.Mozambique;
                    }
                    break;

                case 'F':
                    vinData.Region = Region.Africa;

                    if ('A' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'E')
                    {
                        vinData.Country = Countries.Ghana;
                        break;
                    }

                    if ('F' <= vinData.OriginalVIN[1] && vinData.OriginalVIN[1] <= 'K')
                    {
                        vinData.Country = Countries.Nigeria;
                    }
                    break;
            }
        }
    }
}