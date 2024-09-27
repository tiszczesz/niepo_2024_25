import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';

import './App.css'
import Nwd from './components/Nwd';

function App() {


  return (
    <main className='container'>
      <h2>Ćwiczenie 5</h2>
      <Nwd width={300} height={400} />
    </main>
  )
}

export default App
