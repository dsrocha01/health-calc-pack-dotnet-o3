using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet_pack.Interfaces
{
    public interface IIMC
    {
        double Calcular(double Height, double Weight);
        string GetGategoriaIMC(double IMC);
        bool EhDadoValido(double Height, double Weight);
    }
}
