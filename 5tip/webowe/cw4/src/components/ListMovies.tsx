
import {  useState } from 'react'
import { Movie } from '../models/movies'

type Props = {
    movies: Movie[]
}

const ListMovies = ({ movies }: Props) => {

    const [text, setText] = useState('tu będzie wyświetlony opis filmu');


    function handleOnClick(id:number): void {
        setText(`Tytuł: ${movies[id].title}, Reżyser: ${movies[id].director}, Rok produkcji: ${movies[id].year}`);
    }

    return (
        <>
        <div className='border p-2'>{text}</div>
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
                    <tr style={{cursor:"pointer"}} onClick={()=>handleOnClick(id)} key={id}>
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