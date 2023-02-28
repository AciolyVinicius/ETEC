<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
	<link rel="stylesheet" type="text/css" href="../ui/semantic.css">

	<script type="text/javascript" src="../ui/semantic.js"></script>

	<style type="text/css">
		body{
			width: 100%;
			height: 100%;
		}
		#conteudo{
			margin-bottom: 58px; 
		}
		.footer.segment {
      		padding: 3em 0em;
    	}

	</style>

</head>
<body>
	
	<div class="ui container">
	<!--menu-->
	<div class="ui large top fixed inverted menu">
  		<div class="ui container">
    		<a href="index.blade.php" style="color: white; margin: 1.2%; font-size: 30px;">S.A.G.A.</a>
    		<div class="right menu">
     			<div class="item">
        			<a href="index.blade.php" class="ui inverted blue button">Inicio</a>
     			</div>
      			<div class="item">
        			<a href="solicitar.blade.php" class="ui red inverted button">Solicitar</a>
      			</div>
    		</div>
  		</div>
  	</div>

  	
  	<!--conteudo-->
  	<div id="conteudo" class="ui grid">
  
	  	<div class="row">
	  		
	  		<div class="six wide column">
	  			<br><br>
	  			<form class="ui form" action="login.blade.php" method="post">
	  				<h2>Solicitar o Sistema</h2>
            <b>Nome/Instituição</b><input placeholder="Nome" type="text" name="nome">
			  		<b>E-mail</b><input type="text" name="email" placeholder="E-mail">

            <div class="fields">
              <div class="field">
                <label>Telefone</label>
                <input type="text" placeholder="Telefone">
              </div>
              <div class="field">
                <label><i class="ui icon green whatsapp"></i>WhatsApp</label>
                <input type="text" placeholder="Whats">
              </div>
            </div>

			  		<b>Senha</b><br><input type="password" name="senha" size="35">
			  		<br><br>
			  		<center>
			  			<input class="ui checkbox" type="checkbox" name="esquecer"> Manter-me logado
			  			<br><br>
			  			<input type="submit" value="Entrar" class="ui green button"><br><br>
			  			<a href="">Esqueceu sua senha?</a>
		  			</center>
		  		</form>

	  		</div>
	  		<div class="five wide column"></div>
	  	</div>
  	</div>

  	</div>
  	

  	<!--footer-->
 	<div class="ui inverted vertical footer segment">
    <div class="ui container">
      <div class="ui stackable inverted divided equal height stackable grid">
        <div class="three wide column">
          <h4 class="ui inverted header">About</h4>
          <div class="ui inverted link list">
            <a href="#" class="item">Sitemap</a>
            <a href="#" class="item">Contact Us</a>
            <a href="#" class="item">Religious Ceremonies</a>
            <a href="#" class="item">Gazebo Plans</a>
          </div>
        </div>
        <div class="three wide column">
          <h4 class="ui inverted header">Services</h4>
          <div class="ui inverted link list">
            <a href="#" class="item">Banana Pre-Order</a>
            <a href="#" class="item">DNA FAQ</a>
            <a href="#" class="item">How To Access</a>
            <a href="#" class="item">Favorite X-Men</a>
          </div>
        </div>
        <div class="seven wide column">
          <h4 class="ui inverted header">Footer Header</h4>
          <p>Extra space for a call to action inside the footer that could help re-engage users.</p>
        </div>
      </div>
    </div>
  </div>

</body>
</html>