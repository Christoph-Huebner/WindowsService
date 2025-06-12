# WindowsService

Kompakter Windows-Dienst (.NET 6) als BackgroundService.

## Übersicht
Führt Hintergrundaufgaben als Windows Service (C# Worker Service).

## Voraussetzungen
- Windows 10+
- .NET 6 SDK
- PowerShell (Admin) zur Dienstinstallation

## Build & Start
```bash
git clone https://github.com/Christoph-Huebner/WindowsService.git
cd WindowsService
dotnet build
# Als Konsole starten:
dotnet run --project WindowsService/WindowsService.csproj
```

## Installation als Dienst
```powershell
sc create WindowsService binPath="C:\Pfad\WindowsService.exe" DisplayName="WindowsService" start=auto
sc start WindowsService
sc stop WindowsService
sc delete WindowsService
```

## Konfiguration & Logging
- `appsettings.json` neben der EXE ablegen.
- Logs: Windows-Ereignisprotokoll (Dienst) / Konsole (Run).

## Mitwirken
Issues & PRs willkommen!
