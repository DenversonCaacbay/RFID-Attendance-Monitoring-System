-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 01, 2021 at 10:26 AM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `school`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(15) NOT NULL,
  `username` varchar(32) NOT NULL,
  `password` varchar(32) NOT NULL,
  `admin_access` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `username`, `password`, `admin_access`) VALUES
(1, 'admin', 'admin', '1'),
(2, 'user1', '123', '0'),
(4, 'pocholo', '123', '0'),
(5, 'denver123', '123', '0');

-- --------------------------------------------------------

--
-- Table structure for table `log_record`
--

CREATE TABLE `log_record` (
  `log_id` int(15) NOT NULL,
  `student_number` int(15) NOT NULL,
  `attendance` varchar(1) NOT NULL,
  `date_time` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `log_record`
--

INSERT INTO `log_record` (`log_id`, `student_number`, `attendance`, `date_time`) VALUES
(26, 15, '1', '2021-07-01 08:24:53'),
(27, 15, '0', '2021-07-01 08:24:54'),
(28, 15, '1', '2021-07-01 08:24:55'),
(29, 15, '0', '2021-07-01 08:24:56'),
(30, 16, '1', '2021-07-01 08:25:12'),
(31, 16, '0', '2021-07-01 08:25:13'),
(32, 17, '1', '2021-07-01 08:25:44'),
(33, 17, '0', '2021-07-01 08:25:45');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `student_number` int(15) NOT NULL,
  `lrn` int(30) NOT NULL,
  `first_name` varchar(64) NOT NULL,
  `last_name` varchar(64) NOT NULL,
  `course` varchar(64) NOT NULL,
  `section` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`student_number`, `lrn`, `first_name`, `last_name`, `course`, `section`) VALUES
(15, 201910498, 'Pocholo', 'Gopez', 'BSIT', 'A'),
(16, 201910499, 'Denverson', 'Caacbay', 'BSCS', 'B'),
(17, 201910500, 'Roy', 'Gopez', 'BSCS', 'C');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `log_record`
--
ALTER TABLE `log_record`
  ADD PRIMARY KEY (`log_id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`student_number`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `admin_id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `log_record`
--
ALTER TABLE `log_record`
  MODIFY `log_id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `student_number` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
