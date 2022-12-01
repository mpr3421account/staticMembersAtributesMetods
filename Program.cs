/*Fazer um programa para ler um valor numérico qualquer, e daí mostrar
quanto seria o valor de uma circunferência e do volume de uma esfera
para um raio daquele valor. Informar também o valor de PI com duas
casas decimais.*/


/*Versão 1: métodos na própria classe do programa
• Nota: dentro de um método estático você não pode chamar membros de
instância da mesma classe.*/

using staticMembersAtributesMetods;
using System.Globalization;

Calculadora calc = new Calculadora();


Console.Write("Entre com o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = calc.Circunferencia(raio);
double volume = calc.Volume(raio);

Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
