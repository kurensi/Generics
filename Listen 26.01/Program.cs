/*
List<int> listeI= new List<int>() {10,1,9,2,8,3,7,4,6,5};
<double> listeD = new List<double>() { 2.4, 3.5, 7.2, 4.4, -5.7 };
List<string> listes = new List<string> {"Batman","Messi","Ironman","HoiBärly"};
Console.Write($"Double: ");
SortListeGeneric(listeD);
PrintListGeneric(listeD);
Console.Write($"\nInt: ");
SortListeGeneric(listeI);
PrintListGeneric(listeI);
Console.Write($"\nStrings : ");
SortListeGeneric(listes);
PrintListGeneric(listes);
Console.WriteLine($"Drücken sie eine Taste zum fortfahren.....");
Console.ReadLine();

static void PrintList(List<double> liste)
{
	foreach (var i in liste)
	{
		Console.Write(i+"\t");
	}
}
static void SortListe(List<double> liste)
{
	liste.Sort();

}


int x = 7, y = -1;
double k= 5.3, l = 7.1;
string s1 = "Batman", s2 = "Ironan";
Console.WriteLine($"T1= {k} T2= {l}");

SwapGeneric<double>(ref k, ref l);
Console.WriteLine($"T1= {k} T2= {l}");

static void PrintListGeneric<T>(List<T> liste)
{
	foreach(T x in liste)
	{
		Console.Write(x+" ");
	}
}
static void SortListeGeneric<T>(List<T> liste)
{
	liste.Sort();
}
static void SwapGeneric<T>(ref T t1, ref T t2)
{
	(t2, t1) = (t1, t2);
	Console.WriteLine($"T1= {t1} T2= {t2}");
}

// Erstellen sie ein ein 2d int array mit 4 spalten  3 zeilen // durchschnitt ungerade gerade, gerade zahl plus 10

int[,] array = { {4,6,7,9},{7,10,11,3},{12,1,5,19 } };

double d = 0;
int max = array[0,0], min= array[0,0], g=0, ug=0;

for (int i = 0; i < array.GetLength(0); i++)
{
	for (int j = 0; j < array.GetLength(1); j++)
	{
		if (array[i, j]>max)
		{
			max = array[i, j];
		}
        if (array[i, j] < max)
        {
            max = array[i, j];
        }
		d+=array[i, j];
		if(array[i, j] % 2 != 0)
		{
			ug++;
		}
		if (array[i, j] % 2 != 0)
		{
			ug++;
		}
		else
			g++;
        if (array[i, j] % 2 != 1)
        {
			array[i, j] += 10;
        }
		Console.Write(array[i,j]+"\t");
    }
	Console.WriteLine();
}
Console.WriteLine($"Max = {max} Min= {min} Durchschnitt = {d / (array.GetLength(0)*array.GetLength(1))}");
Console.WriteLine($"ungerade: {ug} Gerade: {g}");
*/
// static methode mit menu  zahl verlange 1 - 3 1 du bist erst 2 du bist 2 er 3 du bist letzter
int b = 0;
Wähle(ref b);
ausgabe(b);

static void Wähle(ref int x)
{
	while (true) {
		try
		{
			Console.Write($"Geben sie eine Zahl zwischen 1 und 3 ein: ");
			x = Convert.ToInt32(Console.ReadLine());
			if (x<=3 && x>=1)
			{
                break;
            }

			
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
static void ausgabe(int b)
{
	switch (b)
	{
		case 1: Console.WriteLine($"Sie sind erster");
			break;
        case 2:
            Console.WriteLine($"Sie sind zweiter");
            break;
        case 3:
            Console.WriteLine($"Sie sind dritter");
            break;
    }
}