using System;
using health_calc_pack_dotnet_pack.Enums;
using health_calc_pack_dotnet_pack.Interfaces;
using health_calc_pack_dotnet_pack.Models;

namespace health_calc_pack_dotnet_pack;

public class MacroNutrientesConext
{
    private IMacroNutrientesStrategy? strategy { get; set; }

    public void SetStrategy(IMacroNutrientesStrategy macroNutrientesStrategy)
    {
        strategy = macroNutrientesStrategy;
    }

    public MacroNutrientesModel? ExecuteStratery(double peso)
    {
        return strategy?.CalcularMacroNutrientes(peso) ?? null;
    }
}

