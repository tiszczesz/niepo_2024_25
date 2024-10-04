import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle.min'
import { defs } from './data'
import './App.css'
import MySelect from './components/MySelect'

function App() {


  return (
    <div className='container'>
     <h1>Ćwiczenie 6</h1>
     <MySelect data={defs} />
    </div>
  )
}


export default App
