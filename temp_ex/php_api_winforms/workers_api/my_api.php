<?php
require_once 'functions.php';
header('Content-Type: application/json');
$method = $_SERVER['REQUEST_METHOD'];
switch ($method) {
    case 'GET':
        if (isset($_GET['id'])) {
            $id = (int)$_GET['id'];
            $worker = getWorkerById($id);
            if ($worker) {
                echo json_encode($worker);
            } else {
                http_response_code(404);
                echo json_encode(['error' => 'Worker not found']);
            }
        } else {
            $workers = getAllWorkers();
            echo json_encode($workers);
        }
        break;
    default:
        http_response_code(405);
        echo json_encode(['error' => 'Method not allowed']);
        break;
}
