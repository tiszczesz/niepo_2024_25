<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h3>Przesłany plik</h3>
    <pre>
    <?php
    $isOK = 1;
    var_dump(scandir(__DIR__ ));
    if (isset($_POST['submit'])) {
        // var_dump(__DIR__);
        $target_dir = __DIR__ . "/uploads/";
        $target_file = $target_dir . basename($_FILES["fileToUpload"]["name"]);
        //var_dump($target_dir);
        //var_dump($target_file);
        $check = getimagesize($_FILES["fileToUpload"]["tmp_name"]);
        //czy plik jest obrazem
        if ($check !== false) {
            echo "Plik jest obrazem - " . $check["mime"] . ".";
            $isOK = 1;
        } else {
            echo "Plik nie jest obrazem";
            $isOK = 0;
        }
        //czy plik istnieje
        if (file_exists($target_file)) {
            echo "Plik już istnieje";
            $isOK = 0;
        }
        //czy plik jest za duży
        if ($_FILES["fileToUpload"]["size"] > 5000000) {
            echo "Plik jest za duży";
            $isOK = 0;
        }
        //sprawdzenie typu pliku
        $imageFileType = strtolower(pathinfo($target_file, PATHINFO_EXTENSION));
        if (
            $imageFileType != "jpg" && $imageFileType != "png" && $imageFileType != "jpeg"
            && $imageFileType != "gif"
        ) {
            echo "Dozwolone są tylko pliki JPG, JPEG, PNG & GIF";
            $isOK = 0;
        }
        //przesyłanie pliku
        if ($isOK == 1) {
            var_dump($target_file);
            var_dump($_FILES["fileToUpload"]["tmp_name"]);
            if (move_uploaded_file($_FILES["fileToUpload"]["tmp_name"], $target_file)) {
                echo "Plik " . htmlspecialchars(basename($_FILES["fileToUpload"]["name"])) . " został przesłany.";
            } else {
                echo "Wystąpił błąd podczas przesyłania pliku";
            }
        }
        var_dump($check);
    } else {
        echo "Nie przesłano pliku";
        $isOK = 0;
    }

    var_dump($_FILES);
    //var_dump($_POST);

    ?>
    </pre>
</body>

</html>