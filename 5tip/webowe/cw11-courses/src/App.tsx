import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import './App.css'
import CoursesList from './components/coursesList';
import { courses } from './Data/courses-data';
function App() {


  function handleSelectedCourse(id: number): void {
    console.log(`Kliknięto kurs o id: ${id}`);
  }

  return (
    <div className='container'>
      <h1 style={{ textAlign: "center", borderBottom: "solid 1px black" }}>Kursy dla programistów</h1>
      <section className='row'>
        <article className='col-6'>
          <CoursesList courses={courses} selectedCourse={handleSelectedCourse} />
        </article>
        <section className='col-6'>
          TODO
        </section>
      </section>

    </div>
  )
}

export default App
