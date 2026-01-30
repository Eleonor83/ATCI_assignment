# Rapport – CI och testautomatisering

Detta repository innehåller min lösning på uppgiften om Continuous Integration och testautomatisering i C#.

---

## Del 1 – Rapport

### Continuous Integration (CI)
Continuous Integration innebär att kod som utvecklas kontinuerligt integreras i ett gemensamt repository.  
Varje gång kod pushas körs automatiska tester och byggen för att kontrollera att allt fortfarande fungerar.

**Fördelar med CI:**
- Fel upptäcks tidigt
- Mindre risk att ny kod förstör befintlig funktionalitet
- Automatisering sparar tid

**Utmaningar med CI:**
- Kräver att tester är korrekt uppsatta
- Kan ta tid om många tester körs
- Kräver viss vana vid verktyg som GitHub Actions

---

### Testautomatisering
Testautomatisering innebär att tester körs automatiskt istället för manuellt.  
I detta projekt används NUnit för tester och Selenium WebDriver för UI-test.

Testautomatisering används tillsammans med CI för att säkerställa att kod som pushas inte innehåller fel.

---

### Automatiska tester i GitHub Actions
För att köra tester automatiskt i GitHub Actions krävs följande steg:

1. Skapa en workflow-fil i `.github/workflows/`
2. Konfigurera workflow så att det körs vid push till `main`
3. Checka ut koden
4. Installera rätt .NET-version
5. Köra `dotnet restore`, `dotnet build` och `dotnet test`

GitHub Actions kör sedan testerna automatiskt vid varje push.

**GitHub-repo:**  
https://github.com/Eleonor83/ATCI_assignment.git

---

## Del 2 – Selenium WebDriver

Ett automatiserat test har skapats för inloggning på https://www.saucedemo.com/.

Testet kontrollerar:
- Att inloggning fungerar med korrekta användaruppgifter
- Att användaren hamnar på startsidan efter inloggning

UI-testet är markerat som `[Ignore]` i CI eftersom Selenium kräver webbläsare.

---

## Del 3 – Integrationstester

Integrationstester har skapats mot https://fakestoreapi.com/.

Testet:
- Gör ett GET-anrop till `/products`
- Verifierar att statuskoden är 200

Testerna körs automatiskt via GitHub Actions vid varje push.

---

## Tekniker som använts
- C#
- .NET 7
- NUnit
- Selenium WebDriver
- GitHub Actions

---

## Köra tester lokalt

```bash
dotnet test

