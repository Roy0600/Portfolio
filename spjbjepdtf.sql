-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 21 nov 2019 om 10:59
-- Serverversie: 10.1.26-MariaDB
-- PHP-versie: 7.1.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `spjbjepdtf`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `docent`
--

CREATE TABLE `docent` (
  `id_docent` int(11) NOT NULL,
  `Email_Adres` varchar(45) DEFAULT NULL,
  `Volledige_Naam` varchar(60) DEFAULT NULL,
  `Wachtwoord` varchar(75) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `docent`
--

INSERT INTO `docent` (`id_docent`, `Email_Adres`, `Volledige_Naam`, `Wachtwoord`) VALUES
(1, 'Piet@mail.com', 'Piet janse', '6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918'),
(2, 'jan@mail.com', 'Jan Beek', '6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918'),
(3, 'Dirk@mail.com', 'Dirk Park', '6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `student`
--

CREATE TABLE `student` (
  `id_student` int(11) NOT NULL,
  `Email_Adres` varchar(45) DEFAULT NULL,
  `Volledige_Naam` varchar(60) DEFAULT NULL,
  `Wachtwoord` varchar(75) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `student`
--

INSERT INTO `student` (`id_student`, `Email_Adres`, `Volledige_Naam`, `Wachtwoord`) VALUES
(2, '400027905@st.roc.a12.nl', 'Wurud', '6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918'),
(3, '400028700@st.roc.a12.nl', 'Roy Heimel', '6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918'),
(16, 'wu.rud@hotmail.com', 'Wurud Salih', '6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918'),
(17, 'nbroers@boltrics.nl', 'Nathan Broers', '5acb1d4a0b9ca1880eedce675275cd05c7d5f21c52e7eaf78de305aaf9968099'),
(18, '400329@student.nl', 'Vincent van Gogh', '6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918'),
(19, '403949@student.com', 'Jan Jaap', '6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918'),
(20, '40039392@mail.com', 'Robin', '6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918'),
(21, '4030@mail.com', 'Jorst Vorst', '6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `vragenlijst`
--

CREATE TABLE `vragenlijst` (
  `id_Vraag` int(10) UNSIGNED NOT NULL,
  `id_students` int(11) NOT NULL,
  `Vraag` longtext,
  `Onderwerp` longtext,
  `Gevraagde_Docent` int(11) NOT NULL,
  `Persoonlijke_Vraag` tinyint(4) DEFAULT NULL,
  `Geholpen_Docent` int(11) NOT NULL,
  `Status` varchar(75) DEFAULT NULL,
  `Notities` varchar(75) DEFAULT NULL,
  `Datum_vraag` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `vragenlijst`
--

INSERT INTO `vragenlijst` (`id_Vraag`, `id_students`, `Vraag`, `Onderwerp`, `Gevraagde_Docent`, `Persoonlijke_Vraag`, `Geholpen_Docent`, `Status`, `Notities`, `Datum_vraag`) VALUES
(31, 2, 'Wat voor huiswerk moet er nog worden gebeurd voor de volgende les?', 'Was niet bij de les', 1, 0, 2, 'opgelost', 'Opdracht 1,2 en 3 moet gemaakt worden \n', '2019-11-01 11:50:13'),
(32, 17, 'help mij', 'ik word geslagen', 1, 0, 1, 'opgelost', 'Lekker man', '2019-11-01 13:08:44'),
(33, 20, 'Wanneer hebben we de volgende toets?', 'Toets', 2, 0, 2, 'Open', NULL, '2019-11-01 11:50:13'),
(34, 19, 'Wat kan de beoordeling zijn?', 'Nederlands', 1, 0, 1, 'Open', NULL, '2019-11-01 11:50:13'),
(35, 18, 'Wat is groen en drijft op water?', 'Nederlands', 2, 0, 1, 'opgelost', '', '2019-11-01 13:15:01'),
(36, 16, 'persoonlijke vraag', 'persoonlijke vraag', 3, 1, 2, 'opgelost\r\n', 'WAT\n', '2019-11-05 07:32:50'),
(37, 16, 'persoonlijke vraag', 'persoonlijke vraag', 1, 1, 1, 'Open', NULL, '2019-11-05 07:33:01');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `docent`
--
ALTER TABLE `docent`
  ADD PRIMARY KEY (`id_docent`),
  ADD UNIQUE KEY `idGebruiker_UNIQUE` (`id_docent`);

--
-- Indexen voor tabel `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id_student`),
  ADD UNIQUE KEY `idGebruiker_UNIQUE` (`id_student`);

--
-- Indexen voor tabel `vragenlijst`
--
ALTER TABLE `vragenlijst`
  ADD PRIMARY KEY (`id_Vraag`,`id_students`,`Geholpen_Docent`,`Gevraagde_Docent`),
  ADD KEY `fk_Vragenlijst_Gebruiker_idx` (`id_students`),
  ADD KEY `fk_Vragenlijst_Docent1_idx` (`Gevraagde_Docent`),
  ADD KEY `fk_Vragenlijst_Docent2_idx` (`Geholpen_Docent`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `docent`
--
ALTER TABLE `docent`
  MODIFY `id_docent` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT voor een tabel `student`
--
ALTER TABLE `student`
  MODIFY `id_student` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT voor een tabel `vragenlijst`
--
ALTER TABLE `vragenlijst`
  MODIFY `id_Vraag` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `vragenlijst`
--
ALTER TABLE `vragenlijst`
  ADD CONSTRAINT `fk_Vragenlijst_Docent1` FOREIGN KEY (`Gevraagde_Docent`) REFERENCES `docent` (`id_docent`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Vragenlijst_Docent2` FOREIGN KEY (`Geholpen_Docent`) REFERENCES `docent` (`id_docent`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Vragenlijst_Gebruiker` FOREIGN KEY (`id_students`) REFERENCES `student` (`id_student`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
