create table auditoria(
nm_usuario varchar(60),
nm_acao varchar(9),
dt_auditoria date,
hr_auditoria time,
cd_captura int
);

delimiter $$ 
USE `db_pedido_3i2`$$
CREATE DEFINER = CURRENT_USER TRIGGER `db_pedido_3i2`.`tr_auditoria` AFTER INSERT ON `tb_vendedor` FOR EACH ROW
			begin
            insert into auditoria set
				cd_captura = new.cd_vendedor,
				nm_usuario = user(),
				nm_acao = 'Cadastro',
				dt_auditoria = curdate(),
				hr_auditoria = curtime();
            end$$
delimiter ;

insert into tb_vendedor (cd_vendedor, nm_vendedor, sg_comissao, vl_salario)
select max(cd_vendedor) + 1, 'Tiago Boldogue', 'c', 5645.99 from tb_vendedor;

delimiter $$ 
USE `db_pedido_3i2`$$
CREATE DEFINER = CURRENT_USER TRIGGER `db_pedido_3i2`.`tr_auditoria_delete` AFTER DELETE ON `tb_vendedor` FOR EACH ROW
			begin
            insert into auditoria set
				cd_captura = last_insert_id(cd_vendedor),
				nm_usuario = user(),
				nm_acao = 'Cadastro',
				dt_auditoria = curdate(),
				hr_auditoria = curtime();
            end$$
delimiter ;


delimiter $$ 
USE `db_pedido_3i2`$$
CREATE DEFINER = CURRENT_USER TRIGGER `db_pedido_3i2`.`tr_auditoria_update` before UPDATE ON `tb_vendedor` FOR EACH ROW
			begin
            insert into auditoria set
				cd_captura = last_insert_id(cd_vendedor),
				nm_usuario = user(),
				nm_acao = 'Alterado',
				dt_auditoria = curdate(),
				hr_auditoria = curtime();
            end$$
delimiter ;
update `db_pedido_3i2`.`tb_vendedor` set
`tb_vendedor`.`nm_vendedor` = 'Pula Boldogue', 
`tb_vendedor`.`sg_comissao` = 'c', 
`tb_vendedor`.`vl_salario` = 5645.99 
where cd_vendedor = (select cd_vendedor from tb_vendedor where `tb_vendedor`.`nm_vendedor` like 'Tiago Boldogue');