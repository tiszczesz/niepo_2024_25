import { FormEvent, useState } from 'react';
import './Nwd.css'

type Props = {
    width: number;
    height: number;
}
function nwdIter(a: number, b: number): number {
    while (a != b) { //tradycyjna wersja Euklidesa
        if (a > b) {
            a -= b;
        } else {
            b -= a;
        }
    }
    return a;
}
const Nwd = ({ width, height }: Props) => {
    const [a, setA] = useState<number>(0);
    const [b, setB] = useState<number>(0);
    const [result, setResult] = useState<string>("Tu będzie wynik");
    function handleSubmit(e: FormEvent<HTMLFormElement>): void {
        e.preventDefault();
        setResult(`NWD(${a}, ${b}) = ${nwdIter(a, b)}`);
    }

    return (
        <section className="nwd-section"
            style={{
                width: width + 'px',
                height: height + 'px'
            }}>
            <h3>Obliczanie NWD</h3>
            <form onSubmit={(e) => handleSubmit(e)}>
                <div className="row m-3">
                    <label className='col-3 text-end' htmlFor="a">a = </label>
                    <input value={a}
                        onChange={(e) => setA(parseInt(e.target.value))}
                        type="number" id="a"
                        className='col-6' min={0} />{a}
                </div>
                <div className="row m-3">
                    <label className='col-3 text-end' htmlFor="b">b = </label>
                    <input value={b}
                        onChange={(e) => setB(parseInt(e.target.value))}
                        type="number" id="b"
                        className='col-6' min={0} />{b}
                </div>
                <div className="row m-3">
                    <input type="submit" className='col-6 offset-3 btn btn-primary'
                        value="Oblicz" />
                </div>
            </form>
            <div className="result">{result}</div>
        </section>
    )
}

export default Nwd