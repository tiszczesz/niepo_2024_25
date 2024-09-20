import { useState } from "react"


type Props = {
    text:string,
    label?:string,
}

const MyButton = ({text,label}: Props) => {
    const [result, setResult] = useState('')
    

  return (
    <>
     <button onClick={()=>setResult(`to jest napis: ${text}`)}>{label}</button>
     <div>{result}</div>
    </>
   
  )
}

export default MyButton