-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Paź 07, 2024 at 08:26 AM
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
-- Database: `3ti_2024_25_cw1`
--
CREATE DATABASE IF NOT EXISTS `3ti_2024_25_cw1` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `3ti_2024_25_cw1`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `groups`
--

CREATE TABLE `groups` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `description` text NOT NULL,
  `teacher` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `groups`
--

INSERT INTO `groups` (`id`, `name`, `description`, `teacher`) VALUES
(1, '1a', 'klasa matematyczna', 'Roman Boman'),
(2, '1b', 'językowa', 'Alicja Kicja '),
(3, '1c', 'klasa policyjna', 'Roman Boman'),
(4, '1tip', 'informatyk', 'Alicja Kicja ');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `students`
--

CREATE TABLE `students` (
  `id` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `group_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`id`, `firstname`, `lastname`, `group_id`) VALUES
(1, 'Andrzej', 'Rybicki', 1),
(2, 'Renamta', 'Sałata', 2),
(3, 'Eryk', 'Beryk', 1),
(4, 'Henryk', 'Sałata', 3),
(5, 'Jan', 'Kowalski', 3),
(6, 'Anna', 'Nowak', 2),
(7, 'Piotr', 'Wiśniewski', 2),
(9, 'Michał', 'Kowalczyk', 3),
(10, 'Agnieszka', 'Kamińska', 4),
(11, 'Tomasz', 'Lewandowski', 4),
(12, 'Monika', 'Zielińska', 4),
(13, 'Paweł', 'Szymański', 1),
(14, 'Ewa', 'Dąbrowska', 1),
(15, 'sdfsf', 'sdfsfsf', 4),
(16, 'Roman', 'Boman', 2),
(19, 'dsfsf', 'sfsfsf', 3);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `groups`
--
ALTER TABLE `groups`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`id`),
  ADD KEY `student_group` (`group_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `groups`
--
ALTER TABLE `groups`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `student_group` FOREIGN KEY (`group_id`) REFERENCES `groups` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
