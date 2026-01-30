# Rapport – CI och testautomatisering

Detta repository innehåller min lösning på uppgiften om Continuous Integration och testautomatisering i C#.

---

## Del 1 – Rapport

### Continuous Integration (CI)
Continuous Integration betyder att kod som jag och andra utvecklare skriver automatiskt byggs och testas när den pushas till GitHub.  
Jag tycker det är bra för att snabbt upptäcka fel innan de sprids till hela projektet.

**Fördelar med CI:**
- Fel upptäcks tidigt
- Ny kod förstör inte befintlig funktionalitet
- Sparar tid med automatiska tester

**Utmaningar med CI:**
- Kräver att tester och workflow är korrekt uppsatta
- Om tester tar lång tid blir pushen långsam
- Måste vara noggrann med commits och kodstandard

---

### Testautomatisering
Testautomatisering innebär att tester körs automatiskt istället för manuellt.  
Jag har använt NUnit för API-test och Selenium WebDriver för UI-test.  

**Koppling till CI:** Testerna körs automatiskt i GitHub Actions vid varje push, vilket gör att jag snabbt ser om något går fel.

---

### Automatiska tester i GitHub Actions
För att tester ska köras automatiskt gjorde jag så här:
1. Skapade workflow-fil i `.github/workflows/ci.yml`
2. Ställde in att workflow körs vid push till `main`
3. Checkade ut koden
4. Installerade .NET 7
5. Körde `dotnet restore`, `dotnet build` och `dotnet test`

GitHub Actions kör nu testerna automatiskt vid varje push.

**GitHub-repo:**  
[https://github.com/Eleonor83/ATCI_assignment.git](https://github.com/Eleonor83/ATCI_assignment.git)

---

## Del 2 – Selenium WebDriver

Jag har skapat ett automatiserat test för inloggning på [https://www.saucedemo.com/](https://www.saucedemo.com/).

Testet gör följande:
- Kontrollerar att inloggning fungerar med rätt användarnamn och lösenord
- Kontrollerar att användaren hamnar på startsidan (inventory page)

Testet är markerat `[Ignore]` i CI eftersom Selenium kräver webbläsare och inte körs i pipeline.

---

## Del 3 – Integrationstester

Integrationstester har jag gjort mot [https://fakestoreapi.com/](https://fakestoreapi.com/).  

Testet gör:
- GET-anrop till `/products`
- Verifierar att statuskoden är 200

Testerna körs automatiskt via GitHub Actions.

---

## Tekniker som använts
- C#  
- .NET 7  
- NUnit  
- Selenium WebDriver  
- GitHub Actions

---

## Köra tester lokalt

Om man vill testa lokalt går det med terminalen i projektroten:

```bash
dotnet restore
dotnet test
