# Choosing one or another

Het 'Strategy' pattern is een patroon die zich huisvestigt in de categorie 'Behavioral' of Gedrag. Bij het Strategy pattern kun je eenvoudig switchen van de ene implementatie naar een andere implementatie door het gebruik van een 'interface'. 

Een van de meest voorkomende situaties waarbij het Strategy pattern zijn bij;
- Het maken van een rekenmachine waarbij elke operatie (+, -, * , /) een eigen uitvoering geeft op de input.
- Het sorteren van lijsten (denk aan; QuickSort, MergeSort en andere vormen).
- Andere situatie waarbij een enkele 'strategy' eigenaar is van een algoritme.

Voor deze demo maken we niet gebruik van bovenstaande situatie, maar maken we een webwinkel. Deze webwinkel is een (kleine) nabootsing van de 'Steam Store' (bij gamers niet geheel onbekend). Als je hier een product aanschaft kun je deze betalen met IDeal, PayPal, Visa en nog wat andere veelvoorkomende betaalmethodieken. Daarnaast heb je binnen Steam ook een eigen 'Wallet'. Hier kun je zo nu en dan geld op zetten. Tijdens deze demo maken we alleen de implementatie van de 'Wallet' en het gebruik van PayPal om af te kunnen rekenen. 

Om te beginnen maken we een nieuw .Net Core project, we gaan weer aan de slag met een simpele Console applicatie.

**Let op** - Als je geen VS2015 wilt gebruiken kun je de eerste 4 stappen volgen in '01'.

1: Start VS2015 en ga naar File > New Project > Visual C# en kies hier vervolgens .NET Core > Console Application .NET Core.

2: Geef het project een naam en selecteer een eigen gekozen locatie om het project op te slaan.

3: Je hebt nu een lege console applicatie. Je kunt testen of dit werkt door in 'Program.cs' de volgende code te schrijven in de 'Main' methode;
````Csharp
public static void Main(string[] args)
{
    Console.ReadKey();
}
````

4: Druk nu op F5 om de applicatie te starten en je ziet een Console venster draaien. Door een willekeurige toets wordt deze weer afgesloten.

**Note** bovenstaand is inderdaad gekopieerd uit '02'. 

Oke nu we weer een standaard .Net applicatie hebben staan kunnen we beginnen met het maken van de classes. Om alvast een start te maken kun je de map 'Interfaces' en 'Models' alvast maken.

5: Maak in de map 'Models' een class met de naam 'Product'. Maak deze abstract en laat deze een 'Price' van het type 'int' retourneren. Zorg ervoor dat het 'Price' veld (of property) protected is en de methode om hem te benaderen publiek.
````csharp
public abstract class Product
{
    protected int Price { get; set; }

    public int GetPrice()
    {
        return Price;
    }
}
````
6: Maak vervolgens 3 nieuwe 'Product' classes. Dit zijn 'Game', 'Poster' en 'Sticker'. Zorg ervoor dat deze zijn afgeleid van 'Product' en dat de prijs wordt gezet in de constructor. Hier een klein voorbeeld van de 'Game' class.
````csharp
public class Game : Product
{
    public Game(int price)
    {
        this.Price = price;
    }
}
````
7: Nu we de producten hebben kun je aan de slag met een 'ShoppingCart'. Maak een nieuwe class genaamd 'Cart' en laat deze een lijst (List) bewaren van 'Product' objecten. Instantieer de lijst in de constructor van 'Cart'.
8: Maak vervolgens een methode 'AddProduct' met als parameter een object van het type 'Product'. Laat deze methode het object toevoegen aan de lijst.
9: Maak als laatste een methode om de lijst te legen, genaamd 'ClearCart'. Deze methode moet de lijst legen. Hier volgt de implementatie van de Cart class.

````csharp
 public class Cart
{
    private List<Product> _items;

    public Cart()
    {
        _items = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _items.Add(product);
    }

    public void ClearCart()
    {
        _items.Clear();
    }
}
````

Nu we de start van ons model klaar hebben kunnen we beginnen aan de eerste 'Strategy'. We beginnen eerst met het maken van een interface en vervolgens met de 'Wallet' strategy.

10: Maak een interface in de 'Interfaces' map met de naam 'IPaymentStrategy'
11: Zorg er voor dat deze een methode van het type 'void' heeft genaamd 'Pay'.
12: Maak nu een classe met de naam 'WalletStrategy'. Zorg ervoor dat deze de IPaymentStrategy implementeerd.
13: Laat 'Pay' methode een simpele string retourneren naar de Console met Console.WriteLine().
14: Maak vervolgens een PaypalStrategy classe en laat deze ook de IPaymentStrategy gebruiken. 
15: Zorg er hier ook voor dat de Pay methode een lijn naar de Console schrijft. Als voorbeeld zie je hieronder de IPaymentStrategy en WalletStrategy.

````csharp
public interface IPaymentStrategy
{
    void Pay();
}

public class WalletStrategy : IPaymentStrategy
{
    public WalletStrategy() { }
    
    public void Pay(int amount)
    {
        Console.WriteLine("Paid using In-Game Wallet.");
    }
}
````

Nu we onze 2 'basic' 'Strategies' hebben. Kunnen we het in werking zien. Als eerste is het belangrijk dat de Cart een afreken methode krijgt en daarbij gebruik maakt van 1 van de strategies.
16. Open 'Cart.cs' en maak een nieuwe methode met de naam 'MakePayment' en geef deze een parameter van het type IPaymentStrategy. Hierdoor kan zowel de WalletStrategy als PaypalStrategy worden gebruikt.

````csharp
public void MakePayment(IPaymentStrategy paymentStrategy)
{
    paymentStrategy.Pay(GetTotalPrice());
}
````

17. Ga vervolgens naar 'Program.cs' en maak een instantie van 'Cart'. 
18. Voeg 3 of 4 producten toe aan de ShoppingCart.

````csharp
Cart shoppingCart = new Cart();
shoppingCart.AddProduct(new Game(50));
shoppingCart.AddProduct(new Game(15));
shoppingCart.AddProduct(new Sticker(5));
shoppingCart.AddProduct(new Poster(10));    
````

19. schrijf vervolgens 2 regels waarbij je de 'MakePayment' methode aanroept met een nieuwe instantie van de PaypalStrategy en WalletStrategy. 
20. Druk vervolgens op F5 en je ziet 2 lijnen verschijnen in de Console. namelijk 'Paid using Paypal' (of een eigen gekozen zin) en 'Paid using In-Game Wallet.'.

**EXTRA**: Om toch wat meer uitdaging en logica toe te voegen kun je enkele dingen toevoegen. Dit is in de demo al gedaan. Meer om toch een real-life situatie na te bootsen. Dit zijn;

- Voeg een gebruikersnaam en wachtwoord toe aan de PayPalStrategy. Je kunt nu een 'test' Login methode maken om te controleren of de gebruiker is ingelogd en mag betalen.
- Voeg een budget toe aan de WalletStrategy. Als de totaalprijs nu meer is dan het budget kan de Wallet de transactie niet voltooien.
- Voeg een username toe aan de WalletStrategy. in Steam werken gebruikers met gebruikersnamen. Leuk om ook te gebruiken. 
- Over totaalprijs gesproken. Maak een methode in de 'Cart' die alle 'Price' van de verschillende producent bij elkaar op telt. Dit kan eenvoudig met;

````csharp
var total = _items.Sum(x => x.GetPrice());
return total;
````

- Zorg ervoor dat de 'Pay' methode nu een 'int' met een totaalprijs kan ontvangen/gebruiken. 
- Als laatste zou je de 'MakePayment' methode iets meer logica kunnen laten bevatten dat het eerst probeert te betalen met de Wallet, maar met ontoereikend budget de PaypalStrategy gebruikt.


En zo simpel is het. Op deze manier kun je eenvoudig een 'Strategy' Pattern implementeren waarbij elke classe een eigen implementatie heeft van de 'Pay' methode. 


