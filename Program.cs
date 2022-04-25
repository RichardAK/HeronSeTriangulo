double lado1, lado2, lado3;
double semip, area;
string tipotriangulo;

Console.WriteLine("Digite os lados do triangulo desejado\n");

Console.Write("lado 1:");
lado1 = Convert.ToDouble(Console.ReadLine());

Console.Write("lado 2:");
lado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("lado 3:");
lado3 = Convert.ToDouble(Console.ReadLine());

if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
{
    Console.WriteLine("Todos os numeros precisam ser maiores que 0");
}

else
{
    if (lado1 < (lado2 + lado3) &&
        lado1 > Math.Abs(lado2 - lado3) &&
        lado2 < (lado1 + lado3) &&
        lado2 > Math.Abs(lado1 - lado3) &&
        lado3 < (lado1 + lado2) &&
        lado3 > Math.Abs(lado1 - lado2)) 
  {

    if(lado1==lado2 && lado2==lado3 )
    {
        tipotriangulo = "Equilátero";
    }   

    else if(lado1 != lado2 && lado1 != lado3 && lado2 != lado3 )
    {
        tipotriangulo = "Escaleno";
    }

    else
    {
        tipotriangulo = "Isósceles";
    }
  
   Console.WriteLine($"Tipo de Triângulo {tipotriangulo}"); 

    semip = (lado1+lado2+lado3)/2;
    area = Math.Sqrt(semip * (semip-lado1) * (semip-lado2) * (semip-lado3));

    Console.WriteLine($" Semiperímetro {semip} ");
    Console.WriteLine($"Área {area}");
  }

else
{
    Console.WriteLine("Estes lados não formam um triângulo");
}

}