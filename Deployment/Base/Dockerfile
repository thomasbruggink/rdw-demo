FROM microsoft/windowsservercore

#The default shell to execute commands
SHELL ["powershell"]

#Download and install the java runtime
ADD http://javadl.oracle.com/webapps/download/AutoDL?BundleId=210185 C:/jre-8u91-windows-x64.exe
RUN start-process -filepath C:\jre-8u91-windows-x64.exe -passthru -wait -argumentlist "/s,INSTALLDIR=c:\Java\jre1.8.0_91,/L,install64.log"
RUN setx JAVA_HOME 'C:\Java\jre1.8.0_91' /M

#Extract 7zip
ADD http://www.7-zip.org/a/7z1604-x64.exe C:/7zip.exe
RUN start-process -filepath C:\7zip.exe -passthru -wait -argumentlist "/S,/D=C:\7zip"

RUN setx PATH ($env:path + ';c:\7zip;C:\Java\jre1.8.0_91\bin') /M

#Cleanup
RUN rm C:\jre-8u91-windows-x64.exe -force
RUN rm C:\7zip.exe -force