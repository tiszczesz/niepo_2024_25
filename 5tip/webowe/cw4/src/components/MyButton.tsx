import { ReactElement, ReactNode, useState } from "react"


type Props = {
    text:string,
    label?:string,
    children?:ReactNode
}

const MyButton = ({text,label,children}: Props) => {
    const [result, setResult] = useState('')
    

  return (
    <>
     <button onClick={()=>setResult(`to jest napis: ${text}`)}>{label}</button>
     {children && <div style={{border:"solid 1px red",padding:"10px"}}>{children}</div>}
      
     <div>{result}</div>
    </>
   
  )
}

export default MyButton