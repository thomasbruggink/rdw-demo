FROM demo1/base

#Download and extract cassandra
ADD http://apache.cs.uu.nl/cassandra/3.10/apache-cassandra-3.10-bin.tar.gz C:/cassandra.tar.gz
RUN cmd.exe '/C 7z x "C:\cassandra.tar.gz" -so | 7z x -aoa -si -ttar -o"C:\"'
ADD ./Files/cassandra.yaml C:/apache-cassandra-3.10/conf/cassandra.yaml


WORKDIR C:/apache-cassandra-3.10/bin

EXPOSE 9042

CMD .\cassandra.bat