<?php
require_once 'Animal.php';
class Dog extends Animal
{
    public function __construct(
        string $name,
        int $age,
        string $color = 'black',
        private string $sound = 'how how'
    ) {
        parent::__construct($name, $age, $color);
        echo "Wywołanie konstruktora Dog<br>";
    }
    public function __destruct()
    {
        echo "Wywołanie destruktora Dog<br>";
    }
    public function __toString()
    {
        return parent::__toString() . "Dźwięk: $this->sound<br>";
    }
    public function getSound(): string
    {
        return $this->sound;
    }
    public function getName():string{
        return $this->name;
    }
}
