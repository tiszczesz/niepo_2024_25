<?php
if(filter_has_var(INPUT_GET, 'id')){
    require_once 'functions.php';
    $id = filter_input(INPUT_GET, 'id', FILTER_SANITIZE_NUMBER_INT);
    deleteStudentFromDB($id);
    header('Location: cw2.php');
}