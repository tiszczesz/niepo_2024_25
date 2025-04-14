<?php
require_once 'Animal.php';
class Cat extends Animal{
    public function __construct(
        string $name,
        int $age,
        string $color = 'pomarańczowy',
        private string $movment = 'drzewa'
    ) {
        parent::__construct($name, $age, $color);
        echo "Wywołanie konstruktora Cat<br>";
    }
    public function __destruct()
    {
        echo "Wywołanie destruktora Cat<br>";
    }
    public function __toString()
    {
        return parent::__toString() . "poruszanie się: $this->movment<br>";
    }
}