<?php
$html .= "<div class='row'>";
$html .= "<div class='col-12 col-md-6'>";
$html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Tema</label>";
$html .= "<div class='form-group'>";
$html .= "<input type='text' name='nome' required='' value='Aula 01 - Definição de Variaveis' class='form-control' id='nome' />";
$html .= "<span class='text-danger'></span>";
$html .= "</div>";
$html .= "</div>";
$html .= "<div class='col-6 col-md-6'>";
$html .= "<label for='data' class='control-label'><span class='text-danger'>*</span>Data</label>";
$html .= "<div class='form-group'>";
$html .= "<input type='date' name='data' required='' value='20/02/2018' class='form-control' id='data' />";
$html .= "<span class='text-danger'></span>";
$html .= "</div>";
$html .= "</div>";
$html .= "<div class='col-12 col-md-12' id='formDescricao'>";
$html .= "<div class='col-12 col-md-12'>";
$html .= "<label for='aviso' class='control-label'><span class='text-danger'>*</span>Anotação</label>";
$html .= "<div class='form-group'>";
$html .= "<textarea class='form-control' name='aviso' required='' id='aviso' rows='8'>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</textarea>";
$html .= "<span class='text-danger'></span>";
$html .= "</div>";
$html .= "</div>";
$html .= "</div>";
$html .= "</div>";