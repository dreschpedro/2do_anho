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


-- Volcando estructura de base de datos para agropecuario
DROP DATABASE IF EXISTS `agropecuario`;
CREATE DATABASE IF NOT EXISTS `agropecuario` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `agropecuario`;

-- Volcando estructura para tabla agropecuario.parcela
DROP TABLE IF EXISTS `parcela`;
CREATE TABLE IF NOT EXISTS `parcela` (
  `id_parcela` int(11) NOT NULL AUTO_INCREMENT,
  `superficie` int(11) DEFAULT NULL,
  `alambrado` varchar(10) DEFAULT NULL,
  `bebederos` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_parcela`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agropecuario.parcela: ~0 rows (aproximadamente)

-- Volcando estructura para tabla agropecuario.pastura
DROP TABLE IF EXISTS `pastura`;
CREATE TABLE IF NOT EXISTS `pastura` (
  `id_pastura` int(11) NOT NULL AUTO_INCREMENT,
  `periodo` varchar(10) DEFAULT NULL,
  `tipo_ganado` varchar(15) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `id_parcela` int(11) NOT NULL,
  PRIMARY KEY (`id_pastura`),
  KEY `fk_id_parcela_pas` (`id_parcela`),
  CONSTRAINT `fk_id_parcela_pas` FOREIGN KEY (`id_parcela`) REFERENCES `parcela` (`id_parcela`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agropecuario.pastura: ~0 rows (aproximadamente)

-- Volcando estructura para tabla agropecuario.precipitaciones
DROP TABLE IF EXISTS `precipitaciones`;
CREATE TABLE IF NOT EXISTS `precipitaciones` (
  `id_precipitaciones` int(11) NOT NULL AUTO_INCREMENT,
  `mes` varchar(12) DEFAULT NULL,
  `mm_caidos` int(11) DEFAULT NULL,
  `id_parcela` int(11) NOT NULL,
  PRIMARY KEY (`id_precipitaciones`),
  KEY `fk_id_parcela_p` (`id_parcela`),
  CONSTRAINT `fk_id_parcela_p` FOREIGN KEY (`id_parcela`) REFERENCES `parcela` (`id_parcela`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agropecuario.precipitaciones: ~0 rows (aproximadamente)

-- Volcando estructura para tabla agropecuario.siembra
DROP TABLE IF EXISTS `siembra`;
CREATE TABLE IF NOT EXISTS `siembra` (
  `id_siembra` int(11) NOT NULL AUTO_INCREMENT,
  `periodo` varchar(10) DEFAULT NULL,
  `tipo_siembra` varchar(15) DEFAULT NULL,
  `rinde_ha` int(11) DEFAULT NULL,
  `fecha_cosecha` varchar(10) DEFAULT NULL,
  `fecha_siembra` varchar(10) DEFAULT NULL,
  `id_parcela` int(11) NOT NULL,
  PRIMARY KEY (`id_siembra`),
  KEY `fk_id_parcela_s` (`id_parcela`),
  CONSTRAINT `fk_id_parcela_s` FOREIGN KEY (`id_parcela`) REFERENCES `parcela` (`id_parcela`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agropecuario.siembra: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
