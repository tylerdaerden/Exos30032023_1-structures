#region Exo_Structure

#region 1.1 Jeu de Cartes

// Définir un tableau d'entier contenant les valeurs comprises entre 1 et 13 inclus
// Définir un tableau de string contenant les valeurs "Coeur" , "Carreau" , "Pique" et "Trefle"
// Définir une structure Carte contenant les 2 variables suivantes public int Valeur ; public string Couleur , 
// Sur base des tableaux Valeurs et Couleurs, définis précédemment, générez le jeu de 52 cartes et leur affecter leur Couleur et leurs valeurs
// Ensuite mélanger le jeu de Carte.
//Enfin afficher chacune des cartes du jeu style " 1 de Coeur" , etc ...


using Exos_Structure;

//D'abord je crée les 2 tableaux pour avoir mes numéros et les 4 couleurs ♠♦
int[] valeurs = new int[13];
for (int i = 0; i < valeurs.Length; i++)
{
    valeurs[i] = i + 1;
}

string[] couleurs = new string[] { "Coeur", "Carreau", "Pique", "Trèfle" };

//Je crée le tableau de 52 Cartes
Cartes[] jeuDeCartes = new Cartes[52];
int icheck = 0;
foreach (int valeur in valeurs)
{
    foreach (string couleur in couleurs)
    {
        jeuDeCartes[icheck].Numéro = valeur; 
        jeuDeCartes[icheck].Couleur = couleur;
        icheck++; 
    }
}
// Vérification de mon paquet 
foreach (Cartes CartesduPaquet in jeuDeCartes)
{
    Console.WriteLine($"{CartesduPaquet.Numéro} de {CartesduPaquet.Couleur}");
}
Console.WriteLine("Paquet Complet et OK !!! ");
//Thread.Sleep(2000); // oui je sais j'abuse des thread , mais j'aime bien sur la console 😎
//Console.Clear();

// Je vais mélanger avec un Random et au final des changements comme pour un remplacement avec les temp 🃏
Random mélange = new Random();
for (int i = 0; i < jeuDeCartes.Length; i++)
{
    int j = mélange.Next(jeuDeCartes.Length);

    do
    {
        Cartes temp = jeuDeCartes[i];
        jeuDeCartes[i] = jeuDeCartes[j];
        jeuDeCartes[j] = temp;
    }

    while (i == j);
}
    Console.WriteLine("Voici les Cartes mélangées");

    foreach (Cartes carte in jeuDeCartes) 
    {
        Console.WriteLine(carte.Numéro + " de " + carte.Couleur);
    }







// Modèle exemple
// Définir un tableau d'entiers contenant les valeurs comprises entre 1 et 13 inclus
//using Exos_Structure;

//int[] valeurs = new int[13];
//        for (int i = 0; i < valeurs.Length; i++)
//        {
//            valeurs[i] = i + 1; // Les valeurs sont stockées dans le tableau en utilisant une boucle for pour aller de 1 à 13 inclus
//        }

// Définir un tableau de string contenant les valeurs "Coeur", "Carreau", "Pique" et "Trèfle"
//string[] couleurs = new string[] { "Coeur", "Carreau", "Pique", "Trèfle" };

//    // Définir une structure Carte contenant les 2 variables suivantes : public int Valeur ; public string Couleur
//    struct Carte
//{
//    public int Valeur;
//    public string Couleur;
//}

// Générer le jeu de 52 cartes et leur affecter leur Couleur et leurs valeurs
//Cartes[] jeuDeCartes = new Cartes[52]; // Le tableau de 52 cartes est créé
//    int index = 0;
//        foreach (int valeur in valeurs) // Parcourez les valeurs
//        {
//            foreach (string couleur in couleurs) // Parcourez les couleurs
//            {
//                jeuDeCartes[index].Numéro = valeur; // Affecter la valeur de la carte
//                jeuDeCartes[index].Couleur = couleur; // Affecter la couleur de la carte
//                index++; // Passer à la carte suivante dans le tableau de cartes
//            }
//        }

//        // Mélanger le jeu de Carte
//        Random random = new Random(); // Créer un objet Random pour générer des nombres aléatoires
//for (int i = 0; i < jeuDeCartes.Length; i++) // Parcourir le tableau de cartes
//{
//    int j = random.Next(i, jeuDeCartes.Length); // Sélectionner un index aléatoire dans le tableau pour échanger avec la carte actuelle
//    Cartes temp = jeuDeCartes[i]; // Stocker temporairement la carte actuelle
//    jeuDeCartes[i] = jeuDeCartes[j]; // Échanger la carte actuelle avec la carte sélectionnée aléatoirement
//    jeuDeCartes[j] = temp; // Remplacer la carte sélectionnée aléatoirement avec la carte temporaire
//}

//// Afficher chacune des cartes du jeu
//foreach (Cartes carte in jeuDeCartes) // Parcourir le tableau de cartes
//{
//    Console.WriteLine(carte.Numéro + " de " + carte.Couleur); // Afficher la valeur et la couleur de la carte




























































#endregion

#endregion