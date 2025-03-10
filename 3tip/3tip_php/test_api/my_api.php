<?php
header("Content-Type: application/json");

// Funkcja do obsługi żądań GET
function get_data()
{
    $data = array(
        "status" => "success",
        "message" => "Hello, world!"
    );
    echo json_encode($data);
}

// Funkcja do obsługi żądań POST
function post_data()
{
    $input = json_decode(file_get_contents("php://input"), true);
    $data = array(
        "status" => "success",
        "received" => $input
    );
    echo json_encode($data);
}

// Obsługa różnych metod HTTP
$method = $_SERVER['REQUEST_METHOD'];
switch ($method) {
    case 'GET':
        get_data();
        break;
    case 'POST':
        post_data();
        break;
    default:
        echo json_encode(array("status" => "error", "message" => "Invalid request method"));
        break;
}
