DELIMITER $$
USE `dbsaga`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertInstituicao`(
  in instituicao VARCHAR(100),
  in fantasia VARCHAR(100),
  in cnpj VARCHAR(20),
  in contato1 VARCHAR(20),
  in contato2 VARCHAR(20),
  in email VARCHAR(100),
  in rua VARCHAR(150),
  in numeracao VARCHAR(8),
  in bairro VARCHAR(100),
  in cidade VARCHAR(100),
  in estado VARCHAR(3),
  in cep VARCHAR(20),
  in mec VARCHAR(30),
  in alvara VARCHAR(15)
)
BEGIN
	if (instituicao!="" && fantasia!="" && cnpj!="" && contato1!="" && contato2!="" && email!="" && rua!="" && 
    numeracao!="" && bairro!="" && cidade!="" && estado!="" && cep!="" && mec!="" && alvara!="") then
  
  insert into `tb_instituicao` (nm_instituicao,nm_fantasia,cd_cnpj,cd_contato1,cd_contato2,nm_email,nm_rua,cd_numeracao,nm_bairro,nm_cidade,nm_estado,cd_cep,cd_mec,cd_alvara)
  values (instituicao,fantasia,cnpj,contato1,contato2,email,rua,numeracao,bairro,cidade,estado,cep,mec,alvara);

  end if;
  
  if ((select nm_instituicao from tb_instituicao where `tb_instituicao`.`nm_instituicao` 
	  like instituicao group by nm_instituicao)!="") then
		select ("Cadastro realizado") as Resultado;
  else
		select ("Cadastro falhou") as Resultado;
  end if;

END$$
DELIMITER ;

DELIMITER $$
USE `dbsaga`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteInstituicaoPorNome`(
in nome VARCHAR (100))
BEGIN
	if (""!= (select nm_instituicao from tb_instituicao where nm_instituicao like nome and cd_instituicao>0 group by nm_instituicao)) then
		delete from tb_instituicao where nm_instituicao like nome and cd_instituicao > 0;
        select ("Instituição deletada") as 'CONCLUÍDO!';        
    else
		select ("Instituição inexistente") as 'ALERTA!';
    end if;
END$$
DELIMITER ;
call `DeleteInstituicaoPorNome`("oiii");

DELIMITER $$
USE `dbsaga`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateInstituicaoPorNome`(
	in n VARCHAR(100),
    in nome VARCHAR (100),
	in instituicao VARCHAR(100),
	in fantasia VARCHAR(100),
	in cnpj VARCHAR(20),
	in contato1 VARCHAR(20),
	in contato2 VARCHAR(20),
	in email VARCHAR(100),
	in rua VARCHAR(150),
	in numeracao VARCHAR(8),
	in bairro VARCHAR(100),
	in cidade VARCHAR(100),
	in estado VARCHAR(3),
	in cep VARCHAR(20),
	in mec VARCHAR(30),
	in alvara VARCHAR(15)
    )
BEGIN
	if(n!='' && nome != '' && instituicao!='' && fantasia!='' && cnpj!='' && contato1!='' && contato2!='' && email!='' && rua!='' && 
    numeracao!='' && bairro!='' && cidade!='' && estado!='' && cep!='' && mec!='' && alvara!='')then    
	update tb_instituicao set nm_instituicao = instituicao where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set nm_fantasia = fantasia  where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set cd_cnpj = cnpj  where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set cd_contato1 = contato1  where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set cd_contato2 = contato2  where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set nm_email = email  where nm_instituicao = n and cd_instituicao > 0 ;
    UPDATE tb_instituicao SET nm_rua = rua where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set cd_numeracao = numeracao  where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set nm_bairro = bairro  where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set nm_cidade = cidade where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set nm_estado = estado  where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set cd_cep = cep  where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set cd_mec = mec  where nm_instituicao = n and cd_instituicao > 0 ;
    update tb_instituicao set cd_alvara = alvara where nm_instituicao = n and cd_instituicao > 0 ;
	end if;
  
  
END$$
DELIMITER ;

DELIMITER $$
USE `dbsaga`$$
CREATE PROCEDURE `InserirUsuario` (
  nome VARCHAR(150),
  sobrenome VARCHAR(150),
  nascimento DATE,
  email VARCHAR(150),
  foto BLOB,
  cpf VARCHAR(15),
  rg VARCHAR(15),
  senha VARCHAR(45),
  contato1 VARCHAR(20),
  contato2 VARCHAR(20),
  cep VARCHAR(20),
  rua VARCHAR(150),
  numeracao VARCHAR(8),
  bairro VARCHAR(100),
  cidade VARCHAR(100),
  estado VARCHAR(3),
  responsavel VARCHAR(150),
  contato_responsavel VARCHAR(20),
  email_responsavel VARCHAR(150),
  cpf_responsavel VARCHAR(20)
)
BEGIN
	insert into tb_usuario (nm_usuario,nm_sobrenome,dt_nascimento,nm_email,im_foto,cd_cpf,cd_rg,cd_senha,cd_contato1,cd_contato2,cd_cep,nm_rua,cd_numeracao,nm_bairro,nm_cidade,nm_estado,nm_responsavel,cd_contato_responsavel,nm_email_responsavel,cd_cpf_responsavel)
    values(nome,
  sobrenome ,
  nascimento,
  email ,
  foto,
  cpf,
  rg,
  senha,
  contato1,
  contato2,
  cep,
  rua,
  numeracao,
  bairro,
  cidade,
  estado,
  responsavel,
  contato_responsavel,
  email_responsavel,
  cpf_responsavel);
END$$
DELIMITER ;

DELIMITER $$
USE `dbsaga`$$
CREATE PROCEDURE `DeleteUsuario` (
cdusuario int
)
BEGIN
	delete from tb_usuario where cdusuario = cd_usuario and cd_usuario>0;	
END$$

DELIMITER ;

DELIMITER $$
USE `dbsaga`$$
CREATE PROCEDURE `UpdateUsuario` (
  cdusuario INT,
  nome VARCHAR(150),
  sobrenome VARCHAR(150),
  nascimento DATE,
  email VARCHAR(150),
  foto BLOB,
  cpf VARCHAR(15),
  rg VARCHAR(15),
  senha VARCHAR(45),
  contato1 VARCHAR(20),
  contato2 VARCHAR(20),
  cep VARCHAR(20),
  rua VARCHAR(150),
  numeracao VARCHAR(8),
  bairro VARCHAR(100),
  cidade VARCHAR(100),
  estado VARCHAR(3),
  responsavel VARCHAR(150),
  contato_responsavel VARCHAR(20),
  email_responsavel VARCHAR(150),
  cpf_responsavel VARCHAR(20)
)
BEGIN
if(cd_usuario != "" &&
  nome != "" &&
  sobrenome != "" &&
  nascimento != "" &&
  email != "" &&
  foto != "" &&
  cpf != "" &&
  rg != "" &&
  senha != "" &&
  contato1 != "" &&
  contato2 != "" &&
  cep != "" &&
  rua != "" &&
  numeracao != "" &&
  bairro != "" &&
  cidade != "" &&
  estado != "" &&
  responsavel != "" && 
  contato_responsavel != "" &&
  email_responsavel != "" &&
  cpf_responsavel != ""  &&
  (select nm_usuario from tb_usuario where nm_usuario = nome) = "" )then
	update tb_usuario 
    set nm_usuario = nome,
    nm_sobrenome = sobrenome,
    dt_nascimento = nascimento,
    nm_email = email,
    im_foto = foto,
    cd_cpf = cpf,
    cd_rg = rg,
    cd_senha = senha,
    cd_contato1 = contato1,
    cd_contato2 = contato2,
    cd_cep = cep,
    nm_rua = rua,
    cd_numeracao = numeracao,
    nm_bairro = bairro,
    nm_cidade = cidade,
    nm_estado = estado,
    nm_responsavel = responsavel,
    cd_contato_responsavel = contato_responsavel,
    nm_email_responsavel = email_responsavel,
    cd_cpf_responsavel = cpf_responsavel
    where cd_usuario = cdusuario;    
    if ((select nm_usuario from tb_usuario where nm_usuario like nome)!="") then 
    select "Atualização Feita" as 'Resultado';
    else
    select "Erro ao Atualizar" as 'Resultado';
	end if;
else
	select "Erro ao Atualizar" as 'Resultado';
end if;
END$$
DELIMITER ;
