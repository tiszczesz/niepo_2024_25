import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import {movies} from './models/movies'
import './App.css'
import ListMovies from './components/ListMovies';

function App() {


  return (
    <>
      <ListMovies movies={movies} />
    </>
  )
}

export default App
