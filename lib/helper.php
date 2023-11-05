<?php
require_once('D:\Xampp\htdocs\shoplaptop\db.php');
$pdo = new DB();
$pdo = $pdo->getPDO();
$pdo->exec('set names utf8');
function generatePage($pdo, $tableName, $count)
{
    $row = $pdo->query('select count(*) as count from ' . $tableName);
    foreach ($row as $r) {
        $allRows = $r['count'];
    }
    $page = ceil($allRows / $count); 
    for ($i = 0; $i < $page; $i++) {
        $pageCount = $i + 1;
        if (isset($_GET['page']) && $_GET['page'] == $pageCount) {
            echo '<a class="active" href="?page=' . $pageCount . '">' . $pageCount . '</a>';
        } else {
            echo '<a href="?page=' . $pageCount . '">' . $pageCount . '</a>';
        }
    }
}
