<?php

function getPage(string $page): string
{
    switch ($page) {
        case 'home':
            include 'home.php';
            return $html;
        case 'form':
            include 'form.php';
            return $html;
        case 'about':
            include 'about.php';
            return $html;
        default:
            return 'home.php';
    }
}

//if(!isset($_GET['page'])){

//}