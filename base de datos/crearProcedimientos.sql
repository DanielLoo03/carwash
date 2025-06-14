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

/*Realización de corte de caja*/
CREATE PROCEDURE realizarCorte(
    IN fechaCorteParam DATE,
    IN idAdminParam INT,
    IN contadoParam DECIMAL (7, 2),
    IN calculadoParam DECIMAL (7, 2),
    IN diferenciaParam DECIMAL (7, 2)
)
BEGIN
    INSERT INTO cortecaja (
        fechaCorte,
        idAdmin,
        contado, 
        calculado,
        diferencia
    )
    VALUES (
       fechaCorteParam,
       idAdminParam,
       contadoParam,
       calculadoParam,
       diferenciaParam
    );
END $$

/* Consulta de administradores */
CREATE PROCEDURE consAdmins()
BEGIN
    SELECT id, nombreUsuario, contrasena
    FROM administradores
    ORDER BY nombreUsuario ASC;
END $$

/* Obtener el id del administrador para registrar quien realizó el corte de caja */
CREATE PROCEDURE obtenerIdAdmin (
    IN nombreUsuarioParam varchar(50)
)
BEGIN
    SELECT id
    FROM administradores
    WHERE nombreUsuario = nombreUsuarioParam;
END $$

CREATE PROCEDURE modAdmin(
    IN idParam             INT,
    IN nombreUsuarioParam  VARCHAR(50),
    IN contrasenaParam     VARCHAR(50)
)
BEGIN
    UPDATE administradores
    SET
        nombreUsuario = nombreUsuarioParam,
        contrasena    = contrasenaParam
    WHERE
        id = idParam;
END $$

CREATE PROCEDURE bajaAdmin(
    IN idParam INT
)
BEGIN
    DELETE FROM administradores
    WHERE id = idParam;
END $$

/*Registro de Gastos*/
CREATE PROCEDURE altaGasto (
    IN fechaGasto DATETIME,
	IN fechaRegistro DATETIME,
    IN monto DECIMAL(7,2),
    IN tipoGasto VARCHAR(50),
    IN descripcion VARCHAR(100),
    IN idAdmin INT
)
BEGIN
    INSERT INTO gastos (
        fechaGasto, 
		fechaRegistro,
        monto, 
        tipoGasto, 
        descripcion, 
        idAdmin
    )
    VALUES (
        fechaGasto, 
		fechaRegistro,
        monto, 
        UPPER(tipoGasto),  -- Asegura que se inserte en mayúsculas
        descripcion, 
        idAdmin
    );
END $$

/*Obtener correspondencia por fecha y empleado*/
CREATE PROCEDURE consCorrespTotal (
    IN fecha DATETIME,
    IN empleado INT
)
BEGIN
    SELECT correspondencia
    FROM ventas
    WHERE fechaVenta = fecha AND numEmpleado = empleado;
END $$
	
/*Obtener ganancias totales por fecha*/
CREATE PROCEDURE consGanTotal (
    IN fechaCons DATETIME
)
BEGIN
    SELECT ganancia
    FROM venta
    WHERE DATE(fechaVenta) = DATE(fechaCons);
END $$

/*Obtener empleados que realizadon una venta por fecha*/
CREATE PROCEDURE ObtenerEmpPorFecha(IN fecha DATE)
BEGIN
    SELECT DISTINCT numEmpleado
    FROM ventas
    WHERE DATE(fechaVenta) = fecha AND cancelado = 0;
END$$

/* Consultar el corte de caja realizado según el día */
CREATE PROCEDURE consCorte(
    IN fechaCorteParam DATETIME
)
BEGIN
    SELECT id, idAdmin, contado, calculado, diferencia 
    FROM cortecaja
    WHERE fechaCorte = fechaCorteParam;
END $$

/* Modificar los datos del corte */
CREATE PROCEDURE modCorte(
    IN idParam INT,
    IN fechaCorteParam DATE,
    IN idAdminParam INT,
    IN contadoParam DECIMAL (7, 2),
    IN calculadoParam DECIMAL (7, 2),
    IN diferenciaParam DECIMAL (7, 2)
)
BEGIN
    UPDATE cortecaja 
    SET
        fechaCorte = fechaCorteParam,
        idAdmin = idAdminParam,
        contado = contadoParam,
        calculado = calculadoParam,
        diferencia = diferenciaParam
    WHERE
        id = idParam;
END $$

/* Consultar la fecha del último corte de caja realizado */
CREATE PROCEDURE consFechaCorte()
BEGIN 
    SELECT fechaCorte
    FROM cortecaja
    ORDER BY id DESC
    LIMIT 1;  
END $$

/* Obtener el nombre de usuario según el id */
CREATE PROCEDURE obtenerNomUsuario(
    IN idParam INT
)
BEGIN
    SELECT nombreUsuario 
    FROM administradores
    WHERE id = idParam;
END $$

/* Consultar el monto contado que existe en caja según el último corte de caja */
CREATE PROCEDURE consCaja()
BEGIN 
    SELECT contado 
    FROM cortecaja
    ORDER BY id DESC
    LIMIT 1;  
END $$

/* Consultar el monto contado que existe en caja según el penúltimo corte de caja (se usa para cuando se hace corte proveniente de una reapertura) */
CREATE PROCEDURE consCajaPen()
BEGIN 
    SELECT contado 
    FROM cortecaja
    ORDER BY id DESC
    LIMIT 1 OFFSET 1;  
END $$

/* Abrir o cerrar caja */
CREATE PROCEDURE modEstadoCaja(
    IN estadoParam boolean
)
BEGIN
    UPDATE configcaja
    SET estado = estadoParam
    WHERE tipoConfig = 'estadoCaja';
END $$

/* Consultar el estado de caja (abierto o cerrado) */
CREATE PROCEDURE consEstadoCaja()
BEGIN
    SELECT estado
    FROM configcaja
    WHERE tipoConfig = 'estadoCaja';
END $$

/* Modificar el valor del monto contado en el corte de caja */
CREATE PROCEDURE modContado(
    IN contadoParam decimal(7, 2)
)
BEGIN
    UPDATE cortecaja
    SET contado = contadoParam
    WHERE id = (
        SELECT MAX(id) FROM cortecaja
    );
END $$

/* Dar de alta una registro en la bitácora */
CREATE PROCEDURE altaBitacora(
    IN idAdminParam int,
    IN fechaHoraParam datetime,
    IN descripcionParam TEXT
)
BEGIN 
    INSERT INTO bitacora (
        idAdmin,
        fechaHora,
        descripcion
    )
    VALUES (
        idAdminParam,
        fechaHoraParam,
        descripcionParam
    );
END $$

/* Consulta de los datos de la bitácora */
CREATE PROCEDURE consBit(
    IN fechaParam date
)
BEGIN 
    SELECT * 
    FROM bitacora
    WHERE DATE(fechaHora) = fechaParam;
END $$

/* Consultar si existe una reapertura de caja en el día actual */
CREATE PROCEDURE consReap()
BEGIN 
    SELECT *
    FROM bitacora
    WHERE DATE(fechaHora) = CURDATE();
END $$

/* Consultar el nombre de usuario del administrador según su id */
CREATE PROCEDURE consNomAdmin(
    IN idAdminParam int
)
BEGIN 
    SELECT nombreUsuario
    FROM administradores
    WHERE id = idAdminParam;
END $$

CREATE PROCEDURE consGastos	(IN fechaBuscada DATE)
BEGIN
    SELECT 
        g.id,
		g.fechaGasto,
        a.nombreUsuario AS nombreAdmin,
        g.tipoGasto,
        g.descripcion,
        g.monto,
		g.cancelado
    FROM gastos g
    INNER JOIN administradores a ON g.idAdmin = a.id
    WHERE DATE(g.fechaRegistro) = fechaBuscada;
END $$

DELIMITER $$

CREATE PROCEDURE consGastosAct (IN fechaBuscada DATE)
BEGIN
    SELECT 
        g.id,
        g.fechaGasto,
        a.nombreUsuario AS nombreAdmin,
        g.tipoGasto,
        g.descripcion,
        g.monto,
        g.cancelado
    FROM gastos g
    INNER JOIN administradores a ON g.idAdmin = a.id
    WHERE DATE(g.fechaRegistro) = fechaBuscada
      AND g.cancelado = 0;
END $$

DELIMITER ;


CREATE PROCEDURE obtenerTiposGasto()
BEGIN
    SELECT COLUMN_TYPE
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = 'gastos'
      AND COLUMN_NAME = 'tipoGasto'
      AND TABLE_SCHEMA = 'carwash';
END $$

CREATE PROCEDURE obtenerPreciosPorFecha (
    IN fechaBusqueda DATE
)
BEGIN
    SELECT precio
    FROM ventas
    WHERE DATE(fechaVenta) = fechaBusqueda
      AND cancelado = 0;
END

CREATE PROCEDURE obtenerMontosPorFecha (
    IN fechaBusqueda DATE
)
BEGIN
    SELECT monto
    FROM gastos
    WHERE DATE(fechaRegistro) = fechaBusqueda
	AND cancelado = 0
      AND tipoGasto != 'GANANCIA';
END$$

CREATE PROCEDURE obtenerMontosGanancia (
    IN p_fechaRegistro DATE
)
BEGIN
    SELECT monto
    FROM gastos
    WHERE tipoGasto = 'GANANCIA'
		AND cancelado = 0
      AND DATE(fechaRegistro) = p_fechaRegistro;
END$$

CREATE PROCEDURE modGasto (
    IN p_id INT,
    IN p_fechaGasto DATETIME,
    IN p_tipoGasto VARCHAR(50),
    IN p_monto DECIMAL(7,2),
    IN p_descripcion VARCHAR(100),
    IN p_idAdmin INT
)
BEGIN
    UPDATE gastos
    SET 
        fechaGasto = p_fechaGasto,
        monto = p_monto,
        tipoGasto = p_tipoGasto,
        descripcion = p_descripcion,
        idAdmin = p_idAdmin
    WHERE id = p_id;
END$$

DELIMITER $$

CREATE PROCEDURE canGasto (
    IN p_id INT
)
BEGIN
    UPDATE gastos
    SET cancelado = TRUE;
    WHERE id = p_id;
END$$

DELIMITER ;

DELIMITER ;