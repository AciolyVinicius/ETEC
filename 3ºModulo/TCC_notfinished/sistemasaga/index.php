<?php
require_once "config.php";
require_once "global.php";

session_start();

if(sizeof($_GET) == 0){
	$controller = "PrincipalController";
	$method = "index";
}else{
	$controller = $_GET['controller']."Controller";
	$method     = $_GET['method'];
}
$controller = new $controller();
$controller->$method();