# Megoldás

## Osztály létrehozása
- Kétféle mód közül bármelyik
  - Ctrl + .
  - Adjunk hozzá egy osztályt
- 5 tulajdonság 
  - public get
  - private set
- 1 konstruktor ?
  - 1 paraméter --> string
  - például: "Acsalapu;levél;6;8"
  - ;-vel vannak elválasztva
  - 4 darab adat --> 5 tulajdonság?
  - átadott, fáljból beolvasott sort:
    - ';' mentén tagoljuk
    - [0] --> Nev
    - [1] --> Resz
    - [2] --> Kezd
    - [3] --> Veg
    - Idotartam --> számolás (lásd következő pont)
- 5-dik tulajdonság --> Időtartam
    - Konstruktorban számoljuk
    - számolása: Vég - Kezdet HA!! Vég > Kezdet
    - Vég > Kezdet --> Vég - Kezdet + 1
    - Egyébként --> 12 - Kezdet + Vég + 1

## Adatok beolvasása és eltárolása
- Listában tároljuk az objektum példányokat
- Olvassuk be:
  - System.IO
  - StreamReader
  - while ciklussal --> amíg tart a fájl
  - Cikluson belül listához hozzáadunk egy új objektum példányt (beolvasott sor a paraméter)

## 1. Feladat
- Hány növény van (lista Count tuljadonság)

## 2. Feladat
- Milyen gyűjthető részek vannak?
- Hány darab van ezekből
- Adatszerk: Dictionary<string, int>
- 1 Milyen gyűjthető részek
  - Foreach "novenyek"
  - Ha a rész nem kulcs --> akkor adjuk hozzá 0-val
- 2 Hány darab van ezekből
  - Foreach "novenyek"
  - Ha "Resz" == Key --> Value++

## 3. Feladat
- Maximum keresés --> Időtartam alapján
  - maximum változó = 0
  - foreach novenyek 
  - ha max < Idotartam --> max = Idotartam
- Növény(ek) amely(ek) a legtöbb ideig szedtek
    - foreach novenyek
    - Kiírni ha Idotartam == max

## 4. Feladat
- Időtartam átlag számítás
  - szum változó = 0 (double)
  - atlag változó
  - foreach novenyek 
  - szum += Idotartam
  - atlag = szum / Count
