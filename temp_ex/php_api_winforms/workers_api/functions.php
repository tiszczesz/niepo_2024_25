<?php
function getConnection(): ?mysqli
{
    $conn = new mysqli("localhost", "root", null, "2tip_db_api_workers");
    if ($conn->connect_error) {
        error_log("Connection failed: " . $conn->connect_error);
        return null;
    }
    return $conn;
}
function getWorkerById(int $id): ?array
{
    $conn = getConnection();
    if (!$conn) {
        return null;
    }
    $stmt = $conn->prepare("SELECT * FROM workers WHERE id = ?");
    if (!$stmt) {
        $conn->close();
        return null;
    }
    $stmt->bind_param("i", $id);
    $stmt->execute();
    $result = $stmt->get_result();
    if ($result->num_rows === 0) {
        $stmt->close();
        $conn->close();
        return null;
    }
    $worker = $result->fetch_assoc();
    $worker['id'] = (int)$worker['id'];
    $worker['salary'] = (float)$worker['salary'];
    $stmt->close();
    $conn->close();
    return $worker;
}
function getAllWorkers(): array
{
    $conn = getConnection();
    if (!$conn) {
        return [];
    }
    $result = $conn->query("SELECT * FROM workers");
    if (!$result) {
        $conn->close();
        return [];
    }
    $workers = $result->fetch_all(MYSQLI_ASSOC);
    foreach ($workers as &$worker) {
        $worker['id'] = (int)$worker['id'];
        $worker['salary'] = (float)$worker['salary'];
    }
    $result->free();
    $conn->close();
    return $workers;
}
