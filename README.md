# KlassePersoneel

Maak een toepassing **KlassePersoneel** om een personeelsobject te
creëren en de gegevens van dat personeelsobject te tonen.

***Class diagram***

![Afbeelding met tekst, schermopname, software, scherm Automatisch
gegenereerde
beschrijving](./media/image1.png)

Je maakt voor deze toepassing eerst de (basis)klasse **Personeel** met
volgende [eigenschappen]:

-   **Naam** - string.

-   **Voornaam** -string.

-   **Geslacht** - string (waarde "M" of "V" ).

-   **Beoordelingscijfer** -- integer waarde van minimum 0 en maximum
    10.

-   **Startjaar** -- integer die aangeeft in welk kalenderjaar het
    personeelslid in dienst getreden is.

Deze klasse bevat ook nog enkele ["read-only"
eigenschappen]:

-   **Dienstjaren** -- integer die het aantal dienstjaren weergeeft:
    huidig jaar wordt verminderd met het startjaar.

-   **GeslachtTekst** -- string met als waarde "Mannelijk" of
    "Vrouwelijk" (afhankelijk van de waarde van de eigenschap Geslacht)

-   **Premie** -- float. De premie wordt als volgt bepaald: eerst
    wordt het basisbedrag berekend: 500€, vermeerderd met 20€ per
    dienstjaar. Dit bedrag wordt gehalveerd voor personeelsleden die een
    Beoordelingscijfer hebben dat lager is dan 5. Voor diegenen die een
    beoordelingscijfer van 7 of 8 hebben, wordt het basisbedrag met 50%
    verhoogd. Voor wie een beoordelingscijfer van 9 of 10 heeft, wordt
    het basisbedrag verdubbeld.

De klasse Personeel bevat volgende [methods]:

-   Constructor **Personeel** in 2 vormen: één zonder parameters waarbij
    een "leeg" personeelslid gecreëerd wordt en één met 5 parameters (de
    5 eerder beschreven eigenschappen, in de volgorde zoals beschreven).

-   **VerhoogBeoordeling** -- deze methode zorgt ervoor dat het
    beoordelingscijfer met 1 verhoogd wordt.

-   **VerlaagBeoordeling** -- deze methode zorgt ervoor dat het
    beoordelingscijfer met 1 verlaagd wordt.

-   **ToonInfo** -- deze functiemethode geeft een string als
    resultaat met alle informatie van het personeelslid. (zie verder
    inhoud van het tekstvak txtResultaat).

Bij de start van het programma, krijgt de gebruiker de vraag of een
"leeg" personeelsobject of een "ingevuld" personeelsobject gecreëerd
moet worden. In het eerste geval is er geen naam en voornaam (leeg), is
het geslacht "M" en het startjaar 2000. In het 2^de^ geval kies je zelf
de "invulwaarden".

![Afbeelding met tekst, schermopname, Lettertype, lijn Automatisch
gegenereerde
beschrijving](./media/image2.png)

Na die keuze verschijnt het venster Personeelsklasse.

Bij keuze van een "leeg" personeelsobject:

![Afbeelding met tekst, schermopname, scherm, software Automatisch
gegenereerde
beschrijving](./media/image3.png)

Mogelijke inhoud bij keuze van een ingevuld personeelsobject:

![Afbeelding met tekst, schermopname, scherm, software Automatisch
gegenereerde
beschrijving](./media/image4.png)

Het venster *Personeelsklasse* bevat volgende objecten (+ enkele
labels):

-   TxtVoornaam: toont de voornaam van het personeelsobject. Bij het
    verlaten van dit tektstvak wordt een eventuele wijziging in het
    personeelsobject uitgevoerd en ook al getoond in het tekstvak
    TxtResultaat.

-   TxtNaam: toont de naam van het personeelsobject. Bij het verlaten
    van dit tektstvak wordt een eventuele wijziging in het
    personeelsobject uitgevoerd en ook al getoond in het tekstvak
    TxtResultaat.

-   TxtStartjaar: toont het startjaar (jaar van indiensttreding) van het
    personeelsobject. Bij het verlaten van dit tektstvak wordt een
    eventuele wijziging in het personeelsobject uitgevoerd en ook al
    getoond in het tekstvak TxtResultaat.

-   CboGeslacht: toont in de listbox het geslacht (M of V) van het
    personeelsobject. Bij het verlaten van dit tektstvak wordt een
    eventuele wijziging in het personeelsobject uitgevoerd en ook al
    getoond in het tekstvak TxtResultaat.

-   TxtResulaat (niet wijzigbaar). In dit tekstvak wordt de informatie
    van het personeelsobject getoond door oproep van de methode
    InformatieVolledig (afdruk zoals in de schermvoorbeelden).

-   BtnVerhoogBeoordeling: bij het drukken van deze knop wordt het
    beoordelingscijfer van het personeelsobject met één verhoogd en ook
    al getoond in het tekstvak TxtResultaat.

-   BtnVerlaagBeoordeling: bij het drukken van deze knop wordt het
    beoordelingscijfer van het personeelsobject met één verlaagd en ook
    al getoond in het tekstvak TxtResultaat.
