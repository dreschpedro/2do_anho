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


-- Volcando estructura de base de datos para agencia_empleo
DROP DATABASE IF EXISTS `agencia_empleo`;
CREATE DATABASE IF NOT EXISTS `agencia_empleo` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `agencia_empleo`;

-- Volcando estructura para tabla agencia_empleo.calificacion
DROP TABLE IF EXISTS `calificacion`;
CREATE TABLE IF NOT EXISTS `calificacion` (
  `id_calificacion` int(11) NOT NULL AUTO_INCREMENT,
  `calificacion` varchar(15) DEFAULT NULL,
  `mes` varchar(15) DEFAULT NULL,
  `id_empleo` int(11) NOT NULL,
  PRIMARY KEY (`id_calificacion`),
  KEY `fk_id_empleo` (`id_empleo`),
  CONSTRAINT `fk_id_empleo` FOREIGN KEY (`id_empleo`) REFERENCES `empleo` (`id_empleo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agencia_empleo.calificacion: ~0 rows (aproximadamente)

-- Volcando estructura para tabla agencia_empleo.empleo
DROP TABLE IF EXISTS `empleo`;
CREATE TABLE IF NOT EXISTS `empleo` (
  `id_empleo` int(11) NOT NULL AUTO_INCREMENT,
  `duracion_contrato` varchar(10) DEFAULT NULL,
  `fecha_contrato` varchar(15) DEFAULT NULL,
  `tipo_contrto` varchar(15) DEFAULT NULL,
  `id_persona` int(11) NOT NULL,
  `id_empresa` int(11) NOT NULL,
  PRIMARY KEY (`id_empleo`),
  KEY `fk_id_empresa_empleo` (`id_empresa`),
  KEY `fk_id_persona_empleo` (`id_persona`),
  CONSTRAINT `fk_id_empresa_empleo` FOREIGN KEY (`id_empresa`) REFERENCES `empresa` (`id_empresa`),
  CONSTRAINT `fk_id_persona_empleo` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id_persona`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agencia_empleo.empleo: ~0 rows (aproximadamente)

-- Volcando estructura para tabla agencia_empleo.empresa
DROP TABLE IF EXISTS `empresa`;
CREATE TABLE IF NOT EXISTS `empresa` (
  `id_empresa` int(11) NOT NULL AUTO_INCREMENT,
  `razon_social` varchar(30) DEFAULT NULL,
  `rubro` varchar(20) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `domicilio` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_empresa`),
  UNIQUE KEY `uk_razon_social` (`razon_social`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agencia_empleo.empresa: ~0 rows (aproximadamente)

-- Volcando estructura para tabla agencia_empleo.idioma
DROP TABLE IF EXISTS `idioma`;
CREATE TABLE IF NOT EXISTS `idioma` (
  `id_idioma` int(11) NOT NULL AUTO_INCREMENT,
  `idioma` varchar(15) DEFAULT NULL,
  `nivel` varchar(15) DEFAULT NULL,
  `id_persona` int(11) NOT NULL,
  PRIMARY KEY (`id_idioma`),
  KEY `fk_id_persona_idioma` (`id_persona`),
  CONSTRAINT `fk_id_persona_idioma` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id_persona`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agencia_empleo.idioma: ~0 rows (aproximadamente)

-- Volcando estructura para tabla agencia_empleo.persona
DROP TABLE IF EXISTS `persona`;
CREATE TABLE IF NOT EXISTS `persona` (
  `id_persona` int(11) NOT NULL AUTO_INCREMENT,
  `dni` varchar(9) NOT NULL,
  `nom_apel` varchar(30) NOT NULL,
  `lic_conducir` varchar(10) DEFAULT NULL,
  `nivel_educ` varchar(10) DEFAULT NULL,
  `domicilio` varchar(30) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `fecha_nacim` varchar(15) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `manejo_office` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_persona`),
  UNIQUE KEY `uk_dni` (`dni`),
  UNIQUE KEY `uk_nom_apel` (`nom_apel`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agencia_empleo.persona: ~0 rows (aproximadamente)

-- Volcando estructura para tabla agencia_empleo.postulante
DROP TABLE IF EXISTS `postulante`;
CREATE TABLE IF NOT EXISTS `postulante` (
  `id_postulante` int(11) NOT NULL AUTO_INCREMENT,
  `remun_pretend` varchar(15) DEFAULT NULL,
  `experiencia` varchar(30) DEFAULT NULL,
  `rango_edad` varchar(10) DEFAULT NULL,
  `id_persona` int(11) NOT NULL,
  `id_puesto` int(11) NOT NULL,
  PRIMARY KEY (`id_postulante`),
  KEY `fk_id_persona_postul` (`id_persona`),
  KEY `fk_id_puesto_postul` (`id_puesto`),
  CONSTRAINT `fk_id_persona_postul` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id_persona`),
  CONSTRAINT `fk_id_puesto_postul` FOREIGN KEY (`id_puesto`) REFERENCES `puesto` (`id_puesto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agencia_empleo.postulante: ~0 rows (aproximadamente)

-- Volcando estructura para tabla agencia_empleo.puesto
DROP TABLE IF EXISTS `puesto`;
CREATE TABLE IF NOT EXISTS `puesto` (
  `id_puesto` int(11) NOT NULL AUTO_INCREMENT,
  `puesto` varchar(20) DEFAULT NULL,
  `requisitos` varchar(100) DEFAULT NULL,
  `id_empresa` int(11) NOT NULL,
  PRIMARY KEY (`id_puesto`),
  KEY `fk_id_empresa_puesto` (`id_empresa`),
  CONSTRAINT `fk_id_empresa_puesto` FOREIGN KEY (`id_empresa`) REFERENCES `empresa` (`id_empresa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agencia_empleo.puesto: ~0 rows (aproximadamente)

-- Volcando estructura para tabla agencia_empleo.titulo
DROP TABLE IF EXISTS `titulo`;
CREATE TABLE IF NOT EXISTS `titulo` (
  `id_titulo` int(11) NOT NULL AUTO_INCREMENT,
  `titutlo` varchar(20) DEFAULT NULL,
  `habilita` varchar(15) DEFAULT NULL,
  `id_persona` int(11) NOT NULL,
  PRIMARY KEY (`id_titulo`),
  KEY `fk_id_persona_tit` (`id_persona`),
  CONSTRAINT `fk_id_persona_tit` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id_persona`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla agencia_empleo.titulo: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
