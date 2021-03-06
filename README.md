# udemy-dating-app
Tutorial app from the udemy course "Build an app with ASPNET Core and Angular from scratch"
Updated version with .NET 5

## useful commands 
### dotnet
`dotnet --info`

`dotnet new -h`

`dotnet new webapi -h`

`dotnet new webapi -n projectname`

`dotnet watch run`

`dotnet tool install --global dotnet-ef`

`dotnet ef -h`

`dotnet ef migrations -h`

`dotnet ef migrations add InitialCreate`

`dotnet ef database update`

`dotnet user-secrets set "AppSettings:Token" "super secret key"`

`dotnet user-secrets list`

### angurlar
`ng new projectname`

`ng serve`

`ng g guard auth --skipTests`

### git
`git rev-parse --show-toplevel`

`git rm file_to_remove.json`

`git rm file_to_remove.json --cached`

### postman
To display an HTML-formatted response, set the Accept HTTP request header to the text/html media type. For example:
`curl -i -H "Accept: text/html" https://localhost:5001/weatherforecast/chicago`



## Downloads
https://dotnet.microsoft.com/download/dotnet-core

https://nodejs.org/en/

https://www.postman.com/downloads/

https://docs.microsoft.com/en-us/powershell/scripting/components/vscode/using-vscode?view=powershell-7

https://sqlitebrowser.org/dl/

# VS Code Addons for .NET
https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp

https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions

https://marketplace.visualstudio.com/items?itemName=jmrog.vscode-nuget-package-manager

# VS Code Addons for Angular
https://marketplace.visualstudio.com/items?itemName=johnpapa.Angular2

https://marketplace.visualstudio.com/items?itemName=alexiv.vscode-angular2-files

https://marketplace.visualstudio.com/items?itemName=Angular.ng-template

https://marketplace.visualstudio.com/items?itemName=formulahendry.auto-rename-tag

https://marketplace.visualstudio.com/items?itemName=CoenraadS.bracket-pair-colorizer-2

https://marketplace.visualstudio.com/items?itemName=msjsdiag.debugger-for-chrome

https://marketplace.visualstudio.com/items?itemName=PKief.material-icon-theme

https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode

https://marketplace.visualstudio.com/items?itemName=ms-vscode.vscode-typescript-tslint-plugin

https://marketplace.visualstudio.com/items?itemName=infinity1207.angular2-switcher

https://marketplace.visualstudio.com/items?itemName=RedVanWorkshop.explorer-exclude-vscode-extension

# Useful web tools
https://randomuser.me/

https://www.json-generator.com/

https://jwt.io/

# Hints
## Use SSL in WSL and trust certs from Windows store

__Run on commandline (Windows 10)__

`dotnet dev-certs https --clean`

`dotnet dev-certs https --trust`

__Install certificate from course__ 

(see assets, section 1 in udemy course)

	1. Double click on the certificate (server.crt)
	2. Click on the button “Install Certificate …”
	3. Select whether you want to store it on user level or on machine level
	4. Click “Next”
	5. Select “Place all certificates in the following store”
	6. Click “Browse”
	7. Select “Trusted Root Certification Authorities”
	8. Click “Ok”
	9. Click “Next”
	10. Click “Finish”


__Run on commandline with admin privileges (Windows 10)__
	
`dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\aspnetapp.pfx -p <cryptic-password>`

__Run on WSL (Z-Shell)__

Add to `~/.zshrc` (or `~/.bashrc` in case of Bash)

    export ASPNETCORE_Kestrel__Certificates__Default__Password="<cryptic-password>" 
    export ASPNETCORE_Kestrel__Certificates__Default__Path=/mnt/c/Users/user-name/.aspnet/https/aspnetapp.pfx
	
