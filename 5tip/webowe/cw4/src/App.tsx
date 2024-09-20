import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import {movies} from './models/movies'
import './App.css'
import ListMovies from './components/ListMovies';
import MyButton from './components/MyButton';

function App() {


  return (
    <>
      <ListMovies movies={movies} />
      {/* Utwórz komponent z div i button  przesyłanie props text do komponentu po naciśnięciu przycisku
       text pojawia sie w div /> */}
       <MyButton text='Hello World' label='przycisk 1'/>
       <MyButton text='ala ma kota' label='przycisk 2'/>
       <MyButton text='Zaraz idziemy' label='przycisk 3'/>
    </>
  )
}

export default App
