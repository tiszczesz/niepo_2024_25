<?php
require_once('Product.php');
class ProductsRepo{
    private ?mysqli $connection;
    private array $products = [];
    public function __construct(string $db){
        $this->connection = new mysqli('localhost', 'root', null,$db);
        $this->connection->set_charset('utf8');//ustawienie kodowania zbedne w nowszych wersjach
        $this->fillProducts();
    }
    private function fillProducts(){
        $result = $this->connection->query('SELECT * FROM products');
        if($result){
            while($row = $result->fetch_assoc()){
                $p = new Product();
            }
        }
    }
    public function getProducts():array{

    }

    public function __destruct(){
        $this->connection->close();
        $this->connection = null;
    }
}