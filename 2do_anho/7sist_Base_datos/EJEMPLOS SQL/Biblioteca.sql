-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         5.5.5-10.0.13-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win32
-- HeidiSQL Versión:             8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Volcando estructura de base de datos para biblioteca
CREATE DATABASE IF NOT EXISTS `biblioteca` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `biblioteca`;


-- Volcando estructura para tabla biblioteca.autor
CREATE TABLE IF NOT EXISTS `autor` (
  `claveautor` int(11) NOT NULL,
  `nombre` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`claveautor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla biblioteca.autor: ~13 rows (aproximadamente)
/*!40000 ALTER TABLE `autor` DISABLE KEYS */;
INSERT INTO `autor` (`claveautor`, `nombre`) VALUES
	(2001, 'Mauro Zara'),
	(2002, 'Laura Peralta'),
	(2003, 'Guido Baldo'),
	(2004, 'Cecilia Velozo'),
	(2005, 'Alejandra Romeo'),
	(2006, 'Claudia Pugliese'),
	(2007, 'Elizabeth Uño'),
	(2008, 'Alicia Acconcia'),
	(2009, 'Angel Puente'),
	(2010, 'Rita Goma'),
	(2011, 'Carla Roa'),
	(2012, 'Virginia Pua'),
	(2013, 'Leticia Puara');
/*!40000 ALTER TABLE `autor` ENABLE KEYS */;


-- Volcando estructura para tabla biblioteca.editorial
CREATE TABLE IF NOT EXISTS `editorial` (
  `claveeditorial` smallint(6) NOT NULL,
  `nombre` varchar(60) DEFAULT NULL,
  `direccion` varchar(60) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`claveeditorial`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla biblioteca.editorial: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `editorial` DISABLE KEYS */;
INSERT INTO `editorial` (`claveeditorial`, `nombre`, `direccion`, `telefono`) VALUES
	(1001, 'Santillana', 'calle aaa', '14253653'),
	(1002, 'Repetto', 'calle bbb', '15689632'),
	(1003, 'Pantaleon', 'calle ccc', '54698756'),
	(1004, 'Smith', 'calle ddd', '58963254'),
	(1005, 'Rosa', 'calle eee', '78965432');
/*!40000 ALTER TABLE `editorial` ENABLE KEYS */;


-- Volcando estructura para tabla biblioteca.ejemplar
CREATE TABLE IF NOT EXISTS `ejemplar` (
  `clavelibro` int(11) NOT NULL,
  `numeroorden` smallint(6) NOT NULL,
  `ubicacion` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`clavelibro`,`numeroorden`),
  CONSTRAINT `ejemplar_ibfk_1` FOREIGN KEY (`clavelibro`) REFERENCES `libro` (`clavelibro`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla biblioteca.ejemplar: ~22 rows (aproximadamente)
/*!40000 ALTER TABLE `ejemplar` DISABLE KEYS */;
INSERT INTO `ejemplar` (`clavelibro`, `numeroorden`, `ubicacion`) VALUES
	(1001, 1, 'a2'),
	(1001, 2, 'a2'),
	(1001, 3, 'a3'),
	(1002, 1, 'a10'),
	(1002, 2, 'a11'),
	(1003, 1, 'a22'),
	(1004, 1, 'b1'),
	(1004, 2, 'b2'),
	(1004, 3, 'b3'),
	(1005, 1, 'b14'),
	(1005, 2, 'b15'),
	(1006, 1, 'a7'),
	(1006, 2, 'a8'),
	(1007, 1, 'c12'),
	(1007, 2, 'c13'),
	(1007, 3, 'c14'),
	(1008, 1, 'c4'),
	(1008, 3, 'c6'),
	(1009, 1, 'f5'),
	(1010, 1, 'f10'),
	(1010, 2, 'f11'),
	(1010, 3, 'f12');
/*!40000 ALTER TABLE `ejemplar` ENABLE KEYS */;


-- Volcando estructura para tabla biblioteca.escrito_por
CREATE TABLE IF NOT EXISTS `escrito_por` (
  `clavelibro` int(11) NOT NULL,
  `claveautor` int(11) NOT NULL,
  KEY `clavelibro` (`clavelibro`),
  KEY `claveautor` (`claveautor`),
  CONSTRAINT `escrito_por_ibfk_1` FOREIGN KEY (`clavelibro`) REFERENCES `libro` (`clavelibro`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `escrito_por_ibfk_2` FOREIGN KEY (`claveautor`) REFERENCES `autor` (`claveautor`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla biblioteca.escrito_por: ~16 rows (aproximadamente)
/*!40000 ALTER TABLE `escrito_por` DISABLE KEYS */;
INSERT INTO `escrito_por` (`clavelibro`, `claveautor`) VALUES
	(1001, 2002),
	(1001, 2003),
	(1001, 2009),
	(1002, 2001),
	(1003, 2004),
	(1003, 2005),
	(1003, 2006),
	(1004, 2007),
	(1004, 2008),
	(1005, 2008),
	(1006, 2009),
	(1007, 2009),
	(1007, 2010),
	(1008, 2011),
	(1009, 2012),
	(1010, 2013);
/*!40000 ALTER TABLE `escrito_por` ENABLE KEYS */;


-- Volcando estructura para tabla biblioteca.libro
CREATE TABLE IF NOT EXISTS `libro` (
  `clavelibro` int(11) NOT NULL,
  `titulo` varchar(60) DEFAULT NULL,
  `idioma` varchar(15) DEFAULT NULL,
  `formato` varchar(15) DEFAULT NULL,
  `edicion` smallint(6) DEFAULT NULL,
  `claveeditorial` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`clavelibro`),
  KEY `claveeditorial` (`claveeditorial`),
  CONSTRAINT `libro_ibfk_1` FOREIGN KEY (`claveeditorial`) REFERENCES `editorial` (`claveeditorial`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla biblioteca.libro: ~10 rows (aproximadamente)
/*!40000 ALTER TABLE `libro` DISABLE KEYS */;
INSERT INTO `libro` (`clavelibro`, `titulo`, `idioma`, `formato`, `edicion`, `claveeditorial`) VALUES
	(1001, 'Analisis matematico I', 'español', '30x40', 1990, 1001),
	(1002, 'Programacion en C', 'español', '22x24', 2000, 1002),
	(1003, 'Estructura de base de datos', 'español', '30x35', 2005, 1003),
	(1004, 'PHP', 'español', '35x30', 2005, 1004),
	(1005, 'Algebra I', 'español', '35x30', 1994, 1005),
	(1006, 'Ingles Tecnico III', 'español', '30x36', 1998, 1001),
	(1007, 'Sistemas de Computacion I', 'español', '35x35', 1992, 1002),
	(1008, 'Modelos Discretos II', 'español', '35x40', 2001, 1003),
	(1009, 'MySQL', 'español', '30x28', 2009, 1004),
	(1010, 'Access', 'español', '25x30', 2003, 1005);
/*!40000 ALTER TABLE `libro` ENABLE KEYS */;


-- Volcando estructura para tabla biblioteca.prestamo
CREATE TABLE IF NOT EXISTS `prestamo` (
  `numeroprestamo` int(11) NOT NULL AUTO_INCREMENT,
  `clavesocio` int(11) NOT NULL,
  `clavelibro` int(11) NOT NULL,
  `numeroorden` smallint(6) NOT NULL,
  `fecha_prestamo` date NOT NULL,
  `fecha_devolucion` date DEFAULT NULL,
  `notas` blob,
  PRIMARY KEY (`numeroprestamo`),
  KEY `clavesocio` (`clavesocio`),
  KEY `clavelibro` (`clavelibro`,`numeroorden`),
  CONSTRAINT `prestamo_ibfk_1` FOREIGN KEY (`clavesocio`) REFERENCES `socio` (`clavesocio`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `prestamo_ibfk_2` FOREIGN KEY (`clavelibro`, `numeroorden`) REFERENCES `ejemplar` (`clavelibro`, `numeroorden`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla biblioteca.prestamo: ~7 rows (aproximadamente)
/*!40000 ALTER TABLE `prestamo` DISABLE KEYS */;
INSERT INTO `prestamo` (`numeroprestamo`, `clavesocio`, `clavelibro`, `numeroorden`, `fecha_prestamo`, `fecha_devolucion`, `notas`) VALUES
	(1, 1, 1007, 1, '2009-06-01', '2009-06-21', NULL),
	(2, 3, 1007, 2, '2012-05-30', '2012-06-05', NULL),
	(3, 3, 1001, 1, '2012-08-10', '2012-08-17', NULL),
	(4, 5, 1004, 1, '2012-07-22', '2012-07-25', NULL),
	(5, 8, 1006, 1, '2012-08-14', '2012-08-17', NULL),
	(6, 8, 1009, 1, '2012-06-10', '2012-08-17', NULL),
	(7, 7, 1010, 1, '2012-06-13', '2012-06-19', NULL);
/*!40000 ALTER TABLE `prestamo` ENABLE KEYS */;


-- Volcando estructura para tabla biblioteca.socio
CREATE TABLE IF NOT EXISTS `socio` (
  `clavesocio` int(11) NOT NULL,
  `nombre` varchar(60) DEFAULT NULL,
  `direccion` varchar(60) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `categoria` char(1) DEFAULT NULL,
  PRIMARY KEY (`clavesocio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla biblioteca.socio: ~8 rows (aproximadamente)
/*!40000 ALTER TABLE `socio` DISABLE KEYS */;
INSERT INTO `socio` (`clavesocio`, `nombre`, `direccion`, `telefono`, `categoria`) VALUES
	(1, 'Alex Pool', 'Triunvirato 554', '4657:8906', '1'),
	(2, 'Tomas Bowling', 'Los incas 123', '4567:9078', '1'),
	(3, 'Lucia Football', 'Moron 234', '4454:7890', '2'),
	(4, 'Alejandra Guitar', 'San Paolo 678', '6243:6588', '3'),
	(5, 'Juana De Arco', 'Liniers 452', '6325:0990', '4'),
	(6, 'Alex De La Iglesia', 'Ituzaingo 56', '6928:8790', '5'),
	(7, 'Jigoro Kano', 'Finlandia 78', '4567:9809', '6'),
	(8, 'Bob Esponja', 'Cuadrados 56', '4356:8790', '2');
/*!40000 ALTER TABLE `socio` ENABLE KEYS */;


-- Volcando estructura para tabla biblioteca.tema
CREATE TABLE IF NOT EXISTS `tema` (
  `clavetema` smallint(6) NOT NULL,
  `nombre` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`clavetema`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla biblioteca.tema: ~24 rows (aproximadamente)
/*!40000 ALTER TABLE `tema` DISABLE KEYS */;
INSERT INTO `tema` (`clavetema`, `nombre`) VALUES
	(1, 'anàlisis matemàtico'),
	(2, 'programaciòn lineal'),
	(3, 'base de datos'),
	(4, 'redes de Petri'),
	(5, 'programaciòn dinàmica'),
	(6, 'ecuaciones diferenciales'),
	(7, 'protocolo de enrutamiento'),
	(8, 'inglès tècnico'),
	(9, 'programaciòn pàginas Web'),
	(10, 'administraciòn de memoria'),
	(11, 'almacenamiento secundario'),
	(12, 'perifèricos'),
	(13, 'sistema de base de datos'),
	(14, 'diseño de base de datos'),
	(15, 'programaciòn orientada al objeto'),
	(16, 'campos vectoriales'),
	(17, 'transformaciones lineales'),
	(18, 'comunicaciones satelitarias'),
	(19, 'algebra de Boole'),
	(20, 'diseño de pàginas web'),
	(21, 'Lenguaje de proramación C'),
	(22, 'Diccionario'),
	(23, 'Ingles'),
	(24, 'Lenguaje SQL');
/*!40000 ALTER TABLE `tema` ENABLE KEYS */;


-- Volcando estructura para tabla biblioteca.trata_sobre
CREATE TABLE IF NOT EXISTS `trata_sobre` (
  `clavelibro` int(11) NOT NULL,
  `clavetema` smallint(6) NOT NULL,
  KEY `clavelibro` (`clavelibro`),
  KEY `clavetema` (`clavetema`),
  CONSTRAINT `trata_sobre_ibfk_1` FOREIGN KEY (`clavelibro`) REFERENCES `libro` (`clavelibro`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `trata_sobre_ibfk_2` FOREIGN KEY (`clavetema`) REFERENCES `tema` (`clavetema`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla biblioteca.trata_sobre: ~30 rows (aproximadamente)
/*!40000 ALTER TABLE `trata_sobre` DISABLE KEYS */;
INSERT INTO `trata_sobre` (`clavelibro`, `clavetema`) VALUES
	(1001, 1),
	(1001, 6),
	(1001, 16),
	(1002, 15),
	(1002, 21),
	(1003, 3),
	(1003, 13),
	(1003, 14),
	(1004, 3),
	(1004, 9),
	(1004, 20),
	(1005, 2),
	(1005, 5),
	(1005, 4),
	(1005, 16),
	(1005, 17),
	(1005, 19),
	(1006, 22),
	(1006, 23),
	(1007, 10),
	(1007, 11),
	(1007, 12),
	(1008, 5),
	(1008, 4),
	(1008, 16),
	(1009, 3),
	(1009, 12),
	(1009, 24),
	(1010, 3),
	(1010, 12);
/*!40000 ALTER TABLE `trata_sobre` ENABLE KEYS */;


-- Volcando estructura para tabla biblioteca.user
CREATE TABLE IF NOT EXISTS `user` (
  `user_id` varchar(40) NOT NULL,
  `user_pas` varchar(40) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla biblioteca.user: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
