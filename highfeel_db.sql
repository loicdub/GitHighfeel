#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: user
#------------------------------------------------------------

CREATE TABLE user(
        userID       int (11) Auto_increment  NOT NULL ,
        userName     Varchar (50) NOT NULL ,
        userPassword Varchar (50) ,
        userMail     Varchar (50) ,
        moodID       Int ,
        PRIMARY KEY (userID ) ,
        UNIQUE (userName ,userMail )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: mood
#------------------------------------------------------------

CREATE TABLE mood(
        moodID   int (11) Auto_increment  NOT NULL ,
        moodRate Int ,
        moodDate Date ,
        clanId   Int NOT NULL ,
        PRIMARY KEY (moodID )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: clan
#------------------------------------------------------------

CREATE TABLE clan(
        clanId    int (11) Auto_increment  NOT NULL ,
        clanName  Varchar (50) NOT NULL ,
        clanAdmin Bool ,
        PRIMARY KEY (clanId ) ,
        UNIQUE (clanName )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: comment
#------------------------------------------------------------

CREATE TABLE comment(
        commentID   int (11) Auto_increment  NOT NULL ,
        commentText Varchar (150) ,
        commentDate Date ,
        userID      Int NOT NULL ,
        PRIMARY KEY (commentID )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: belongs
#------------------------------------------------------------

CREATE TABLE belongs(
        clanId Int NOT NULL ,
        userID Int NOT NULL ,
        PRIMARY KEY (clanId ,userID )
)ENGINE=InnoDB;

ALTER TABLE user ADD CONSTRAINT FK_user_moodID FOREIGN KEY (moodID) REFERENCES mood(moodID);
ALTER TABLE mood ADD CONSTRAINT FK_mood_clanId FOREIGN KEY (clanId) REFERENCES clan(clanId);
ALTER TABLE comment ADD CONSTRAINT FK_comment_userID FOREIGN KEY (userID) REFERENCES user(userID);
ALTER TABLE belongs ADD CONSTRAINT FK_belongs_clanId FOREIGN KEY (clanId) REFERENCES clan(clanId);
ALTER TABLE belongs ADD CONSTRAINT FK_belongs_userID FOREIGN KEY (userID) REFERENCES user(userID);
