-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.0.13-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.0.0.6468
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para bd_banco
DROP DATABASE IF EXISTS `bd_banco`;
CREATE DATABASE IF NOT EXISTS `bd_banco` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bd_banco`;

-- Volcando estructura para tabla bd_banco.cliente
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `cedula_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `apellido_cliente` varchar(10) NOT NULL,
  `nombre_cliente` varchar(20) NOT NULL,
  `email_1_cliente` varchar(30) NOT NULL,
  `email_2_cliente` varchar(30) DEFAULT NULL,
  `celular_cliente` varchar(12) NOT NULL,
  PRIMARY KEY (`cedula_cliente`),
  UNIQUE KEY `uk_nom_ape` (`apellido_cliente`,`nombre_cliente`),
  UNIQUE KEY `uk_email_1` (`email_1_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_banco.cliente: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_banco.cuenta
DROP TABLE IF EXISTS `cuenta`;
CREATE TABLE IF NOT EXISTS `cuenta` (
  `num_cuenta` int(11) NOT NULL AUTO_INCREMENT,
  `saldo_cuenta` int(11) NOT NULL,
  `tipo_intereses` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`num_cuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_banco.cuenta: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_banco.cuenta_titulares
DROP TABLE IF EXISTS `cuenta_titulares`;
CREATE TABLE IF NOT EXISTS `cuenta_titulares` (
  `id_cuenta_titular` int(11) NOT NULL AUTO_INCREMENT,
  `cedula_cliente` int(11) NOT NULL,
  `num_cuenta` int(11) NOT NULL,
  PRIMARY KEY (`id_cuenta_titular`),
  KEY `fk_cedula_cte` (`cedula_cliente`),
  KEY `fk_num_cta` (`num_cuenta`),
  CONSTRAINT `fk_cedula_cte` FOREIGN KEY (`cedula_cliente`) REFERENCES `cliente` (`cedula_cliente`),
  CONSTRAINT `fk_num_cta` FOREIGN KEY (`num_cuenta`) REFERENCES `cuenta` (`num_cuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_banco.cuenta_titulares: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_banco.empleado
DROP TABLE IF EXISTS `empleado`;
CREATE TABLE IF NOT EXISTS `empleado` (
  `cod_empleado` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_vinculo` varchar(8) NOT NULL,
  `antiguedad` int(11) NOT NULL,
  `cod_sucursal` int(11) NOT NULL,
  PRIMARY KEY (`cod_empleado`),
  KEY `fk_cod_sucursal_e` (`cod_sucursal`),
  CONSTRAINT `fk_cod_sucursal_e` FOREIGN KEY (`cod_sucursal`) REFERENCES `sucursal` (`cod_sucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_banco.empleado: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_banco.pago
DROP TABLE IF EXISTS `pago`;
CREATE TABLE IF NOT EXISTS `pago` (
  `num_pago` int(11) NOT NULL AUTO_INCREMENT,
  `num_prestamo` int(11) NOT NULL,
  `importe` int(11) NOT NULL,
  `fecha_pago` varchar(10) NOT NULL,
  PRIMARY KEY (`num_pago`),
  KEY `fk_num_prest` (`num_prestamo`),
  CONSTRAINT `fk_num_prest` FOREIGN KEY (`num_prestamo`) REFERENCES `prestamo` (`num_prestamo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_banco.pago: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_banco.prestamo
DROP TABLE IF EXISTS `prestamo`;
CREATE TABLE IF NOT EXISTS `prestamo` (
  `num_prestamo` int(11) NOT NULL AUTO_INCREMENT,
  `cod_sucursal` int(11) NOT NULL,
  `importe` float NOT NULL,
  PRIMARY KEY (`num_prestamo`),
  KEY `fk_cod_sucursal` (`cod_sucursal`),
  CONSTRAINT `fk_cod_sucursal` FOREIGN KEY (`cod_sucursal`) REFERENCES `sucursal` (`cod_sucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_banco.prestamo: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_banco.prestamo_cliente
DROP TABLE IF EXISTS `prestamo_cliente`;
CREATE TABLE IF NOT EXISTS `prestamo_cliente` (
  `id_prest_cte` int(11) NOT NULL AUTO_INCREMENT,
  `num_prestamo` int(11) NOT NULL,
  `cedula_cliente` int(11) NOT NULL,
  PRIMARY KEY (`id_prest_cte`),
  KEY `fk_num_prestamo` (`num_prestamo`),
  KEY `fk_ced_cte` (`cedula_cliente`),
  CONSTRAINT `fk_num_prestamo` FOREIGN KEY (`num_prestamo`) REFERENCES `prestamo` (`num_prestamo`),
  CONSTRAINT `fk_ced_cte` FOREIGN KEY (`cedula_cliente`) REFERENCES `cliente` (`cedula_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_banco.prestamo_cliente: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_banco.subordinados
DROP TABLE IF EXISTS `subordinados`;
CREATE TABLE IF NOT EXISTS `subordinados` (
  `id_subordinado` int(11) NOT NULL AUTO_INCREMENT,
  `cod_empleado` int(11) NOT NULL,
  `nom_ape` varchar(30) NOT NULL,
  PRIMARY KEY (`id_subordinado`),
  UNIQUE KEY `uk_nomApe` (`nom_ape`),
  KEY `fk_cod_empleado` (`cod_empleado`),
  CONSTRAINT `fk_cod_empleado` FOREIGN KEY (`cod_empleado`) REFERENCES `empleado` (`cod_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_banco.subordinados: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_banco.sucursal
DROP TABLE IF EXISTS `sucursal`;
CREATE TABLE IF NOT EXISTS `sucursal` (
  `cod_sucursal` int(11) NOT NULL AUTO_INCREMENT,
  `cuidad` varchar(30) NOT NULL,
  PRIMARY KEY (`cod_sucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_banco.sucursal: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
