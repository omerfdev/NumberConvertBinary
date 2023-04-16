int enternumber = int.Parse(Console.ReadLine());
double ascii=0;
int i = 0;

while (enternumber >= 2)
{
    ascii = ascii + (enternumber % 2) * (Math.Pow(10,i));
    enternumber = enternumber / 2;
    i++;
}
ascii=ascii+(enternumber* Math.Pow(10, i));   
Console.WriteLine(ascii);
Console.ReadLine();
