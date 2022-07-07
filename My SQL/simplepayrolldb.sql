-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 10, 2022 at 11:10 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `simplepayrolldb`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee_db`
--

CREATE TABLE `employee_db` (
  `Employee_ID` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Email` varchar(60) DEFAULT NULL,
  `Mobile` int(20) DEFAULT NULL,
  `Address` varchar(100) DEFAULT NULL,
  `SSN` int(20) DEFAULT NULL,
  `Bank_Details` varchar(100) DEFAULT NULL,
  `Total_Salary` decimal(10,0) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_db`
--

INSERT INTO `employee_db` (`Employee_ID`, `Name`, `Email`, `Mobile`, `Address`, `SSN`, `Bank_Details`, `Total_Salary`, `date`) VALUES
(0, 'remi', 'asd', 231, 'asd', 123, '123', '246', '2022-04-09 18:01:06'),
(4, 'Pam Beesly', 'Pam26@gmail.com', 254535692, 'Dunder Mifflin', 123123123, 'Receptionist', '7500', '2022-04-09 18:01:06'),
(5, 'Michael Scott', 'ScottM@gmail.com', 2147483647, 'England', 15243682, 'Regional Manager', '15000', '2022-04-09 18:01:06'),
(6, 'Oscar Martinez', 'MartsO@gmail.com', 2147483647, 'California', 2147483647, 'Sales Rep', '15000', '2022-04-09 18:01:06'),
(7, 'Angela Martinw', 'AngelaM@gmail.com', 2147483647, 'Paranormal City', 111111111, 'Transaction Rep', '19500', '2022-04-09 18:01:06'),
(8, 'Kevin Malone', 'MaloneK@gmail.com', 1231231231, 'London', 52513543, 'Food Rep', '15000', '2022-04-09 18:01:06'),
(9, 'Kelly Kapoor', 'KellyKap@gmail.com', 2147483647, 'Pittsburgh', 2147483647, 'Customer Service', '15000', '2022-04-09 18:01:06'),
(10, 'Ryan Howard', 'HowardRay@gmail.com', 2147483647, 'Lancaster', 123123123, 'Customer Service', '18000', '2022-04-09 18:01:06'),
(11, 'Phyliss Lapin', 'Phylap@gmail.com', 2147483647, 'West Chester', 123, 'Sales Rep', '15000', '2022-04-09 18:01:06'),
(13, 'Cameron Smith', 'csmith@gmail.com', 1231232112, 'Nevada', 2323232, 'Programmer', '18000', '2022-04-09 18:01:06'),
(15, 'Remi', 'asdasd', 1923123, 'asdasd', 123123, '', '400', '2022-04-09 18:01:06'),
(12312, 'we', 'we', 12, 'ew', 12, 'eqw', '321', '2022-04-09 18:01:55'),
(173788125, '3', '2', 2, '2', 3, '3', '99', '2022-04-09 18:01:06'),
(526794011, 'Remi', '2', 12, '12', 1212, '212', '4', '2022-04-09 18:01:06'),
(847692147, 'asd', 'asd', 0, 'asd', 0, 'asd', '4', '2022-04-09 18:01:06'),
(993970795, 'wert', 'wer', 123, 'wer', 0, 'qwe', '4', '2022-04-09 18:01:06'),
(1109978916, 'Remi', 'qweqwe', 0, 'qwewe', 0, 'qwe', '123', '2022-04-09 18:01:06'),
(1240717967, 'rem', 're', 2, 're', 2, 're', '4', '2022-04-09 18:01:06'),
(1646200498, '2', '2', 2, '2', 2, '2', '4', '2022-04-09 18:01:06'),
(1796886106, 'Andrea', 'asd', 123, 'dav', 123, '123', '246', '2022-04-09 18:01:06');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userID` int(30) NOT NULL,
  `name` text DEFAULT NULL,
  `username` varchar(60) DEFAULT NULL,
  `password` varchar(90) DEFAULT NULL,
  `type` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userID`, `name`, `username`, `password`, `type`) VALUES
(1, 'Sample Admin', 'Admin', 'Admin', 'Administrator');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee_db`
--
ALTER TABLE `employee_db`
  ADD PRIMARY KEY (`Employee_ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userID` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
