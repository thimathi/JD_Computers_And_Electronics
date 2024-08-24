CREATE DATABASE JDCE_LOCAL_002;
USE JDCE_LOCAL_002;

CREATE TABLE itemTable(
    itemID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
    modelID varchar(50) not null,
    brand varchar(100),
    category varchar(100),
    details varchar(200),
    quantity int,
    barcode int,
    supplier varchar(100),
    sellingPricePerUnit float,
    boughtPrice float,
    status varchar(50)
);

CREATE TABLE availableSTOCKS(
	itemID INT PRIMARY KEY,
	FOREIGN KEY (itemID) REFERENCES itemTable(itemID),
	availableQTY int,
	lastUpdatedDATE DATE);

CREATE TABLE soldSTOCKS(
	itemID INT PRIMARY KEY,
	FOREIGN KEY (itemID) REFERENCES itemTable(itemID),
	soldQTY INT,
	discountRate FLOAT,
	totalSold INT,
	soldDATE DATE);

	

CREATE TABLE invoiceTable(
    invoiceID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
    itemID INT,
    FOREIGN KEY (itemID) REFERENCES itemTable(itemID),
    customerID INT,
    customerName varchar(100),
    customerType varchar(100),
    totalBillAmount float
);

CREATE TABLE returnTable(
    returnID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
    itemID INT,
    FOREIGN KEY (itemID) REFERENCES itemTable(itemID),
    itemDetails varchar(200),
    price float,
    issuedDate date,
    validPeriod int,
    returnReason varchar(200)
);

CREATE TABLE userTable(
	userID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	employeeID INT,
	userType varchar(200),
	fullName varchar(100),
	nic varchar(15),
	tel int,
	email varchar(50),
	userAddress varchar(200),
	dob date,
	username varchar(50),
	details varchar(200),
	userPassword varchar(50),
	positionIndex int);

CREATE TABLE employeeTable(
	employeeID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	userID INT,
	FOREIGN KEY (userID) REFERENCES userTable(userID),
	employeeType varchar(200),
	positionIndex int);

CREATE TABLE paysheetTable(
	paysheetID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	employeeID INT,
	FOREIGN KEY (employeeID) REFERENCES employeeTable(employeeID),
	employeeName varchar(100),
	employeeType varchar(100),
	payMonth varchar(50),
	basicSalary float,
	incentive float,
	workingDays int,
	otHours int,
	hourRate float,
	etf float,
	totalSalary float);

CREATE TABLE report(
	reportID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	reportType varchar(100));

CREATE TABLE schedule(
	scheduleID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	employeeID INT,
	FOREIGN KEY (employeeID) REFERENCES employeeTable(employeeID),
	employeeName varchar(100),
	scheduleDate date,
	scheduleTime time,
	scheduleLocation varchar(200));

CREATE TABLE supplier(
	supplierID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	supplierType varchar(200),
	supplierName varchar(100),
	supplierAddress varchar(200),
	email varchar(50),
	tel int,
	company varchar(100));

CREATE TABLE sessionStart(
	sessionID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	userID INT,
	FOREIGN KEY (userID) REFERENCES userTable(userID),
	sessionStartTime DATETIME);

CREATE TABLE sessionEnd(
	sessionID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	userID INT,
	FOREIGN KEY (userID) REFERENCES userTable(userID),
	sessionEndTime DATETIME);

CREATE TABLE projectTable(
	projectID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	projectName varchar(100),
	projectType varchar(100),
	projectLocation varchar(200),
	customerID INT,
	customerName varchar(100),
	createDate date,
	workingProcedure varchar(200))

CREATE TABLE customerTable(
	customerID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	customerType varchar(100),
	firstName varchar(100),
	lastName varchar(100),
	email varchar(100),
	tel int,
	city varchar(100),
	nic varchar(20),
	customerAddress varchar(200),
	customerLocation varchar(100),
	dob date,
	regDate date,
	gender varchar(20));

CREATE TABLE salesReportCount(
	salesReportID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	itemID INT,
    FOREIGN KEY (itemID) REFERENCES itemTable(itemID),
	salesMonth varchar(100),
	saleType varchar(100),
	itemSold int,
	serviceCharge float,
	materialCost float,
	equipmentCost float,
	totalSalary float,
	transportCost float,
	totalSales int,
	serviceIncome float,
	totalCost float);

CREATE TABLE salesCount(
	salesReportID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	itemID INT,
    FOREIGN KEY (itemID) REFERENCES itemTable(itemID),
	modelID INT,
	brand varchar(100),
	category varchar(100),
	supplier varchar(100),
	qty int,
	stockUpdateDate date,
	qtyAvailable int,
	qtySold int);

CREATE TABLE managerTable(
	managerID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	userID INT,
	FOREIGN KEY (userID) REFERENCES userTable(userID),
	positionIndex int);

CREATE TABLE accountantTable(
	accountantID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	userID INT,
	FOREIGN KEY (userID) REFERENCES userTable(userID),
	positionIndex int);

CREATE TABLE cashierTable(
	cashierID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	userID INT,
	FOREIGN KEY (userID) REFERENCES userTable(userID),
	positionIndex int);

CREATE TABLE siteEngineerTable(
	siteEngineerID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	userID INT,
	FOREIGN KEY (userID) REFERENCES userTable(userID),
	positionIndex int);

CREATE TABLE stockManagerTable(
	stockmanagerID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	userID INT,
	FOREIGN KEY (userID) REFERENCES userTable(userID),
	positionIndex int);

CREATE TABLE workerTable(
	workerID INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	userID INT,
	FOREIGN KEY (userID) REFERENCES userTable(userID),
	positionIndex int);
	
	