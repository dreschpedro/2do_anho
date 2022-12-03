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


-- Volcando estructura de base de datos para bd_alumnos
CREATE DATABASE IF NOT EXISTS `bd_alumnos` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bd_alumnos`;

-- Volcando estructura para tabla bd_alumnos.alumnos
CREATE TABLE IF NOT EXISTS `alumnos` (
  `idAlumno` int(11) NOT NULL AUTO_INCREMENT,
  `dni` varchar(8) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `nombres` varchar(30) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  PRIMARY KEY (`idAlumno`),
  UNIQUE KEY `uk_dni` (`dni`),
  UNIQUE KEY `uk_nomApe` (`apellido`,`nombres`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_alumnos.alumnos: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_alumnos.alumno_materia
CREATE TABLE IF NOT EXISTS `alumno_materia` (
  `id_alum_materia` int(11) NOT NULL AUTO_INCREMENT,
  `id_alumno` int(11) NOT NULL,
  `cod_materia` int(11) NOT NULL,
  PRIMARY KEY (`id_alum_materia`),
  UNIQUE KEY `uk_id_alumno` (`id_alumno`),
  KEY `cod_materia` (`cod_materia`),
  CONSTRAINT `alumno_materia_ibfk_1` FOREIGN KEY (`id_alumno`) REFERENCES `alumnos` (`idAlumno`),
  CONSTRAINT `alumno_materia_ibfk_2` FOREIGN KEY (`cod_materia`) REFERENCES `materia` (`cod_materia`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_alumnos.alumno_materia: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_alumnos.materia
CREATE TABLE IF NOT EXISTS `materia` (
  `cod_materia` int(11) NOT NULL AUTO_INCREMENT,
  `nom_materia` varchar(20) NOT NULL,
  `id_profesor` int(11) NOT NULL,
  PRIMARY KEY (`cod_materia`),
  UNIQUE KEY `uk_nom_materia` (`nom_materia`),
  KEY `id_profesor` (`id_profesor`),
  CONSTRAINT `materia_ibfk_1` FOREIGN KEY (`id_profesor`) REFERENCES `profesor` (`id_profesor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_alumnos.materia: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_alumnos.profesor
CREATE TABLE IF NOT EXISTS `profesor` (
  `id_profesor` int(11) NOT NULL AUTO_INCREMENT,
  `dni_profesor` int(11) NOT NULL,
  `apellido_profesor` varchar(15) NOT NULL,
  `nombres_profesor` varchar(30) NOT NULL,
  `direccion_profesor` varchar(50) NOT NULL,
  `tel_profesor` varchar(12) NOT NULL,
  PRIMARY KEY (`id_profesor`),
  UNIQUE KEY `uk_dni` (`dni_profesor`),
  UNIQUE KEY `uk_nom_ape` (`apellido_profesor`,`nombres_profesor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bd_alumnos.profesor: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
