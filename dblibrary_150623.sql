-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-06-2023 a las 02:19:24
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `dblibrary`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `books`
--

CREATE TABLE `books` (
  `ID` int(11) NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Description` longtext NOT NULL,
  `Editorial` longtext DEFAULT NULL,
  `Author` varchar(50) NOT NULL,
  `CategoryID` int(11) NOT NULL DEFAULT 0,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `books`
--

INSERT INTO `books` (`ID`, `Title`, `Description`, `Editorial`, `Author`, `CategoryID`, `Quantity`) VALUES
(1, 'Maleficent', 'Esta es una prueba de descripcion de un libro con respecto a la app mobile de xamarin', 'Youbridge', 'Derrik', 1, 0),
(2, 'Hi-Life', 'Sharable content-based success', 'Geba', 'Ingeberg', 9, 0),
(3, 'Rage: Carrie 2, The', 'Exclusive asynchronous implementation', 'Yakidoo', 'Tamara', 6, 1),
(4, 'Thirty-Two Short Films About Glenn Gould', 'Multi-channelled 4th generation strategy', 'Vinder', 'Erna', 9, 0),
(5, 'Quiet Chaos (Caos calmo)', 'Switchable fault-tolerant portal', 'Thoughtbeat', 'Libbey', 4, 0),
(6, 'Piano in a Factory, The (Gang de qin)', 'Re-contextualized transitional pricing structure', 'Gigashots', 'Regen', 2, 1),
(7, 'A Thousand Times Goodnight', 'Triple-buffered encompassing software', 'Jayo', 'Rolph', 9, 1),
(8, 'Nazi Officer\'s Wife, The', 'Focused mission-critical functionalities', 'Thoughtblab', 'Viviene', 4, 0),
(9, 'Bad Teacher', 'Configurable grid-enabled customer loyalty', 'Zoozzy', 'Mitchael', 4, 0),
(10, 'Kill the Irishman', 'Balanced asynchronous solution', 'Twinte', 'Maiga', 9, 0),
(11, 'Red Shoes, The (Bunhongsin)', 'Phased composite portal', 'Mydeo', 'Nevsa', 1, 0),
(12, 'Bully', 'Mandatory neutral toolset', 'Twitterbeat', 'Dennis', 5, 0),
(13, 'Massacre at Central High', 'Synchronised homogeneous internet solution', 'Youspan', 'Nolly', 8, 0),
(14, 'When the Levees Broke: A Requiem in Four Acts', 'Total executive budgetary management', 'Livetube', 'Pavel', 6, 0),
(15, 'On the Town', 'Seamless even-keeled firmware', 'Kazu', 'Ave', 10, 1),
(16, 'Alone in the Dark II', 'Versatile user-facing standardization', 'Quimm', 'Dex', 4, 0),
(17, 'Man from Planet X, The', 'Right-sized even-keeled circuit', 'Flashset', 'Shantee', 4, 0),
(18, 'Whatever Lola Wants', 'Diverse national migration', 'Wordpedia', 'Leonidas', 10, 1),
(19, 'Aloft', 'Customizable homogeneous implementation', 'Thoughtstorm', 'Eve', 7, 0),
(20, 'Citizen Gangster ', 'Profound zero tolerance secured line', 'Avamba', 'Ram', 9, 1),
(21, 'Ladrones', 'Universal holistic infrastructure', 'Jabbertype', 'Anet', 6, 0),
(22, 'Casino Royale', 'Devolved user-facing info-mediaries', 'Quinu', 'Darcy', 6, 0),
(23, 'How to Die in Oregon', 'Compatible solution-oriented collaboration', 'Pixope', 'Emmerich', 3, 0),
(24, 'Low Down, The', 'Enterprise-wide encompassing framework', 'Roodel', 'Alexio', 4, 1),
(25, 'Sunlight Jr.', 'Configurable interactive time-frame', 'Kaymbo', 'Alex', 9, 1),
(26, 'Cure, The', 'Organized multi-state open system', 'Yodo', 'Helen', 8, 0),
(27, '3 on a Couch (Three on a Couch)', 'Intuitive encompassing solution', 'Plambee', 'Bernhard', 6, 0),
(28, 'When the Road Bends: Tales of a Gypsy Caravan', 'Implemented background circuit', 'Zoombeat', 'Roseline', 4, 0),
(29, 'Loser', 'Streamlined analyzing architecture', 'Agivu', 'Viva', 6, 0),
(30, 'Dark Star', 'Triple-buffered stable task-force', 'Dabjam', 'Ardisj', 9, 1),
(31, 'Tie Xi Qu: West of the Tracks (Tiexi qu)', 'Diverse composite policy', 'Quinu', 'Nye', 3, 1),
(32, 'Fish Child, The (El niño pez)', 'Open-source 24/7 toolset', 'Wikizz', 'Alister', 5, 0),
(33, 'Loop the Loop (Up and Down) (Horem pádem)', 'Intuitive 24 hour monitoring', 'Zoonoodle', 'Melvin', 8, 0),
(34, 'Weird Science', 'Cross-platform coherent local area network', 'Skyble', 'Anders', 8, 0),
(35, 'Charlotte\'s Web', 'Polarised zero tolerance software', 'Ailane', 'Shaylynn', 3, 0),
(36, 'Addicted to Love', 'Mandatory client-server analyzer', 'Cogilith', 'Davin', 6, 0),
(37, 'Hogfather (Terry Pratchett\'s Hogfather)', 'Cloned scalable migration', 'Viva', 'Gabey', 9, 1),
(38, 'Klown: The Movie (Klovn)', 'Assimilated uniform flexibility', 'Feednation', 'Margaretta', 1, 0),
(39, 'Shakespeare\'s Globe: Henry V', 'Enhanced asynchronous synergy', 'Oba', 'Melloney', 2, 0),
(40, 'Warriors, The', 'Visionary 24/7 hub', 'Oodoo', 'Bennie', 7, 1),
(41, 'Back in the Saddle (Back in the Saddle Again)', 'Exclusive composite portal', 'Katz', 'Lacey', 9, 0),
(42, 'Sidestreet', 'Cross-group transitional complexity', 'Linkbridge', 'Franciska', 7, 1),
(43, 'Edge of Darkness', 'Proactive interactive hardware', 'Wikido', 'Cary', 4, 0),
(44, 'Girl with Hyacinths', 'Synergized stable extranet', 'Snaptags', 'Kane', 3, 0),
(45, 'Party Girl', 'Integrated zero tolerance website', 'Brainverse', 'Channa', 2, 0),
(46, 'Resistance', 'Fundamental system-worthy database', 'Chatterbridge', 'Clara', 1, 0),
(47, 'Magnetic Man, The (Magneettimies)', 'Upgradable fault-tolerant middleware', 'Twinte', 'Angie', 7, 0),
(48, 'Wisegirls', 'Operative value-added structure', 'Divape', 'Chadwick', 1, 0),
(49, 'Ella Lola, a la Trilby', 'Enhanced full-range approach', 'Avaveo', 'Kylen', 5, 1),
(50, 'Short Film About Love, A (Krótki film o milosci)', 'Organized leading edge archive', 'Browsezoom', 'Celene', 8, 0),
(51, 'Critters 2: The Main Course', 'Persevering content-based frame', 'Meembee', 'Jereme', 10, 0),
(52, 'Lollilove', 'Profit-focused contextually-based service-desk', 'Podcat', 'Fidel', 1, 0),
(53, 'Marksman, The', 'Multi-tiered bandwidth-monitored algorithm', 'Thoughtworks', 'Frazier', 3, 1),
(54, 'Dolly Sisters, The', 'Managed transitional capacity', 'Blogspan', 'Gwendolyn', 7, 0),
(55, 'This Is the End', 'Open-source coherent project', 'Twinte', 'Holmes', 1, 0),
(56, 'Battle for Brooklyn', 'Triple-buffered asynchronous migration', 'Zazio', 'Charil', 2, 0),
(57, 'Lady from Shanghai, The', 'Sharable object-oriented orchestration', 'Skinte', 'Tiff', 10, 0),
(58, 'Ceremony', 'De-engineered bi-directional complexity', 'Riffpedia', 'Gloriane', 10, 0),
(59, 'Cold Moon (Lune froide)', 'Up-sized methodical circuit', 'Trudeo', 'Mikel', 6, 0),
(60, 'Anna Nicole (Anna Nicole Smith Story, The)', 'Persistent incremental access', 'Yambee', 'Vladimir', 5, 1),
(61, 'Silent Souls (Ovsyanki)', 'Implemented zero administration leverage', 'Trupe', 'Scotti', 2, 0),
(62, 'I Married a Monster from Outer Space', 'Fully-configurable needs-based system engine', 'Topicshots', 'Fanchon', 9, 0),
(63, 'Revenge of the Green Dragons', 'Profit-focused solution-oriented encoding', 'Rhyzio', 'Hedi', 6, 1),
(64, 'Immortals', 'Enterprise-wide heuristic success', 'Fanoodle', 'Paddie', 6, 1),
(65, 'Seven Samurai (Shichinin no samurai)', 'Operative zero administration flexibility', 'Dabjam', 'Mil', 1, 1),
(66, 'Populaire', 'Diverse full-range solution', 'Roombo', 'Mirabel', 8, 1),
(67, 'Hamlet', 'Quality-focused context-sensitive middleware', 'Voonder', 'Curry', 9, 1),
(68, 'Judge, The', 'Multi-tiered exuding model', 'Pixoboo', 'Gillie', 6, 0),
(69, 'Orlando', 'Face to face directional methodology', 'Jetwire', 'Will', 10, 1),
(70, 'Don McKay', 'Robust dedicated local area network', 'Pixope', 'Weider', 3, 1),
(71, 'Heat\'s On, The', 'Reactive 24/7 methodology', 'Yodel', 'Tandie', 7, 0),
(72, 'Millie', 'Enterprise-wide zero defect approach', 'Dynazzy', 'Bab', 6, 0),
(73, 'Souls for Sale', 'Up-sized background service-desk', 'Voonyx', 'Hall', 6, 0),
(74, 'The Scapegoat', 'Persevering context-sensitive budgetary management', 'Eamia', 'Calida', 5, 0),
(75, 'Star Trek: Of Gods and Men', 'Inverse leading edge orchestration', 'Avaveo', 'Karlene', 6, 1),
(76, 'Love Bug, The', 'Operative composite hardware', 'Agimba', 'Shirl', 9, 1),
(77, 'Actor\'s Revenge, An (Yukinojô henge)', 'Cross-platform reciprocal methodology', 'Geba', 'Letizia', 2, 1),
(78, 'American Sniper', 'Automated content-based paradigm', 'Wikizz', 'Rouvin', 10, 0),
(79, 'Kit Kittredge: An American Girl', 'Synergistic 24/7 access', 'Ntags', 'Davida', 2, 1),
(80, 'Trois', 'Expanded client-server projection', 'Meevee', 'Livvyy', 5, 1),
(81, 'A Man Called Magnum', 'Function-based client-server encryption', 'Wikido', 'Allene', 6, 0),
(82, 'Wasabi', 'Polarised well-modulated artificial intelligence', 'Blogtag', 'Suzanne', 1, 1),
(83, 'Christmas Carol, A', 'Fully-configurable multi-tasking service-desk', 'Twitterworks', 'Carline', 10, 1),
(84, 'Wirey Spindell', 'Open-architected global time-frame', 'Fatz', 'Normie', 2, 1),
(85, 'Alibi, The (Lies and Alibis)', 'Face to face uniform projection', 'Voonix', 'Tish', 2, 0),
(86, 'Babylon 5: In the Beginning', 'Multi-channelled fresh-thinking knowledge base', 'Buzzdog', 'Augie', 7, 0),
(87, 'Where Danger Lives', 'Profit-focused local task-force', 'Eare', 'Cherianne', 9, 1),
(88, 'Shadow Dancer', 'Balanced coherent local area network', 'Realfire', 'Rafaellle', 1, 0),
(89, 'One Day in September', 'Up-sized motivating encryption', 'Demivee', 'Xaviera', 1, 0),
(90, 'Little Prince, The', 'Enterprise-wide 24/7 installation', 'Meejo', 'Rollie', 6, 1),
(91, 'Hit, The', 'Multi-tiered composite success', 'Jaxworks', 'Camille', 3, 0),
(92, 'Streetcar Named Desire, A', 'Expanded non-volatile definition', 'Wikibox', 'Neile', 2, 0),
(93, 'Jungle Book, The', 'Automated 6th generation access', 'Zava', 'Lanette', 3, 1),
(94, 'Sex: The Annabel Chong Story', 'Streamlined contextually-based protocol', 'Riffpedia', 'Derrick', 1, 0),
(95, 'Sleeping Beauty', 'Proactive solution-oriented secured line', 'Omba', 'Addy', 5, 1),
(96, 'American Friend, The (Amerikanische Freund, Der)', 'Re-contextualized full-range local area network', 'Yakidoo', 'Stormy', 5, 0),
(97, 'Trip, The', 'Progressive content-based definition', 'Meetz', 'Thor', 3, 0),
(98, 'Notorious C.H.O.', 'Upgradable 4th generation capability', 'Thoughtbeat', 'Ellette', 5, 1),
(99, 'Carrie', 'Seamless fault-tolerant encryption', 'Trudoo', 'Christy', 6, 0),
(100, 'Kedma', 'Reverse-engineered 24 hour alliance', 'Ntag', 'Waylin', 10, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categories`
--

CREATE TABLE `categories` (
  `ID` int(11) NOT NULL,
  `Name` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `categories`
--

INSERT INTO `categories` (`ID`, `Name`) VALUES
(1, 'Didácticos y lúdicos'),
(2, 'Científicos'),
(3, 'Técnicos'),
(4, 'Biográficos y autobiográficos'),
(5, 'Sagrados o religiosos'),
(6, 'De viajes'),
(7, 'Cuentos o novelas'),
(8, 'poesía'),
(9, 'Humor'),
(10, 'Microrrelatos'),
(11, 'Filosoficos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `readers`
--

CREATE TABLE `readers` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Address` longtext DEFAULT NULL,
  `Email` longtext DEFAULT NULL,
  `Phone` longtext DEFAULT NULL,
  `DNI` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `readers`
--

INSERT INTO `readers` (`ID`, `Name`, `Address`, `Email`, `Phone`, `DNI`) VALUES
(1, 'Oleg Hoffman', '6816 Lorem Ave', 'cras.convallis.convallis@aol.ca', '(153) 777-9517', '64473748'),
(2, 'Florence Bradshaw', 'Ap #895-9907 Vestibulum, Ave', 'fusce.dolor@yahoo.com', '1-837-839-7381', '99994981'),
(3, 'Vance Christensen', '955-4270 Sed Rd.', 'luctus.et@yahoo.net', '1-564-934-7787', '35168209'),
(4, 'Joan Lowery', 'Ap #290-4992 Nec Rd.', 'donec@protonmail.edu', '1-631-987-1837', '61668198'),
(5, 'Nomlanga Webster', '263-9634 Id Ave', 'aenean.euismod@yahoo.couk', '(751) 455-1603', '28351876'),
(6, 'Orli Richardson', '2232 Mauris St.', 'neque.sed.sem@outlook.edu', '(683) 991-5753', '16001686'),
(7, 'Gannon Pugh', '400-2397 Massa. St.', 'elit.erat@aol.net', '1-645-234-9167', '89833745'),
(8, 'Benjamin Merritt', 'Ap #628-1768 Non, Road', 'donec.est@protonmail.couk', '1-266-313-8346', '44232170'),
(9, 'Kameko Vincent', '665-326 Magna Ave', 'mauris@icloud.com', '1-243-826-8166', '34721521'),
(10, 'Nero Kirk', 'Ap #322-2177 Sagittis Rd.', 'eleifend.egestas@google.ca', '1-526-913-9518', '33442082'),
(11, 'Cora Guthrie', '593-1448 Vel Rd.', 'et.malesuada@google.org', '1-347-588-6346', '69142701'),
(12, 'Amos Barber', '717-3123 Sed Road', 'eu.enim@yahoo.com', '(328) 552-8109', '93858230'),
(13, 'Alea Klein', '223-8101 Neque Ave', 'semper.rutrum@aol.org', '1-985-627-0345', '89348225'),
(14, 'Harding Carlson', '892 Tortor Road', 'non@icloud.net', '(764) 242-4738', '59376909'),
(15, 'Lynn Lee', 'Ap #333-1214 Ac, Rd.', 'eget.volutpat@icloud.edu', '1-609-741-3295', '46044055'),
(16, 'Grady Melendez', 'Ap #235-8548 Vitae Rd.', 'ligula.aenean.euismod@yahoo.edu', '(647) 478-0351', '33856702'),
(17, 'Harlan Alford', '186-5439 Vitae Rd.', 'porttitor.vulputate.posuere@protonmail.couk', '(440) 743-4949', '55678979'),
(18, 'Allen Kemp', '716-779 Donec Ave', 'donec.sollicitudin@google.com', '1-143-178-4260', '64568365'),
(19, 'Zachery Carney', 'Ap #953-8736 Augue Rd.', 'interdum.feugiat@hotmail.couk', '1-345-703-9843', '89882631'),
(20, 'Jin Lancaster', 'Ap #903-9063 Ipsum. Rd.', 'quam.dignissim.pharetra@icloud.net', '(243) 948-1844', '11930187'),
(21, 'Lance Abbott', '679-1429 Blandit Road', 'primis.in@icloud.net', '(736) 877-2751', '62050775'),
(22, 'Sheila Weeks', 'Ap #937-1618 Adipiscing Ave', 'ornare.in@yahoo.ca', '1-428-856-3516', '14609440'),
(23, 'Lewis Harvey', '959-9451 Urna, Rd.', 'lorem@yahoo.org', '(473) 233-4715', '58348491'),
(24, 'Ariel Kramer', '849-8137 Blandit Street', 'in.lorem.donec@aol.ca', '(973) 635-8801', '38308461'),
(25, 'Vernon Arnold', '597-9775 Cras Avenue', 'est.tempor.bibendum@yahoo.com', '(316) 537-8785', '90482301'),
(26, 'Mauricio Baroni', 'Calle 1', 'mauriciobaroni@hotmail.com', '3498123456', '43005339'),
(27, 'Jose de San Martin', 'Calle1 España', 'jdsm@gmail.com', '568749009', '43005339'),
(28, 'Faber-Castell', 'Nuremberg, 1 street 4555', 'fabercastel@mail.com', '12345678', '0987654323');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transactions`
--

CREATE TABLE `transactions` (
  `ID` int(11) NOT NULL,
  `LoanDate` datetime(6) NOT NULL,
  `ReturnDate` datetime(6) DEFAULT NULL,
  `BookID` int(11) NOT NULL,
  `ReaderID` int(11) NOT NULL,
  `status` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `transactions`
--

INSERT INTO `transactions` (`ID`, `LoanDate`, `ReturnDate`, `BookID`, `ReaderID`, `status`) VALUES
(7, '2023-05-22 12:32:00.377591', '2023-05-22 15:18:32.142511', 5, 8, 1),
(8, '2023-05-22 13:52:28.803784', NULL, 6, 5, 1),
(9, '2023-05-22 13:53:18.236133', NULL, 10, 3, 1),
(10, '2023-05-22 13:56:32.453690', NULL, 25, 26, 1),
(11, '2023-05-22 14:00:09.828425', NULL, 7, 7, 1),
(12, '2023-05-22 14:07:30.915804', '2023-05-22 16:32:16.677545', 1, 7, 1),
(13, '2023-05-22 14:59:28.903176', NULL, 6, 6, 1),
(14, '2023-05-22 15:14:06.059512', NULL, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20230105155345_DB_Init', '5.0.5'),
('20230221160952_correccionBook', '5.0.5'),
('20230221172953_correccionBook2', '5.0.5'),
('20230223002823_transactionRefactor', '5.0.5');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `IX_Books_CategoryID` (`CategoryID`);

--
-- Indices de la tabla `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `readers`
--
ALTER TABLE `readers`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `IX_Transactions_BookID` (`BookID`),
  ADD KEY `IX_Transactions_ReaderID` (`ReaderID`);

--
-- Indices de la tabla `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `books`
--
ALTER TABLE `books`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT de la tabla `categories`
--
ALTER TABLE `categories`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `readers`
--
ALTER TABLE `readers`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT de la tabla `transactions`
--
ALTER TABLE `transactions`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `FK_Books_Categories_CategoryID` FOREIGN KEY (`CategoryID`) REFERENCES `categories` (`ID`) ON DELETE CASCADE;

--
-- Filtros para la tabla `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `FK_Transactions_Books_BookID` FOREIGN KEY (`BookID`) REFERENCES `books` (`ID`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Transactions_Readers_ReaderID` FOREIGN KEY (`ReaderID`) REFERENCES `readers` (`ID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
