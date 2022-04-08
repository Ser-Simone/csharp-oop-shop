using Csharp_Shop;


Prodotto shop = new Prodotto("Pasta", "spaghetti", 1);
Console.WriteLine("------- PRODOTTO 1--------");
shop.StampaProdotto();


Prodotto shop2 = new Prodotto("Marmellata", "marmellata di fichi", 3);
Console.WriteLine("------- PRODOTTO 2--------");
shop2.StampaProdotto();

Prodotto shop3 = new Prodotto("Pizza", "Napoli", 4.50);
Console.WriteLine("------- PRODOTTO 3--------");
shop3.StampaProdotto();