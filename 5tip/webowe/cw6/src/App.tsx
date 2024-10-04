import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle.min'
import { defs } from './data'
import './App.css'
import MySelect from './components/MySelect'
import MySelect2 from './components/MySelect2'

function App() {


  function handleSelect(elem: string): void {
    console.log(elem)
    document.body.style.backgroundColor = elem
  }

  return (
    <div className='container'>
     <h1>Ćwiczenie 6</h1>
     <MySelect data={defs} />
     <hr />
     <MySelect2 
     colors={['red', 'green', 'blue', 'yellow', 'purple']}
     selectOnChange={handleSelect} />
    </div>
  )
}


export default App
