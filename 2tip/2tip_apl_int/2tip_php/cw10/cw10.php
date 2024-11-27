<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    //do select
    require_once('functions.php');
    $drinks = getDrinks();
    echo generSelect($drinks, 'drink');
    //wielolinijkowy string w jednym echo
    echo <<< TABLE
 <table>
        <tr>
            <td>3</td>
            <td>4</td>
            <td>4</td>
            <td>5</td>
        </tr>
        <tr>
            <td>3</td>
            <td>5</td>
            <td>6</td>
            <td>6</td>
        </tr>
        <tr>
            <td>3</td>
            <td>6</td>
            <td>6</td>
            <td>6</td>
        </tr>
        <tr>
            <td>3</td>
            <td>6</td>
            <td>4</td>
            <td>4</td>
        </tr>
        <tr>
            <td>3</td>
            <td>5</td>
            <td>5</td>
            <td>5</td>
        </tr>
     </table>

TABLE;    
        

    ?>
    <!-- formularz na impreze -->
    
</body>
</html>