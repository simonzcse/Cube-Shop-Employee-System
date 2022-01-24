drop database IF EXISTS project_manangement;
CREATE DATABASE `project_manangement` character set utf8;
use project_manangement;

drop  TABLE IF EXISTS Tenant;
create table Tenant
(
	TenantID int(9) NOT NULL,
	Name Varchar(255) NOT NULL,
	Phone Int(8) NOT NULL,
	Address varchar(255)	NOT NULL,
	Email Varchar(255) NOT NULL,
	DateTimeofCreation	DATETIME	 NULL,
	Tenant_Username varchar(20) 	NOT NULL,
	Tenant_Password varchar(20) 	NOT NULL,
	DateOfBirth	DATE	NOT NULL,
	Tenant_HKIDNumber	VARCHAR(20)	NOT NULL,
	CommisionRate int(3)	not null,
	
		CONSTRAINT PK_Tenant PRIMARY KEY (TenantID)
 );
 ALTER TABLE `Tenant` CHANGE `DateTimeofCreation` `DateTimeofCreation` DATETIME NULL DEFAULT CURRENT_TIMESTAMP;
 insert  into `Tenant` values (100000001,'Roy Chan','12345678', '4/F 20 Tsing Yi Road NT', 'x5800@gmail.com','2018-01-10 17:27:34', 'royC', 'roy12345', '1928-01-13', 'H123456(7)', 1);
 insert  into `Tenant` values (100000002,'Ben Chan','45456456', '12/F 123 Nathen Road KLN','hghg@gmail.com','2018-02-13 17:27:34', 'benC', 'benC12345', '1960-01-13', 'H123456(7)', 2);
 insert  into `Tenant` values (100000003,'John Wick','43578566', '5/F 34 Canton Road KLN','john.wick@gmail.com','2018-06-13 17:27:34', 'Jardani', 'Jardani12345', '1985-03-13', 'H123456(7)', 3);
 insert  into `Tenant` values (100000004,'Mariyan Aditi','67426364', '2/F House 5 Tuen Mun Village NT','ggrrhrh@gmail.com','2018-06-13 17:27:34', 'AditiA', 'AditiA12345', '1985-04-13', 'H123456(7)', 4);
 insert  into `Tenant` values (100000005,'Flo Lovise','46327785', '6/F 234 Causeway Road HK','Lovise@gmail.com','2018-06-13 17:49:37', 'LoviseF', 'LoviseF12345', '1973-05-13', 'H123456(7)', 5);

 
 drop table IF EXISTS Customer;
 create table Customer
(
	CustomerID Int(9) NOT NULL,
	DateTIMEofCreation	dateTIME	NOT NULL,
	Name	Varchar(255) NOT NULL,
	Phone	Int(8)	 NOT NULL,
	email	Varchar(255)  NOT NULL,
	Customer_Username varchar(20) not null,
	Customer_password varchar(20) not null,
	DateOfBirth	DATE	NOT NULL,
			CONSTRAINT PK_Customer PRIMARY KEY (CustomerID)
 );
ALTER TABLE `customer` CHANGE `DateTIMEofcreation` `DateTIMEofcreation` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP;
insert  into `Customer` values (219000001,'2019-01-14 03:32:39', 'Saibh Concepta','45325743','saibh.concepta@gmail.com', 'SaibhC', 'Saibh12345', '1974-03-23');
insert  into `Customer` values (219000002,'2019-02-01 03:32:39', 'Manish Pasqualina','54535654','manish.pasqualina@gmail.com', 'ManishP', 'Manish12345', '1977-02-21');
insert  into `Customer` values (219000003,'2019-03-24 03:32:39', 'Mayamiko Anže','55656542','saibh.concepta@gmail.com', 'MayamikoA', 'Mayamiko12345', '1933-03-25');
insert  into `Customer` values (219000004,'2019-04-18 03:32:39', 'Blagoje Muhtar','73456256','saibh.concepta@gmail.com', 'BlagojeM', 'Blagoje12345', '1973-08-23'); 
insert  into `Customer` values (219000005,'2019-05-13 03:32:39', 'David Muhsin','12525655','saibh.concepta@gmail.com', 'DavidM', 'David12345', '1973-01-29'); 
/*All order must be start after this day 2019-05-13 03:32:39*/

Drop TABLE IF EXISTS Staff ;
CREATE TABLE Staff(
	StaffID	INT(9)	NOT NULL,
    Staff_Name	VARCHAR(20)	NOT NULL,
	Staff_HKIDNumber	VARCHAR(20)	NOT NULL,
	Staff_Username varchar(20)	NOT NULL,
	Staff_password varchar(20)	NOT NULL,
	StaffPosition	Varchar(255)	NOT NULL,
	DateOfBirth	DATE	NOT NULL,
	HourSalary	INT(3)	NOT NULL,
	HireDate	DATE	NOT NULL,
	isFulltime	boolean 	NOT NULL,
	CONSTRAINT PK_Staff PRIMARY KEY (StaffID)
	);
	
	insert  into `Staff` values (910000001,'Rachele Fong', 'A123456(7)', 'Rachele', 'Rachele123', 'Founder', '1960-5-30', 200, '1984-04-04', true);
	insert  into `Staff` values (910000002,'Laurus Gwynedd', 'B122333(2)', 'Laurus', 'Laurus123', 'HR', '1976-2-22', 100, '1994-09-05', true);
	insert  into `Staff` values (910000122,'Navin Aleta', 'H143331(8)', 'Navin', 'Navin123', 'HR', '1986-2-22', 100, '1999-09-05', true);
	insert  into `Staff` values (910036643,'Angharad Warinhari', 'P332343(8)', 'Angharad', 'Angharad123', 'Accounting', '1976-2-22', 100, '2013-08-31', true);
	insert  into `Staff` values (910036654,'Pasquale Ceinwen', 'P372312(8)', 'Pasquale', 'Pasquale123', 'Accounting', '1978-2-22', 100, '2013-08-31', true);
	insert  into `Staff` values (910216643,'Chang Hana', 'Y642323(1)', 'HanaC', 'Hana123', 'Salesman', '1995-2-22', 100, '2016-12-31', true);
	insert  into `Staff` values (910226672,'Sandy Chiu', 'Y342343(1)', 'SandyC', 'Sandy123', 'Salesman', '1997-6-18', 100, '2017-09-30', true);
	insert  into `Staff` values (910236677,'Amitabh Takeshi', 'Y742343(1)', 'TakeshiA', 'Takeshi123', 'Salesman', '1999-8-18', 80, '2019-04-30', false);
	insert  into `Staff` values (910266672,'Mina Chan', 'Y842643(7)', 'MinaC', 'Mina123', 'Salesman', '2000-7-12', 80, '2019-05-01', false);
	
Drop TABLE  IF EXISTS DailyWorkingRecord;
CREATE TABLE	DailyWorkingRecord(
	StaffID	INT(9)	NOT NULL,
	WorkedHour	INT(5)	NULL, /*Work hour of this day*/
	Date_of_workout	DATE	NOT NULL,
	CONSTRAINT PK_DailyWorkingRecord PRIMARY KEY (StaffID, Date_of_workout),
		CONSTRAINT FK_DailyWorkingRecord_StaffID FOREIGN KEY (StaffID)
			REFERENCES Staff(StaffID)
	);

 	insert  into `DailyWorkingRecord` values (910266672,10,'2019-05-14');
	insert  into `DailyWorkingRecord` values (910266672,10,'2019-05-15');
	insert  into `DailyWorkingRecord` values (910266672,10,'2019-05-16');
	insert  into `DailyWorkingRecord` values (910236677,10,'2019-05-16');
	insert  into `DailyWorkingRecord` values (910226672,10,'2019-05-17');
	insert  into `DailyWorkingRecord` values (910266672,10,'2019-05-18');
	
	
 /*
 Drop TABLE IF EXISTS WalletInformation;
 CREATE TABLE WalletInformation(
	Walletaccount	VARCHAR(255)	NOT NULL,
	WalletType	VARCHAR(255)	NOT NULL,
	MemberID	INT(9)	NOT NULL,
		CONSTANT	FK_WalletInformation_MemberID FOREIGN KEY(MemberID)
		REFERENCES	Onlinemember(MemberID)
	CONSTRAINT PK_WalletInformation PRIMARY KEY (Walletaccount,MemberID)
	);
	*/
Drop TABLE IF EXISTS Store;
CREATE TABLE Store(
	StoreID	INT(9)	NOT NULL,
	address	Varchar(255) NOT NULL,
	Name	VARCHAR(255) Not NULL,
	Phone Int(8) NOT NULL,
			CONSTRAINT PK_Store PRIMARY KEY (StoreID)
			/* CONSTRAINT FK_Showcase_TenantID FOREIGN KEY (TenantID)
			REFERENCES Rentmember(TenantID)*/
	);
	insert into Store VALUES (840900001, '1, Nelson Street, Mong Kok', 'Mong Kok 1', 12345678);
	insert into Store VALUES (840900002, '500, Nathan Road, Mong Kok', 'Mong Kok 2', 12345678);
	insert into Store VALUES (840900003, '345, Kwai Chung Road, Kwai Chung', 'Kwai Fong', 12345678);
	insert into Store VALUES (840900004, '3 King Ling Road, Tiu Keng Leng', 'Tiu Keng Leng', 12345678);
	insert into Store VALUES (840900005, '124, Nathan Road, Tsim Sha Tsui', 'Tsim Sha Tsui', 12345678);
	
Drop TABLE IF EXISTS Showcase;
CREATE TABLE Showcase(
	ShowcaseID	INT(9)	NOT NULL,
	StoreID	INT(9)	NOT NULL,
	Standard_RentFee	INT(9)	NOT NULL,
	ShowcaseType	Varchar(255)  NOT NULL,	
	adv_description	Varchar(255)	NULL,
		CONSTRAINT PK_Showcase PRIMARY KEY (ShowcaseID),
		CONSTRAINT FK_Showcase_StoreID FOREIGN KEY (StoreID)
			REFERENCES Store(StoreID)
	);
	insert into Showcase VALUES(120000001, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000002, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000003, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000004, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000005, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000006, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000007, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000008, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000009, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000010, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000011, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000012, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000013, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000014, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000015, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000016, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000017, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000018, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000019, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000020, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000021, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000022, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000023, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000024, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000025, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000026, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000027, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000028, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000029, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000030, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000031, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(120000032, 840900002, 400, 'Regular', null);
	insert into Showcase VALUES(110000001, 840900001, 400, 'Regular', null);
	insert into Showcase VALUES(110000002, 840900001, 400, 'Regular', null);
	insert into Showcase VALUES(110000003, 840900001, 400, 'Regular', null);
	insert into Showcase VALUES(110000004, 840900001, 400, 'Regular', null);
	insert into Showcase VALUES(110000005, 840900001, 400, 'Regular', null);
	insert into Showcase VALUES(110000006, 840900001, 400, 'Regular', null);
	insert into Showcase VALUES(110000007, 840900001, 400, 'Regular', null);
	insert into Showcase VALUES(110000008, 840900001, 400, 'Regular', null);
	insert into Showcase VALUES(110000009, 840900001, 400, 'Regular', null);
	insert into Showcase VALUES(110000010, 840900001, 400, 'Regular', null);
	insert into Showcase VALUES(140100001, 840900004, 600, 'Large', null);
	insert into Showcase VALUES(140100002, 840900004, 600, 'Large', null);
	insert into Showcase VALUES(140100003, 840900004, 600, 'Large', null);
	insert into Showcase VALUES(140100004, 840900004, 600, 'Large', null);
	insert into Showcase VALUES(140100005, 840900004, 600, 'Large', null);
	insert into Showcase VALUES(140100006, 840900004, 600, 'Large', null);
	insert into Showcase VALUES(140100007, 840900004, 600, 'Large', null);
	insert into Showcase VALUES(140100008, 840900004, 600, 'Large', null);
	insert into Showcase VALUES(140100009, 840900004, 600, 'Large', null);
	insert into Showcase VALUES(140100010, 840900004, 600, 'Large', null);
	insert into Showcase VALUES(110800001, 840900001, 650, 'Iced', null);
	insert into Showcase VALUES(110800002, 840900001, 650, 'Iced', null);
	insert into Showcase VALUES(110800003, 840900001, 650, 'Iced', null);
	insert into Showcase VALUES(110800004, 840900001, 650, 'Iced', null);
	insert into Showcase VALUES(110800005, 840900001, 650, 'Iced', null);
	insert into Showcase VALUES(110800006, 840900001, 650, 'Iced', null);
	insert into Showcase VALUES(110800007, 840900001, 650, 'Iced', null);
	insert into Showcase VALUES(110800008, 840900001, 650, 'Iced', null);
	insert into Showcase VALUES(130000001, 840900003, 650, 'Iced', null);
	insert into Showcase VALUES(130000002, 840900003, 650, 'Iced', null);
	insert into Showcase VALUES(150000001, 840900005, 650, 'Iced', null);
	
Drop TABLE IF EXISTS Showcase_rentrecord;
CREATE TABLE Showcase_rentrecord(
	rentrecordID	INT(9)	NOT NULL,
	ShowcaseID	INT(9)	NOT NULL,
	TenantID	INT(9)	 NOT NULL, 
	LeaseStartDate	DATE	NOT NULL,
	LeaseTermTo	DATE	NOT NULL,
	RentFee		INT(9)	NOT NULL,
	CONSTRAINT PK_Showcase_rentrecord PRIMARY KEY (rentrecordID),
	CONSTRAINT FK_Showcase_rentrecord_ShowcaseID FOREIGN KEY (ShowcaseID)
		REFERENCES Showcase(ShowcaseID),
	CONSTRAINT FK_Showcase_rentrecord_TenantID FOREIGN KEY (TenantID)
		REFERENCES Tenant(TenantID)	
	);
	insert into Showcase_rentrecord VALUES(710000001, 140100010, 100000003,'2019-05-12' , '2019-06-12', 1891);
	insert into Showcase_rentrecord VALUES(710000002, 130000001, 100000004,'2019-05-25' , '2020-07-25', 7332);
	insert into Showcase_rentrecord VALUES(710000003, 140100010, 100000004,'2020-04-27' , '2020-07-27', 1891);
	/*test this*/insert into Showcase_rentrecord VALUES(710000004, 130000002, 100000003,'2020-05-30' , '2020-07-30', 650);	
	insert into Showcase_rentrecord VALUES(710000005, 110800004, 100000005,'2020-06-27' , '2020-08-27', 1300);
	insert into Showcase_rentrecord VALUES(710000006, 150000001, 100000003,'2019-05-12' , '2020-06-12', 1300);

Drop TABLE IF EXISTS Bookedshowcase;/* for Reserve showcase*/
CREATE TABLE Bookedshowcase(
	ShowcaseID	INT(9)	NOT NULL,
	TenantID	INT(9)	NOT NULL,
	BookingID	INT(9)	NOT NULL,
	BookingStartDate	Date	NOT NULL,
	BookingTermTo	Date	NOT NULL,
	Prepaid_credit		INT(9)	 NOT NULL,
	PrepaidDate	Date	NULL,
	/*duration	INT(3)	NOT NULL,*/
		CONSTRAINT PK_Bookedshowcase PRIMARY KEY (BookingID),
		CONSTRAINT FK_Bookedshowcase_TenantID FOREIGN KEY (TenantID)
			REFERENCES Tenant(TenantID),
		CONSTRAINT FK_Bookedshowcase_ShowcaseID FOREIGN KEY (ShowcaseID)
			REFERENCES Showcase(ShowcaseID)
	);

insert into Bookedshowcase VALUES(110000006, 100000001, 400000001, '2020-04-27' , '2020-07-27', 0, null);
insert into Bookedshowcase VALUES(110000010, 100000002, 400000002, '2020-05-30' , '2020-06-30', 0, null);
insert into Bookedshowcase VALUES(130000002, 100000003, 400000003, '2020-08-28' , '2020-09-28', 650, '2020-06-30');

Drop TABLE IF EXISTS Product;
CREATE TABLE Product(
	Name	VARCHAR(255)	NOT NULL,
	TenantID	INT(9)	 NULL, /* null mean self company product*/
	ProductID	INT(9)	NOT NULL,
	ProductFee	Int(10)	NOT NULL,
	Discount	Int(10)	NOT NULL,
	PrivateLabelItems BOOLEAN	NOT NULL,
	Description	VARCHAR(255)	NULL,
	CONSTRAINT PK_Product PRIMARY KEY (ProductID),
	CONSTRAINT FK_Product_TenantID FOREIGN KEY (TenantID)
			REFERENCES Tenant(TenantID)
);

insert into Product	VALUES('Drink', 100000003, 500000001, 10, 1, true, null);
insert into Product	VALUES('Food', 100000003, 500000002, 20, 10, true, null);
insert into Product	VALUES('camera', 100000002, 500000003, 20000, 0, true, 'Used');

Drop TABLE IF EXISTS Showcase_product;
CREATE TABLE Showcase_product(
	ShowcaseID	INT(9)	NOT NULL,
	ProductID	INT(9)	NOT NULL,
	stock	INT(9)	NOT NULL,
	product_description	VARCHAR(255) NULL,
		CONSTRAINT PK_Showcase_product PRIMARY KEY (ProductID, ShowcaseID),
		CONSTRAINT FK_PK_Showcase_product_ProductID FOREIGN KEY (ProductID)
			REFERENCES Product(ProductID),
		CONSTRAINT FK_Showcase_product_ShowcaseID FOREIGN KEY (ShowcaseID)
			REFERENCES Showcase(ShowcaseID)
	);

insert into Showcase_product VALUES(130000002, 500000001, 10, 'Iced');
insert into Showcase_product VALUES(130000002, 500000003, 1, null);
insert into Showcase_product VALUES(130000001, 500000002, 15,  null);
insert into Showcase_product VALUES(150000001, 500000002, 15,  null);



Drop TABLE  IF EXISTS SalesRecord;
CREATE TABLE SalesRecord
(	SalesID	Int(9)	 NOT NULL, /* INVOICE ID */
	SalesDATETIME	DATETIME	NOT NULL,
	StoreID	Int(9)	 NOT NULL,
	TotalSalesAmount	Int(10)	 NOT NULL,/* normaly, it = Product(ProductFee) but sometimes will discount , the actual price */
	Tender	Int(10)	 NOT NULL,
	Changecost	Int(10)	 NOT NULL,
	StaffID	Int(9)	 NOT NULL,/*Sales*/
	
	Paymethod	varchar(20)	not null,
		CONSTRAINT PK_SalesRecord PRIMARY KEY (SalesID),
		CONSTRAINT FK_SalesRecord_StaffID FOREIGN KEY (StaffID)
			REFERENCES Staff(StaffID)
	);
	ALTER TABLE `salesrecord` CHANGE `SalesDATETIME` `SalesDATETIME` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP;


insert into SalesRecord VALUES(680000001, '2019-05-14 18:24:54', 840900005,  20020, 22050, 30, 910266672, 'Cash');
insert into SalesRecord VALUES(680000002, '2019-05-16 17:31:21', 840900001,  20000, 20000, 0,  910236677, 'Cash');
insert into SalesRecord VALUES(680000003, '2020-07-16 17:31:21', 840900001,  20, 100, 80, 910236677, 'Cash');
 
 
Drop TABLE  IF EXISTS SalesRecord_Product;/* Order item */
CREATE TABLE SalesRecord_Product
 (	SalesID	Int(9)	 NOT NULL, /* INVOICE ID */
	ProductID	Int(9)	 NOT NULL,
	ShowcaseID	INT(9)	NOT NULL,
	Qty	Int(9)	 NOT NULL,
	eachFee	Int(10)	not null,
	Discount	int(10)	not null,
		CONSTRAINT PK_SalesRecord_Product PRIMARY KEY (SalesID, ProductID),
		CONSTRAINT FK_SalesRecord_Product_SalesID FOREIGN KEY (SalesID)
			REFERENCES SalesRecord(SalesID),
		CONSTRAINT FK_SalesRecord_Product_ProductID FOREIGN KEY (ProductID)
			REFERENCES Product(ProductID)
			);
insert into SalesRecord_Product VALUES(680000001, 500000003, 130000002, 1, 20000, 0);
insert into SalesRecord_Product VALUES(680000001, 500000002, 150000001, 2, 20, 10);
insert into SalesRecord_Product VALUES(680000002, 500000003, 130000002, 1, 20000, 0);
insert into SalesRecord_Product VALUES(680000003, 500000002, 130000002, 1, 20, 0);