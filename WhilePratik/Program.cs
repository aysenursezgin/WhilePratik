/*Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları while kullanarak yapınız.

1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
*/

Console.WriteLine("1 -> Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");

int i = 1;
while (i < 11)
{
    Console.WriteLine(i+ "  Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

Console.WriteLine("1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");

int x = 2;
while (x < 20)
{
    Console.WriteLine(x);
    x++;
}

Console.WriteLine("3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");

int y = 1;
while (y < 20)
{
    if(y%2==0)
    Console.WriteLine(y);
    y++;
}

Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");

int z = 51;
int topZ = 0;
while (z < 150)
{
    topZ = topZ+z;
    z++;
}
Console.WriteLine(topZ);

Console.WriteLine("5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");

int q = 1;
int topCift = 0;
int topTek = 0;

while(q < 120)
{
    if (q % 2 == 0)
    {
        topCift = topCift + q; 
    }

    else
    {
        topTek = topTek + q;
    }
    q++;
}

Console.WriteLine(" 1 ile 120 arasındaki çift sayıların toplamları  "+topCift);
Console.WriteLine(" 1 ile 120 arasındaki tek sayıların toplamları  "+topTek);