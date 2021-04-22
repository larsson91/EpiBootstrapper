# EpiBootstrapper
Ett bra projekt att utgå ifrån för dig som ska bygga epi!

# Labb
**Setup**

Ladda ner .Net Framework 4.8 (eller 4.7.1)

Ladda ner SQL Server Management Studio

a. Sätt upp siten i IIS (domän: epibootstrap.local)

b. Lägg till epibootstrap.local i hosts-filen som ligger `C:\Windows\System32\drivers\etc` på egen rad: `127.0.0.1	epibootstrap.local`

c. Fixa en licens: https://license.episerver.com/ (EPiServer Partner Developer License EPiServer CMS 7) och lägg i mappen för projektet (på samma nivå web.config)

d. Surfa till http://epibootstrap.local/episerver logga in med AD (se till att sitta på VPN)

# Labb 1
a. Skapa en sida.

b. Lägg till Rubrik, top-bild, formatterbar text, blockyta

# Labb 2
a. Skapa ett block, lägg till blocket på ovanstående sida

b. Skapa block-i-block

# Labb 2.9 (FE-fokus) styling
Vill jag labba med css? kanske ska köra scss direkt så det blir nice! Se om du kan sätta upp något basic bygge med t.ex. npm, gulp eller webpack för att bygga scss m.m.

# Labb 3 (FE-fokus) styling
a. Hur gör jag generell styling för alla sidor

b. Hur stylar jag footer & header

c. Hur gifter sig generell sidstyling med block

d. Hur ska jag styla block samt när olika block kommer efter varandra

e. Hur stylar jag block i block (T.ex. om jag har ett block som i sin tur har 1, 2, eller 3 block i sig som ska visas jämte varandra i desktop och ovan/under i mobil)

# Labb 3.5 (FE-fokus) utforskande
Om vi skulle vilja ha en mer dynamisk sida och kanske kombinera epi med t.ex. Vue, hur skulle det funka

Heads-Up: Jag (Martin Larsson) har aldrig gjort detta själv, men det är rätt vanligt att man diskuterar och implementerar någon typ av lösning

# Labb 4 (Lite mer BE, men FE borde klara också :) )
Skapa en sida som listar sidor under den själv (Likt en nyhetslista eller en blog).

a. Börja med att hämta sidor precis under listsidan

b. Testa sedan att lägga sidorna hierarkiskt och hämta allt under oavsett nivå

c. Lägg sedan till en filtrering på kategori, så t.ex. alla sidor måste ha en viss kategori för att synas

Tips: Kanske måste gå in i EPiServer admin för att sätta vilka sidor som tillåts under vilka

Tips: Använd IContentLoader för att hämta children/descendents

Tips: För nr 3. kategori-filter kan det vara smart att lägga till en kategori-väljare på listsidan, så alla under listsidan måste ha samma som den som är vald på listsidan

**Resterande labbar är lite mer avancerade och har ingen inbördes ordning, gör de ni tycker verkar kul!**

# Labb 5 (BE-fokus)
a. Skapa en meny som automatisk listar alla sidor direkt under Startsidan

b. Den ska endast lista sidor som har checkboxen "Visa i navigering" iklickad (DisplayInNavigation heter den i epi typ)

c. Den ska också hålla koll på vilken sida man är på just nu med hjälp av CurrentPage

# Labb 6 (BE-fokus)
Skapa ett schemalagt jobb som hämtar data från valfritt api, t.ex. katter, pokemon etc. 

Skapa sedan sidor utifrån detta jobb och placera under en utpekad nod. (Varför vill man göra detta? jo, för att kunna utgå från material men ha möjlighet att redigera, + gratis url, struktur & rättigheter)

Tips: För att hämta startsidans ContentReference, använd ContentReference.StartPage

Tips: Troligtvis kommer ContentReference.StartPage vara null till en början, då behöver man gå in i admin-läget, config ->  Manage Websites -> epibootstrap.local -> Lägg till * på host name

Tips: Peka ut vald toppsida från startsidan

# Labb 7 (BE-fokus)
Sätt upp EPiServer Find, Indexera siten och skapa en sökresultatsida

Lägg till kategorier som Facets och gör det möjligt att filtrera sök på dessa

Tips: måste skaffa en EPiServer Find demo-licens för find och lägga in i web.config
