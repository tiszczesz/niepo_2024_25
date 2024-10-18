import React from 'react'

type Props = {
    title: string;
    list: string[];
}

function SearchList({ title, list }: Props) {
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