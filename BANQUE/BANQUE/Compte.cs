using System;

namespace BANQUE
{
    public class Compte
    {
        private int ID;
        private string name;
        private double sold;
        private double maxOverdraft;

        public Compte()
        {
            this.ID = 0;
            this.name = "Admin";
            this.sold = 0;
            this.maxOverdraft = 0;
        }

        public Compte(int id, string name, double sold, double overdraft)
        {
            ID = id;
            this.name = name;
            this.sold = sold;
            maxOverdraft = overdraft;
        }

        public bool debiter(double montant)
        {
            return true;
        }

        public void crediter(double montant)
        {
            this.sold = montant;
        }

        public bool transferer(double montant, Compte Target)
        {
            if (this.sold > montant)
            {
                this.sold -= montant;
                Target.sold += montant;
                return true;
            }
            else return false;
        }

        public bool betterThan(double montant)
        {
            return true;
        }

        public int accountId
        {
            get { return ID; }
        }

        public string accountName
        {
            get { return name; }
        }

        public double accountSold
        {
            get { return sold; }
        }
        public double accountOverdraft
        {
            get { return maxOverdraft; }
        }
    }
}