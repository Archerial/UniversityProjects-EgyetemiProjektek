-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1:3306
-- Létrehozás ideje: 2020. Jan 28. 16:00
-- Kiszolgáló verziója: 5.7.26
-- PHP verzió: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `aawebprog`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `pictures`
--

DROP TABLE IF EXISTS `pictures`;
CREATE TABLE IF NOT EXISTS `pictures` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `image` varchar(200) COLLATE latin2_hungarian_ci NOT NULL,
  `text` text COLLATE latin2_hungarian_ci NOT NULL,
  `uploader` varchar(200) COLLATE latin2_hungarian_ci NOT NULL,
  `picname` varchar(250) COLLATE latin2_hungarian_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `picname` (`picname`)
) ENGINE=MyISAM AUTO_INCREMENT=136 DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

--
-- A tábla adatainak kiíratása `pictures`
--

INSERT INTO `pictures` (`id`, `image`, `text`, `uploader`, `picname`) VALUES
(134, 'images.jpg', 'asf', 'adam', 'mario'),
(135, 'Cat03.jpg', 'Look my cat', 'user', 'mycat');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) COLLATE latin2_hungarian_ci NOT NULL,
  `email` varchar(255) COLLATE latin2_hungarian_ci NOT NULL,
  `password` varchar(255) COLLATE latin2_hungarian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `username`, `email`, `password`) VALUES
(6, 'eszter', 'eszter@sample.com', 'e43228f5ebcdc95e00951dc69f29e343'),
(5, 'Adam', 'adam@example.com', '1d7c2923c1684726dc23d2901c4d8157'),
(4, 'User', 'user@sample.copm', 'ee11cbb19052e40b07aac0ca060c23ee'),
(7, 'joel', 'joel@sample.com', 'c000ccf225950aac2a082a59ac5e57ff');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
