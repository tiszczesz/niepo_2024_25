import './Nwd.css'

type Props = {
    width: number;
    height: number;
}

const Nwd = ({ width, height }: Props) => {
    return (
        <section className="nwd-section"
            style={{
                width: width + 'px',
                height: height + 'px'
            }}>
            <h3>Obliczanie NWD</h3>
        </section>
    )
}

export default Nwd