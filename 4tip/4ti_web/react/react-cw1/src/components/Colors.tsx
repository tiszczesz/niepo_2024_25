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
                {colors.map((color, index) => (
                    <option key={index} value={color}>{color}</option>
                ))}
            </select>
            <hr />
            {colors.map((c, index) => (
                <div
                    style={{
                        color: c
                    }}
                    key={index}>{c}</div>
            ))}
            <hr />
            {colors.map((c, index) => (
                <span
                    style={{
                        color: c,
                        width: "100px",
                        height: "100px",
                        backgroundColor: c,
                        borderRadius: "50%",
                        display: "inline-block",
                        margin: "5px",
                        border: "1px solid black",
                    }}
                    key={index}></span>
            ))}
        </div>
    )
}

export default Colors