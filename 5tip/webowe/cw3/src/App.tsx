import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import './App.css'
import Colors from './components/Colors';

function App() {

  const items = [
    { text: "To jest fajny tekst", color: "red" },
    { text: "ala ma kota", color: "green" },
    { text: "Zaraz weekend", color: "blue" },
    { text: "Ale tylko dwa dni", color: "purple" },
  ]

  return (
    <div className='container'>
      <ol className='list-group'>
        <li className='list-group-item'>
          <Colors text={items[0].text} color={items[0].color} />
        </li>
        <li className='list-group-item'>
          <Colors text={items[1].text} color={items[1].color} />
        </li>
        <li className='list-group-item'>
          <Colors text={items[2].text} color={items[2].color} />
        </li>
        <li className='list-group-item'>
          <Colors text={items[3].text} color={items[3].color} />
        </li>
      </ol>
    </div>
  )
}

export default App
