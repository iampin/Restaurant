-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 03, 2020 at 04:23 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `food`
--
CREATE DATABASE IF NOT EXISTS `food` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `food`;

-- --------------------------------------------------------

--
-- Table structure for table `employeee`
--

CREATE TABLE `employeee` (
  `no` int(11) NOT NULL,
  `id` varchar(11) NOT NULL,
  `username` varchar(11) NOT NULL,
  `password` varchar(11) NOT NULL,
  `role` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employeee`
--

INSERT INTO `employeee` (`no`, `id`, `username`, `password`, `role`) VALUES
(1, 'dup01', 'naj', 'naj', 'manager'),
(2, 'dup02', 'pin', 'pin', 'staff'),
(3, 'dup03', 'dow', 'dow', 'staff');

-- --------------------------------------------------------

--
-- Table structure for table `forder`
--

CREATE TABLE `forder` (
  `oid` int(11) NOT NULL,
  `MemberID` int(11) NOT NULL,
  `grandtotal` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `forder`
--

INSERT INTO `forder` (`oid`, `MemberID`, `grandtotal`) VALUES
(1, 7, 441.91),
(2, 9, 201.16),
(3, 9, 94.16);

-- --------------------------------------------------------

--
-- Table structure for table `forderdetail`
--

CREATE TABLE `forderdetail` (
  `no` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `foodname` varchar(50) NOT NULL,
  `qty` double NOT NULL,
  `price` double NOT NULL,
  `total` double NOT NULL,
  `memo` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `forderdetail`
--

INSERT INTO `forderdetail` (`no`, `oid`, `foodname`, `qty`, `price`, `total`, `memo`) VALUES
(1, 1, 'Boneless(L)-Ori', 1, 129, 129, ''),
(2, 1, 'Boneless(L)-Spi', 1, 129, 129, ''),
(3, 1, 'Sticky Rice', 4, 19, 76, ''),
(4, 1, 'Tteok-Bokki', 1, 79, 79, ''),
(5, 2, 'Wings(L)-Ori', 2, 129, 129, ''),
(6, 2, 'Chicken Pop-Ori', 1, 59, 59, ''),
(7, 3, 'Wings(S)-Spi', 1, 69, 69, ''),
(8, 3, 'Stream Rice', 2, 19, 19, '');

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `MemberID` int(11) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `PhoneNumber` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`MemberID`, `FirstName`, `LastName`, `PhoneNumber`) VALUES
(1, 'Downy', 'Downy', '0873226746'),
(2, 'Najjy', 'Najjy', '0819273677'),
(3, 'Pinny', 'Pinny', '0992206628'),
(7, 'Naj', 'Real', '0957901894'),
(8, 'u', 'u', '0806724497'),
(9, 'king', 'lhor', '0818282847');

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `foodID` int(11) NOT NULL,
  `category` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `price` double NOT NULL,
  `image` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`foodID`, `category`, `name`, `price`, `image`) VALUES
(1, 'Original Chickens', 'Wings(S)-Ori\r\n', 69, 'wings.jpg'),
(2, 'Original Chickens', 'Wings(L)-Ori\r\n', 129, ''),
(3, 'Original Chickens', 'Boneless(S)-Ori', 69, 'boneless.jpg'),
(4, 'Original Chickens', 'Boneless(L)-Ori', 129, ''),
(5, 'Original Chickens', 'Chicken Pop-Ori', 59, 'pop.jpg'),
(6, 'Spicy Chickens', 'Wings(S)-Spi', 69, 'wings.jpg'),
(7, 'Spicy Chickens', 'Wings(L)-Spi', 129, ''),
(8, 'Spicy Chickens', 'Boneless(S)-Spi', 69, 'boneless.jpg'),
(9, 'Spicy Chickens', 'Boneless(L)-Spi', 129, ''),
(10, 'Spicy Chickens', 'Chicken Pop-Spi', 59, 'pop.jpg'),
(11, 'Side Dishes', 'Stream Rice', 19, 'stream.jpg'),
(12, 'Side Dishes', 'Sticky Rice', 19, 'sticy.jpg'),
(13, 'Side Dishes', 'Tteok-Bokki', 79, 'tok.jpg'),
(14, 'Baverage', 'Drinking Water', 20, 'water.jpg'),
(15, 'Baverage', 'Green Tea', 25, 'tea.jpg'),
(16, 'Beverage', 'Coca-Cola', 35, 'coke.jpg'),
(19, 'Beverage', 'Soda', 30, 'soda.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employeee`
--
ALTER TABLE `employeee`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `forder`
--
ALTER TABLE `forder`
  ADD PRIMARY KEY (`oid`);

--
-- Indexes for table `forderdetail`
--
ALTER TABLE `forderdetail`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`MemberID`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`foodID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employeee`
--
ALTER TABLE `employeee`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `forder`
--
ALTER TABLE `forder`
  MODIFY `oid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `forderdetail`
--
ALTER TABLE `forderdetail`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `MemberID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `menu`
--
ALTER TABLE `menu`
  MODIFY `foodID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
