<?php
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
   // var_dump($_POST);
    require_once 'functions.php';
    $firstname = trim(filter_input(INPUT_POST, 'firstname'));
    // $firstname = trim($_POST['firstname']);
    $lastname = trim(filter_input(INPUT_POST, 'lastname'));
    $group = trim(filter_input(INPUT_POST, 'group'));
    if ($firstname === '' || $lastname === '' || $group === '') {
        header('Location: addForm.php');
        exit();
    }
    saveStudentToDb($firstname, $lastname, $group);
    header('Location: cw2.php');
} else {
    header('Location: addForm.php');
    echo 'Niepoprawne dane';
}
