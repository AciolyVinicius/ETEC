<?php
$html .= "<div class='row'>";
$html .= "<div class='col-12 col-md-12'>";
      					
$html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Destinatario</label>";
$html .= "<div class='row'>";
$html .= "<div class='col-4 col-md-4'>";
$html .= "<center>";
$html .= "<div class='form-check'>";
$html .= "<input class='form-check-input' type='radio' name='destinatario' id='geral' value='geral' checked>";
$html .= "<label class='form-check-label for='geral'>Geral</label>";
$html .= "</div>";
$html .= "</center>";
$html .= "</div>";
$html .= "<div class='col-4 col-md-4'>";
$html .= "<center>";
$html .= "<div class='form-check'>";
$html .= "<input class='form-check-input' type='radio' name='destinatario' id='curso' value='curso'>";
$html .= "<label class='form-check-label' for='curso'>Curso</label>";
$html .= "</div>";
$html .= "</center>";
$html .= "</div>";
$html .= "<div class='col-4 col-md-4'>";
$html .= "<center>";
$html .= "<div class='form-check'>";
$html .= "<input class='form-check-input' type='radio' name='destinatario' id='turma' value='turma'>";
$html .= "<label class='form-check-label' for='turma'>Turma</label>";
$html .= "</div>";
$html .= "</center>";
$html .= "</div>";
$html .= "</div>";
$html .= "<span class='text-danger'></span>";
      					
$html .= "</div>";

$html .= "<div class='col-12 col-md-12'>";
$html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Nome</label>";
$html .= "<div class='form-group'>";
$html .= "<input type='text' name='nome' required='' value='Passeio Microsoft' class='form-control' id='nome' />";
$html .= "<span class='text-danger'></span>";
$html .= "</div>";
$html .= "</div>";
$html .= "<div class='col-6 col-md-6'>";
$html .= "<label for='data' class='control-label'><span class='text-danger'>*</span>Data</label>";
$html .= "<div class='form-group'>";
$html .= "<input type='date' name='data' required='' value='10/03/2018' class='form-control' id='data' />";
$html .= "<span class='text-danger'></span>";
$html .= "</div>";
$html .= "</div>";
$html .= "<div class='col-6 col-md-6'>";
$html .= "<label for='anexo' class='control-label'>Anexo</label>";
$html .= "<div class='form-group'>";
$html .= "<input type='file' name='anexo' value='' class='form-control' id='anexo' />";
$html .= "<span class='text-danger'></span>";
$html .= "</div>";
$html .= "</div>";
$html .= "<div class='col-12 col-md-12' id='formDescricao'>";
$html .= "<div class='col-12 col-md-12'>";
$html .= "<label for='aviso' class='control-label'><span class='text-danger'>*</span>Escrever Aviso</label>";
$html .= "<div class='form-group'>";
$html .= "<textarea class='form-control' name='aviso' required='' id='aviso' rows='8'>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse	cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</textarea>";
$html .= "<span class='text-danger'></span>";
$html .= "</div>";
$html .= "</div>";
$html .= "</div>";
$html .= "</div>";