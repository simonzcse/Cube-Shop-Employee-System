-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: May 16, 2020 at 04:52 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ProjectDB`
--
CREATE DATABASE IF NOT EXISTS `ProjectDB` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `ProjectDB`;

-- --------------------------------------------------------

--
-- Table structure for table `ConsignmentStore`
--

CREATE TABLE `ConsignmentStore` (
  `consignmentStoreID` int(10) NOT NULL,
  `tenantID` varchar(50) NOT NULL,
  `ConsignmentStoreName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ConsignmentStore`
--

INSERT INTO `ConsignmentStore` (`consignmentStoreID`, `tenantID`, `ConsignmentStoreName`) VALUES
(1, 'marcus888', 'Marucs ConsignmentStore');

-- --------------------------------------------------------

--
-- Table structure for table `ConsignmentStore_Shop`
--

CREATE TABLE `ConsignmentStore_Shop` (
  `consignmentStoreID` int(10) NOT NULL,
  `shopID` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ConsignmentStore_Shop`
--

INSERT INTO `ConsignmentStore_Shop` (`consignmentStoreID`, `shopID`) VALUES
(1, 1),
(1, 2);

-- --------------------------------------------------------

--
-- Table structure for table `Customer`
--

CREATE TABLE `Customer` (
  `customerEmail` varchar(50) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `password` varchar(50) NOT NULL,
  `phoneNumber` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Customer`
--

INSERT INTO `Customer` (`customerEmail`, `firstName`, `lastName`, `password`, `phoneNumber`) VALUES
('taiMan@gmail.com', 'Tai Man', 'Chan', 'marcus123', '52839183');

-- --------------------------------------------------------

--
-- Table structure for table `Goods`
--

CREATE TABLE `Goods` (
  `goodsNumber` int(10) NOT NULL,
  `consignmentStoreID` int(10) NOT NULL,
  `goodsName` varchar(255) NOT NULL,
  `stockPrice` decimal(10,1) NOT NULL,
  `remainingStock` int(7) NOT NULL DEFAULT 0,
  `status` int(1) NOT NULL COMMENT 'The goods should include 2 stock status:  \n1. “Available”: Show only the available goods.  \n2. “Unavailable”: The goods has been discontinued or not already for sell.  '
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Goods`
--

INSERT INTO `Goods` (`goodsNumber`, `consignmentStoreID`, `goodsName`, `stockPrice`, `remainingStock`, `status`) VALUES
(1, 1, 'Bracelet', '99.5', 8, 1),
(2, 1, 'Anklet', '200.0', 10, 1);

-- --------------------------------------------------------

--
-- Table structure for table `OrderItem`
--

CREATE TABLE `OrderItem` (
  `orderID` int(10) NOT NULL,
  `goodsNumber` int(10) NOT NULL,
  `quantity` int(7) NOT NULL,
  `sellingPrice` decimal(10,1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `OrderItem`
--

INSERT INTO `OrderItem` (`orderID`, `goodsNumber`, `quantity`, `sellingPrice`) VALUES
(1, 1, 3, '99.5'),
(1, 2, 1, '200.0'),
(2, 1, 1, '99.5');

-- --------------------------------------------------------

--
-- Table structure for table `Orders`
--

CREATE TABLE `Orders` (
  `orderID` int(10) NOT NULL,
  `customerEmail` varchar(50) NOT NULL,
  `consignmentStoreID` int(10) NOT NULL,
  `shopID` int(6) NOT NULL,
  `orderDateTime` datetime NOT NULL,
  `status` int(1) NOT NULL COMMENT 'The orders should include 3 statuses:  \n1.     “Delivery”: The parts are delivering to shop  \n2.     “Awaiting”: Goods are ready for pick up  \n3.     “Completed”: The goods has been picked up from customer  ',
  `totalPrice` decimal(10,1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Orders`
--

INSERT INTO `Orders` (`orderID`, `customerEmail`, `consignmentStoreID`, `shopID`, `orderDateTime`, `status`, `totalPrice`) VALUES
(1, 'taiMan@gmail.com', 1, 1, '2020-05-14 07:34:29', 3, '498.5'),
(2, 'taiMan@gmail.com', 1, 2, '2020-06-22 08:25:13', 2, '99.5');

-- --------------------------------------------------------

--
-- Table structure for table `Shop`
--

CREATE TABLE `Shop` (
  `shopID` int(6) NOT NULL,
  `address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Shop`
--

INSERT INTO `Shop` (`shopID`, `address`) VALUES
(1, 'No. 18, 1 / F, Trendy Zone, 580A Nathan Road, Mong Kok'),
(2, 'No. 1047, 10/F, Nan Fung Centre, 264-298 Castle Peak Road, Tsuen Wan');

-- --------------------------------------------------------

--
-- Table structure for table `Tenant`
--

CREATE TABLE `Tenant` (
  `tenantID` varchar(50) NOT NULL,
  `name` varchar(255) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Tenant`
--

INSERT INTO `Tenant` (`tenantID`, `name`, `password`) VALUES
('marcus888', 'Marcus', 'it888');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ConsignmentStore`
--
ALTER TABLE `ConsignmentStore`
  ADD PRIMARY KEY (`consignmentStoreID`),
  ADD KEY `FKConsignmen625115` (`tenantID`);

--
-- Indexes for table `ConsignmentStore_Shop`
--
ALTER TABLE `ConsignmentStore_Shop`
  ADD PRIMARY KEY (`consignmentStoreID`,`shopID`),
  ADD KEY `FKConsignmen537135` (`consignmentStoreID`),
  ADD KEY `FKConsignmen824630` (`shopID`);

--
-- Indexes for table `Customer`
--
ALTER TABLE `Customer`
  ADD PRIMARY KEY (`customerEmail`);

--
-- Indexes for table `Goods`
--
ALTER TABLE `Goods`
  ADD PRIMARY KEY (`goodsNumber`),
  ADD KEY `FKGoods866951` (`consignmentStoreID`);

--
-- Indexes for table `OrderItem`
--
ALTER TABLE `OrderItem`
  ADD KEY `FKOrderItem915607` (`orderID`),
  ADD KEY `FKOrderItem82428` (`goodsNumber`);

--
-- Indexes for table `Orders`
--
ALTER TABLE `Orders`
  ADD PRIMARY KEY (`orderID`),
  ADD KEY `FKOrders837071` (`customerEmail`),
  ADD KEY `FKOrders959018` (`consignmentStoreID`,`shopID`);

--
-- Indexes for table `Shop`
--
ALTER TABLE `Shop`
  ADD PRIMARY KEY (`shopID`);

--
-- Indexes for table `Tenant`
--
ALTER TABLE `Tenant`
  ADD PRIMARY KEY (`tenantID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ConsignmentStore`
--
ALTER TABLE `ConsignmentStore`
  MODIFY `consignmentStoreID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `Goods`
--
ALTER TABLE `Goods`
  MODIFY `goodsNumber` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `Orders`
--
ALTER TABLE `Orders`
  MODIFY `orderID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `Shop`
--
ALTER TABLE `Shop`
  MODIFY `shopID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `ConsignmentStore`
--
ALTER TABLE `ConsignmentStore`
  ADD CONSTRAINT `FKConsignmen625115` FOREIGN KEY (`tenantID`) REFERENCES `Tenant` (`tenantID`);

--
-- Constraints for table `ConsignmentStore_Shop`
--
ALTER TABLE `ConsignmentStore_Shop`
  ADD CONSTRAINT `FKConsignmen537135` FOREIGN KEY (`consignmentStoreID`) REFERENCES `ConsignmentStore` (`consignmentStoreID`),
  ADD CONSTRAINT `FKConsignmen824630` FOREIGN KEY (`shopID`) REFERENCES `Shop` (`shopID`);

--
-- Constraints for table `Goods`
--
ALTER TABLE `Goods`
  ADD CONSTRAINT `FKGoods866951` FOREIGN KEY (`consignmentStoreID`) REFERENCES `ConsignmentStore` (`consignmentStoreID`);

--
-- Constraints for table `OrderItem`
--
ALTER TABLE `OrderItem`
  ADD CONSTRAINT `FKOrderItem82428` FOREIGN KEY (`goodsNumber`) REFERENCES `Goods` (`goodsNumber`),
  ADD CONSTRAINT `FKOrderItem915607` FOREIGN KEY (`orderID`) REFERENCES `Orders` (`orderID`);

--
-- Constraints for table `Orders`
--
ALTER TABLE `Orders`
  ADD CONSTRAINT `FKOrders837071` FOREIGN KEY (`customerEmail`) REFERENCES `Customer` (`customerEmail`),
  ADD CONSTRAINT `FKOrders959018` FOREIGN KEY (`consignmentStoreID`,`shopID`) REFERENCES `ConsignmentStore_Shop` (`consignmentStoreID`, `shopID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
