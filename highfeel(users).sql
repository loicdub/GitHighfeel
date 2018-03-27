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
-- Structure de la table `belongs`
--

CREATE TABLE `belongs` (
  `clanId` int(11) NOT NULL,
  `userId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
-- Structure de la table `clan`
--

CREATE TABLE `clan` (
  `clanId` int(11) NOT NULL,
  `clanName` varchar(50) NOT NULL,
  `clanAdmin` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `clan`
--

INSERT INTO `clan` (`clanId`, `clanName`, `clanAdmin`) VALUES
(1, 'I.FA-P3B', 1),
(2, 'Otaku', 1),
(3, 'Les gros pédés', 4);

-- --------------------------------------------------------

--
-- Structure de la table `comment`
--

CREATE TABLE `comment` (
  `commentID` int(11) NOT NULL,
  `commentText` varchar(150) DEFAULT NULL,
  `commentDate` date DEFAULT NULL,
  `userID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `comment`
--

INSERT INTO `comment` (`commentID`, `commentText`, `commentDate`, `userID`) VALUES
(1, 'Je vais mettre fin à aux jours de mon père. Date à suivre...', '2018-03-25', 4);

-- --------------------------------------------------------

--
-- Structure de la table `feels`
--

CREATE TABLE `feels` (
  `userID` int(11) NOT NULL,
  `moodID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `feels`
--

INSERT INTO `feels` (`userID`, `moodID`) VALUES
(4, 1);

-- --------------------------------------------------------

--
-- Structure de la table `mood`
--

CREATE TABLE `mood` (
  `moodID` int(11) NOT NULL,
  `moodRate` int(11) DEFAULT NULL,
  `moodDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `mood`
--

INSERT INTO `mood` (`moodID`, `moodRate`, `moodDate`) VALUES
(1, 5, '2018-03-25');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `userId` int(11) NOT NULL,
  `userName` varchar(50) NOT NULL,
  `userPassword` varchar(50) DEFAULT NULL,
  `userMail` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `belongs`
--
ALTER TABLE `belongs`
  ADD PRIMARY KEY (`clanId`,`userId`),
  ADD KEY `FK_belongs_userID` (`userId`);

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
  ADD PRIMARY KEY (`userID`,`moodID`),
  ADD KEY `FK_feels_moodID` (`moodID`);

--
-- Index pour la table `mood`
--
ALTER TABLE `mood`
  ADD PRIMARY KEY (`moodID`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userId`),
  ADD UNIQUE KEY `userName` (`userName`,`userMail`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `clan`
--
ALTER TABLE `clan`
  MODIFY `clanId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `comment`
--
ALTER TABLE `comment`
  MODIFY `commentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT pour la table `mood`
--
ALTER TABLE `mood`
  MODIFY `moodID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `userId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `belongs`
--
ALTER TABLE `belongs`
  ADD CONSTRAINT `FK_belongs_clanId` FOREIGN KEY (`clanId`) REFERENCES `clan` (`clanId`),
  ADD CONSTRAINT `FK_belongs_userID` FOREIGN KEY (`userId`) REFERENCES `user` (`userId`);

--
-- Contraintes pour la table `clan`
--
ALTER TABLE `clan`
  ADD CONSTRAINT `clan_ibfk_1` FOREIGN KEY (`clanAdmin`) REFERENCES `user` (`userId`);

--
-- Contraintes pour la table `comment`
--
ALTER TABLE `comment`
  ADD CONSTRAINT `FK_comment_userID` FOREIGN KEY (`userID`) REFERENCES `user` (`userId`);

--
-- Contraintes pour la table `feels`
--
ALTER TABLE `feels`
  ADD CONSTRAINT `FK_feels_moodID` FOREIGN KEY (`moodID`) REFERENCES `mood` (`moodID`),
  ADD CONSTRAINT `FK_feels_userID` FOREIGN KEY (`userID`) REFERENCES `user` (`userId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
