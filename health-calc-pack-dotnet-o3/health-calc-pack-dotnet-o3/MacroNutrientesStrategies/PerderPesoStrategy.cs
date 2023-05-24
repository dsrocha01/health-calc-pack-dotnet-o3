using System;
using health_calc_pack_dotnet_pack.Enums;
using health_calc_pack_dotnet_pack.Interfaces;
using health_calc_pack_dotnet_pack.Models;

namespace health_calc_pack_dotnet_pack.MacroNutrientesStrategies;

public class PerderPesoStrategy : IMacroNutrientesStrategy
{
    public MacroNutrientesModel CalcularMacroNutrientes(double peso)
    {
        return new MacroNutrientesModel(carboidratos: 3.0 * peso, proteinas: 4.0 * peso, gorduras: 3.0 * peso);
    }
}

