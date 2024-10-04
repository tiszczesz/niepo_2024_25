import React from 'react'

type Props = {
    selectOnChange(elem:string): void
    colors: string[]
}

const MySelect2 = (props: Props) => {
  return (
    <div>
        <select onChange={(e)=>props.selectOnChange(e.target.value)}>
            {props.colors.map((color) => (
            <option key={color}>{color}</option>
            ))}
        </select>        
    </div>
  )
}

export default MySelect2