import { Item } from "../models/data"

type Props = {
    item:Item
}

const Colors = ({item}: Props) => {
    return (
        <>
            <h3 style={{ color: item.color }}>{item.text}</h3>
            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Odio obcaecati distinctio harum ea, non asperiores aliquid error, aut culpa, eveniet odit cupiditate reiciendis commodi. Laboriosam dolor dicta ratione distinctio eveniet!</p>
        </>
    )
}

export default Colors