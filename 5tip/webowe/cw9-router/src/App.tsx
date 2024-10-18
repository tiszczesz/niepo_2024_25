import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';

import './App.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Layout from './components/Layout';
import About from './components/About';
import Page1 from './components/Page1';
import Home from './components/Home';
import SearchList from './components/SearchList';
import { Animals } from './animals';

function App() {


  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />} >
          <Route path='about' element={<About />} />
          <Route path='page1' element={<Page1 />} />
          <Route path='home' element={<Home />} />
          <Route path='list' element={<SearchList title='Zwierzęta' list={Animals} />} />
        </Route>
      </Routes>
    </BrowserRouter>
  )
}

export default App
