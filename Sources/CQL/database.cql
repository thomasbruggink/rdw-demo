CREATE KEYSPACE rdwdemo WITH replication = {'class': 'SimpleStrategy', 'replication_factor': '1'}  AND durable_writes = true;

CREATE TABLE rdwdemo.blogs (
    id timeuuid PRIMARY KEY,
    title text,
    content text,
    writer text,
    date timestamp
);

CREATE TABLE rdwdemo.users (
    username text PRIMARY KEY,
    password ascii,
    salt ascii
);