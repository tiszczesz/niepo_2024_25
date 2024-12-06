<?php
if (!isset($_GET['page']) || $_GET['page'] !== 'about') {
    header('Location: layout.php?page=home');
    exit();
}


$html = <<<html

<h1>Strona O firmie</h1>
<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam sint est velit possimus sit repudiandae dolorum quae! Perferendis dignissimos quam odit ullam esse, consectetur similique perspiciatis facere libero recusandae!</p>
<div>
    <h2>Lista pracowników</h2>
    <ul>
        <li>Jan Kowalski</li>
        <li>Anna Nowak</li>
        <li>Adam Małysz</li>
    </ul>
    <img src="images/firma.jpg" alt="firma">
</div>
html;
