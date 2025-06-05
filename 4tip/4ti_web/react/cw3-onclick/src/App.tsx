
import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import type { MouseEvent } from 'react'

function App() {


  function handeFulllYES(event: MouseEvent<HTMLButtonElement>): void {
    console.log("TAK")
  }

  function handleFullNO(event: MouseEvent<HTMLButtonElement>): void {
    console.log("TAK")
  }

  // function handelYES(): void {
  //   console.log("TAK")
  // }

  // function handleNO(): void {
  //   console.log("NIE")
  // }

  return (
    <>
      <h2 className='header'>Hello</h2>
      <h5>Czy fajnie było na praktykach?</h5>
      {/* <div className='d-flex gap-2 p-2'>
        <button onClick={()=>console.log("TAK")} className='btn btn-success w-50'>TAK</button>
        <button onClick={()=>console.log("NIE")} className='btn btn-success w-50'>NIE</button>
      </div> */}
      {/* <div className='d-flex gap-2 p-2'>
        <button onClick={()=>handelYES()} className='btn btn-success w-50'>TAK</button>
        <button onClick={()=>handleNO()} className='btn btn-success w-50'>NIE</button>
      </div> */}
      <div className='d-flex gap-2 p-2'>
        <button onClick={(event) => handeFulllYES(event)} className='btn btn-success w-50'>TAK</button>
        <button onClick={handleFullNO} className='btn btn-success w-50'>NIE</button>
      </div>
    </>
  )
}
``
export default App
