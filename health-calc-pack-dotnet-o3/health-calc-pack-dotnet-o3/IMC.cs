using health_calc_pack_dotnet_pack.Interfaces;

namespace health_calc_pack_dotnet_pack
{
    public class IMC : IIMC
    {
        public double Calc(double Height, double Weight)
        {
            return Math.Round(Weight / (Height * Height), 2);
        }

        /*
         IMC	                CLASSIFICAÇÃO	    OBESIDADE (GRAU)
         MENOR QUE 18,5	        MAGREZA	            0
         ENTRE 18,5 E 24,9	    NORMAL	            0
         ENTRE 25,0 E 29,9	    SOBREPESO	        I
         ENTRE 30,0 E 39,9	    OBESIDADE	        II
         MAIOR QUE 40,0	        OBESIDADE GRAVE	    III
         */

        public string GetIMCCategory(double IMC)
        {
            var Result = string.Empty;

            if (IMC < 18.5)
                Result = "MAGREZA";
            else if (IMC >= 18.5 && IMC <= 25)
                Result = "NORMAL";
            else if (IMC >= 18.5 && IMC <= 30)
                Result = "SOBREPESO";
            else if (IMC >= 18.5 && IMC <= 40)
                Result = "OBSIDADE";
            else if (IMC >= 40)
                Result = "OBSIDADE GRAVE";

            return Result;
        }

        public bool IsValidData(double Height, double Weight)
        {
            return (Height < 3.0 && Weight <= 300);
        }
    }
}