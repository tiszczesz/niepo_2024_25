import { useEffect, useState } from 'react'

import './App.css'

function App() {
  const [timer, setTimer] = useState(new Date().toLocaleTimeString());

  useEffect(() => {
    const interval = setInterval(() => {
      setTimer(new Date().toLocaleTimeString());
    }, 1000);

    return () => {
      clearInterval(interval);
    };
  }, [timer]);

  return (
    <>
      <div style={{
        fontSize:"6rem",
        backgroundColor:"#f1f1f1",
        padding:"20px",
        border:"1px solid black",
        borderRadius:"10px",
        }}>
        {timer}
      </div>
    </>
  )
}

export default App
