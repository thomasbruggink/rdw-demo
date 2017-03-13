FROM microsoft/windowsservercore

# Download files
ADD https://artifacts.elastic.co/downloads/kibana/kibana-5.2.2-windows-x86.zip c:/kibana.zip
 
RUN powershell Expand-Archive c:/kibana.zip -DestinationPath c:/tools

ADD ./Files/kibana.yml c:/tools/kibana-5.2.2-windows-x86/config/kibana.yml

EXPOSE 5601

CMD C:/tools/kibana-5.2.2-windows-x86/bin/kibana.bat