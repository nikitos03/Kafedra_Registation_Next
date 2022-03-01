-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Мар 01 2022 г., 08:25
-- Версия сервера: 5.7.24
-- Версия PHP: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `registerkadrov`
--

-- --------------------------------------------------------

--
-- Структура таблицы `dekanata`
--

CREATE TABLE `dekanata` (
  `id` int(11) NOT NULL,
  `Familiy` varchar(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Otchestvo` varchar(100) NOT NULL,
  `Position` varchar(100) NOT NULL,
  `Academicstep` varchar(100) NOT NULL,
  `Discipline` varchar(100) NOT NULL,
  `Workload` varchar(100) NOT NULL,
  `Socialwork` varchar(100) NOT NULL,
  `Parttimework` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `kadr`
--

CREATE TABLE `kadr` (
  `id` int(11) UNSIGNED NOT NULL,
  `Familiy` varchar(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Otchestvo` varchar(100) NOT NULL,
  `Position` varchar(100) NOT NULL,
  `Academicstep` varchar(100) NOT NULL,
  `Discipline` varchar(100) NOT NULL,
  `Workload` varchar(100) NOT NULL,
  `Socialwork` varchar(100) NOT NULL,
  `Parttimework` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `dekanata`
--
ALTER TABLE `dekanata`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `kadr`
--
ALTER TABLE `kadr`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `dekanata`
--
ALTER TABLE `dekanata`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `kadr`
--
ALTER TABLE `kadr`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
