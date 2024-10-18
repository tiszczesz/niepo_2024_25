
import { Link, Outlet } from 'react-router-dom'

type Props = {}

const Layout = (props: Props) => {
  return (
    <div className='container'>
        <nav>
            <ul className='nav-list'>
                <li> <Link to='/'>Home</Link> </li>
                <li> <Link to='about'>O nas</Link> </li>
                <li> <Link to='page1'>Strona 1</Link> </li>
                <li> <Link to='list'>Zwierzęta</Link> </li>
            </ul>
        </nav>
        <main>
            <Outlet />
        </main>
    </div>
  )
}

export default Layout