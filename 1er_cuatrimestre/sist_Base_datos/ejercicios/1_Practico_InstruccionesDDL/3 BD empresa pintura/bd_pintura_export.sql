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


-- Volcando estructura de base de datos para bd_pintura
DROP DATABASE IF EXISTS `bd_pintura`;
CREATE DATABASE IF NOT EXISTS `bd_pintura` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bd_pintura`;

-- Volcando estructura para tabla bd_pintura.categoria
DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `id_categoria` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_cat` varchar(15) NOT NULL,
  PRIMARY KEY (`id_categoria`),
  UNIQUE KEY `uk_nombre_cat` (`nombre_cat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_pintura.categoria: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_pintura.envase
DROP TABLE IF EXISTS `envase`;
CREATE TABLE IF NOT EXISTS `envase` (
  `id_envase` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_envase` varchar(15) NOT NULL,
  `capacidad_envase` int(11) NOT NULL,
  PRIMARY KEY (`id_envase`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_pintura.envase: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_pintura.producto
DROP TABLE IF EXISTS `producto`;
CREATE TABLE IF NOT EXISTS `producto` (
  `id_producto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_prod` varchar(30) NOT NULL,
  `stock` int(11) DEFAULT NULL,
  `precio_venta` int(11) DEFAULT NULL,
  `stock_seguridad` int(11) DEFAULT NULL,
  `id_categoria` int(11) NOT NULL,
  `id_envase` int(11) NOT NULL,
  PRIMARY KEY (`id_producto`),
  UNIQUE KEY `uk_nombre_prod` (`nombre_prod`),
  KEY `fk_id_categoria` (`id_categoria`),
  KEY `fk_id_envase` (`id_envase`),
  CONSTRAINT `fk_id_categoria` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id_categoria`),
  CONSTRAINT `fk_id_envase` FOREIGN KEY (`id_envase`) REFERENCES `envase` (`id_envase`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_pintura.producto: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
