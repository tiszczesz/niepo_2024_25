W HTML istnieje wiele typów kontrolek `input`, które można użyć w formularzach. Oto lista najczęściej używanych typów:

- `text`: Pole tekstowe do wprowadzania jednowierszowego tekstu.
- `password`: Pole tekstowe do wprowadzania hasła, gdzie wprowadzone znaki są ukrywane.
- `email`: Pole tekstowe do wprowadzania adresu e-mail.
- `number`: Pole tekstowe do wprowadzania liczb.
- `date`: Pole do wyboru daty.
- `checkbox`: Pole wyboru (checkbox).
- `radio`: Przycisk radiowy.
- `file`: Pole do wyboru pliku.
- `submit`: Przycisk do wysyłania formularza.
- `reset`: Przycisk do resetowania formularza.
- `button`: Przycisk, który można zaprogramować do wykonania dowolnej akcji.
- `color`: Pole do wyboru koloru.
- `tel`: Pole tekstowe do wprowadzania numeru telefonu.
- `url`: Pole tekstowe do wprowadzania adresu URL.
- `search`: Pole tekstowe do wprowadzania tekstu wyszukiwania.
- `range`: Suwak do wyboru wartości z zakresu.

Przykład użycia różnych typów kontrolek `input` w formularzu:

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Form Example</title>
</head>
<body>
    <h1>Formularz</h1>
    <form>
        <label for="name">Name:</label>
        <input type="text" id="name" name="name"><br><br>

        <label for="email">Email:</label>
        <input type="email" id="email" name="email"><br><br>

        <label for="password">Password:</label>
        <input type="password" id="password" name="password"><br><br>

        <label for="age">Age:</label>
        <input type="number" id="age" name="age"><br><br>

        <label for="dob">Date of Birth:</label>
        <input type="date" id="dob" name="dob"><br><br>

        <label for="file">Upload File:</label>
        <input type="file" id="file" name="file"><br><br>

        <label for="color">Favorite Color:</label>
        <input type="color" id="color" name="color"><br><br>

        <label for="phone">Phone Number:</label>
        <input type="tel" id="phone" name="phone"><br><br>

        <label for="website">Website:</label>
        <input type="url" id="website" name="website"><br><br>

        <label for="search">Search:</label>
        <input type="search" id="search" name="search"><br><br>

        <label for="range">Range:</label>
        <input type="range" id="range" name="range" min="0" max="100"><br><br>

        <input type="checkbox" id="subscribe" name="subscribe">
        <label for="subscribe">Subscribe to newsletter</label><br><br>

        <input type="radio" id="male" name="gender" value="male">
        <label for="male">Male</label><br>
        <input type="radio" id="female" name="gender" value="female">
        <label for="female">Female</label><br><br>

        <input type="submit" value="Submit">
        <input type="reset" value="Reset">
    </form>
</body>
</html>
```

