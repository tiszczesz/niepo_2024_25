import csharp from '../assets/c#.jpg';
import java from '../assets/java.png';
import js from '../assets/js.png';
import kotlin from '../assets/kotlin.png';
import cpp from '../assets/cpp.png';
import ts from '../assets/ts.png';
export type Course = {
    id: number;
    title: string;    
    img: string;
    price: number;
    place: string;
    data:Date;
}
export const courses = [
    {
        id: 1,
        title: 'C# od podstaw',
        img: csharp,
        price: 100,
        place: 'Warszawa',
        data: new Date(2021, 10, 1)
    },
    {
        id: 2,
        title: 'Java od podstaw',
        img: java,
        price: 150,
        place: 'Kraków',
        data: new Date(2021, 10, 15)
    },
    {
        id: 3,
        title: 'TypeScript od podstaw',
        img: ts,
        price: 200,
        place: 'Gdańsk',
        data: new Date(2021, 10, 30)
    },
    {
        id: 4,
        title: 'Kotlin od podstaw',
        img: kotlin,
        price: 250,
        place: 'Wrocław',
        data: new Date(2021, 11, 15)
    },
    {
        id: 5,
        title: 'JS od podstaw',
        img: js,
        price: 300,
        place: 'Poznań',
        data: new Date(2021, 11, 30)
    },
    {
        id: 6,
        title: 'C++ od podstaw',
        img: cpp,
        price: 350,
        place: 'Szczecin',
        data: new Date(2021, 12, 15)
    },
   
];