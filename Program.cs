/*Fazer um programa para ler um valor numérico qualquer, e daí mostrar
quanto seria o valor de uma circunferência e do volume de uma esfera
para um raio daquele valor. Informar também o valor de PI com duas
casas decimais.*/


/*Versão 1: métodos na própria classe do programa
• Nota: dentro de um método estático você não pode chamar membros de
instância da mesma classe.*/

using System.Globalization;
double pi = 3.14;

Console.Write("Entre com o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = Circunferencia(raio);
double volume = Volume(raio);

Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor de PI: " + pi);


//Console.WriteLine("Valor de PI: " + );

static double Circunferencia(double r, double pi = 3.14)
{
    return 2.0 * pi * r;
}
static double Volume(double r, double pi = 3.14)
{
    return 4.0 / 3.0 * pi * r * r * r;
}



