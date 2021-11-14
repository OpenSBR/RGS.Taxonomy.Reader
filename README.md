# RGS Taxonomy Reader

## Inleiding

Voor het RGS-Experiment van SBR Vernieuwing en RGS MKB is een tool ontwikkeld om de koppelingen tussen RGS-codes en SBR-concepten in de huidige RGS-taxonomie (t/m versie 3.3) te vertalen naar XML en JSON. Dit kan per entrypoint. Deze output kan men eenvoudig gebruiken en inlezen in andere applicaties.

## Toelichting

Via [nltaxonomie.nl](https://nltaxonomie.nl/) zijn alle formulieren (entrypoints) beschikbaar waarmee rapportages kunnen worden opgesteld volgens SBR-standaarden. De RGS-taxonomie staat ook op deze website. Deze beschrijft o.a. de relatie tussen RGS-codes en SBR-begrippen (concepten), gepresenteerd per rapportage die we kennen binnen SBR (bijvoorbeeld het jaarverslag voor de Kamer van Koophandel).  
 
Met de tool die is gebouwd in dit experiment kan men eenvoudig de [link](https://nltaxonomie.nl/rgs/) naar het gewenste formulier (entrypoint) als input opgeven. De gebruiker heeft vervolgens de keuze om een overzicht in JSON en/of XML te creëren. Ook is er de keuze om een ‘simple report’ te maken, hier komen we straks op terug. Vervolgens gaat de tool het formulier inladen en alle relaties naar andere bestanden ophalen en uiteindelijk vertaalt het de gegevens naar de gewenste output. 
In een ‘simple report’ worden alle dimensie en member velden weggelaten. Deze informatie is niet voor iedereen relevant en maakt het output bestand groter. Belangrijk om te vermelden: deze informatie is noodzakelijk voor software om uiteindelijk SBR-rapportages te kunnen generen/lezen etc. 

De output die de tool maakt geeft: 
* Het RGS-entrypoint 
* Het SBR-entrypoint 
* De prefixes die gebruikt zijn om het bestand kleiner te houden (bijvoorbeeld de afkorting ‘rgs-i’ verwijst naar een lange URL)
* De mapping van alle combinaties van RGS-codes en SBR-concepten
* From = de RGS-code
* To = SBR-concept 
* Qname = de formulering die machines (moeten) gebruiken
* Label = leesbare omschrijving van code/concept

## Voorbeelden

* [RGS-taxonomie 3.3 (ZIP)](https://www.referentiegrootboekschema.nl/rgs-taxonomie-33)
* [RGS-taxonomie 3.3 (links)](https://nltaxonomie.nl/rgs/nt15/rgs/20210217/entrypoints/)
* [Overige RGS-taxonomieen](https://nltaxonomie.nl/rgs/)

## Over de tool

Deze tool is tot stand gekomen vanuit SBR Vernieuwing.

Copyright: [SBR Vernieuwing](https://www.sbr-nl.nl/over-sbr/toekomstvisie/sbr-vernieuwing) - 2021 
Licentie: MIT (bijlage)
