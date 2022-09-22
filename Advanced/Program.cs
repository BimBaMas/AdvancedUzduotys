Console.Write("Iveskite zodi arba sakini : ");
Advanced1(Console.ReadLine());

Console.Write("Iveskite kuri Fibonaci skaiciu norit suzinoti : ");
Console.WriteLine($"Jusu ieskomas skaicius : {Advanced2(0, 1, 1, int.Parse(Console.ReadLine()))}");

Console.Write("Iveskite skaiciu, ir apskaiciuosime jo skaitmenu suma : ");
Console.WriteLine($"Jusu ivesto skaiciaus skaitmenu suma = {Advanced3(int.Parse(Console.ReadLine()), 0)}");

Console.Write("Iveskite kokio skaiciaus faktoriala norite suzinoti : ");
Console.WriteLine($"Sio skaiciaus faktorialas : {Advanced4(1, 1, int.Parse(Console.ReadLine()))}");

void Advanced1(string data)
{
    Console.Write($"Jusu ivestas tesktas '{data}' ");
    data = data.ToLower();
    List<char> chars = new List<char>();
    chars.AddRange(data);
    chars.RemoveAll(x => x == ' ');
    bool result = true;
    for (int i = 0; i < chars.Count; i++)
    {
        if (chars[i] != chars[chars.Count - i - 1])
        {
            result = false;
            break;
        }
    }
    if (result)
    {
        Console.WriteLine("yra palindromas");
    }
    else
    {
        Console.WriteLine("nera palindromas");
    }
}

int Advanced2(int first, int second, int count, int kelintas)
{
    if (count < kelintas)
    {
        return Advanced2(second, first + second, count + 1, kelintas);
    }
    return first;
}

int Advanced3(int data, int sum)
{
    if (data > 0)
    {
        return Advanced3((data - data % 10) / 10, sum + data % 10);
    }
    return sum;
}

int Advanced4(int fact, int count, int number)
{
    if (count <= number)
    {
        return Advanced4(fact * count, count + 1, number);
    }
    return fact;
}