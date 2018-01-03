# HumaneSociety

DB
-------------
Create Table People
(
ID int IDENTITY(1,1) PRIMARY KEY,
Pet_Name varchar(50),
Animal_Type int,
Age int,
Cost float,
Room_Number int,
Adoption_Status bit,
Shot_Status bit,
Food_Consumption int,
);

Create Table Age
(
ID int IDENTITY(1,1) PRIMARY KEY,
Age_in_Years float,
);

Create Table Animal_Type
(
ID int IDENTITY(1,1) PRIMARY KEY,
Species Varchar(50),
);

Create Table Food_Amount
(
ID int IDENTITY(1,1) PRIMARY KEY,
Lbs_Of_Food_Weekly float,
);

Create Table Room_Number
(
ID int IDENTITY(1,1) PRIMARY KEY,
Room int,
);

EXEC sp_rename 'People', 'Animals'

ALTER TABLE Animals
ADD FOREIGN KEY (Animal_Type) REFERENCES Animal_Type(ID);

ALTER TABLE Animals
ADD FOREIGN KEY (Room_Number) REFERENCES Room_Number(ID);

ALTER TABLE Animals
ADD FOREIGN KEY (Food_Consumption) REFERENCES Food_Amount(ID);

ALTER TABLE Animals
ADD FOREIGN KEY (Age) REFERENCES Age(ID);

INSERT INTO Animal_Type VALUES ('Cat'), ('Dog'), ('Bird'), ('Rabbit'), ('Ferret');

INSERT INTO Age VALUES ('.5'), ('1'), ('2'), ('3'), ('4'), ('5'), ('6'), ('7'), ('8'), ('9'), ('10'), ('11'), ('12');

INSERT INTO Food_Amount VALUES ('.5'), ('1'), ('1.5'), ('2'), ('2.5'), ('3'), ('3.5'), ('4'), ('4.5'), ('5'), ('5.5'), ('6');

INSERT INTO Room_Number VALUES ('1'), ('2'), ('3'), ('4'), ('5'), ('6'), ('7'), ('8'), ('9'), ('10');