-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2024-04-20 10:29:44.786

-- tables
-- Table: Animal
CREATE TABLE Animal (
    IdAnimal int  NOT NULL,
    Name nvarchar(200)  NOT NULL,
    Description nvarchar(200)  NULL,
    Category nvarchar(200)  NOT NULL,
    Area nvarchar(200)  NOT NULL,
    CONSTRAINT Animal_pk PRIMARY KEY  (IdAnimal)
);

-- End of file.

