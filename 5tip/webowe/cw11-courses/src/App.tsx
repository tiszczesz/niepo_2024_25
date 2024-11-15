import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import './App.css'
import CoursesList from './components/coursesList';
import { Course, courses } from './Data/courses-data';
import CourseInfo from './components/CourseInfo';
import { useState } from 'react';
function App() {
  const [selectedCourse, setSelectedCourse] = useState<Course>();

  function handleSelectedCourse(id: number): void {
    console.log(`Kliknięto kurs o id: ${id}`);
    const course = courses.find(course => course.id === id);//szukanie po id
    setSelectedCourse(course); //zmiana stanu wybranego kursu
   // selectedCourse = course; //to nie zadziała
  }

  return (
    <div className='container'>
      <h1 style={{ textAlign: "center", borderBottom: "solid 1px black" }}>Kursy dla programistów</h1>
      <section className='row'>
        <article className='col-5 m-1'>
          <CoursesList courses={courses} selectedCourse={handleSelectedCourse} />
        </article>
        <section className='col-6 m-1'>
          { selectedCourse && <CourseInfo selectedCourse={selectedCourse} />}
        </section>
      </section>

    </div>
  )
}

export default App
