import 'bootstrap/dist/css/bootstrap.css';
import './App.css'
import { useState } from 'react';


function App() {
  console.log('App renderuje się');
  
  // Stan komponentu
  const [text,setText] = useState('stan początkowy122');
  const [number1,setNumber1] = useState('0');
  // text zmieniany jest przez input
  // stan komponentu jest aktualizowany przez funkcję setText
  // text = "ffffff"; // To jest niepoprawne, ponieważ nie można bezpośrednio modyfikować stanu w ten sposób
  // Poprawny sposób aktualizacji stanu to użycie funkcji setText
  // setText("ffffff"); // To jest poprawne, ponieważ używa funkcji do aktualizacji stanu
  return (
    <div className='container'>
     <h1>Praca ze stanem komponentu</h1>
     <input onChange={(e)=>{setText(e.target.value)}} type="text"className='form-control' value={text} />
    {text.toUpperCase()}
     <input onChange={(e)=>{setNumber1(e.target.value)}} 
     type="number"className='form-control' value={number1} />
    {number1}
    </div>
  )
}

export default App
