# WindowsService

Compact Windows Service (.NET 9) implemented as a BackgroundService.

## Overview
Executes background tasks as a Windows Service using the .NET Worker Service template.

## Prerequisites
- Windows 10 or newer
- .NET 9 SDK (also compatible with .NET 6)
- PowerShell with Administrator rights (for service installation)

## Build & Run Locally
```bash
git clone https://github.com/Christoph-Huebner/WindowsService.git
cd WindowsService

dotnet build
# Run as console application:
dotnet run --project WindowsService/WindowsService.csproj
```

## Install as Windows Service
```powershell
sc create WindowsService binPath="C:\Path\To\WindowsService.exe" DisplayName="WindowsService" start=auto
sc start WindowsService
sc stop WindowsService
sc delete WindowsService
```

## Configuration & Logging
- Place `appsettings.json` next to the executable to override default settings.
- Logs write to the Windows Event Log when running as a service, or to the console in local mode.

## Contributing
Issues and pull requests are welcome!
