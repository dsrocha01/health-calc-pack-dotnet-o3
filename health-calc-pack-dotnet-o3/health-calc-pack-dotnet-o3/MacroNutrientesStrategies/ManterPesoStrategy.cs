using System;
using health_calc_pack_dotnet_pack.Interfaces;
using health_calc_pack_dotnet_pack.Models;

namespace health_calc_pack_dotnet_pack.MacroNutrientesStrategies
{
    public class ManterPesoStrategy : IMacroNutrientesStrategy
    {
        public MacroNutrientesModel CalcularMacroNutrientes(double peso)
        {
           return new MacroNutrientesModel(carboidratos: 4.0 * peso, proteinas: 4.0 * peso, gorduras: 2.0 * peso);
        }
    }
}

