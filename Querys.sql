

ALTER TABLE dbo.t_registro_de_equipos
add CONSTRAINT CU_id_usuaro_encargado UNIQUE (id_usuario_encargado);