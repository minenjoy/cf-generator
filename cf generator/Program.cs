// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
string nome = "";
    string cfnome = "";
string cognome = "";
string cfcognome = "";
int giorno = 0;
int mese = 0;
int anno = 0;
string sesso = "";
string comune = "";
int err = 0;
do
{
	if (err == 1)
	{
		Console.WriteLine("c'è stato un errore, riprova");
	}
Console.WriteLine("qual'è il tuo nome?");
	try
	{
nome=Console.ReadLine();

	}
	catch (Exception)
	{
		Console.WriteLine("c'è stato un errore, riprova");

	}
	err = 1;
} while (nome == ""||(nome.Contains("!")|| nome.Contains("=") || nome.Contains("|") || nome.Contains("£") || nome.Contains("$") || nome.Contains("%") || nome.Contains("&") || nome.Contains("/") || nome.Contains("(") || nome.Contains(")") || nome.Contains("'") || nome.Contains("?") || nome.Contains("^") || nome.Contains("1") || nome.Contains("2") || nome.Contains("3") || nome.Contains("4") || nome.Contains("5") || nome.Contains("6") || nome.Contains("7") || nome.Contains("8") || nome.Contains("9") || nome.Contains("0") || nome.Contains("#") || nome.Contains("@") || nome.Contains("*") || nome.Contains("+") || nome.Contains("}") || nome.Contains("]") || nome.Contains("[") || nome.Contains("{") || nome.Contains(",") || nome.Contains(";") || nome.Contains(".") || nome.Contains(":") || nome.Contains("-") || nome.Contains("_") || nome.Contains("€")));

err = 0;
nome = nome.ToUpper();
string[] arrnome= new string[nome.Length];
string[] consnome = new string[nome.Length];
int count = 0;
int countvoc = 0;

for (int i = 0; i < nome.Length; i++)
{
	arrnome[i]=nome.Substring(i,1);
	if (arrnome[i]!="A"&& arrnome[i] != "E" && arrnome[i] != "I" && arrnome[i] != "O" && arrnome[i] != "U" && arrnome[i] != " " && arrnome[i] != "'")
	{
		consnome[count] = arrnome[i];
        //Console.WriteLine(consnome[count]);
		count=count+1;
    }
}
	Array.Resize(ref consnome,count);
Console.WriteLine(consnome.Length);
if (consnome.Length >= 4) {
	cfnome = consnome[0] + consnome[2] + consnome[3];
    Console.WriteLine(cfnome);
} else if (consnome.Length == 3) {
    cfnome = consnome[0] + consnome[1] + consnome[2];
    Console.WriteLine(cfnome);
}
else
{
	for (int i = 0; i < consnome.Length; i++)
	{
		cfnome += consnome[i];
		countvoc=countvoc+1;

	}
	
		for (int i = 0; i < arrnome.Length; i++)
		{
			if (arrnome[i] == "A" || arrnome[i] == "E" || arrnome[i] == "I" || arrnome[i] == "O" || arrnome[i] == "U") {
				cfnome += arrnome[i];
				countvoc=countvoc+1;

            }
		if (countvoc==3)
		{
			break;
		}
	}
	
    Console.WriteLine(cfnome);
}



do
{
    if (err == 1)
    {
        Console.WriteLine("c'è stato un errore, riprova");
    }

    Console.WriteLine("qual'è il tuo cognome?");

try
{
    cognome = Console.ReadLine();

}
catch (Exception)
{
    Console.WriteLine("c'è stato un errore, riprova");

}
err = 1;
} while (cognome == "" || (cognome.Contains("!") || cognome.Contains("=") || cognome.Contains("|") || cognome.Contains("£") || cognome.Contains("$") || cognome.Contains("%") || cognome.Contains("&") || cognome.Contains("/") || cognome.Contains("(") || cognome.Contains(")") || cognome.Contains("'") || cognome.Contains("?") || cognome.Contains("^") || cognome.Contains("1") || cognome.Contains("2") || cognome.Contains("3") || cognome.Contains("4") || cognome.Contains("5") || cognome.Contains("6") || cognome.Contains("7") || cognome.Contains("8") || cognome.Contains("9") || cognome.Contains("0") || cognome.Contains("#") || cognome.Contains("@") || cognome.Contains("*") || cognome.Contains("+") || cognome.Contains("}") || cognome.Contains("]") || cognome.Contains("[") || cognome.Contains("{") || cognome.Contains(",") || cognome.Contains(";") || cognome.Contains(".") || cognome.Contains(":") || cognome.Contains("-") || cognome.Contains("_") || cognome.Contains("€"))) ;

err = 0;
cognome = cognome.ToUpper();
string[] arrcogn = new string[cognome.Length];
string[] conscogn = new string[cognome.Length];
count = 0;
countvoc = 0;

for (int i = 0; i < cognome.Length; i++)
{
    arrcogn[i] = cognome.Substring(i, 1);
    if (arrcogn[i] != "A" && arrcogn[i] != "E" && arrcogn[i] != "I" && arrcogn[i] != "O" && arrcogn[i] != "U" && arrcogn[i] != " " && arrcogn[i] != "'")
    {
        conscogn[count] = arrcogn[i];
        //Console.WriteLine(consnome[count]);
        count = count + 1;
    }
}
Array.Resize(ref conscogn, count);
Console.WriteLine(conscogn.Length);
if (conscogn.Length >= 3)
{
    cfcognome = conscogn[0] + conscogn[1] + conscogn[2];
    Console.WriteLine(cfcognome);
}
else
{
    for (int i = 0; i < conscogn.Length; i++)
    {
        cfcognome += conscogn[i];
        countvoc = countvoc + 1;

    }

    for (int i = 0; i < arrcogn.Length; i++)
    {
        if (arrcogn[i] == "A" || arrcogn[i] == "E" || arrcogn[i] == "I" || arrcogn[i] == "O" || arrcogn[i] == "U")
        {
            cfcognome += arrcogn[i];
            countvoc = countvoc + 1;

        }
        if (countvoc == 3)
        {
            break;
        }
    }

    Console.WriteLine(cfcognome);
}




Console.WriteLine("qual'è il tuo sesso?");
sesso = Console.ReadLine();

Console.WriteLine("qual'è il tuo anno di nascita?");
anno = Int32.Parse(Console.ReadLine());

Console.WriteLine("qual'è il tuo mese di nascita?");
mese = Int32.Parse(Console.ReadLine());

Console.WriteLine("qual'è il tuo giorno di nascita?");
giorno = Int32.Parse(Console.ReadLine());

Console.WriteLine("qual'è il tuo comune di nascita?");
comune = Console.ReadLine();


