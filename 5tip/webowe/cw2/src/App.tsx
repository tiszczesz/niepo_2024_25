import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import rowerek from './assets/rower2.jpg';
import CompWithChildren from './components/CompWithChildren';
function App() {


  return (
    <div className='container'>
      <h1>Aplikacja z bootstrapem</h1>
      <CompWithChildren >
        <p>Jest dziecko</p>
      </CompWithChildren>
      <hr />
      <CompWithChildren>
        <ol>
          <li>asas</li>
          <li>sadsad</li>
          <li>asdsad</li>
        </ol>
      </CompWithChildren>
      <hr />
      <CompWithChildren color='red'>
        <p>ala ma kota</p>
        <p>ala ma kota</p>
      </CompWithChildren>
      <CompWithChildren color='yellow'>
        <img src={rowerek} alt="rower" />
      </CompWithChildren>
    </div>
  )
}

export default App
