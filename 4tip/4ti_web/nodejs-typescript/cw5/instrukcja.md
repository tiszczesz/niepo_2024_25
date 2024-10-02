## Utworzyć projekt w Type Script

```ts
const type   Movie {
    id: number;
    title: string;
    director: string;
    year: number;
}

const movies: Movie[] = [
    { id: 1, title: "Inception", director: "Christopher Nolan", year: 2010 },
    { id: 2, title: "The Matrix", director: "Lana Wachowski, Lilly Wachowski", year: 1999 },
    { id: 3, title: "Interstellar", director: "Christopher Nolan", year: 2014 },
    { id: 4, title: "The Godfather", director: "Francis Ford Coppola", year: 1972 },
    { id: 5, title: "Pulp Fiction", director: "Quentin Tarantino", year: 1994 },
    { id: 6, title: "The Dark Knight", director: "Christopher Nolan", year: 2008 },
    { id: 7, title: "Fight Club", director: "David Fincher", year: 1999 },
    { id: 8, title: "Forrest Gump", director: "Robert Zemeckis", year: 1994 },
    { id: 9, title: "The Shawshank Redemption", director: "Frank Darabont", year: 1994 },
    { id: 10, title: "The Lord of the Rings: The Return of the King", director: "Peter Jackson", year: 2003 }
];


```

## napisać skrypt

generujący tabelke bootstrapową z danymi z pliku Data.ts po naciśnięciu przycisku na stronie
