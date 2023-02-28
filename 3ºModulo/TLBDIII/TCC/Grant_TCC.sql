CREATE USER 'admin'@'localhost' identified by 'sagagrouplovesteachersoftlbd';
grant all on dbsaga.* 
	to 'admin'@'localhost';

CREATE USER 'usuario'@'localhost' identified by 'sagagrouplovesteachersoftlbd';
grant select on dbsaga.* 
	to 'usuario'@'localhost';