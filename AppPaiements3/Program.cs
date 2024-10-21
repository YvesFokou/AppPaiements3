using AppPaiements3;

internal class Program
{
    private static void Main(string[] args)
    {
        
        CarteCredit paiement1 = new CarteCredit(344.00, "Achat telephone", 46367);
        CarteCredit paiement2 = new CarteCredit(132.00, "Achat ordinateur",7667661);
        CarteCredit paiement3 = new CarteCredit(985.00, "Achat Vetements",88887);

        paiement1.AfficherDetails();
        paiement2.AfficherDetails();
        paiement3.AfficherDetails();
    }
}