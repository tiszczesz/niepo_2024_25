-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 24, 2025 at 10:22 AM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `3tip_2024_25_cw2`
--
CREATE DATABASE IF NOT EXISTS `3tip_2024_25_cw2` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `3tip_2024_25_cw2`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `contacts`
--

DROP TABLE IF EXISTS `contacts`;
CREATE TABLE `contacts` (
  `id` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `contact_method_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `contacts`
--

INSERT INTO `contacts` (`id`, `firstname`, `lastname`, `address`, `contact_method_id`) VALUES
(4, 'Antoni', 'Małecki', 'Kraków, ul. Kujawska 12/45', 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `contat_method`
--

DROP TABLE IF EXISTS `contat_method`;
CREATE TABLE `contat_method` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `description` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `contat_method`
--

INSERT INTO `contat_method` (`id`, `name`, `description`) VALUES
(1, 'telefon_kom', 'połączenie telefon komórkowy itd'),
(2, 'telefon_dom', 'połączenie telefon domowy itd'),
(3, 'email', 'użycie email'),
(4, 'poczta', 'wykorzystanie poczty');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `contacts`
--
ALTER TABLE `contacts`
  ADD PRIMARY KEY (`id`),
  ADD KEY `contact_methods_fk` (`contact_method_id`);

--
-- Indeksy dla tabeli `contat_method`
--
ALTER TABLE `contat_method`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `contacts`
--
ALTER TABLE `contacts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `contat_method`
--
ALTER TABLE `contat_method`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `contacts`
--
ALTER TABLE `contacts`
  ADD CONSTRAINT `contact_methods_fk` FOREIGN KEY (`contact_method_id`) REFERENCES `contat_method` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
