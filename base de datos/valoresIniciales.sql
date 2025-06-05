/* Ingresar administrador definitivo */
INSERT INTO administradores (nombreUsuario, contrasena)
VALUES
("Jesus-Cardona", "17390234");

/* Ingresar configuraciones de venta iniciales */
INSERT INTO configventas (tipoConfig, porcentaje)
VALUES 
("ganancia", 50),
("correspondencia", 50);

/* Ingresar configuraciones de caja iniciales */
INSERT INTO configcaja (tipoConfig, estado)
VALUES
("estadoCaja", 1);