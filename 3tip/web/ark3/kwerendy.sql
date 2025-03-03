SELECT ogloszenie.tresc, uzytkownik.imie,uzytkownik.nazwisko ,kategoria.nazwa,podkategoria.nazwa
from ogloszenie INNER JOIN uzytkownik 
on ogloszenie.uzytkownik_id=uzytkownik.id
INNER join kategoria on ogloszenie.kategoria=kategoria.id
INNER join podkategoria on ogloszenie.podkategoria=podkategoria.id;