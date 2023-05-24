using health_calc_pack_dotnet_pack.Interfaces;

namespace health_calc_pack_dotnet_pack
{
    public class IMC : IIMC
    {

        private const double ALTURA_MAXIMA_PERMITIDA = 3.0;
        private const double PESO_MAXIMO_PERMITIDO = 300.0;

        public double Calcular(double altura, double peso)
        {
            double resultado = peso / (altura * altura);
            return Math.Round(resultado, 2);
        }

        /*
         IMC	                CLASSIFICAÇÃO	    OBESIDADE (GRAU)
         MENOR QUE 18,5	        MAGREZA	            0
         ENTRE 18,5 E 24,9	    NORMAL	            0
         ENTRE 25,0 E 29,9	    SOBREPESO	        I
         ENTRE 30,0 E 39,9	    OBESIDADE	        II
         MAIOR QUE 40,0	        OBESIDADE GRAVE	    III
         */

        public string GetGategoriaIMC(double IMC)
        {
            if (IMC < 18.5)
                return IMCConstants.MAGREZA;
            else if (IMC < 25)
                return IMCConstants.NORMAL;
            else if (IMC < 30)
                return IMCConstants.SOBREPESO;
            else if (IMC < 40)
                return IMCConstants.OBESIDADE;
            else
                return IMCConstants.OBESIDADE_GRAVE;
        }

        public bool EhDadoValido(double Height, double Weight)
        {
            return (Height < 3.0 && Weight <= 300);
        }
    }
}