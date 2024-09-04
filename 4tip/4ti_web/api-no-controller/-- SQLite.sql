-- SQLite
CREATE TABLE Movies(
 Id Integer PRIMARY KEY,
 Title text,
 Director text,
 Year text
 )
 INSERT INTO Movies (Id, Title, Director, Year) VALUES 
(1, 'Inception', 'Christopher Nolan', '2010'),
(2, 'The Godfather', 'Francis Ford Coppola', '1972'),
(3, 'Pulp Fiction', 'Quentin Tarantino', '1994'),
(4, 'The Shawshank Redemption', 'Frank Darabont', '1994'),
(5, 'The Dark Knight', 'Christopher Nolan', '2008'),
(6, 'Fight Club', 'David Fincher', '1999'),
(7, 'Forrest Gump', 'Robert Zemeckis', '1994'),
(8, 'The Matrix', 'Lana Wachowski, Lilly Wachowski', '1999'),
(9, 'The Lord of the Rings: The Return of the King', 'Peter Jackson', '2003'),
(10, 'Star Wars: Episode IV - A New Hope', 'George Lucas', '1977');