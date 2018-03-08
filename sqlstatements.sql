/* Get all users of the selected clan */
SELECT DISTINCT `user`.`userName` FROM `user`, `clan`, `belongs` WHERE `user`.`userID` = `belongs`.`userID` AND `belongs`.`clanId` = /* selected clanId */

/* Get all clans of the logged user */
SELECT DISTINCT `clan`.`clanName` FROM `clan`, `user`, `belongs` WHERE `clan`.`clanId` = `belongs`.`clanId` AND `belongs`.`userId` = /* logged userId */

