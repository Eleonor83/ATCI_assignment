# CI och Testautomatisering – C#

Detta repository innehåller lösningen för en inlämningsuppgift inom
Continuous Integration och testautomatisering.

## Innehåll

### Del 1 – Rapport
- Continuous Integration (CI)
- Testautomatisering
- GitHub Actions

### Del 2 – Selenium WebDriver
- Automatiserat test av inloggning på https://www.saucedemo.com/
- Test verifierar lyckad inloggning

### Del 3 – Integrationstester
- Integrationstest mot https://fakestoreapi.com/
- GET-anrop till `/products` verifierar statuskod 200

## Tekniker
- C#
- .NET
- NUnit
- Selenium WebDriver
- GitHub Actions

## CI
Alla tester körs automatiskt vid push till `main`.

## Kör tester lokalt
```bash
dotnet test
