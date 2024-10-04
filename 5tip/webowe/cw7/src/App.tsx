
import { useState } from 'react'
import './App.css'
import Ranger from './components/Ranger'

function App() {
  const [red, setRed] = useState(0)
  const [green, setGreen] = useState(0)
  const [blue, setBlue] = useState(0)

  function handleOnChangeRed(value: number): void {
    setRed(value);
  }
  function handleOnChangeGreen(value: number): void {
    setGreen(value);
  }
  function handleOnChangeBlue(value: number): void {
    setBlue(value);
  }

  return (
    <>
      <Ranger info="red" rangeOnChange={handleOnChangeRed} /><br />
      <Ranger info="green" rangeOnChange={handleOnChangeGreen} /><br />
      <Ranger info="blue" rangeOnChange={handleOnChangeBlue} /><br />
      <hr />
      <section>Red: {red} Green: {green} Blue: {blue}</section>
      <div style={{
        height: '100px',
        width: '100px',
        border: '1px solid black',
        backgroundColor: `rgb(${red}, ${green}, ${blue})`
      }}></div>
    </>
  )
}

export default App
