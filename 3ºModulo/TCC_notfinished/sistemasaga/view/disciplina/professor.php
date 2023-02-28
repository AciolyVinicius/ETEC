<?php
$html .= "<!-- MODALS DISCIPLINAS VISAO PROFESSOR -->";
$html .= "<!-- TAB1 -->";
$html .= "<!-- INICIO EDITÇÃO EMENTA DISCIPLINA -->";
$html .= "<div class='modal fade' id='exampleModalObjetivoDisciplina' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-info'> </i>  Informações da Disciplina</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            
          $html .= "<div class='row'>";
  
  $html .= "<div class='col-12 col-md-12'>";
    $html .= "<label for='turma' class='control-label'><span class='text-danger'>*</span>Turma</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Turma 01</option>";
            $html .= "<option>Turma 02</option>";
            $html .= "<option>Turma 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
    $html .= "</div>";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
    
    $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='ementa' class='control-label'><span class='text-danger'>*</span>Ementa da Disciplina</label>";
      $html .= "<div class='form-group'>";
        $html .= "<textarea class='form-control' name='ementa' required='' id='ementa' rows='8'></textarea>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='bibliografia' class='control-label'><span class='text-danger'>*</span>Bibliografia Utilizada</label>";
      $html .= "<div class='form-group'>";
        $html .= "<textarea class='form-control' name='bibliografia' required='' id='bibliografia' rows='8'></textarea>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

  $html .= "<div class='col-12 col-md-12'>";
    $html .= "<label for='nomeProfessor' class='control-label'><span class='text-danger'>*</span>Nome do Professor</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='text' name='nomeProfessor' required='' value='' class='form-control' id='nomeProfessor' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  $html .= "<div class='col-12 col-md-12'>";
    $html .= "<label for='formacao' class='control-label'><span class='text-danger'>*</span>Formação do Professor</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='text' name='formacao' required='' value='' class='form-control' id='formacao' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  $html .= "<div class='col-12 col-md-12'>";
    $html .= "<label for='instituicaoFormacao' class='control-label'><span class='text-danger'>*</span>Instituição de Formação</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='text' name='instituicaoFormacao' required='' value='' max='6' min='1' class='form-control' id='instituicaoFormacao' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  
$html .= "</div>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='submit' id='btnCadastrar' class='btn btn-success'><i class='fa fa-check'></i> Finalizar</button>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM EDITÇÃO EMENTA DISCIPLINA -->";

$html .= "<!-- TAB2 -->";
$html .= "<!-- INICIO ADD MATERIAL -->";
$html .= "<div class='modal fade' id='exampleModalAddMaterial' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-paperclip'> </i>  Adicionar Material</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            
          $html .= "<div class='row'>";
  
  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='nomeMaterial' class='control-label'><span class='text-danger'>*</span>Nome Aula</label>";
      $html .= "<div class='form-group'>";
        $html .= "<input class='form-control' name='nomeMaterial' required='' placeholder='Aula 01 - Assunto da Aula - Data' id='nomeMaterial'>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='descricaoMaterial' class='control-label'><span class='text-danger'>*</span> Descrição</label>";
      $html .= "<div class='form-group'>";
        $html .= "<textarea class='form-control' name='descricaoMaterial' required='' id='descricaoMaterial' rows='4'>Exemplos:     1. Material usado em sala (slides) (ppt ou atividade para fazer);";
        $html .= "2. Atividade para data (pdf com instruções e etc);";
        $html .= "3. Revisão para Prova 1</textarea>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

  $html .= "<div class='col-12 col-md-12'>";
    $html .= "<label for='anexoMaterial' class='control-label'><span class='text-danger'>*</span> Anexar Material</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='file' name='anexoMaterial' required='' value='' max='6' min='1' class='form-control' id='anexoMaterial' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  
$html .= "</div>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='submit' id='btnCadastrar' class='btn btn-success'><i class='fa fa-check'></i> Finalizar</button>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM ADD MATERIAL -->";

$html .= "<!-- INICIO EDIT MATERIAL -->";
$html .= "<div class='modal fade' id='exampleModalEditMaterial' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-paperclip'> </i>  Editar Material</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            
          $html .= "<div class='row'>";
  
  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='nomeMaterial' class='control-label'><span class='text-danger'>*</span>Nome Aula</label>";
      $html .= "<div class='form-group'>";
        $html .= "<input class='form-control' name='nomeMaterial' required='' value='Aula 01 - Assunto da Aula - Data' id='nomeMaterial'>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='descricaoMaterial' class='control-label'><span class='text-danger'>*</span> Descrição</label>";
      $html .= "<div class='form-group'>";
      $html .= "<textarea class='form-control' name='descricaoMaterial' required='' id='descricaoMaterial' rows='4'>Revisão para Prova 1</textarea>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

  $html .= "<div class='col-12 col-md-12'>";
    $html .= "<label for='anexoMaterial' class='control-label'><span class='text-danger'>*</span> Anexar Material</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='file' name='anexoMaterial' required='' value='' max='6' min='1' class='form-control' id='anexoMaterial' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  
$html .= "</div>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='submit' id='btnCadastrar' class='btn btn-success'><i class='fa fa-check'></i> Finalizar</button>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM EDIT MATERIAL -->";

$html .= "<!-- INICIO DELETE MATERIAL 1-->";
$html .= "<div class='modal fade' id='exampleModalDeleteMaterial1' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-paperclip'> </i>  Retirar Material</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            
          $html .= "<div class='row'>";
  
    $html .= "<div class='col-12 col-md-12'>        ";
    $html .= "<label for='material' class='control-label'><span class='text-danger'>*</span>Material</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Material 01</option>";
            $html .= "<option>Material 02</option>";
            $html .= "<option>Material 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
      $html .= "</div>  ";
      $html .= "<span class='text-danger'></span>";
  $html .= "</div>";
  
$html .= "</div>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
          $html .= "<a href='' id='btnCadastrar' class='btn btn-success' data-toggle='modal' data-target='#exampleModalDeleteMaterial2'><i class='fa fa-check'></i> Remover</a>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM DELETE MATERIAL 1-->";

$html .= "<!-- INICIO DELETE MATERIAL 2-->";
$html .= "<div class='modal fade' id='exampleModalDeleteMaterial2' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-exclamation-triangle'> </i>  Atenção!</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        $html .= "Tem certeza que deseja remover este Material?";
      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
        $html .= "<form method='post' action='#'>";
          $html .= "<button type='button' class='btn btn-secondary' data-dismiss='modal'>Não, cancelar</button>";
          $html .= "<button type='submit' class='btn btn-danger'><i class='fa fa-trash'></i> Sim, remover</button>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM DELETE MATERIAL 2-->";

$html .= "<!-- TAB3 -->";
$html .= "<!-- INICIO ADD AULA -->";
$html .= "<div class='modal fade' id='exampleModalAula' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-paste'> </i>  Criar Aula</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            
          $html .= "<div class='row'>";
  
    $html .= "<div class='col-3 col-md-3'>        ";
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Curso</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Curso 01</option>";
            $html .= "<option>Curso 02</option>";
            $html .= "<option>Curso 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
      $html .= "</div>  ";
      $html .= "<span class='text-danger'></span>";
  $html .= "</div>";
  $html .= "<div class='col-3 col-md-3'>";
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Turma</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Turma 01</option>";
            $html .= "<option>Turma 02</option>";
            $html .= "<option>Turma 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
    $html .= "</div>";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
    $html .= "<div class='col-3 col-md-3'>";
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Disciplina</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Disciplina 01</option>";
            $html .= "<option>Disciplina 02</option>";
            $html .= "<option>Disciplina 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
    $html .= "</div>";
      $html .= "<span class='text-danger'></span>";
  $html .= "</div>";
  $html .= "<div class='col-3 col-md-3'>";
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Turno</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Turno 01</option>";
            $html .= "<option>Turno 02</option>";
            $html .= "<option>Turno 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
      $html .= "</div>";
      $html .= "<span class='text-danger'></span>";
  $html .= "</div>";
  
  $html .= "<div class='col-6 col-md-6'>";
    $html .= "<label for='nomeAula' class='control-label'><span class='text-danger'>*</span>Nome</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='text' name='nomeAula' required='' value='' class='form-control' id='nomeAula' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  $html .= "<div class='col-4 col-md-4'>";
    $html .= "<label for='data' class='control-label'><span class='text-danger'>*</span>Data</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='date' name='data' required='' value='' class='form-control' id='data' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  $html .= "<div class='col-2 col-md-2'>";
    $html .= "<label for='data' class='control-label'><span class='text-danger'>*</span>Nº Aulas</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='number' name='data' required='' value='' max='6' min='1' class='form-control' id='data' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  
$html .= "</div>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='submit' id='btnCadastrar' class='btn btn-success'><i class='fa fa-check'></i> Finalizar</button>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM ADD AULA -->";

$html .= "<!-- INICIO ADD CHAMADA -->";
$html .= "<div class='modal fade' id='exampleModalChamada' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-check'> </i>  Realizar Chamada</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            $html .= "<div class='row'>";
  $html .= "<div class='col-6 col-md-6'>";
                
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Selecione a Aula</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Aula 01</option>";
            $html .= "<option>Aula 02</option>";
            $html .= "<option>Aula 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
      
      $html .= "</div>";
        $html .= "<span class='text-danger'></span>";
                
    $html .= "</div>";

    $html .= "<div class='col-6 col-md-6'>";
    $html .= "<label for='data' class='control-label'><span class='text-danger'>*</span>Data</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='date' name='data' required='' value='' class='form-control' id='data' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";

    $html .= "<div class='col-12 col-md-12'>";
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Chamada</label>";
    $html .= "<div class='form-group'>";
      
      $html .= "<div class='table-responsive'>";
        $html .= "<table class='table table-hover'>";
          $html .= "<thead>";
            $html .= "<th>Aluno</th>";
            $html .= "<th>1</th>";
            $html .= "<th>2</th>";
            $html .= "<th>3</th>";
            $html .= "<th>4</th>";
            $html .= "<th>5</th>";
            $html .= "<th>6</th>";
          $html .= "</thead>";
          $html .= "<tbody>";
            $html .= "<tr>";
              $html .= "<td>Pedro Silva</td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
            $html .= "</tr>";
            $html .= "<tr>";
              $html .= "<td>Matheus Guedes</td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
            $html .= "</tr>";
            $html .= "<tr>";
              $html .= "<td>Saura Dino</td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
            $html .= "</tr>";
            $html .= "<tr>";
              $html .= "<td>Vinicius Acioly</td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
              $html .= "<td><input type='checkbox' name=''></td>";
            $html .= "</tr>";
          $html .= "</tbody>";
        $html .= "</table>";
      $html .= "</div>";

    $html .= "</div>";
  $html .= "</div>";
  
  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='aviso' class='control-label'><span class='text-danger'>*</span>Observação</label>";
      $html .= "<div class='form-group'>";
        $html .= "<textarea class='form-control' name='aviso' required='' id='aviso' rows='4'></textarea>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='submit' id='btnCadastrar' class='btn btn-success'><i class='fa fa-check'></i> Finalizar</button>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM ADD CHAMADA -->";

$html .= "<!-- INICIO DELETE CHAMADA -->";
$html .= "<div class='modal fade' id='exampleModalDeleteAula' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-exclamation-triangle'> </i>  Atenção!</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        $html .= "Tem certeza que deseja remover esta Aula?";
      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
        $html .= "<form method='post' action='#'>";
          $html .= "<button type='button' class='btn btn-secondary' data-dismiss='modal'>Não, cancelar</button>";
          $html .= "<button type='submit' class='btn btn-danger'><i class='fa fa-trash'></i> Sim, remover</button>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM DELETE CHAMADA -->";

$html .= "<!-- TAB4 -->";
$html .= "<!-- INICIO ADD AVALIACAO -->";
$html .= "<div class='modal fade' id='exampleModalAvaliacao' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-edit'> </i>  Criar Avaliação</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            
          $html .= "<div class='row'>";
  
  $html .= "<div class='col-6 col-md-6'>";
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Turma</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Turma 01</option>";
            $html .= "<option>Turma 02</option>";
            $html .= "<option>Turma 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
    $html .= "</div>";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
    $html .= "<div class='col-6 col-md-6'>";
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Turno</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Turno 01</option>";
            $html .= "<option>Turno 02</option>";
            $html .= "<option>Turno 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
      $html .= "</div>";
      $html .= "<span class='text-danger'></span>";
  $html .= "</div>";
  
  $html .= "<div class='col-6 col-md-6'>";
    $html .= "<label for='nomeAula' class='control-label'><span class='text-danger'>*</span>Nome</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='text' name='nomeAula' required='' value='' class='form-control' id='nomeAula' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  $html .= "<div class='col-6 col-md-6'>";
    $html .= "<label for='data' class='control-label'><span class='text-danger'>*</span>Data</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='date' name='data' required='' value='' class='form-control' id='data' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='descricaoAvaliacao' class='control-label'><span class='text-danger'>*</span>Descrição</label>";
      $html .= "<div class='form-group'>";
        $html .= "<textarea class='form-control' name='descricaoAvaliacao' required='' id='descricaoAvaliacao' rows='4'></textarea>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='descricaoAvaliacao' class='control-label'><span class='text-danger'>*</span>Valor total da Avaliação</label>";
      $html .= "<div class='form-group'>";
        
        $html .= "<div class='container'>";
          $html .= "<div class='row'>";
            $html .= "<div class='col-lg-12'>";
              $html .= "<div class='star-rating'>";
                $html .= "<span class='fa fa-star-o' data-rating='1'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='2'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='3'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='4'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='5'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='6'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='7'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='8'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='9'></span>";
            $html .= "<span class='fa fa-star-o' data-rating='10'></span>";
            $html .= "<input type='hidden' name='whatever1' class='rating-value' value=''>";
              $html .= "</div>";
            $html .= "</div>";
          $html .= "</div>";
        $html .= "</div>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='descricaoAvaliacao' class='control-label'><span class='text-danger'>*</span>Peso da Avaliação</label>";
      $html .= "<div class='form-group'>";
        
        $html .= "<div class='container'>";
          $html .= "<div class='row'>";
            $html .= "<div class='col-lg-12'>";
              $html .= "<div class='anchor-rating'>";
                $html .= "<span class='fa fa-anchor' data-rating='1'></span>";
              $html .= "<span class='fa fa-anchor' data-rating='2'></span>";
              $html .= "<span class='fa fa-anchor' data-rating='3'></span>";
              $html .= "<span class='fa fa-anchor' data-rating='4'></span>";
              $html .= "<span class='fa fa-anchor' data-rating='5'></span>";
            $html .= "<input type='hidden' name='whatever2' class='rating-value' value=''>";
              $html .= "</div>";
            $html .= "</div>";
          $html .= "</div>";
        $html .= "</div>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

$html .= "</div>";

$html .= "<style type='text/css'>

  .star-rating {
    line-height: 50px;
    font-size:3.25em;
  }

  .anchor-rating {
    line-height: 50px;
    font-size:3.25em;
  }

  .star-rating .fa-star{color: goldenrod;}

  .anchor-rating .fa-anchor{color: gray;}

</style>";

$html .= "<script src='". DOCUMENT_ROOT ."/public/js/professor.js'></script>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='submit' id='btnCadastrar' class='btn btn-success'><i class='fa fa-check'></i> Finalizar</button>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM ADD AVALIACAO -->";

$html .= "<!-- INICIO SHOW AVALIACAO -->";
$html .= "<div class='modal fade' id='exampleModalShowAvaliacao' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-edit'> </i> Avaliação</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            
          $html .= "<div class='container-fluid'>";
  $html .= "<div class='row'>";
    $html .= "<div class='col-12 col-md-12 jumbotron'>";
      $html .= "<h2>nome</h2>";
      $html .= "<br>";
      $html .= "<div class='row'>";
              $html .= "<div class='col-md-12'>";
                $html .= "<p class='text'>";
                      $html .= "<strong>Titulo:</strong> Nome <br>";
                      $html .= "<strong>Data:</strong> 22/12/2018 <br>";
                      $html .= "<strong>Valor da Avaliação: </strong> 10 pontos <br>";
                      $html .= "<strong>Peso da Avaliação: </strong> 2 <br><br>";
                      $html .= "<strong>Descrição: </strong> <br> Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                      consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
                  $html .= "</p>    ";
              $html .= "</div>";
        $html .= "</div>";
      $html .= "</div>  ";
  $html .= "</div>";
$html .= "</div>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='submit' id='btnCadastrar' class='btn btn-success'><i class='fa fa-check'></i> Finalizar</button>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM SHOW AVALIACAO -->";

$html .= "<!-- INICIO EDIT AVALIACAO -->";
$html .= "<div class='modal fade' id='exampleModalEditAvaliacao' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-edit'> </i>  Editar Avaliação</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            
          $html .= "<div class='row'>";
  
  $html .= "<div class='col-6 col-md-6'>";
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Turma</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Turma 01</option>";
            $html .= "<option selected=''>Turma 02</option>";
            $html .= "<option>Turma 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
    $html .= "</div>";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
    $html .= "<div class='col-6 col-md-6'>";
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Turno</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Turno 01</option>";
            $html .= "<option>Turno 02</option>";
            $html .= "<option selected=''>Turno 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
      $html .= "</div>";
      $html .= "<span class='text-danger'></span>";
  $html .= "</div>";
  
  $html .= "<div class='col-6 col-md-6'>";
    $html .= "<label for='nomeAula' class='control-label'><span class='text-danger'>*</span>Nome</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='text' name='nomeAula' required='' value='Prova 1' class='form-control' id='nomeAula' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  $html .= "<div class='col-6 col-md-6'>";
    $html .= "<label for='data' class='control-label'><span class='text-danger'>*</span>Data</label>";
    $html .= "<div class='form-group'>";
      $html .= "<input type='date' name='data' required='' value='12/12/2018' class='form-control' id='data' />";
      $html .= "<span class='text-danger'></span>";
    $html .= "</div>";
  $html .= "</div>";
  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='descricaoAvaliacao' class='control-label'><span class='text-danger'>*</span>Descrição</label>";
      $html .= "<div class='form-group'>";
      $html .= "<textarea class='form-control' name='descricaoAvaliacao' required='' id='descricaoAvaliacao' rows='4'>Lorem ipsum dolor sit amet, onsectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo  consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</textarea>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='descricaoAvaliacao' class='control-label'><span class='text-danger'>*</span>Valor total da Avaliação</label>";
      $html .= "<div class='form-group'>";
        
        $html .= "<div class='container'>";
          $html .= "<div class='row'>";
            $html .= "<div class='col-lg-12'>";
              $html .= "<div class='star-rating'>";
                $html .= "<span class='fa fa-star-o' data-rating='1'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='2'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='3'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='4'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='5'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='6'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='7'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='8'></span>";
              $html .= "<span class='fa fa-star-o' data-rating='9'></span>";
            $html .= "<span class='fa fa-star-o' data-rating='10'></span>";
            $html .= "<input type='hidden' name='whatever1' class='rating-value' value='2'>";
              $html .= "</div>";
            $html .= "</div>";
          $html .= "</div>";
        $html .= "</div>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='descricaoAvaliacao' class='control-label'><span class='text-danger'>*</span>Peso da Avaliação</label>";
      $html .= "<div class='form-group'>";
        
        $html .= "<div class='container'>";
          $html .= "<div class='row'>";
            $html .= "<div class='col-lg-12'>";
              $html .= "<div class='anchor-rating'>";
                $html .= "<span class='fa fa-anchor' data-rating='1'></span>";
              $html .= "<span class='fa fa-anchor' data-rating='2'></span>";
              $html .= "<span class='fa fa-anchor' data-rating='3'></span>";
              $html .= "<span class='fa fa-anchor' data-rating='4'></span>";
              $html .= "<span class='fa fa-anchor' data-rating='5'></span>";
            $html .= "<input type='hidden' name='whatever2' class='rating-value' value=''>";
              $html .= "</div>";
            $html .= "</div>";
          $html .= "</div>";
        $html .= "</div>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";

$html .= "</div>";

$html .= "<style type='text/css'>

  .star-rating {
    line-height: 50px;
    font-size:3.25em;
  }

  .anchor-rating {
    line-height: 50px;
    font-size:3.25em;
  }

  .star-rating .fa-star{color: goldenrod;}

  .anchor-rating .fa-anchor{color: gray;}

</style>";

$html .= "<script src='". DOCUMENT_ROOT ."/public/js/professor2'></script>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='submit' id='btnCadastrar' class='btn btn-success'><i class='fa fa-check'></i> Finalizar</button>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM EDIT AVALIACAO -->";

$html .= "<!-- INICIO DELETE AVALIACAO -->";
$html .= "<div class='modal fade' id='exampleModalDeleteAvaliacao' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-exclamation-triangle'> </i>  Atenção!</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        $html .= "Tem certeza que deseja remover esta Avaliação?";
      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
        $html .= "<form method='post' action='#'>";
          $html .= "<button type='button' class='btn btn-secondary' data-dismiss='modal'>Não, cancelar</button>";
          $html .= "<button type='submit' class='btn btn-danger'><i class='fa fa-trash'></i> Sim, remover</button>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM DELETE AVALIACAO -->";

$html .= "<!-- INICIO ADD NOTAS AVALIACAO 1-->";
$html .= "<div class='modal fade' id='exampleModalNotasAvaliacao' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-paperclip'> </i>  Dar Notas</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            
          $html .= "<div class='row'>";
  
    $html .= "<div class='col-6 col-md-6'>        ";
    $html .= "<label for='turma' class='control-label'><span class='text-danger'>*</span>Turma</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Turma 01</option>";
            $html .= "<option>Turma 02</option>";
            $html .= "<option>Turma 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
      $html .= "</div>  ";
      $html .= "<span class='text-danger'></span>";
  $html .= "</div>";
  $html .= "<div class='col-6 col-md-6'>        ";
    $html .= "<label for='turno' class='control-label'><span class='text-danger'>*</span>Turno</label>";
    $html .= "<div class='row'>";
      $html .= "<div class='col-12 col-md-12'>";
        $html .= "<center>";
          $html .= "<select class='form-control'>";
            $html .= "<option>Turno 01</option>";
            $html .= "<option>Turno 02</option>";
            $html .= "<option>Turno 03</option>";
          $html .= "</select>";
        $html .= "</center>";
      $html .= "</div>";
      $html .= "</div>  ";
      $html .= "<span class='text-danger'></span>";
  $html .= "</div>";
  
$html .= "</div>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
          $html .= "<a href='' id='btnCadastrar' class='btn btn-success' data-toggle='modal' data-target='#exampleModalNotasAvaliacao2'><i class='fa fa-angle-double-right'></i> Continuar</a>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM ADD NOTAS AVALIACAO 1-->";

$html .= "<!-- INICIO ADD NOTAS AVALICAO 2-->";
$html .= "<div class='modal fade' id='exampleModalNotasAvaliacao2' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
  $html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
    $html .= "<div class='modal-content'>";
      $html .= "<div class='modal-header'>";
        $html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
          $html .= "<i class='fa fa-check-circle'> </i>  Avaliar Turma</h3>";
        $html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
          $html .= "<i class='fa fa-times'></i>";
        $html .= "</button>";
      $html .= "</div>";
      $html .= "<div class='modal-body'>";
        
        $html .= "<form method='post' action='#'>";
            
          $html .= "<div class='row'>";
  
    $html .= "<div class='col-12 col-md-12'>";
    $html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Notas</label>";
    $html .= "<div class='form-group'>";
      
      $html .= "<div class='table-responsive'>";
        $html .= "<table class='table table-hover'>";
          $html .= "<thead>";
            $html .= "<th>Aluno</th>";
            $html .= "<th>Pontuação</th>";
          $html .= "</thead>";
          $html .= "<tbody>";
            $html .= "<tr>";
              $html .= "<td>Pedro Silva</td>";
              $html .= "<td><input type='number' min='0' max='10' name=''></td>";
            $html .= "</tr>";
            $html .= "<tr>";
              $html .= "<td>Saura Dino</td>";
              $html .= "<td><input type='number' min='0' max='10' name=''></td>";
            $html .= "</tr>";
            $html .= "<tr>";
              $html .= "<td>Guilherme Fernandes</td>";
              $html .= "<td><input type='number' min='0' max='10' name=''></td>";
            $html .= "</tr>";
            $html .= "<tr>";
              $html .= "<td>Giovanna Ramalho</td>";
              $html .= "<td><input type='number' min='0' max='10' name=''></td>";
            $html .= "</tr>";
            $html .= "<tr>";
              $html .= "<td>Pablo Jonathan</td>";
              $html .= "<td><input type='number' min='0' max='10' name=''></td>";
            $html .= "</tr>";
            $html .= "<tr>";
              $html .= "<td>Amanda Kyrui</td>";
              $html .= "<td><input type='number' min='0' max='10' name=''></td>";
            $html .= "</tr>";
            $html .= "<tr>";
              $html .= "<td>Leonardo Dantas Barros</td>";
              $html .= "<td><input type='number' min='0' max='10' name=''></td>";
            $html .= "</tr>";
            $html .= "<tr>";
              $html .= "<td>Lotito</td>";
              $html .= "<td><input type='number' min='0' max='10' name=''></td>";
            $html .= "</tr>";
          $html .= "</tbody>";
        $html .= "</table>";
      $html .= "</div>";

    $html .= "</div>";
  $html .= "</div>";
  
  $html .= "<div class='col-12 col-md-12' id='formDescricao'>";
    $html .= "<div class='col-12 col-md-12'>";
      $html .= "<label for='aviso' class='control-label'><span class='text-danger'>*</span>Observação</label>";
      $html .= "<div class='form-group'>";
        $html .= "<textarea class='form-control' name='aviso' required='' id='aviso' rows='4'></textarea>";
        $html .= "<span class='text-danger'></span>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";

      $html .= "</div>";
      $html .= "<div class='modal-footer'>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='submit' id='btnCadastrar' class='btn btn-success'><i class='fa fa-check'></i> Finalizar</button>";
          $html .= "</div>";
          $html .= "<div class='col-12 col-md-6'>";
            $html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
          $html .= "</div>";
        $html .= "</form>";
      $html .= "</div>";
    $html .= "</div>";
  $html .= "</div>";
$html .= "</div>";
$html .= "<!-- FIM  ADD NOTAS AVALIACAO 2-->";