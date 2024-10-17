import './MyForm1.css'

type Props = {
    title: string;
}

const MyForm1 = (props: Props) => {
  return (
    <>
    <h3>{props.title}</h3>
    <form >
        <input type="text" name="firstname" placeholder="podaj imię" /><br />
        <input type="text" name="lastname" placeholder="podaj nazwisko" /><br />
        <input type="date" name="dateB"   /><br />
        <input type="number" name="salary" placeholder="podaj pensję" /><br />
        <input type="submit" value="Wyślij" />
    </form>
    </>
  )
}

export default MyForm1