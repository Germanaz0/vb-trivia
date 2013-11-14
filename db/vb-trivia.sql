-- phpMyAdmin SQL Dump
-- version 4.0.6deb1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 13, 2013 at 11:12 PM
-- Server version: 5.5.34-0ubuntu0.13.10.1
-- PHP Version: 5.5.3-1ubuntu2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `vb-trivia`
--

-- --------------------------------------------------------

--
-- Table structure for table `preguntas`
--

CREATE TABLE IF NOT EXISTS `preguntas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `pregunta` text NOT NULL,
  `respuesta` text NOT NULL,
  `puntaje` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Dumping data for table `preguntas`
--

INSERT INTO `preguntas` (`id`, `pregunta`, `respuesta`, `puntaje`) VALUES
(4, '¿En qué deporte se usa tiza?.', 'Pool', 5),
(5, '¿Cuántas manos tiene un caballo? ( en número )', '2', 5),
(6, '¿Qué instrumento musical tiene nombre y forma geométricos?', 'triangulo', 5),
(7, '¿Cuáles son las dos primeras palabras de la Biblia?', 'Al Principio', 15),
(8, '¿Quién escribió "El Diario de Ana Frank"?', 'Ana Frank', 20),
(9, '¿Cómo se llaman las crías de la mula?', 'No tiene', 1),
(10, '¿Cuál es el limite de edad establecido para participar en los Juegos Olímpicos? (en número)', '0', 20),
(11, '¿Qué isla del Caribe tiene nombre de flor?', 'Isla Margarita', 15),
(12, '¿Qué capital española tiene cinco veces la misma vocal "a"?', 'Guadalajara', 10),
(13, '¿Cuántas capitales de provincia españolas empiezan por "V"? (en número)', '3', 20);

-- --------------------------------------------------------

--
-- Table structure for table `resultados`
--

CREATE TABLE IF NOT EXISTS `resultados` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario_id` int(11) NOT NULL,
  `resultado` int(11) NOT NULL DEFAULT '0',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `resultados`
--

INSERT INTO `resultados` (`id`, `usuario_id`, `resultado`, `created_at`) VALUES
(7, 1, 36, '2013-11-14 02:12:17');

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `rol` enum('user','admin') NOT NULL DEFAULT 'user',
  PRIMARY KEY (`id`),
  KEY `username` (`username`,`password`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`id`, `username`, `password`, `rol`) VALUES
(1, 'admin', 'admin', 'admin'),
(2, 'user', 'user', 'user');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
