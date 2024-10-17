
import { FormEvent, useState } from 'react';
import './MyForm1.css'

type Props = {
    title: string;
}

const MyForm1 = (props: Props) => {

    const [result, setResult] = useState<string>('');
    function handleSubmit(event: FormEvent<HTMLFormElement>): void {
        event.preventDefault();
        const form = event.currentTarget;
        const formData = new FormData(form);
        console.log(formData);
        console.log(formData.entries());
        const data = Object.fromEntries(formData.entries()) as { [key: string]: string };
        console.log(data.firstname);
        console.log(data.lastname);
        console.log(data.dateB);
        console.log(data.salary);
        console.log(data);
        setResult(JSON.stringify(data));
    }

    return (
        <>
            <h3>{props.title}</h3>
            <form onSubmit={handleSubmit} >
                <input type="text" name="firstname" placeholder="podaj imię" /><br />
                <input type="text" name="lastname" placeholder="podaj nazwisko" /><br />
                <input type="date" name="dateB" /><br />
                <input type="number" name="salary" placeholder="podaj pensję" /><br />
                <input type="submit" value="Wyślij" />
            </form>
            <div>
                {result}
            </div>
        </>
    )
}

export default MyForm1