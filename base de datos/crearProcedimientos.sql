DELIMITER $$

/*Alta de empleados*/
CREATE PROCEDURE InsertEmpleado(
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
    SELECT nombre, apellidoPaterno, apellidoMaterno, numEmpleado,  numTelefono, fechaNacimiento, calle, colonia, codigoPostal, numInterior, numExterior  FROM empleados
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
END$$

/*Consulta números de empleado*/
CREATE PROCEDURE obtenerNumsEmpleado
BEGIN
    SELECT numEmpleado from Empleados;
END $$

DELIMITER ;