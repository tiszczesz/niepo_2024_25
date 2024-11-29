-- SQLite
CREATE TABLE cars (
    id INTEGER PRIMARY KEY,
    name TEXT,
    brand TEXT,
    price float,
    year INTEGER
);
INSERT INTO cars (name, brand, price, year) VALUES ('Aventador', 'Lamborghini', 500000, 2019);
INSERT INTO cars (name, brand, price, year) VALUES ('Huracan', 'Lamborghini', 250000, 2019);
INSERT INTO cars (name, brand, price, year) VALUES ('488', 'Ferrari', 300000, 2019);
INSERT INTO cars (name, brand, price, year) VALUES ('F8', 'Ferrari', 350000, 2019);
INSERT INTO cars (name, brand, price, year) VALUES ('720s', 'McLaren', 300000, 2019);
INSERT INTO cars (name, brand, price, year) VALUES ('GT', 'Ford', 50000, 2019);
INSERT INTO cars (name, brand, price, year) VALUES ('Corvette', 'Chevrolet', 60000, 2019);