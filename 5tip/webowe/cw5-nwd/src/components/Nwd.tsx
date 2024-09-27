import { FormEvent, useState } from 'react';
import './Nwd.css'

type Props = {
    width: number;
    height: number;
}
function nwdIter(a: number, b: number): number {
    while (b != 0) {
        let temp = a % b;
        a = b;
        b = temp;
    }
    return a;
}
const Nwd = ({ width, height }: Props) => {
    const [a, setA] = useState<number>(0);
    const [b, setB] = useState<number>(0);
    const [result, setResult] = useState<string>("Tu będzie wynik");
    function handleSubmit(e: FormEvent<HTMLFormElement>): void {
        e.preventDefault();
        if (isNaN(a) || isNaN(b)) return setResult("Podaj liczby całkowite");
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
                        onChange={(e) => {
                            if (isNaN(parseInt(e.target.value))) {
                                setA(0);
                            } else {

                            } setA(parseInt(e.target.value))
                        }
                        }
                        type="number" id="a"
                        className='col-6' min={0} />{a}
                </div>
                <div className="row m-3">
                    <label className='col-3 text-end' htmlFor="b">b = </label>
                    <input value={b}
                        onChange={(e) => {
                            if (isNaN(parseInt(e.target.value))) {
                                setB(0);
                            } else {

                            } setB(parseInt(e.target.value))
                        }}
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