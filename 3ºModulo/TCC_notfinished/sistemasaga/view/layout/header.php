<?php

$html = "<!DOCTYPE html>";
$html .= "<html>";
$html .= "<head>";
$html .= "<meta charset='utf-8'>";
$html .= "<meta http-equiv='X-UA-Compatible' content='IE=edge'>";
$html .= "<title>S.A.G.A.</title>";
$html .= "<!-- Tell the browser to be responsive to screen width -->";
$html .= "<meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>";
$html .= "<!-- Ionicons -->";
$html .= "<link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css'>";

$html .= "<!-- Bootstrap -->";
$html .= "<link rel='stylesheet' type='text/css' href='" . DOCUMENT_ROOT . "/public/lib/css/bootstrap.min.css'>";

$html .= "<!-- Font Awesome -->";
$html .= "<link rel='stylesheet' type='text/css' href='" . DOCUMENT_ROOT . "/public/lib/css/font-awesome.min.css'>";

$html .= "<!-- Datetimepicker -->";
$html .= "<link rel='stylesheet' type='text/css' href='" . DOCUMENT_ROOT . "/public/lib/css/bootstrap-datetimepicker.min.css'>";

$html .= "<!-- Tema Style -->";
$html .= "<link rel='stylesheet' type='text/css' href='" . DOCUMENT_ROOT . "/public/lib/css/AdminLTE.min.css'>";

$html .= "<!-- Skins do tema -->";
$html .= "<link rel='stylesheet' type='text/css' href='" . DOCUMENT_ROOT . "/public/lib/css/_all-skins.min.css'>";

$html .= "<!-- CSS -->";
$html .= "<link rel='stylesheet' type='text/css' href='" . DOCUMENT_ROOT . "/public/lib/css/maindash.css'>";

$html .= "<!--DataTables-->";
$html .= "<link rel='stylesheet' type='text/css' href='" . DOCUMENT_ROOT . "/public/lib/datatables/datatables.css'>";

    $html .= "<link href='/tcc/calendarioTeste/css/fullcalendar.min.css' rel='stylesheet' />";

    $html .= "<link rel='stylesheet' type='text/css' href='/tcc/resources/css/chat.css'>";

$html .= "</head>";
$html .= "<body class='hold-transition skin-blue sidebar-mini'>";

$html .= "<div class='wrapper'>";
$html .= "<header class='main-header'>";
$html .= "<!-- Logo -->";
$html .= "<a href='" . DOCUMENT_ROOT . "/Dashboard/home' class='logo' id='logo'>";
$html .= "<!-- mini logo for sidebar mini 50x50 pixels -->";
$html .= "<span class='logo-mini'>S.A.G.A.</span>";
$html .= "<!-- logo for regular state and mobile devices -->";
$html .= "<span class='logo-lg'>S.A.G.A.</span>";
$html .= "</a>";

$html .= "<!-- Header Navbar: style can be found in header.less -->";
$html .= "<nav class='navbar navbar-static-top' id='navcor'>";
$html .= "<!-- Sidebar toggle button-->";
$html .= "<a href='#' class='sidebar-toggle' data-toggle='offcanvas' role='button'>";
$html .= "<span class='sr-only'>Toggle navigation</span>";
$html .= "</a>";

$html .= "<div class='navbar-custom-menu'>";
$html .= "<ul class='nav navbar-nav'>";
$html .= "<!-- User Account: style can be found in dropdown.less -->";
$html .= "<li class='dropdown user user-menu'>";
$html .= "<a href='#' class='dropdown-toggle' data-toggle='dropdown'>";
$html .= "<img src='".DOCUMENT_ROOT.$_SESSION['foto']."?v=".Date("Y.m.d.G.i.s")."' class='user-image' alt='User Image'>";
$html .= "<span class='hidden-xs'> " . $_SESSION['nome'] . "</span>";
$html .= "</a>";
$html .= "<ul class='dropdown-menu'>";
$html .= "<!-- User image -->";
$html .= "<li class='user-header' id='user-header'>";
$html .= "<img src='".DOCUMENT_ROOT.$_SESSION['foto']."?v=".Date("Y.m.d.G.i.s")."' class='img-circle' alt='User Image'>";
$html .= "<p>";
$html .= $_SESSION['nome'] . " - ".$_SESSION['tipo_nome'];
$html .= "<small>".$_SESSION['tipo_nome']." do Sistema S.A.G.A.</small>";
$html .= "</p>";
$html .= "</li>";
$html .= "<!-- Menu Footer-->";
$html .= "<li class='user-footer'>";
$html .= "<div class='pull-left'>";
$html .= "<a href='" . DOCUMENT_ROOT . "/Dashboard/perfil' class='btn btn-info btn-flat'>Perfil</a>";
$html .= "</div>";
$html .= "<div class='pull-right'>";
$html .= "<a href='" . DOCUMENT_ROOT . "/Dashboard/logout' class='btn btn-warning btn-flat'>Deslogar</a>";
$html .= "</div>";
$html .= "</li>";
$html .= "</ul>";
$html .= "</li>";
$html .= "</ul>";
$html .= "</div>";
$html .= "</nav>";
$html .= "</header>";
$html .= "<aside class='main-sidebar'>";
$html .= "<!-- sidebar: style can be found in sidebar.less -->";
$html .= "<section class='sidebar'>";
$html .= "<!-- Sidebar user panel -->";
$html .= "<div class='user-panel'>";
$html .= "<div class='pull-left image'>";
$html .= "<img src='".DOCUMENT_ROOT.$_SESSION['foto']."?v=".Date("Y.m.d.G.i.s")."' class='img-circle' alt='User Image'>";
$html .= "</div>";
$html .= "<div class='pull-left info'>";
$html .= "<p>" . $_SESSION['nome'] . "</p>";
$html .= "<a href='#'><i class='fa fa-circle text-success'></i> Online</a>";
$html .= "</div>";
$html .= "</div>";
$html .= "<!-- sidebar menu: : style can be found in sidebar.less -->";
$html .= "<ul class='sidebar-menu'>";
$html .= "<li class='header'>MENU DE NAVEGAÇÃO</li>";
$html .= "<li>";
$html .= "<a href='" . DOCUMENT_ROOT . "/Dashboard/home'>";
$html .= "<i class='fa fa-dashboard'></i> <span>Dashboard</span>";
$html .= "</a>";
$html .= "</li>";

if ($_SESSION['tipo_id'] >= 5)
{
	$html .= "<li>";
	$html .= "<a href='" . DOCUMENT_ROOT . "/Dashboard/gerenciamento'>";
	$html .= "<i class='fa fa-cog'></i> <span>Gerenciamento</span>";
	$html .= "</a>";
	$html .= "</li>";
}

$html .= "<li>";
$html .= "<a href='" . DOCUMENT_ROOT . "/view/tarefa'>";
$html .= "<i class='fa fa-calendar'></i> <span>Calendarios</span>";
$html .= "</a>";
$html .= "<ul class='treeview-menu'>";
$html .= "<li class='active'>";
$html .= "<a href='tarefa/index.php'><i class='fa fa-list-ul'></i> Seu Calendario</a>";
$html .= "</li>";
$html .= "<li>";
$html .= "<a href='tarefa/add.php'><i class='fa fa-plus'></i> Calendario Academico</a>";
$html .= "</li>";
$html .= "</ul>";
$html .= "</li>";
$html .= "<li>";
$html .= "<a href='" . DOCUMENT_ROOT . "/Dashboard/disciplina'>";
$html .= "<i class='fa fa-book'></i> <span>Disciplinas</span>";
$html .= "</a>";
$html .= "</li>";
$html .= "<li>";
$html .= "<a href='" . DOCUMENT_ROOT . "/Dashboard/nota'>";
$html .= "<i class='fa fa-plus'></i> <span>Notas</span>";
$html .= "</a>";
$html .= "</li>";
$html .= "<li>";
$html .= "<a href='" . DOCUMENT_ROOT . "/view/frequencia'>";
$html .= "<i class='fa fa-plus'></i> <span>Frequencia</span>";
$html .= "</a>";
$html .= "</li>";
$html .= "</ul>";
$html .= "</section>";
$html .= "<!-- /.sidebar -->";
$html .= "</aside>";