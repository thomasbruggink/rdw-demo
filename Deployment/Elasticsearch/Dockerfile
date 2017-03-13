FROM demo1/base

ADD https://artifacts.elastic.co/downloads/elasticsearch/elasticsearch-5.2.2.zip c:/elasticsearch.zip
RUN powershell Expand-Archive c:\elasticsearch.zip -DestinationPath c:\tools
ADD ./Files/elasticsearch.yml c:/tools/elasticsearch-5.2.2/config/elasticsearch.yml

EXPOSE 9200 9300

CMD C:\tools\elasticsearch-5.2.2\bin\elasticsearch.bat