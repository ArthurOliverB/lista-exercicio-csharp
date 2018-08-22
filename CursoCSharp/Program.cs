using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Exercicio 1: Celsius Fahrenheit - Fundamentos", CelsiusFahrenheit.Executar},
                {"Exercicio 2: Fahrenheit Celsius - Fundamentos", FahrenheitCelsius.Executar},
                {"Exercicio 3: Calcular IMC - Fundamentos", IMC.Executar},
                {"Exercicio 4: Ao Quadrado e Ao Cubo - Fundamentos", QuadradoCubo.Executar},
                {"Exercicio 5: Calcular Área Triangulo - Fundamentos", AreaTriangulo.Executar},
                {"Exercicio 5: Calcular Equacao de Segundo Grau - Fundamentos", EquacaoSegundoGrau.Executar}, 

                {"Exercicio 5: Calcular Equacao de Segundo Grau - Estruturas de Controle", EquacaoSegundoGrau.Executar}, 
            });

            central.SelecionarEExecutar();
        }
    }
}