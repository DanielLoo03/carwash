DELIMITER $$

/*Consulta de administradores*/
CREATE PROCEDURE obtenerAdministradores ()   
BEGIN
    SELECT nombreUsuario, contrasena FROM administradores;
END$$

/* Alta de administradores */
CREATE PROCEDURE altaAdministrador(
    IN nombreUsuarioParam VARCHAR(50),
    IN contrasenaParam    VARCHAR(50)
)
BEGIN
    INSERT INTO administradores (
        nombreUsuario,
        contrasena
    )
    VALUES (
        nombreUsuarioParam,
        contrasenaParam
    );
END $$

/*Alta de empleados*/
CREATE PROCEDURE altaEmpleado(
    IN nombres VARCHAR(50),
    IN apellidoPaterno VARCHAR(50),
    IN apellidoMaterno VARCHAR(50),
    IN numTelefono VARCHAR(12),
    IN numEmpleado INT,
    IN fechaNacimiento DATE,
    IN calle VARCHAR(50),
    IN colonia VARCHAR(50),
    IN numExterior VARCHAR(4),
    IN numInterior VARCHAR(4),
    IN codigoPostal VARCHAR(5)
)
BEGIN
    INSERT INTO Empleados (
        nombres,
        apellidoPaterno,
        apellidoMaterno,
        numTelefono,
        numEmpleado,
        fechaNacimiento,
        calle,
        colonia,
        numExterior,
        numInterior,
        codigoPostal
    )
    VALUES (
        nombres,
        apellidoPaterno,
        apellidoMaterno,
        numTelefono,
        numEmpleado,
        fechaNacimiento,
        calle,
        colonia,
        numExterior,
        numInterior,
        codigoPostal
    );
END $$

/*Consulta de empleados*/
CREATE PROCEDURE consultarEmpleados()
BEGIN
    SELECT nombres, apellidoPaterno, apellidoMaterno, numEmpleado, numTelefono, fechaNacimiento, calle, colonia, codigoPostal, numInterior, numExterior  
    FROM empleados
    ORDER BY nombres ASC;
END $$

/*Modificación de empleados*/
CREATE PROCEDURE modificarEmpleado(
    IN nombresParam VARCHAR(50),
    IN apellidoPaternoParam VARCHAR(50),
    IN apellidoMaternoParam VARCHAR(50),
    IN numTelefonoParam VARCHAR(12),
    IN numEmpleadoParam INT,
    IN fechaNacimientoParam DATE,
    IN calleParam VARCHAR(50),
    IN coloniaParam VARCHAR(50),
    IN numExteriorParam VARCHAR(4),
    IN numInteriorParam VARCHAR(4),
    IN codigoPostalParam VARCHAR(5)
)
BEGIN
    UPDATE Empleados
    SET
        nombres = nombresParam,
        apellidoPaterno = apellidoPaternoParam,
        apellidoMaterno = apellidoMaternoParam,
        numTelefono = numTelefonoParam,
        fechaNacimiento = fechaNacimientoParam,
        calle = calleParam,
        colonia = coloniaParam,
        numExterior = numExteriorParam,
        numInterior = numInteriorParam,
        codigoPostal = codigoPostalParam
    WHERE
        numEmpleado = numEmpleadoParam;
END $$

/*Eliminación de empleados*/
CREATE PROCEDURE eliminarEmpleado(IN numEmpleadoParam INT)
BEGIN
    DELETE FROM empleados
    WHERE numEmpleado = numEmpleadoParam;
END $$

/*Consulta números de empleado*/
CREATE PROCEDURE obtenerNumsEmpleado()
BEGIN
    SELECT numEmpleado FROM Empleados;
END $$

/*Registro de ventas*/
CREATE PROCEDURE registrarVenta(
    IN marcaCarroParam VARCHAR(50),
    IN modeloCarroParam VARCHAR(50),
    IN colorCarroParam VARCHAR(50),
    IN precioParam decimal(6,2),
    IN gananciaParam decimal(6,2),
    IN correspondenciaParam decimal(6,2),
    IN numEmpleadoParam int,
    IN fechaVentaParam DATE
)
BEGIN
    INSERT INTO ventas (
        marcaCarro,
        modeloCarro,
        colorCarro,
        precio,
        ganancia,
        correspondencia,
        numEmpleado,
        fechaVenta
    )
    VALUES (
        marcaCarroParam,
        modeloCarroParam,
        colorCarroParam,
        precioParam,
        gananciaParam,
        correspondenciaParam,
        numEmpleadoParam,
        fechaVentaParam
    );
END $$

/* Obtener número de empleado en base al nombre completo de empleado*/
CREATE PROCEDURE obtenerNumEmpleado(
    IN nombresParam VARCHAR(50),
    IN apellidoPaternoParam VARCHAR(50),
    IN apellidoMaternoParam VARCHAR(50)
)
BEGIN 
    SELECT numEmpleado 
    FROM empleados
    WHERE nombres = nombresParam
        AND apellidoPaterno = apellidoPaternoParam
        AND apellidoMaterno = apellidoMaternoParam;
END $$

/* Obtener nombre completo de empleado en base al número de empleado*/
CREATE PROCEDURE obtenerNombreEmpleado(IN numEmpleadoParam INT)
BEGIN 
    SELECT 
        CONCAT(nombres, ' ', apellidoPaterno, ' ', apellidoMaterno) AS nombreCompleto
    FROM empleados
    WHERE numEmpleado = numEmpleadoParam;
END $$

/* Modificar porcentaje de ganancia */
CREATE PROCEDURE setPorcentajeGanancia(IN porcentajeParam INT) 
BEGIN
    UPDATE configventas
    SET porcentaje = porcentajeParam
    WHERE tipoConfig = 'ganancia';
END $$

/* Modificar porcentaje de correspondencia */
CREATE PROCEDURE setPorcentajeCorrespondencia(IN porcentajeParam INT) 
BEGIN
    UPDATE configventas
    SET porcentaje = porcentajeParam
    WHERE tipoConfig = 'correspondencia';
END $$

/* Consultar porcentajes (ganancia y correspondencia) */
CREATE PROCEDURE obtenerPorcentajes()
BEGIN
    SELECT porcentaje, tipoConfig
    FROM configventas;
END $$

/* Consultar nombres completos de empleados */
CREATE PROCEDURE consNomCompletos()
BEGIN
    SELECT CONCAT(nombres, ' ', apellidoPaterno, ' ', apellidoMaterno) as nomCompleto
    FROM empleados;
END $$

/* Consultar todas las ventas según el día */
CREATE PROCEDURE consVentas(IN fechaParam DATETIME)
BEGIN
    SELECT v.id, v.marcaCarro, v.modeloCarro, v.colorCarro, v.precio, v.ganancia, v.correspondencia, v.cancelado, CONCAT(e.nombres, ' ', e.apellidoPaterno, ' ', e.apellidoMaterno) as nomCompleto
    FROM ventas v
    INNER JOIN empleados e ON v.numEmpleado = e.numEmpleado
    WHERE v.fechaVenta = fechaParam
    ORDER BY v.id;
END $$

/* Consultar ventas (sin incluir las canceladas) según el día */
CREATE PROCEDURE consVentasNoCan(IN fechaParam DATETIME)
BEGIN
    SELECT v.id, v.marcaCarro, v.modeloCarro, v.colorCarro, v.precio, v.ganancia, v.correspondencia, v.cancelado, CONCAT(e.nombres, ' ', e.apellidoPaterno, ' ', e.apellidoMaterno) as nomCompleto
    FROM ventas v
    INNER JOIN empleados e ON v.numEmpleado = e.numEmpleado
    WHERE v.fechaVenta = fechaParam
        AND v.cancelado = FALSE
    ORDER BY v.id;
END $$

/* Modificar venta */
CREATE PROCEDURE modVenta(
    IN idParam INT,
    IN marcaCarroParam VARCHAR(50),
    IN modeloCarroParam VARCHAR(50),
    IN colorCarroParam VARCHAR(50),
    IN numEmpParam int
)
BEGIN
    UPDATE ventas
    SET
        marcaCarro = marcaCarroParam,
        modeloCarro = modeloCarroParam,
        colorCarro = colorCarroParam,
        numEmpleado = numEmpParam
    WHERE
        id = idParam;
END $$

/* Cancelar venta */
CREATE PROCEDURE canVenta(
    IN idParam INT
)
BEGIN
    UPDATE ventas
    SET
        cancelado = TRUE
    WHERE
        id = idParam;
END $$

/* Consulta de administradores */
CREATE PROCEDURE consAdmins()
BEGIN
    SELECT nombreUsuario, contrasena
    FROM administradores
    ORDER BY nombreUsuario ASC;
END $$

DELIMITER ;
