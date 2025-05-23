CREATE DATABASE IF NOT EXISTS carwash;
USE carwash;

CREATE TABLE administradores (
  id int NOT NULL AUTO_INCREMENT,
  nombreUsuario varchar(50) NOT NULL,
  contrasena varchar(50) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE articulo (
  id int NOT NULL AUTO_INCREMENT,
  nombre varchar(50) NOT NULL,
  descripcion varchar(200) DEFAULT NULL,
  unidadesDisponibles int NOT NULL,
  costoUnidad decimal(7,2) DEFAULT NULL,
  stockBajo int DEFAULT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE empleados (
  id int NOT NULL AUTO_INCREMENT,
  nombres varchar(50) NOT NULL,
  apellidoPaterno varchar(50) NOT NULL,
  apellidoMaterno varchar(50) NOT NULL,
  numTelefono varchar(12) NOT NULL,
  numEmpleado int NOT NULL,
  fechaNacimiento date NOT NULL,
  calle varchar(50) NOT NULL,
  colonia varchar(50) NOT NULL,
  numExterior varchar(4) DEFAULT NULL,
  numInterior varchar(4) DEFAULT NULL,
  codigoPostal varchar(5) NOT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY numEmpleado (numEmpleado)
);

CREATE TABLE ventas (
  id int NOT NULL AUTO_INCREMENT,
  marcaCarro varchar(50) DEFAULT NULL,
  modeloCarro varchar(50) DEFAULT NULL,
  colorCarro varchar(50) DEFAULT NULL,
  precio decimal(7, 2) NOT NULL,
  ganancia decimal(7, 2) NOT NULL,
  correspondencia decimal(7, 2) NOT NULL,
  numEmpleado int NOT NULL,
  fechaVenta datetime NOT NULL,
  cancelado boolean NOT NULL DEFAULT FALSE,
  PRIMARY KEY (id),
  FOREIGN KEY (numEmpleado) REFERENCES empleados (numEmpleado) 
  ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE configVentas (
  tipoConfig varchar(50) NOT NULL,
  porcentaje int NOT NULL, 
  PRIMARY KEY (tipoConfig)
);