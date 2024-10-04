
type Props = {
    info: string,
    rangeOnChange: (value: number) => void
}

const Ranger = ({ info, rangeOnChange }: Props) => {
    return (
        <div>
            <label >{info}</label>
            <input type="range" min={0} max={255} 
                onChange={(e) => rangeOnChange(parseInt(e.target.value))} />
        </div>
    )
}

export default Ranger