const movies = [
    {
        title: "Inception",
        director: "Christopher Nolan",
        year: 2010
    },
    {
        title: "The Matrix",
        director: "Lana Wachowski, Lilly Wachowski",
        year: 1999
    },
    {
        title: "Parasite",
        director: "Bong Joon-ho",
        year: 2019
    },
    {
        title: "The Godfather",
        director: "Francis Ford Coppola",
        year: 1972
    },
    {
        title: "Pulp Fiction",
        director: "Quentin Tarantino",
        year: 1994
    },
    {
        title: "The Dark Knight",
        director: "Christopher Nolan",
        year: 2008
    },
    {
        title: "Fight Club",
        director: "David Fincher",
        year: 1999
    },
    {
        title: "Forrest Gump",
        director: "Robert Zemeckis",
        year: 1994
    },
    {
        title: "The Shawshank Redemption",
        director: "Frank Darabont",
        year: 1994
    },
    {
        title: "Interstellar",
        director: "Christopher Nolan",
        year: 2014
    }
];

console.log(movies);



function generTabMovies(data, elem) {
    const table = document.createElement("table");
    table.className = "table table-striped";
    table.insertRow().innerHTML = "<th>Lp</th><th>Tytuł</th><th>Reżyser</th><th>Rok produkcji</th>";
    let lp = 0;
    for (const movie of data) {
        const row = table.insertRow();
        row.innerHTML = `<td>${++lp}</td>
                        <td>${movie.title}</td>
                       <td>${movie.director}</td>
                       <td>${movie.year}</td>`;
    }
    elem.appendChild(table);
}
const elem = document.querySelector("#result");
generTabMovies(movies, elem);