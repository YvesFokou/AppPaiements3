internal class Program
{
    internal class Paiement
    {
        
        public double Montant { get; set; }
        public string Description { get; set; }


      
        public Paiement(double montant, string description)
        {
            Montant = montant;
            Description = description;

        }

       
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"le Montant est :{Montant},et la Description est:{Description}");
        }



    }
}