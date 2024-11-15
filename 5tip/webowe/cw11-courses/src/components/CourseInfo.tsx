import { Course } from "../Data/courses-data"


type Props = {
    selectedCourse:Course;
}

const CourseInfo = ({selectedCourse}: Props) => {
  return (
    <main style={{border:"solid 1px grey",padding:"10px",backgroundColor:"lightseagreen"}}>
        <img src={selectedCourse.img} alt="obrazek"  style={{float:"left"}}/>
        <h3>Szczegóły wybranego kursu</h3>
        <h5>{selectedCourse.title}</h5>
        <h6>Miejsce kursu: {selectedCourse.place}</h6>
        <article>Cena kursu: {selectedCourse.price} zł</article>
        <article>Data kursu: {selectedCourse.data.toLocaleDateString()}</article>
    </main>
  )
}

export default CourseInfo