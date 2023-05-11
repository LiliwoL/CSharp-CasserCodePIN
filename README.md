# Casser un code PIN par force brute

> Pré requis : Visual Studio code doit être installé sur la machine.

# Sommaire

v 0.1

# Attendu

- Rapport de TP en répondant aux questions posées
- Dépôt GitHub contenant les sources de votre programme

# Travail à faire

- Démarrer Visual Studio Code.

- Créer une nouvelle solution : menu Fichier / Nouveau / Solution 
    Catégorie Windows Applications          Modèle Console Application 
    Nom : CasserCodePIN 
    Emplacement : votre dossier de travail, par ex. Documents \ TP cyber sécurité \ TP 10

- Copier le code suivant qui calcule le temps d’exécution d’un programme :

```csharp
namespace CasserCodePIN
{
    class Program
    {
        public static void Main(string[] args)
        {
            // start représente l'heure de démarrage du programme					
            DateTime start = DateTime.Now;

            Console.WriteLine("Début du programme");
            Console.WriteLine("Fin du programme");

            // durée du programme = heure de fin - heure de démarrage
            TimeSpan duree = DateTime.Now - start;
            Console.WriteLine("durée du programme : " + duree);


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
```

- Lancez le programme

- Quelle est la durée de ce programme en secondes ?


- En millisecondes (ms) ?

- Générez un code PIN à 4 chiffres aléatoire en ajoutant le code suivant :

```csharp
...
Console.WriteLine("Début du programme");
            
// Générateur de nombre aléatoire
Random rnd = new Random();
// code secret compris entre 0 et 9999
int codeSecret = rnd.Next(9999);

Console.WriteLine("Fin du programme");
...
```

- Ecrivez le programme qui va essayer de trouver ce nombre par force brute, au moyen d’une boucle **while**

```csharp
// start représente l'heure de démarrage du programme                    
DateTime start = DateTime.Now;
            
Console.WriteLine("Début du programme");
            
Random rnd = new Random();
int codeSecret = rnd.Next(9999);

// booléen qui indique si on a trouvé le code secret            
bool trouve = false;
// compteur de boucle
int i = 0;
while(i < 10000 && trouve == false)
{
    Console.Write(i + " ");
                    
    // si on trouve le code PIN, il faut afficher i et interrompre la boucle 
    // A COMPLETER...

    i++;
}
            
Console.WriteLine("Fin du programme");
// durée du programme = heure de fin - heure de démarrage
TimeSpan duree = DateTime.Now - start;
Console.WriteLine("durée du programme : " + duree);
Console.Write("Press any key to continue . . . ");
Console.ReadKey(true);
```

- Résultat (fournissez une impression ecran)

- Quelle est la durée du programme en secondes ?

- Afin de ralentir les attaquants, le système attaqué a une **temporisation**, c’est-à-dire qu’à chaque comparaison infructueuse, le programme attend un certain temps.

> Travail à faire :
ajoutez en haut du programme :

```csharp
using System;
using System.Threading;

...
```


Ajoutez une temporisation de 5 millisecondes (ms) dans la boucle while :

```csharp
Thread.Sleep(5);
```

- Relancez le programme. Quelle est sa durée ?


- Mettez maintenant une temporisation de 1 seconde (= 1 000 ms).
Lancez le programme : quel est l’effet sur l’attaquant ?