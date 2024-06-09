using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite o seu peso (em kg):");
            double peso;
            if (!double.TryParse(Console.ReadLine(), out peso))
            {
                Console.WriteLine("Peso inválido.");
                return;
            }

            Console.WriteLine("Por favor, digite a sua altura (em metros):");
            double altura;
            if (!double.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("Altura inválida.");
                return;
            }

            double imc = peso / (altura * altura);

            string categoria;
            if (imc < 18.5)
            {
                categoria = "Abaixo do peso";
            }
            else if (imc < 24.9)
            {
                categoria = "Peso normal";
            }
            else if (imc < 29.9)
            {
                categoria = "Sobrepeso";
            }
            else if (imc < 34.9)
            {
                categoria = "Obesidade grau I";
            }
            else if (imc < 39.9)
            {
                categoria = "Obesidade grau II";
            }
            else
            {
                categoria = "Obesidade grau III";
            }

            Console.WriteLine($"Seu IMC é: {imc:F2}");
            Console.WriteLine($"Categoria: {categoria}");
        }
    }









