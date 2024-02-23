Individuellt Databasprojekt
Detta projekt är en individuell uppgift inom ramen för en databaskurs. Det syftar till att demonstrera kunskaper och färdigheter inom databashantering och tillämpning av olika koncept som normalisering och SQL-frågor.

Beskrivning
Projektet är enkelt utformat för att visa grundläggande koncept inom databaser. Det består av följande komponenter:

Databasdesign: En databasdesign skapad med hjälp av SQL för att definiera tabellstrukturer, nycklar och relationer mellan tabeller.

SQL-frågor: Ett antal SQL-frågor som används för att hämta, uppdatera, infoga och radera data från databasen.

Kör SQL-frågor: Använd SQL-förfrågningsverktyget för att köra SQL-frågor mot den importerade databasen och se resultaten.

Exempel
Här är ett exempel på hur man kan köra några SQL-frågor mot databasen:

-- Visa alla kunder
SELECT * FROM Customers;

-- Uppdatera kundens adress
UPDATE Customers SET Address = 'Ny adress' WHERE CustomerID = 1;

-- Lägg till en ny produkt
INSERT INTO Products (ProductName, Price) VALUES ('Nytt Produkt', 10.99);

-- Ta bort en produkt
DELETE FROM Products WHERE ProductID = 5;
