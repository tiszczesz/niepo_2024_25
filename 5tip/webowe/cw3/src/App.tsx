import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import { items } from './models/data';
import './App.css'
import Colors from './components/Colors';

function App() {

  return (
    <div className='container'>
      <ol className='list-group'>
        {/* <li className='list-group-item'>
          <Colors item={items[0]} />
        </li>
        <li className='list-group-item'>
          <Colors item={items[1]} />
        </li>
        <li className='list-group-item'>
          <Colors item={items[2]} />
        </li>
        <li className='list-group-item'>
          <Colors item={items[3]} />
        </li>
        <li className='list-group-item'>
          <Colors item={items[4]} />
        </li> */}
        {items.map((item, index) => (
          <li style={{ cursor: "pointer", margin: "10px" }}
            key={index}
            onClick={() => console.log(item.text)}
            className='list-group-item'>
            <Colors item={item} />
          </li>
        ))}



      </ol>
    </div>
  )
}

export default App
