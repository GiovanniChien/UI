create database goodmanagesys;
use goodmanagesys;

create table category(
	categoryID int NOT NULL AUTO_INCREMENT,
	categoryName varchar(100),
	parentCategoryID int,
	parentCategoryName varchar(50),
	unit varchar(10),
	color varchar(10),
	firm varchar(100),
	minStock int,
	maxStock int,
	expirationDate int,
	isValid tinyint(1),
	PRIMARY KEY(categoryID)
);

create table good(
	goodID int NOT NULL AUTO_INCREMENT,
	categoryID int,
	productionDate varchar(10),
	purchaseDate varchar(10),
	cost double,
	price double,
	isValid tinyint(1),
	PRIMARY KEY(goodID),
	FOREIGN KEY(categoryID) REFERENCES category(categoryID)
);

create table staff(
	staffID int not null auto_increment,
	staffName varchar(20),
	pwd varchar(20),
	staffPhone varchar(15),
	role int,
	PRIMARY KEY(staffID)
);

create table sale(
	saleID int not null auto_increment,
	goodID int,
	saleDate varchar(10),
	profit double,
	staffID int,
	PRIMARY KEY(saleID,goodID),
	FOREIGN KEY(goodID) REFERENCES good(goodID),
	FOREIGN KEY(staffID) REFERENCES staff(staffID)
); 

create table membership(
	msID int not null auto_increment,
	msName varchar(20),
	msPhone varchar(15),
	msPoint int,
	isValid tinyint(1),
	PRIMARY KEY(msID)
);

create table purchase(
	purchaseID int not null auto_increment,
	categoryID int,
	purchaseDate varchar(10),
	quantity int,
	cost double,
	staffID int,
	PRIMARY KEY(purchaseID,categoryID),
	FOREIGN KEY(categoryID) REFERENCES category(categoryID),
	FOREIGN KEY(staffID) REFERENCES staff(staffID)
);
