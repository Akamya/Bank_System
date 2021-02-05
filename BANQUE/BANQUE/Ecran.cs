using System;
using System.Collections.Generic;

namespace BANQUE
{
	public class Ecran
	{
		public static List<Compte> cpt = new List<Compte>();	
		public Ecran()
		{
		}
		
		public static void mainMenu() 
		{
			while (true)
			{
				Console.WriteLine("1 - Créer un compte\n2 - Affichage des infos d'un compte\n3 - Afficher la liste des comptes\nQ - Quitter");
				string choice = Console.ReadLine().ToUpper();
				Console.Write("\n");
				if (choice == "1")
				{
					createAccount();
				} 
				else if (choice == "2")
                {
					affichageInfo();
				}
				else if (choice == "3")
				{
					for (int i = 0; i < cpt.Count; i++)
					{
						Console.WriteLine("Nom: {0}",cpt[i].accountName);
					}
				}
				else if(choice == "Q")
                {
					break;
                }
			}
		}

		public static void createAccount()
        {
			Console.WriteLine("Entrer le nom du compte: ");
			string name = Console.ReadLine();
			Console.WriteLine("Entrer le solde: ");
			double sold = Double.Parse(Console.ReadLine());
			cpt.Add(new Compte(0000, name, sold, 500));
		}

		public static void affichageInfo()
		{
			Console.WriteLine("Nom du compte: ");
			string name = Console.ReadLine();
			for (int i = 0; i < cpt.Count; i++)
			{
				if (cpt[i].accountName == name)
				{
					Console.WriteLine("ID: {0} \nNom: {1} \nSolde: {2} \nDécouvert autorisé: {3}\n",
											cpt[i].accountId, cpt[i].accountName, cpt[i].accountSold, cpt[i].accountOverdraft);
				}
				Console.ReadLine();
			}
		}
	}
}