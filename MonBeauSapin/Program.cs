
using System.ComponentModel.Design;

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Veuillez entrer la hauteur de notre super sapin de Noël s'il-vous-plaît (entre 1 et 30) : ");
int saisieHauteur = int.Parse(Console.ReadLine());

void DessinerFeuilles()
{

    if (saisieHauteur > 0 && saisieHauteur <= 30)
    {
        for (int i = 0; i < saisieHauteur; i++)
        {
            for (int j = 0; j >= saisieHauteur - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");
            Console.SetCursorPosition((Console.WindowWidth - (2 * i + 1) / 2), Console.CursorTop);
            Console.ResetColor();
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Vous devez entrer une hauteur entre 1 et 30");
        Console.ResetColor();
    }
    
}


//while (hauteurSapin > 0 && hauteurSapin <= 30)
//{
//    hauteurSapin++;
//}

//Console.ForegroundColor = ConsoleColor.Red;
//for (int i = 0; i <= 30; ++i) {
//    Console.WriteLine("Merci");
//    }

//void DessinerFeuilles()



