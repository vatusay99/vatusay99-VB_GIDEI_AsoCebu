SELECT TOP (1000) [nombre]
      ,[tipo]
      ,[serial]
      ,[id_departamento_area]
      ,[fecha_ingreso]
      ,[activo]
      ,[id_usuario_encargado]
      ,[id_equipo]
  FROM [gestorInventarioEquipos].[dbo].[t_registro_de_equipos]

  SELECT * FROM t_registro_de_equipos WHERE id_usuario_encargado = 1004;


  SELECT r.id_usuario_encargado, u.nombre_completo
  FROM t_registro_de_equipos r
  JOIN t_usuarios u ON r.id_usuario_encargado = u.id_usuario
  GROUP BY r.id_usuario_encargado, u.nombre_completo
  HAVING r.id_usuario_encargado = 1004;

  SELECT u.nombre_completo, COUNT(r.id_usuario_encargado) AS Total_registro FROM t_usuarios u
  INNER JOIN t_registro_de_equipos r ON u.id_usuario = r.id_usuario_encargado
  GROUP BY r.id_usuario_encargado, u.nombre_completo
  HAVING r.id_usuario_encargado = 1004;

  SELECT * FROM [t_registro_de_equipos] WHERE activo = 'Inactivo';










