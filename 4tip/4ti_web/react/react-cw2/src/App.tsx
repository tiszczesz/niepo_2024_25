import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css'
import Info from './components/Info';

function App() {
  const names = ['Jan', 'Kasia', 'Marek', 'Ola', 'Tomek'];
  const randomColor = () => {
    const red = Math.floor(Math.random() * 256);
    const green = Math.floor(Math.random() * 256);
    const blue = Math.floor(Math.random() * 256);
    return `rgb(${red}, ${green}, ${blue})`;
  }
  return (
    <>
      <h1>Praca z komponentami i propsami</h1>
      <main>
        <h2>Lista imion</h2>
        <Info name={names[0]} />
        <Info name={names[1]} />
        <Info name={names[2]} />
        <hr />
        <h2>Za pomocą map</h2>
        {names.map((elem, i) => (
          <Info key={i} name={elem}
            color={randomColor()} />
        ))}
      </main>
    </>
  )
}

export default App
