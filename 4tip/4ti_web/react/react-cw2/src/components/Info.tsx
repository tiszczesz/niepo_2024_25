

type Props = {
    name: string,
    color?:string
}

const Info = (props: Props) => {
    return (
        <section style={{
            border: '1px solid black',
            padding: '10px',
            margin: '10px',
            backgroundColor: props.color 
            ? props.color : 'white',
        }}>
            <h4>Informacja o użytkowniku</h4>
            <p>Imię: {props.name}</p>
        </section>
    )
}

export default Info