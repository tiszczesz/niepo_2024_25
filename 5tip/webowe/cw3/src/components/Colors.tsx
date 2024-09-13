

type Props = {
    color: string;
    text: string;
}

const Colors = (props: Props) => {
    return (
        <>
            <h3 style={{ color: props.color }}>{props.text}</h3>
            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Odio obcaecati distinctio harum ea, non asperiores aliquid error, aut culpa, eveniet odit cupiditate reiciendis commodi. Laboriosam dolor dicta ratione distinctio eveniet!</p>
        </>
    )
}

export default Colors