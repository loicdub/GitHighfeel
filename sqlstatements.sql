/* Get all users of the selected clan */
SELECT DISTINCT `user`.`userName` FROM `user`, `clan`, `belongs` WHERE `user`.`userID` = `belongs`.`userID` AND `belongs`.`clanId` = /* selected clanId */

/* Get all clans of the logged user */
SELECT DISTINCT `clan`.`clanName` FROM `clan`, `user`, `belongs` WHERE `clan`.`clanId` = `belongs`.`clanId` AND `belongs`.`userId` = /* logged userId */

/*----------------------------------------------- CREATE CLAN -----------------------------------------------*/
/* Create a clan */
INSERT INTO `highfeel`.`clan` (`clanName`, `clanAdmin`) VALUES ('/* tbxClanName */', '/* connected userId */');
/* Get the clanId of the created clan */
int $clanId = SELECT `clanId` FROM `clan` WHERE `clanName` = "/* tbxClanName */"
/* Add the connected user as admin of new clan */
INSERT INTO `highfeel`.`belongs` (`clanId`, `userID`) VALUES ('$clanId', '/* connected userId */');
/*-----------------------------------------------------------------------------------------------------------*/

/* Add members to a clan */
int $userId = SELECT `userID` FROM `user` WHERE `userName` = "/* selected userName */"
INSERT INTO `highfeel`.`belongs` (`clanId`, `userID`) VALUES ('/* selected clanId */', '/* selected userId */');

/* Show all users */
SELECT * FROM `user`

/* Send note */
INSERT INTO `highfeel`.`mood` (`moodID`, `moodRate`, `moodDate`) VALUES (NULL, '/* note clicked by user */', '/* selected date */');
INSERT INTO `highfeel`.`feels` (`userID`, `moodID`) VALUES ('/* connected userId */', '/* moodId */');
