using System;

namespace Etudedecas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"E:\B+5\Utilisation des IDE\Etudedecas\Etudedecas\client.txt");

                if (lines.Length != 0)
                {
                    foreach (string line in lines)
                    {
                       
                            string[] mots = line.Split(";");

                        if (mots.Length == 4)
                        {
                            string id = null;
                            string name = null;
                            string firstname = null;
                            string address = null;

                            id = mots[0];
                            name = mots[1];
                            firstname = mots[2];
                            address = mots[3];



                            ajoutClient(id, name, firstname, address);
                        }
                        else {
                            System.Console.WriteLine("Un champ n'est pas renseigné, veuillez séparer chaque élément par un ;");
                        }
                       
                    }
                }
                else
                {
                    System.Console.WriteLine("Fichier texte null ");
                }

            }
            catch (System.IO.FileNotFoundException e)
            {
                System.Console.WriteLine("Le fichier client.txt n'héxiste pas");
            }


        }

        private static void ajoutClient(string id ,string name, string firstame , string address)
        {

            Client client = new Client();
            client.Id = id;
            client.Name = name;
            client.FirstName = firstame;
            client.Adresse = address;

            // Création de l'objet Bdd pour l'intéraction avec la base de donnée MySQL
            Bdd bdd = new Bdd();
            bdd.AddContact(client);
        }
    }
}
