-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 15 Mars 2018 à 14:50
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `highfeel`
--
CREATE DATABASE IF NOT EXISTS `highfeel` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `highfeel`;

-- --------------------------------------------------------

--
-- Structure de la table `belongs`
--

CREATE TABLE IF NOT EXISTS `belongs` (
  `clanId` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  PRIMARY KEY (`clanId`,`userID`),
  KEY `FK_belongs_userID` (`userID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `belongs`
--

INSERT INTO `belongs` (`clanId`, `userID`) VALUES
(1, 1),
(3, 1),
(2, 2),
(1, 3),
(2, 3);

-- --------------------------------------------------------

--
-- Structure de la table `clan`
--

CREATE TABLE IF NOT EXISTS `clan` (
  `clanId` int(11) NOT NULL AUTO_INCREMENT,
  `clanName` varchar(50) NOT NULL,
  `clanAdmin` int(11) DEFAULT NULL,
  PRIMARY KEY (`clanId`),
  UNIQUE KEY `clanName` (`clanName`),
  KEY `clanAdmin` (`clanAdmin`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `clan`
--

INSERT INTO `clan` (`clanId`, `clanName`, `clanAdmin`) VALUES
(1, 'test', 1),
(2, 'swaggyster', 2),
(3, 'testset', 1);

-- --------------------------------------------------------

--
-- Structure de la table `comment`
--

CREATE TABLE IF NOT EXISTS `comment` (
  `commentID` int(11) NOT NULL AUTO_INCREMENT,
  `commentText` varchar(150) DEFAULT NULL,
  `commentDate` date DEFAULT NULL,
  `userID` int(11) NOT NULL,
  PRIMARY KEY (`commentID`),
  KEY `FK_comment_userID` (`userID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `feels`
--

CREATE TABLE IF NOT EXISTS `feels` (
  `userID` int(11) NOT NULL,
  `moodID` int(11) NOT NULL,
  PRIMARY KEY (`userID`,`moodID`),
  KEY `FK_feels_moodID` (`moodID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `feels`
--

INSERT INTO `feels` (`userID`, `moodID`) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `mood`
--

CREATE TABLE IF NOT EXISTS `mood` (
  `moodID` int(11) NOT NULL AUTO_INCREMENT,
  `moodRate` int(11) DEFAULT NULL,
  `moodDate` date DEFAULT NULL,
  PRIMARY KEY (`moodID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Contenu de la table `mood`
--

INSERT INTO `mood` (`moodID`, `moodRate`, `moodDate`) VALUES
(1, 10, '2018-03-08');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `userID` int(11) NOT NULL AUTO_INCREMENT,
  `userName` varchar(50) NOT NULL,
  `userPassword` varchar(50) DEFAULT NULL,
  `userMail` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`userID`),
  UNIQUE KEY `userName` (`userName`,`userMail`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `user`
--

INSERT INTO `user` (`userID`, `userName`, `userPassword`, `userMail`) VALUES
(1, 'admin', 'Super', 'admin@root'),
(2, 'Billy', 'otacul', 'billy.ngn@eduge.ch'),
(3, 'Loïc', 'otacon', 'loic.dbsmr@eduge.ch');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `belongs`
--
ALTER TABLE `belongs`
  ADD CONSTRAINT `FK_belongs_clanId` FOREIGN KEY (`clanId`) REFERENCES `clan` (`clanId`),
  ADD CONSTRAINT `FK_belongs_userID` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`);

--
-- Contraintes pour la table `clan`
--
ALTER TABLE `clan`
  ADD CONSTRAINT `clan_ibfk_1` FOREIGN KEY (`clanAdmin`) REFERENCES `user` (`userID`);

--
-- Contraintes pour la table `comment`
--
ALTER TABLE `comment`
  ADD CONSTRAINT `FK_comment_userID` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`);

--
-- Contraintes pour la table `feels`
--
ALTER TABLE `feels`
  ADD CONSTRAINT `FK_feels_moodID` FOREIGN KEY (`moodID`) REFERENCES `mood` (`moodID`),
  ADD CONSTRAINT `FK_feels_userID` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
