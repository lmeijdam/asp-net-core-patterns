# 01 - Let's Build(er) Design Pattern

Het Builder Design Pattern is een 'Creation' pattern. Dat wil zeggen dat het een best practice is voor het aanmaken van objecten.
Het Builder pattern is vooral geschikt voor het creeeren van gecompliceerde objecten.
In deze 'tutorial' maken we een maaltijd Builder. We beginnen deze workshop simpel, zonder ASP, met een simpele .NET Core Console applicatie.


1. Maak op een locatie naar keuze een folder aan en noem deze 'Builder'. Vanuit deze folder beginnen we het 'project'.

2. Open Command Prompt (Windows Search -> 'cmd' -> enter) en navigeer naar de betreffende folder.\ 

3. Type nu onderstaande code en druk vervolgens op enter om een .NET Core Console applicatie aan te maken. 
  ```
  dotnet new
  ```
<sub>Je kan ook in Visual Studio 2015 kiezen voor File, New, Project, Visual C#, .NET Core en dan Console Application .NET Core.

4. Indien je voorheen niet Visual Studio hebt gebruikt maar Visual Studio Code met de Command Prompt dan dien je nu eerst een restore van de packages toe doen middels:

```
dotnet restore
```


Het basis Console project staat nu. Dus laten we beginnen met het Builder Pattern.
De maaltijd die we gaan 'builden' bestaat uit items (zoals hamburgers en cola) die natuurlijk moet worden ingepakt in een verpakking (bijvoorbeeld een flesje of een doosje) 

5. We beginnen met het definieren van de Interfaces. Maak in het project een nieuwe folder 'Interfaces' aan.
6. Maak een nieuwe Interface class aan en noem deze IPacking.cs
7. De IPacking interface bevat een enkele `string` property met de naam 'Pack' en een public 'getter'.

```c
namespace Builder.Interfaces
{
    public interface IPacking
    {
        string Pack { get; }
    }
}
```
Het IPacking.cs bestand mag je nu weer sluiten (of niet.. ..wat je zelf wilt)

8. Creëer in dezelfde interface folder een nieuwe Interface class en noem deze 'IItem.cs'.
9. In de `public interface IItem` schrijven we een drietal properties met een public 'getter'.
      * `string Name { get; }`
      * `IPacking Packing { get; }`
      * `float Price { get; }`
```c
namespace Builder.Interfaces
{
    public interface IItem
    {
        string Name { get; }

        IPacking Packing { get; }

        float Price { get; }
    }
}
```

Dat was het voor de Interfaces. We gaan nu de Interface concreet maken.

10. Maak in de root van het project een nieuwe folder aan en noem deze 'Models'.
11. Maak in de 'Models' folder een nieuwe class aan en noem deze 'Bottle.cs'.
12. De 'Bottle.cs' class implementeert de `IPacking` interface. Hiervoor dien je nog wel even naar de 'Interfaces' folder te refereren.

Protip: Wanneer je de interface benoemd in je class krijg je standaard een rode kringel onder de interface naam. Ga met je muis op de rode kringel staan en druk vervolgens op `CTRL + . ` (Control + punt), Selecteer in het context menu dat verschijnt: 'Implement Interface' en het meeste werk wordt direct voor je gedaan.

13. Implementeer de 'Pack' property en laat deze de tekst 'Bottle' retourneren.

```c
using Builder.Interfaces;

namespace Builder.Models
{
    public class Bottle : IPacking
    {
        public string Pack
        {
            get { return "Bottle"; }
        }
    }
}
```
14. Sluit nu het 'Bottle.cs' bestand, hier zijn we ook alweer klaar mee (het gaat lekker snel zo)

15. Dezelfde stappen (11 t/m 14) herhalen we voor een 'Box'. Het nieuwe bestand noem je nu dus 'Box.cx' en de IPacking interface implementeert 'Pack' welke de tekst 'Box' retourneert.

```c
using Builder.Interfaces;

namespace Builder.Models
{
    public class Box : IPacking
    {
        public string Pack
        {
            get { return "Box"; }
        }
    }
}
``` 

Nu we een `Box` en een `Bottle` hebben kunnen we ons voedsel ergens in bewaren. Tijd voor het maken van de voedsel klasses.

16. We beginnen met het maken van een nieuwe `abstract` class met de naam Burger.cs, nog steeds in de 'Models' folder.
17. Burger implementeert de `IItem` interface. 
18. De `Name` en `Price` properties implementeren we hier nog niet, dat doen we in de burger implementaties, dus zetten we ze door als `abstract` properties met een `public get`.
19. De `Packing` property laten we een `new Box();` retourneren in de public `get`.

De Burger.cs code zou er ongeveer zou uit moeten zien:
```c
using Builder.Interfaces;

namespace Builder.Models
{
    public abstract class Burger : IItem
    {
        public abstract string Name { get; }

        public IPacking Packing
        {
            get { return new Box(); }
        }

        public abstract float Price { get; }
    }
}
```

Het bestand 'Burger.cs' is nu gereed en mag je naar wens sluiten.

We maken nu een tweetal typen 'Burgers' aan. Namelijk een Hamburger en een ChickenBurger.
20. Nog steeds in de 'Models' folder: Maak een nieuwe class aan met de naam 'Hamburger'
21. `Hamburger` implementeert (logischerwijs) de `Burger` class die we eerder hebben aangemaakt.
22. Implementeer de 'overgebleven' properties `Name` en `Price`. (CTRL + . )
23. Zorg er voor dat `Name` de waarde "Hamburger" retourneert in de getter.
24. Voor `Price` mag je `2.80f` retourneren (nee de `f` staat niet voor de ouderwetsche Neerlandische Frank maar voor `float`)

Een voorbeeld van de `Hamburger` class met de sexy nieuwe alternatieve manier van de 'get return' implementaties.
```c
namespace Builder.Models
{
    public class Hamburger : Burger
    {
        public override string Name => "Hamburger";

        public override float Price => 2.80f;
    }
}
``` 

25. Tijd voor de `ChickenBurger` maak in de 'Models' folder het bestand 'ChickenBurger.cs' aan.
26. Herhaal de bovenstaande stappen 21 t/m 24 waarbij je in dit geval `Hamburger` vervangt voor `ChickenBurger` en pas je de prijs aan naar `2.50f`.

Dat was snel, de `ChickenBurger` class:
 ```c
namespace Builder.Models
{
    public class ChickenBurger : Burger
    {
        public override string Name => "ChickenBurger";

        public override float Price => 2.50f;
    }
}
``` 

# HIER VERDER MET Drink implemtatie: Cola en Coffee. Vervolgens Meal.cs en tot slot de MealBuilder en Program.cs