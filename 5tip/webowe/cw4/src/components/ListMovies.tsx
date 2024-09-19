
import { Movie } from '../models/movies'

type Props = {
    movies: Movie[]
}

const ListMovies = ({ movies }: Props) => {
    return (
        <>
            <div>Lista filmów</div>
            {/*utworzyc tabelke html z filmami z propsa movies */}
        </>

    )
}

export default ListMovies