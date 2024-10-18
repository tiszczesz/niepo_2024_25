-- SQLite
CREATE TABLE Animals(
    id Integer PRIMARY KEY,
    name Text,
    species Text,
    age Integer,
    weight Real
)

INSERT INTO Animals (id, name, species, age, weight) VALUES
(1, 'Bella', 'Dog', 3, 20.5),
(2, 'Max', 'Cat', 2, 4.3),
(3, 'Charlie', 'Rabbit', 1, 1.2),
(4, 'Lucy', 'Dog', 5, 25.0),
(5, 'Milo', 'Cat', 4, 4.7),
(6, 'Luna', 'Rabbit', 2, 1.5),
(7, 'Rocky', 'Dog', 6, 30.2),
(8, 'Oliver', 'Cat', 3, 5.1),
(9, 'Daisy', 'Rabbit', 1, 1.3),
(10, 'Buddy', 'Dog', 4, 22.8);