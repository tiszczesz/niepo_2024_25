-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 09, 2025 at 09:08 AM
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
-- Database: `2tip_sklep_ark2`
--
CREATE DATABASE IF NOT EXISTS `2tip_cw20` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `2tip_cw20`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `samochody`
--

DROP TABLE IF EXISTS `samochody`;
CREATE TABLE `samochody` (
  `id` int(10) UNSIGNED NOT NULL,
  `marka` text DEFAULT NULL,
  `model` text DEFAULT NULL,
  `rocznik` year(4) DEFAULT NULL,
  `kolor` text DEFAULT NULL,
  `stan` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `samochody`
--

INSERT INTO `samochody` (`id`, `marka`, `model`, `rocznik`, `kolor`, `stan`) VALUES
(1, 'Fiat', 'Punto', '2016', 'czerwony', 'bardzo dobry'),
(2, 'Fiat', 'Punto', '2002', 'czerwony', 'dobry'),
(3, 'Fiat', 'Punto', '2007', 'niebieski', 'bardzo bobry'),
(4, 'Opel', 'Corsa', '2016', 'grafitowy', 'bardzo dobry'),
(5, 'Opel', 'Astra', '2003', 'niebieski', 'porysowany lakier'),
(6, 'Toyota', 'Corolla', '2016', 'czerwony', 'bardzo dobry'),
(7, 'Toyota', 'Corolla', '2014', 'szary', 'dobry'),
(8, 'Toyota', 'Yaris', '2004', 'granatowy', 'dobry');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zamowienia`
--

DROP TABLE IF EXISTS `zamowienia`;
CREATE TABLE `zamowienia` (
  `id` int(10) UNSIGNED NOT NULL,
  `Samochody_id` int(10) UNSIGNED NOT NULL,
  `Klient` text DEFAULT NULL,
  `telefon` text DEFAULT NULL,
  `dataZam` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `zamowienia`
--

INSERT INTO `zamowienia` (`id`, `Samochody_id`, `Klient`, `telefon`, `dataZam`) VALUES
(1, 3, 'Anna Kowalska', '111222333', '2016-02-15'),
(2, 6, 'Jan Nowakowski', '222111333', '2016-02-15'),
(3, 8, 'Marcin Kolwal', '333111222', '2016-02-15');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `samochody`
--
ALTER TABLE `samochody`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `zamowienia`
--
ALTER TABLE `zamowienia`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `samochody`
--
ALTER TABLE `samochody`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `zamowienia`
--
ALTER TABLE `zamowienia`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
