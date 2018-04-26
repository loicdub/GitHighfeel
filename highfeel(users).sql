-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  mar. 27 mars 2018 à 16:10
-- Version du serveur :  5.7.17
-- Version de PHP :  5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `highfeel`
--
CREATE DATABASE IF NOT EXISTS `highfeel` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `highfeel`;

-- --------------------------------------------------------

--
-- Déchargement des données de la table `belongs`
--

INSERT INTO `belongs` (`clanId`, `userId`) VALUES
(1, 1),
(2, 1),
(1, 2),
(2, 2),
(1, 3),
(2, 3),
(1, 4),
(3, 4),
(1, 5),
(3, 5),
(1, 6),
(1, 7),
(1, 8),
(1, 9),
(1, 10),
(1, 11),
(1, 12);

-- --------------------------------------------------------

--
-- Déchargement des données de la table `clan`
--

INSERT INTO `clan` (`clanId`, `clanName`, `clanAdmin`) VALUES
(1, 'I.FA-P3B', 1),
(2, 'Otaku', 1),
(3, 'Les gros pédés', 4);

-- --------------------------------------------------------

--
-- Déchargement des données de la table `comment`
--

INSERT INTO `comment` (`commentID`, `commentText`, `commentDate`, `userID`) VALUES
(1, 'Je vais mettre fin à aux jours de mon père. Date à suivre...', '2018-03-25', 4);

-- --------------------------------------------------------

--
-- Déchargement des données de la table `feels`
--

INSERT INTO `feels` (`userID`, `moodID`) VALUES
(4, 1);

-- --------------------------------------------------------

--
-- Déchargement des données de la table `mood`
--

INSERT INTO `mood` (`moodID`, `moodRate`, `moodDate`) VALUES
(1, 5, '2018-03-25');

-- --------------------------------------------------------

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`userId`, `userName`, `userPassword`, `userMail`) VALUES
(1, 'admin', 'Super', 'admin@root'),
(2, 'Billy', 'Super', 'billy.ngn@eduge.ch'),
(3, 'Loïc', 'Super', 'loic.dbsmr@eduge.ch'),
(4, 'Jorge', 'Super', NULL),
(5, 'Gregory', 'Super', NULL),
(6, 'Simon', 'Super', NULL),
(7, 'Cristiano', 'Super', NULL),
(8, 'Kiady', 'Super', NULL),
(9, 'Lucas', 'Super', NULL),
(10, 'Thibault', 'Super', NULL),
(11, 'Safia', 'Super', NULL),
(12, 'Terrier-sama', 'Super', NULL);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
