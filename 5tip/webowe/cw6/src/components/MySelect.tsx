
import { ChangeEvent, useState } from 'react'
import { BiolDefs } from '../data'

type Props = {
    data: BiolDefs[]
}

const MySelect = (props: Props) => {
    const [selected, setSelected] = useState<BiolDefs>({ def: "", info: "" })


    function handleSelectChange(e: ChangeEvent<HTMLSelectElement>): void {
        const current = props.data.find((elem) => elem.def === e.target.value)
        if (current) setSelected(current)
    }

    return (
        <section className='d-flex m-3 gap-3' >
            <select value={selected.def} onChange={(e) => handleSelectChange(e)}>
                {props.data.map((elem) => (
                    <option key={elem.def}>{elem.def}</option>
                ))}
            </select>
            <article style={
                {
                    border: "solid black 1px",
                    minWidth: "300px",
                    padding: "0.5rem",
                }}>
                {selected.info}
            </article>
        </section>
    )
}

export default MySelect

