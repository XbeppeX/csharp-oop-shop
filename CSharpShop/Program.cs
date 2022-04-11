
using CSharpShop;



Prodotto Mioprodotto = new Prodotto("banane", "Provenienza Africa", 210, 22);

int codice= Mioprodotto.getCodice();
Console.WriteLine("Il codice prodotto è: " + codice);

Mioprodotto.StampaCalcoloPrezzoConIva();

Mioprodotto.StampaPrezzoConIva();

Mioprodotto.StampaPrezzoSenzaIva();

Console.WriteLine("");

Mioprodotto.StampaProdotto();



