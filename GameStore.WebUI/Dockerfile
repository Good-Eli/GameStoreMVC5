FROM mcr.microsoft.com/dotnet/framework/aspnet
ARG source
RUN powershell -Command msbuild .\GameStore.WebUI\GameStore.WebUI.csproj /t:Package
WORKDIR /inetpub/wwwroot
COPY GameStore.WebUI/obj/Debug/Package/PackageTmp .
