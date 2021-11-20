CREATE DATABASE Hotel;
use Hotel;
select * from User_table;
drop table User_Table;
drop database db_hotel;

CREATE TABLE Users
(
	User_ID INT IDENTITY (1,1) PRIMARY KEY,
	User_LoginName VARCHAR(150) UNIQUE NOT NULL,
	User_Password VARCHAR(150) NOT NULL,
	User_FirstName VARCHAR (100) NOT NULL,
	User_LastName VARCHAR (100) NOT NULL,
	User_Position VARCHAR (100) NOT NULL,
	User_Email VARCHAR (100) NOT NULL,
	
);

declare @user varchar(100)='admin'
declare @pass varchar(100)='admin'
select *from Users where User_LoginName=@user and User_Password=@pass

INSERT INTO Users VALUES ('admin','admin', 'Rafael','Silva','Administrador','suporte@hotelsantos.com');

INSERT INTO Users VALUES ('rafael.juliao','f23dbc4', 'Rafael','Juliao','Administrador','rafajuliao@outlook.com');

INSERT INTO Users VALUES ('vinicius.galvao','f23cij6', 'Vinicius','Galvao','Administrador','suporte@hotelsantos.com');

INSERT INTO Users VALUES ('carlos.pinheiro','f21ijj0', 'Carlos','Pinheiro','Administrador','suporte@hotelsantos.com');

INSERT INTO Users VALUES ('murillo.cabral','f23aaf2', 'Murillo','Cabral','Administrador','suporte@hotelsantos.com');

INSERT INTO Users VALUES ('lenik.bryan','n621478', 'Lenik','Bryan','Administrador','suporte@hotelsantos.com');

INSERT INTO Users VALUES ('ayala.neto','n665971', 'Ayala','Neto','Administrador','suporte@hotelsantos.com');



select * from Users;

UPDATE User_Table
SET user_name = 'lenik.bryan'
WHERE user_id = 5

DELETE FROM User_Table
WHERE user_id = 6

drop table User_Table;

SELECT * from Client_Table;
CREATE TABLE Client_Table
(
	Client_ID INT IDENTITY(1,1) NOT NULL,
	Client_FirstName VARCHAR(150) NOT NULL,
	Client_LastName VARCHAR(150) NOT NULL,
	Client_Phone VARCHAR(15) UNIQUE NOT NULL,
	Client_Address VARCHAR(150) NOT NULL,
	CONSTRAINT Client_Table_Client_ID_PK PRIMARY KEY (Client_ID)
);



INSERT INTO Client_Table VALUES
('Daniel','Dantas','988776655','Guaruja'),
('Felipe','Mendes','988776611','Santos'),
('Neymar','Junior','988446622','Paris');

CREATE TABLE Room_Table
(
	Room_Number INT IDENTITY(1,1) NOT NULL,
	Room_Type VARCHAR(20) NOT NULL,
	Room_Phone VARCHAR(15) UNIQUE NOT NULL,
	Room_Free VARCHAR(3) NOT NULL,
	CONSTRAINT Room_Table_Room_Number_PK PRIMARY KEY (Room_Number)
);
drop table Room_Table
select * from Room_Table
INSERT INTO Room_Table VALUES
('Solteiro','1234','Yes'),
('Familia','5678','No'),
('Presidencial','9988','YES');

update Room_Table
set Room_Free = 'Yes'
where Room_Number = 3;