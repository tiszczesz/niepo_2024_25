-- SQLite
CREATE TABLE Product(
    id INTEGER PRIMARY KEY,
    name TEXT,
    price decimal(10,2),
    description TEXT
)
INSERT INTO Product(name,price,description)
VALUES('Apple', 1.00, 'A red apple'),
('Banana', 0.50, 'A yellow banana'),
('Cherry', 0.25, 'A red cherry'),
('Date', 0.10, 'A brown date'),
('Elderberry', 0.05, 'A black elderberry')