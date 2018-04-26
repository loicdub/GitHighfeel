-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  jeu. 26 avr. 2018 à 15:09
-- Version du serveur :  5.7.17
-- Version de PHP :  7.1.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `highfeel2`
--
CREATE DATABASE IF NOT EXISTS `highfeel2` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `highfeel2`;

-- --------------------------------------------------------

--
-- Structure de la table `belongs`
--

DROP TABLE IF EXISTS `belongs`;
CREATE TABLE `belongs` (
  `clanId` int(11) NOT NULL,
  `userID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `belongs`
--

INSERT INTO `belongs` (`clanId`, `userID`) VALUES
(1, 1),
(2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `clan`
--

DROP TABLE IF EXISTS `clan`;
CREATE TABLE `clan` (
  `clanId` int(11) NOT NULL,
  `clanName` varchar(50) NOT NULL,
  `clanAdmin` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `clan`
--

INSERT INTO `clan` (`clanId`, `clanName`, `clanAdmin`) VALUES
(1, 'Test', 1),
(2, 'I', 1);

-- --------------------------------------------------------

--
-- Structure de la table `comment`
--

DROP TABLE IF EXISTS `comment`;
CREATE TABLE `comment` (
  `commentID` int(11) NOT NULL,
  `commentText` varchar(150) DEFAULT NULL,
  `commentDate` date DEFAULT NULL,
  `userID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `feels`
--

DROP TABLE IF EXISTS `feels`;
CREATE TABLE `feels` (
  `userID` int(11) NOT NULL,
  `moodID` int(11) NOT NULL,
  `clanId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `mood`
--

DROP TABLE IF EXISTS `mood`;
CREATE TABLE `mood` (
  `moodID` int(11) NOT NULL,
  `moodRate` int(11) DEFAULT NULL,
  `moodDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `userID` int(11) NOT NULL,
  `userName` varchar(50) NOT NULL,
  `userPassword` varchar(50) DEFAULT NULL,
  `userMail` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`userID`, `userName`, `userPassword`, `userMail`) VALUES
(1, 'admin', 'Super', 'admin@root');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `belongs`
--
ALTER TABLE `belongs`
  ADD PRIMARY KEY (`clanId`,`userID`),
  ADD KEY `FK_belongs_userID` (`userID`);

--
-- Index pour la table `clan`
--
ALTER TABLE `clan`
  ADD PRIMARY KEY (`clanId`),
  ADD UNIQUE KEY `clanName` (`clanName`),
  ADD KEY `clanAdmin` (`clanAdmin`);

--
-- Index pour la table `comment`
--
ALTER TABLE `comment`
  ADD PRIMARY KEY (`commentID`),
  ADD KEY `FK_comment_userID` (`userID`);

--
-- Index pour la table `feels`
--
ALTER TABLE `feels`
  ADD PRIMARY KEY (`userID`,`moodID`,`clanId`),
  ADD KEY `FK_feels_moodID` (`moodID`),
  ADD KEY `FK_feels_clanId` (`clanId`),
  ADD KEY `userID` (`userID`);

--
-- Index pour la table `mood`
--
ALTER TABLE `mood`
  ADD PRIMARY KEY (`moodID`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userID`),
  ADD UNIQUE KEY `userName` (`userName`,`userMail`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `clan`
--
ALTER TABLE `clan`
  MODIFY `clanId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `comment`
--
ALTER TABLE `comment`
  MODIFY `commentID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `mood`
--
ALTER TABLE `mood`
  MODIFY `moodID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Contraintes pour les tables déchargées
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
  ADD CONSTRAINT `FK_feels_clanId` FOREIGN KEY (`clanId`) REFERENCES `clan` (`clanId`),
  ADD CONSTRAINT `FK_feels_moodID` FOREIGN KEY (`moodID`) REFERENCES `mood` (`moodID`),
  ADD CONSTRAINT `FK_feels_userID` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
