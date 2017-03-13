FROM demo1/base

#The default shell to execute commands
SHELL ["powershell"]

#Download and extract cassandra
ADD http://apache.cs.uu.nl/cassandra/3.10/apache-cassandra-3.10-bin.tar.gz C:/cassandra.tar.gz
RUN cmd.exe '/C 7z x "C:\cassandra.tar.gz" -so | 7z x -aoa -si -ttar -o"C:\"'

#The default shell to execute commands
SHELL ["cmd"]
WORKDIR C:/apache-cassandra-3.10/bin
CMD java cassandra