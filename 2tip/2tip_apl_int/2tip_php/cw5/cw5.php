<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ćwiczenie 5</title>
</head>

<body>
    <h1>Ćwiczenie 5</h1>
    <?php
    include 'functions.php';
    // include_once 'functions.php';
    // require 'functions.php';
    // require_once 'functions.php';
    function Hello(): void
    {
        echo "<h3>Hello, World!</h3>";
    }
    function Hello2(string $message): void
    {
        print_r("<h3>Hello: {$message}</h3>");
    }

    // function Hello3(int $a,int $b) {
    //     return $a + $b;
        
    // }
    Hello();
    Hello2("PHP");
    // Hello2(345);
    // Hello2(true);
    echo Hello3("John", true);
    echo Hello3("Ann", false);

    function Hello3(string $firstname, bool $isStudent): string
    {
        return $isStudent ? "Hello, {$firstname}! You are a student. <br>"
            : "Hello, {$firstname}! You are not a student. <br>";
    }

    echo NwdRec(12, 8);
    ?>
    <!-- Napisac 2 funkcje NwdRec i NwdIter -->
</body>

</html>