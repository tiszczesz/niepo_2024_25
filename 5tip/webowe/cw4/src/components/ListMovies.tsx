
import { MouseEvent } from 'react'
import { Movie } from '../models/movies'

type Props = {
    movies: Movie[]
}

const ListMovies = ({ movies }: Props) => {
    function handleOnClick(e: MouseEvent<HTMLTableRowElement>): void {
        console.log(e.currentTarget.innerText);        
    }

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
                    <tr style={{cursor:"pointer"}} onClick={(e)=>handleOnClick(e)} key={id}>
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