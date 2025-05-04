DELIMITER $$

/*Consulta de administradores*/
CREATE PROCEDURE obtenerAdministradores ()   
BEGIN
    SELECT nombreUsuario, contrasena FROM administradores;
END$$

/*Alta de empleados*/
CREATE PROCEDURE altaEmpleado(
    IN nombre VARCHAR(50),
    IN apellidoPaterno VARCHAR(50),
    IN apellidoMaterno VARCHAR(50),
    IN numTelefono VARCHAR(10),
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
        nombre,
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
        nombre,
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
    SELECT nombre, apellidoPaterno, apellidoMaterno, numEmpleado, numTelefono, fechaNacimiento, calle, colonia, codigoPostal, numInterior, numExterior  
    FROM empleados
    ORDER BY nombre ASC;
END $$

/*Modificación de empleados*/
CREATE PROCEDURE modificarEmpleado(
    IN nombreParam VARCHAR(50),
    IN apellidoPaternoParam VARCHAR(50),
    IN apellidoMaternoParam VARCHAR(50),
    IN numTelefonoParam VARCHAR(10),
    IN numEmpleadoActualParam INT,
    IN numEmpleadoNuevoParam INT,
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
        nombre = nombreParam,
        apellidoPaterno = apellidoPaternoParam,
        apellidoMaterno = apellidoMaternoParam,
        numTelefono = numTelefonoParam,
        numEmpleado = numEmpleadoNuevoParam,
        fechaNacimiento = fechaNacimientoParam,
        calle = calleParam,
        colonia = coloniaParam,
        numExterior = numExteriorParam,
        numInterior = numInteriorParam,
        codigoPostal = codigoPostalParam
    WHERE
        numEmpleado = numEmpleadoActualParam;
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
    IN numEmpleadoParam int
)
BEGIN
    INSERT INTO ventas (
        marcaCarro,
        modeloCarro,
        colorCarro,
        precio,
        ganancia,
        correspondencia,
        numEmpleado
    )
    VALUES (
        marcaCarroParam,
        modeloCarroParam,
        colorCarroParam,
        precioParam,
        gananciaParam,
        correspondenciaParam,
        numEmpleadoParam
    );
END $$

/* Obtener número de empleado en base al nombre completo de empleado*/
CREATE PROCEDURE obtenerNumEmpleado(
    IN nombreParam VARCHAR(50),
    IN apellidoPaternoParam VARCHAR(50),
    IN apellidoMaternoParam VARCHAR(50)
)
BEGIN 
    SELECT numEmpleado 
    FROM empleados
    WHERE nombre = nombreParam
        AND apellidoPaterno = apellidoPaternoParam
        AND apellidoMaterno = apellidoMaternoParam;
END $$

/* Obtener nombre completo de empleado en base al número de empleado*/
CREATE PROCEDURE obtenerNombreEmpleado(IN numEmpleadoParam INT)
BEGIN 
    SELECT 
        CONCAT(nombre, ' ', apellidoPaterno, ' ', apellidoMaterno) AS nombreCompleto
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
    SELECT porcentaje 
    FROM configventas;
END $$

/* Consultar nombres completos de empleados */
CREATE PROCEDURE consNomCompletos()
BEGIN
    SELECT CONCAT(nombre, ' ', apellidoPaterno, ' ', apellidoMaterno) as nomCompleto
    FROM empleados;
END $$

DELIMITER ;