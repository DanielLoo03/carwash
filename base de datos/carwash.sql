CREATE DATABASE IF NOT EXISTS carwash;
USE carwash;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `obtenerAdministradores` ()   
BEGIN
    SELECT nombreUsuario, contrasena FROM administradores;
END$$

DELIMITER ;

CREATE TABLE `administradores` (
  `id` int(11) NOT NULL,
  `nombreUsuario` varchar(50) NOT NULL,
  `contrasena` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `articulo` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `unidadesDisponibles` int(11) NOT NULL,
  `costoUnidad` decimal(7,2) DEFAULT NULL,
  `stockBajo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `empleados` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellidoPaterno` varchar(50) NOT NULL,
  `apellidoMaterno` varchar(50) DEFAULT NULL,
  `numTelefono` varchar(10) NOT NULL,
  `numEmpleado` int(11) NOT NULL,
  `fechaNacimiento` date DEFAULT NULL,
  `calle` varchar(50) DEFAULT NULL,
  `colonia` varchar(50) DEFAULT NULL,
  `numExterior` varchar(4) DEFAULT NULL,
  `numInterior` varchar(4) DEFAULT NULL,
  `codigoPostal` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `ventas` (
  `id` int(11) NOT NULL,
  `monto` decimal(6,2) NOT NULL,
  `idEmpleado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

ALTER TABLE `administradores`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `articulo`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `empleados`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `numEmpleado` (`numEmpleado`);

ALTER TABLE `ventas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fkVentasEmpleados` (`idEmpleado`);

ALTER TABLE `administradores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `articulo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `empleados`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `ventas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `ventas`
  ADD CONSTRAINT `fkVentasEmpleados` FOREIGN KEY (`idEmpleado`) REFERENCES `empleados` (`id`);

COMMIT;