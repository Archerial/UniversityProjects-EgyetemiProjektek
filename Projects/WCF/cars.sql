-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1:3306
-- Létrehozás ideje: 2020. Jan 29. 18:41
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
-- Adatbázis: `cars`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `carstable`
--

DROP TABLE IF EXISTS `carstable`;
CREATE TABLE IF NOT EXISTS `carstable` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `brand` varchar(255) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `type` varchar(255) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `plate_number` char(6) COLLATE latin2_hungarian_ci NOT NULL,
  `age` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=29 DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

--
-- A tábla adatainak kiíratása `carstable`
--

INSERT INTO `carstable` (`id`, `brand`, `type`, `plate_number`, `age`) VALUES
(21, 'Suzuki', 'Ignis', 'FRT234', 23),
(20, 'BMW', 'X5', 'REW324', 6),
(18, 'Ford', 'Escort', 'GHI454', 21),
(19, 'Ford', 'Orion', 'HFR432', 15),
(6, 'Audi', 'A1', 'ABC456', 35),
(7, 'Jaguar', 'X5', 'GFD543', 4),
(22, 'Suzuki', 'Vitara', 'RFT301', 5),
(9, 'Reanult', 'Megan', 'GHI563', 12),
(23, 'Tesla', 'Model S', 'RRR342', 4),
(24, 'Honda', 'Civic', 'HFR434', 16),
(25, 'Mercedes', 'Benz', 'FRE432', 11),
(26, 'Citroen', 'C4', 'FRW345', 16),
(27, 'Peugeot', '307', 'KLP423', 19);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
