
import { Movie } from '../models/movies'

type Props = {
    movies: Movie[]
}

const ListMovies = ({ movies }: Props) => {
    return (
        <>
            <div>Lista filmów</div>
        <table className="table w-75">
            <thead>
                <tr>
                    <th scope="col">Tytuł</th>
                    <th scope="col">Reżyser</th>
                    <th scope="col">Rok produkcji</th>
                </tr>
            </thead>
            <tbody>
                {movies.map((movie,id) => (
                    <tr key={id}>
                        <td>{movie.title}</td>
                        <td>{movie.director}</td>
                        <td className='text-end'>{movie.year}</td>
                    </tr>
                ))}
            </tbody>
        </table>
        </>

    )
}

export default ListMovies