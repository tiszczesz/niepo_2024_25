<?php

function getPage(string $page) : string {
    switch($page){
        case 'home':
            include 'home.php';
            return $html;
        case 'form':
            return 'form.php';
        case 'about':
            return 'about.php';
        default:
            return 'home.php';
    }
    
}