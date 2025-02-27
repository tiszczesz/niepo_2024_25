-- SQLite
CREATE TABLE IF NOT EXISTS "products" (
    "id" INTEGER PRIMARY KEY,
    "name" TEXT NOT NULL,
    "description" TEXT NOT NULL,
    "price" REAL NOT NULL
);
INSERT INTO "products" ("name", "description", "price") VALUES
('Laptop', 'High performance laptop', 999.99),
('Smartphone', 'Latest model smartphone', 699.99),
('Headphones', 'Noise-cancelling headphones', 199.99),
('Smartwatch', 'Water-resistant smartwatch', 149.99),
('Tablet', '10-inch display tablet', 329.99),
('Camera', 'Digital SLR camera', 499.99),
('Printer', 'Wireless color printer', 89.99),
('Monitor', '27-inch 4K monitor', 399.99),
('Keyboard', 'Mechanical keyboard', 79.99),
('Mouse', 'Wireless ergonomic mouse', 49.99);
