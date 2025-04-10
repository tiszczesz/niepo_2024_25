import { colors } from "../data/colors"
function Colors() {
    // const colorList = [];
    // for(let color of colors) {
    //     colorList.push(<option key={color} value={color}>{color}</option>)
    // }
  return (
    <div>
        <h5>Lista kolorów</h5>
        <select>
            {colors.map((color,index)=>(
                <option key={index} value={color}>{color}</option>
            ))}
        </select>
    </div>
  )
}

export default Colors