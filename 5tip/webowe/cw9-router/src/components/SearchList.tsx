import React from 'react';
import { Animals } from '../animals';

type Props = {
    title: string;    
}

function SearchList({ title}: Props) {
    const [list, setList] = React.useState(Animals);
    return (
        <div>
            <h2>{title}</h2>
            <input type="text" placeholder='wybierz zwierzę' />
            <ul>
                {list.map((item, index) => (
                    <li key={index}>{item}</li>
                ))}
            </ul>
        </div>
    )
}

export default SearchList