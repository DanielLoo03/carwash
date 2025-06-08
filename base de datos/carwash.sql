CREATE DATABASE IF NOT EXISTS carwash;
USE carwash;

CREATE TABLE administradores (
  id int NOT NULL AUTO_INCREMENT,
  nombreUsuario varchar(50) NOT NULL UNIQUE,
  contrasena varchar(50) NOT NULL,
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

CREATE TABLE cortecaja (
  id int NOT NULL AUTO_INCREMENT,
  fechaCorte datetime NOT NULL UNIQUE,
  idAdmin int NOT NULL UNIQUE,
  contado decimal (7, 2) NOT NULL,
  calculado decimal (7, 2) NOT NULL,
  diferencia decimal (7, 2) NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (idAdmin) REFERENCES administradores (id)
);

CREATE TABLE configcaja (
  tipoConfig varchar(50) NOT NULL,
  estado boolean NOT NULL DEFAULT 1,
  PRIMARY KEY (tipoConfig)
)