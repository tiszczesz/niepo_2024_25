<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <title>Document</title>
</head>

<body>
    <?php
    if (isset($_POST['firstname'])) {
        $firstname = trim($_POST['firstname']);
        $lastname = trim($_POST['lastname']);
        $birthday = $_POST['birthDate'];
        $division = $_POST['division'];
        $gender = $_POST['gender'] === 'm' ? 'Mężczyzna' : 'Kobieta';
        if (isset($_POST['hobby'])) {
            $hobbies = $_POST['hobby'];
        } else {
            $hobbies = [];
        }
        if ($firstname !== '' && $lastname !== '') {
            echo "<h2>Witaj {$firstname} {$lastname}</h2>";
            echo "<div>Data urodzenia: {$birthday}</div>";
            echo "<div>Dział: {$division}</div>";
            echo "<div>Płeć: {$gender}</div>";
            if(count(($hobbies))){
                echo "<div>Zainteresowania: <ul>";
                foreach($hobbies as $hobby){
                    echo "<li>{$hobby}</li>";
                }
                echo "</ul></div>";
            }else{
                echo "<div style=\"color:red\">Brak zainteresowań</div>";
            }
        } else {
            echo "<h2>Witaj nieznajomy</h2>";
        }
    } else {
        echo "<h2>Witaj nieznajomy</h2>";
    }
    var_dump($_POST);

    ?>
</body>

</html>