FROM microsoft/windowsservercore

SHELL ["powershell"]

RUN Install-WindowsFeature web-server
RUN Install-WindowsFeature Web-Asp-Net45
RUN Install-WindowsFeature Web-Scripting-Tools
RUN New-Item C:\Web -ItemType Directory

RUN Get-Website | where { $_.Name -eq 'Default Web Site' } | select -First 1 | Remove-Website
RUN New-WebAppPool -Name 'WebAppPool'
RUN New-Website -Name 'WebSite' -PhysicalPath C:\Web

ADD ./Files/Binaries C:/Web
ADD ./Files/application.conf C:/Web/
ADD ./Files/pause.ps1 C:/

CMD C:/pause.ps1