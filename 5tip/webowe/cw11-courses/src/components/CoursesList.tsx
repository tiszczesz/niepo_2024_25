import { MouseEvent } from "react";
import { Course } from "../Data/courses-data";
import './CoursesList.module.css';

type Props = {
    courses: Course[];
    selectedCourse(id: number): void;
}

const CoursesList = ({ courses,selectedCourse }: Props) => {
  

    

    return (
        <>
            <h3>Dostępne kursy</h3>
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>Lp</th>
                        <th>Tytuł</th>
                        <th>Cena</th>
                        <th>Miejsce</th>
                        <th>Data</th>
                    </tr>
                </thead>
                <tbody>
                    {courses.map((course, index) => (
                        <tr key={course.id} onClick={() => selectedCourse(course.id)}>
                            <td>{index + 1}</td>
                            <td>{course.title}</td>
                            <td>{course.price}</td>
                            <td>{course.place}</td>
                            <td>{course.data.toLocaleDateString()}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </>
    )
}

export default CoursesList