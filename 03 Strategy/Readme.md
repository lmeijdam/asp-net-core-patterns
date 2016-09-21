# Choosing one or another

Het 'Strategy' pattern is een patroon die zich huisvestigt in de categorie 'Behavioral' of Gedrag. Bij het Strategy pattern kun je eenvoudig switchen van de ene implementatie naar een andere implementatie door het gebruik van een 'interface'. 

Een van de meest voorkomende situaties waarbij het Strategy pattern zijn bij;
- Het maken van een rekenmachine waarbij elke operatie (+, -, * , /) een eigen uitvoering geeft op de input.
- Het sorteren van lijsten (denk aan; QuickSort, MergeSort en andere vormen).
- Andere situatie waarbij een enkele 'strategy' eigenaar is van een algoritme.

Voor deze demo maken we niet gebruik van bovenstaande situatie, maar maken we een webwinkel. Deze webwinkel is een (kleine) nabootsing van de 'Steam Store' (bij gamers niet geheel onbekend). Als je hier een product aanschaft kun je deze betalen met IDeal, PayPal, Visa en nog wat andere veelvoorkomende betaalmethodieken. Daarnaast heb je binnen Steam ook een eigen 'Wallet'. Hier kun je zo nu en dan geld op zetten.

Tijdens deze demo maken we alleen de implementatie van de 'Wallet' en het gebruik van PayPal om af te kunnen rekenen. Er zal een standaard budget zijn voor de 'Wallet' van 50 (euro, dollar, you name it).

Om te beginnen maken we een nieuw .Net Core project, we gaan weer aan de slag met een simpele Console applicatie.

**Let op** - Als je geen VS2015 wilt gebruiken kun je de eerste 4 stappen volgen in '01'.

1. Start VS2015 en ga naar File > New Project > Visual C# en kies hier vervolgens .NET Core > Console Application .NET Core.
2. Geef het project een naam en selecteer een eigen gekozen locatie om het project op te slaan.
3. Je hebt nu een lege console applicatie. Je kunt testen of dit werkt door in 'Program.cs' de volgende code te schrijven in de 'Main' methode;
````Csharp
public static void Main(string[] args)
{
    Console.ReadKey();
}
````

4. Druk nu op F5 om de applicatie te starten en je ziet een Console venster draaien. Door een willekeurige toets wordt deze weer afgesloten.

**Let op 2** bovenstaand is inderdaad gekopieerd uit '02'. 

Oke nu we weer een standaard .Net applicatie hebben staan kunnen we beginnen met het maken van de classes. Om alvast een start te maken kun je de map 'Interfaces' en 'Models' alvast maken.

1. Maak in de map 'Models' een class met de naam 'Product'. Maak deze abstract en laat deze een 'Price' van het type 'int' retourneren. Zorg ervoor dat het 'Price' veld (of property) protected is en de methode om hem te benaderen publiek.
**CODE**
2. Maak vervolgens 3 nieuwe 'Product' classes. Dit zijn 'Game', 'Poster' en 'Sticker'. Zorg ervoor dat deze zijn afgeleid van 'Product' en dat de prijs wordt gezet in de constructor.
**CODE**
3. Nu we de producten hebben kun je aan de slag met een 'ShoppingCart'. Maak een nieuwe class genaamd 'Cart' en laat deze een lijst (List) bewaren van 'Product' objecten. Instantieer de lijst in de constructor van 'Cart'.
4. Maak vervolgens een methode 'AddProduct' met als parameter een object van het type 'Product'. Laat deze methode het object toevoegen aan de lijst.
5. Maak als laatste een methode om de lijst te legen, genaamd 'ClearCart'. Deze methode moet de lijst legen.
**CODE**

Nu we de start van ons model klaar hebben kunnen we beginnen aan de eerste 'Strategy'. We beginnen eerst met het maken van een interface en vervolgens met de 'Wallet' strategy.

1. Maak een interface in de 'Interfaces' map met de naam 'IPaymentStrategy'
### HIER VERDER


