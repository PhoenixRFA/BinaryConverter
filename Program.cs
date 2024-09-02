// See https://aka.ms/new-console-template for more information


using System.Text;

void ToString()
{

    Console.WriteLine("Enter bits:");
    string res = "";

    while (true)
    {
        string inp = Console.ReadLine();
        if(string.IsNullOrEmpty(inp)) break;

        string[] parts = inp.Split(' ');

        for(int i=0; i<parts.Length; i++)
        {
            byte b = Convert.ToByte(parts[i], 2);
            char c = Convert.ToChar(b);
            res += c;
        }
    }

    Console.WriteLine("result:");
    Console.WriteLine(res);

}

void ToBits()
{
    Console.WriteLine("Enter string:");
    string inp = Console.ReadLine();

    if (string.IsNullOrEmpty(inp))
    {
        return;
    }
    
    string res = "";
    var bytes = Encoding.ASCII.GetBytes(inp);
    for(int i = 0; i < bytes.Length; i++)
    {
        res += (i > 0 ? (i > 0 && i % 2 == 0 ? "\n" : " ") : "") + Convert.ToString(bytes[i], 2).PadLeft(8, '0');
    }

    Console.WriteLine("result:");
    Console.WriteLine(res);
}

ToBits();
ToString();
Console.ReadLine();