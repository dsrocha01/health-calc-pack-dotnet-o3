﻿using health_calc_pack_dotnet_pack;
using health_calc_pack_dotnet_pack.Interfaces;
using health_calc_pack_dotnet_pack.MacroNutrientesStrategies;
using health_calc_pack_dotnet_pack.Models;

// -------- GANHAR MASSA MUSCULAR
double altura = 1.71;
double peso = 95;
IIMC imc = new IMC();

MacroNutrientesConext strategy = new();
strategy.SetStrategy(new GanharMassaMuscularStrategy());
MacroNutrientesModel resultado = strategy.ExecuteStratery(peso)!;
string complemento = "ganho de massa muscular";

string texto = $@"Para uma dieta de {complemento}, consuma:
{resultado.Carboidratos}g kilo de carboidratos, {resultado.Proteinas}g kilo de proteínas e {resultado.Gorduras}g kilo de gorduras.";


Console.WriteLine(texto);
// -------- PERDER PESO
strategy.SetStrategy(new PerderPesoStrategy());
resultado = strategy.ExecuteStratery(88.8)!;
complemento = "perda de peso";
texto = $@"Para uma dieta de {complemento}, consuma:
{resultado.Carboidratos}g kilo de carboidratos, {resultado.Proteinas}g kilo de proteínas e {resultado.Gorduras}g kilo de gorduras.";
Console.WriteLine(texto);

// -------- MANTER PESO
strategy.SetStrategy(new ManterPesoStrategy());
resultado = strategy.ExecuteStratery(88.8)!;
complemento = "manter peso";
texto = $@"Para uma dieta de {complemento}, consuma:
{resultado.Carboidratos}g kilo de carboidratos, {resultado.Proteinas}g kilo de proteínas e {resultado.Gorduras}g kilo de gorduras.";
Console.WriteLine(texto);


Console.WriteLine($"\nSeu IMC atual é: {imc.Calcular(altura, peso)} e atualmente a categoria é {imc.GetGategoriaIMC(imc.Calcular(altura, peso))}");

Console.ReadKey();