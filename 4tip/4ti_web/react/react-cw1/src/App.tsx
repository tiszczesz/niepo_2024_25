import './App.css'
import obrazek from './assets/react.svg'
import Colors from './components/Colors'
import First from './components/First'
import Welcome from './components/Welcome'
function App() {
  

  return (  
    <>
    <img src="/vite.svg" alt="ffff" />
    <h1>To jest to!!!</h1>
    <p>sdfdsfs s fsd</p>
    <img src={obrazek} alt="saad" />
    <div>{obrazek}</div>
    <hr />
    <First />
    <Welcome />
    <Colors />
    </> 
  )
}

export default App
