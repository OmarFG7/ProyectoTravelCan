-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 18-11-2019 a las 17:32:40
-- Versión del servidor: 10.1.36-MariaDB
-- Versión de PHP: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `travelcan`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `aspnetroles`
--

INSERT INTO `aspnetroles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`) VALUES
('1', 'Administrador', 'ADMINISTRADOR', '1'),
('2', 'Usuario', 'USUARIO', '2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `aspnetuserroles`
--

INSERT INTO `aspnetuserroles` (`UserId`, `RoleId`) VALUES
('56c9bff7-558f-4c4f-8e73-599265615f79', '1'),
('926b727c-5864-4be0-bdad-3c9017c69e2a', '2'),
('a60e055a-9de0-4a24-a5cb-58a86f5514a9', '2'),
('f5eab4ce-bc46-4f6c-8f0f-09ec2023aab6', '2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `PasswordHash` longtext,
  `SecurityStamp` longtext,
  `ConcurrencyStamp` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('56c9bff7-558f-4c4f-8e73-599265615f79', 'luis@gmail.com', 'LUIS@GMAIL.COM', 'luis@gmail.com', 'LUIS@GMAIL.COM', b'0', 'AQAAAAEAACcQAAAAEFg9ClzqWdB+DIWHrKdDm6LuA7qWEUC+DJGxiZEKzRg4DADU4tB2BO/dDhvB8WT7+g==', 'ZO3FIIBUKLND4ZURW3RRY3NHBVXFKVBO', 'f0c5d803-a33b-42fc-8f3a-867a69d43a9a', NULL, b'0', b'0', NULL, b'1', 0),
('926b727c-5864-4be0-bdad-3c9017c69e2a', 'omar@rata.com', 'OMAR@RATA.COM', 'omar@rata.com', 'OMAR@RATA.COM', b'0', 'AQAAAAEAACcQAAAAEAHBgR7MPoLrO1fsHh2Jkw5bUwsLfX8kRixScmaM1cJinX7gXC6bROkGGiPA0t3alw==', 'MHRTPVTYWNIFBWLQFSJFTXBAKRWXVM6S', '02b6ff17-674b-42bb-b36e-a73910194e02', NULL, b'0', b'0', NULL, b'1', 0),
('a60e055a-9de0-4a24-a5cb-58a86f5514a9', 'bagre@usil.com', 'BAGRE@USIL.COM', 'bagre@usil.com', 'BAGRE@USIL.COM', b'0', 'AQAAAAEAACcQAAAAELGoK8Z4Y29HRNtaY4k14ri2ga7dRQW2BAU1tIJy5A6XFcVAmax3g+g+aZp6V6nP1g==', '7VH332PMODKKVUXAQXM2GGTPUY5NSESF', '63fc0b07-d328-4e3d-a92f-5dd469c8d1ea', NULL, b'0', b'0', NULL, b'1', 0),
('f5eab4ce-bc46-4f6c-8f0f-09ec2023aab6', 'kharlota@tb.com', 'KHARLOTA@TB.COM', 'kharlota@tb.com', 'KHARLOTA@TB.COM', b'0', 'AQAAAAEAACcQAAAAEOg4YjB4tDYOs40QffEIRVQrxEVzF+XxcvnwuxtdLYqzQf/OeNzcrlegpv8iZ/sLrg==', 'IOQBMAXXLYDDELDXO57YOIG5PHUD7NPR', '91199c45-89ab-4270-9652-cb19269c3250', NULL, b'0', b'0', NULL, b'1', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `Id` int(11) NOT NULL,
  `Nombres` longtext NOT NULL,
  `FechaNacimiento` datetime(6) NOT NULL,
  `Celular` longtext NOT NULL,
  `Correo` longtext NOT NULL,
  `PerroId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`Id`, `Nombres`, `FechaNacimiento`, `Celular`, `Correo`, `PerroId`) VALUES
(1, 'Ana', '1997-08-09 09:08:00.000000', '9123451862', 'ana@s.com', 1),
(2, 'Ana', '1997-09-07 09:05:00.000000', '92637613', 'anaLuz@s.com', 2),
(3, 'Cielo Danet', '1999-10-30 09:45:00.000000', '940285048', 'bagre@usil.com', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perros`
--

CREATE TABLE `perros` (
  `Id` int(11) NOT NULL,
  `NombreMascota` longtext NOT NULL,
  `Raza` longtext NOT NULL,
  `Sexo` longtext NOT NULL,
  `Edad` int(11) NOT NULL,
  `Foto` longtext NOT NULL,
  `Descripcion` longtext NOT NULL,
  `CartillaSanitaria` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perros`
--

INSERT INTO `perros` (`Id`, `NombreMascota`, `Raza`, `Sexo`, `Edad`, `Foto`, `Descripcion`, `CartillaSanitaria`) VALUES
(1, 'rambo', 'mestizo', 'Macho', 1, 'https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTLpo6zUuwp-3JS5dr_tdYrv9ggsLLmo4h4b9crSX-qoKNWWpkx', 'bello', 'data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUTExMVFhUXGRgaGBgYGBYYGBgXGBoaGBsYFhobHygiGBolGxgXITEhJSkrLi4uGB81ODMtNygtLisBCgoKDg0OGhAQGiseHx8tKy0rLSstLS8tLS0tLS0tLS0tLS0tLS0tLS0tLS0rLS0tLS0tLSstKy0tLS0rLS0tLf/AABEIAKkBKwMBIgACEQEDEQH/xAAcAAABBQEBAQAAAAAAAAAAAAADAQIEBQYHAAj/xABEEAACAQMCAwUFBQYFAgUFAAABAhEAAyESMQRBUQUTImFxBgeBkfAjMkLB0RRSYnKhsTOCsuHxQ5IVFiQ1c4Ois8LS/8QAGgEAAgMBAQAAAAAAAAAAAAAAAAQBAgMFBv/EACoRAAICAQMDAwQCAwAAAAAAAAABAhEDEiExBAVBEyIyUWFxgZHwFELB/9oADAMBAAIRAxEAPwB9wZPrXgM7U5x/ekLVyqOxSFpYobPQLvGqu5HTcD86mrIciTNeNwD+1QlvM2UV2B2KKzgnoCogn0qV/wCD8Y2Bwt/4ppn/ALjj0q3ptkepFcsRr4pycRmKkp7H8ewBFgL5NcRT8pP96m2/d7xh3awJ/jeR6wkf1q6wyKvPBeSq/aeXWmPxQGZgeZHw+NaIe7jiCJN+0D5LcI+cj+1af2c9j7PDAO32l399hsf4F2X13q0cD8mcupil7TM9jeyt+/DXPsbfUj7Q7fdUjwg5y2cbVtuyuw7FjNpPEN2JLMfVj+VWQt53Pp9fWaXTy+opmOOMeEJzyynyxSfofnSikVfh5frSgAVoZiivKsUjvFCW/MwDgweXyncedAB6Wo9pmIBOOvz9TyqRQB41HvcMraSwBKGVJ/C0ESPOCaOaC7kmAfU7wP1NACWVnPy/WjbUgNZn299qBwVjUGXvrnhsqebc2I5hRnzwOdAGnBqMzdIVidjzE5/pPzrIexHvDs8aBafTa4iPuE+G5'),
(2, 'Roshi', 'Chino', 'Macho', 2, 'https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR0Y_wp_cL1bW4lKcrdwtn3UCtK7DITpamVfzM_35xUket36JWS', 'Es un amor', 'data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUTExMVFhUXGRgaGBgYGBYYGBgXGBoaGBsYFhobHygiGBolGxgXITEhJSkrLi4uGB81ODMtNygtLisBCgoKDg0OGhAQGiseHx8tKy0rLSstLS8tLS0tLS0tLS0tLS0tLS0tLS0tLS0rLS0tLS0tLSstKy0tLS0rLS0tLf/AABEIAKkBKwMBIgACEQEDEQH/xAAcAAABBQEBAQAAAAAAAAAAAAADAQIEBQYHAAj/xABEEAACAQMCAwUFBQYFAgUFAAABAhEAAyESMQRBUQUTImFxBgeBkfAjMkLB0RRSYnKhsTOCsuHxQ5IVFiQ1c4Ois8LS/8QAGgEAAgMBAQAAAAAAAAAAAAAAAAQBAgMFBv/EACoRAAICAQMDAwQCAwAAAAAAAAABAhEDEiExBAVBEyIyUWFxgZHwFELB/9oADAMBAAIRAxEAPwB9wZPrXgM7U5x/ekLVyqOxSFpYobPQLvGqu5HTcD86mrIciTNeNwD+1QlvM2UV2B2KKzgnoCogn0qV/wCD8Y2Bwt/4ppn/ALjj0q3ptkepFcsRr4pycRmKkp7H8ewBFgL5NcRT8pP96m2/d7xh3awJ/jeR6wkf1q6wyKvPBeSq/aeXWmPxQGZgeZHw+NaIe7jiCJN+0D5LcI+cj+1af2c9j7PDAO32l399hsf4F2X13q0cD8mcupil7TM9jeyt+/DXPsbfUj7Q7fdUjwg5y2cbVtuyuw7FjNpPEN2JLMfVj+VWQt53Pp9fWaXTy+opmOOMeEJzyynyxSfofnSikVfh5frSgAVoZiivKsUjvFCW/MwDgweXyncedAB6Wo9pmIBOOvz9TyqRQB41HvcMraSwBKGVJ/C0ESPOCaOaC7kmAfU7wP1NACWVnPy/WjbUgNZn299qBwVjUGXvrnhsqebc2I5hRnzwOdAGnBqMzdIVidjzE5/pPzrIexHvDs8aBafTa4iPuE+G5'),
(3, 'Luquitas', 'Pug', 'Macho', 1, 'https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTrRlY9xX2ruPvCSDXyLiQ2Az1ChJ1IBB8ZhLN1CVzrKHRZR94t', 'Es Muy Delicado.', 'https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQF8_pEgf25C0is3OWtqkKT1tuAglqTmj_at87-AVyXTsFG9JUo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reservas`
--

CREATE TABLE `reservas` (
  `IdCliente` int(11) NOT NULL,
  `IdViaje` int(11) NOT NULL,
  `Fecha` datetime(6) NOT NULL,
  `clientesId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `reservas`
--

INSERT INTO `reservas` (`IdCliente`, `IdViaje`, `Fecha`, `clientesId`) VALUES
(1, 1, '2019-11-16 12:55:29.717807', 1),
(2, 2, '2019-11-16 14:49:34.512175', 2),
(3, 5, '2019-11-16 22:07:37.414882', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reseñas`
--

CREATE TABLE `reseñas` (
  `Id` int(11) NOT NULL,
  `Descripcion` longtext,
  `Foto` longtext,
  `CorreoUsuario` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `reseñas`
--

INSERT INTO `reseñas` (`Id`, `Descripcion`, `Foto`, `CorreoUsuario`) VALUES
(1, 'Nos DIvertimos Super Junto a mis Hijos', 'https://scontent.flim15-1.fna.fbcdn.net/v/t1.0-9/75282337_948876378802863_8344418558960205824_o.jpg?_nc_cat=106&_nc_oc=AQl0V7W_9lbLhhzxVCMNhNeme8a1OTR6A3Pk-UNbBN2B4lMiCJI05Gb6toZcuqAqtKc&_nc_ht=scontent.flim15-1.fna&oh=9627d9aaafbdc6c5e74b1806f471a5d3&oe=5E8A86D4', 'ana@s.com'),
(2, 'Hermoso Dia en aquel lugar, todavia me acuerdo que encotramos varios cangrejos y firu escarbó la arena para sacarlo..... Se los recomiendo', 'https://scontent.flim15-1.fna.fbcdn.net/v/t1.0-9/74594639_948877732136061_2124407853870481408_o.jpg?_nc_cat=104&_nc_oc=AQlVb4Unn9h0AW-WNe_bGeSOy7Onizdpo6eFg4zfsZnXnQttfNgYlrfpmW_elIUKe3g&_nc_ht=scontent.flim15-1.fna&oh=cfd5eaf3be5418f4fe67185c5566737e&oe=5E54BC22', 'bagre@usil.com'),
(3, 'Fue un dia excelente con mi perro Rambo, jugamos y nos ejercitamos mucho.... Gracias travelCan', 'https://scontent.flim15-1.fna.fbcdn.net/v/t1.0-9/s960x960/74602845_947294855627682_5384561221519278080_o.jpg?_nc_cat=108&_nc_oc=AQnMrXADCUyW0nM6m_MA0JtNrquzdg8e4cvvuH1K6r0-J9WZGsTP2RY0ClFq0xsfAWU&_nc_ht=scontent.flim15-1.fna&oh=ae5dcda877ee9916e9bbff0e236a4b56&oe=5E4C4E26', 'omar@rata.com'),
(6, 'Disfrute del gran sueño con mi gata Gloming, disfrutamos del sueño bien rico... Obvi', 'https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcT5Osm-aflBSt-V5zAWO0WOyeFYWysk4nBhQAX3YSKmJ7OD_Hzl', 'kharlota@tb.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tarjetas`
--

CREATE TABLE `tarjetas` (
  `Id` int(11) NOT NULL,
  `NumeroTarjeta` int(11) NOT NULL,
  `Mes` int(11) NOT NULL,
  `Año` int(11) NOT NULL,
  `CVV` int(11) NOT NULL,
  `NombreEnTarjeta` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `viajes`
--

CREATE TABLE `viajes` (
  `Id` int(11) NOT NULL,
  `Foto` longtext NOT NULL,
  `Descripcion` longtext NOT NULL,
  `nombrePartida` longtext NOT NULL,
  `nombreDestino` longtext NOT NULL,
  `Costo` float NOT NULL,
  `Fecha` datetime(6) NOT NULL,
  `DescripcionCompleta` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `viajes`
--

INSERT INTO `viajes` (`Id`, `Foto`, `Descripcion`, `nombrePartida`, `nombreDestino`, `Costo`, `Fecha`, `DescripcionCompleta`) VALUES
(1, 'https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRC5oonF4hA1P7kVLRQskujZ0IDjayvGb35o58oCDu-48I7Rmck', 'El Oasis Escondido en Ica \"Pet Friendly\"-Sáb 14 y Dom 15 De Diciembre', 'Lima | La Molina', 'Ica | Pisco-Independecnia', 280, '2019-12-14 05:00:00.000000', '\"FDS EN EL MEJOR OASIS ESCONDIDO PETFRIENDLY DE ICA\"\r\n  \r\nFIN DE SEMANA EN EL MÁS IMPRESIONANTE OASIS EN EL DESIERTO DE ICA. HEMOS ORGANIZADO UN VIAJE RELÁMPAGO DE FIN DE SEMANA APTO PARA TODA LA FAMILIA, EN DONDE NOS INSTALAREMOS EN UN REFUGIO ECÓLOGICO EXCLUSIVAMENTE PARA NOSOTROS Y NUESTROS ENGREÍDOS DE 4PATITAS. ¡AL ÚNICO ESTILO DE TRAVELCAN PERÚ!\r\n\r\n??FECHA DISPONIBLE:\r\n- SÁBADO 26 AL DOMINGO 27 DE OCTUBRE (2 días / 1 noche)\r\n \r\n??A TENER EN CUENTA:\r\n- Apto para todas las razas y sus cruces\r\n- La mascota debe encontrarse en buen estado de salud (No mascotas con insuficiencia cardíaca, insuficiencia renal u otras enfermedades que podrían poner en riesgo la vida del animal)\r\n- No se permiten mascotas AGRESIVAS ni en CELO\r\n- OBLIGATORIO: La mascota debe estar al día en su rol de vacunación y desparasitación (se adjuntará la tarjeta de vacunas junto con la inscripción) \r\n- El dueño deberá supervisar y hacerse responsable de su mascota durante todo el desarrollo de nuestro viaje canino.\r\n- Se realizará la reserva de los cupos con el 50% de adelanto, el otro 50% se entregará al abordar la movilidad.\r\n\r\n??HORA Y LUGAR DE ENCUENTRO:\r\n- 6:00 AM: MUNICIPALIDAD DE LOS OLIVOS (solo 10 minutos de tolerancia)\r\n\r\n- 7:00 AM: ESTACIONAMIENTO KIA MOTORS REF. CRUCE DE JAVIER PRADO ESTE 401 CON PASEO PARODI - SAN ISIDRO (solo 10 minutos de tolerancia)\r\n\r\n??ITINERARIO:\r\nDía 1: SÁBADO 26 OCTUBRE \r\n- 6:10 AM. Salida con destino al punto II de embarque\r\n- 7:10 AM. Salida con destino a Ica \r\n- 12:00 AM. Hora de Llegada aproximada al Refugio Ecolodge, instalación en hospedaje y/o armado de carpas \r\n- 01:30 PM. Hora de Almuerzo y compartir con el grupo (INCLUYE)\r\n- 05:00 PM. Caminata en las dunas para disfrutar del sunset y actividades como SandBoard.\r\n- 08:00 PM.  Noche de Fogata y cena (INCLUYE)\r\n\r\nDía 2: DOMINGO 27 OCTUBRE\r\n- 08:00 AM. Desayuno grupal (INCLUYE)\r\n- 10:00 AM caminata y Recreación hacia la hermosa y escondida laguna, uso de Kayak, Paddles, paseos en minibotes, natación, etc.\r\n- 01:00 PM Parrilla Grupal (INCLUYE)\r\n-04:00 PM Retorno a Lima\r\n- 09:00 PM Hora de llegada aproximada a Lima al punto de encuentro II (Cruce Av. Javier Prado con Av. Paseo Parodi).\r\n-10:00 p.m. Hora de llegada aproximada al punto de encuentro I (Municipalidad de los Olivos).\r\n\r\n?? PRECIO: \r\n?Modalidad CAMPAMENTO \r\n- S/ 280 POR PERSONA + UN (1) PERRITO que viaja cargado por su dueño en un asiento. Asiento ADICIONAL para la mascota S/ 150.00 ADICIONALES (recomendado para perros medianos y/o grandes)\r\n\r\n- Asiento para una persona acompañante  (sin mascota): S/ 250.00 \r\n- Asiento para una persona acompañante niño (sin mascota/ max. 14 años - certificar con DNI): S/ 200.00\r\n\r\n?Modalidad HOSPEDAJE\r\n- S/ 350 POR PERSONA + UN (1) PERRITO que viaja cargado por su dueño en un asiento. Asiento ADICIONAL para la mascota S/ 150.00 ADICIONALES (recomendado para perros medianos y/o grandes)\r\n\r\n- Asiento para una persona acompañante  (sin mascota): S/ 320.00 \r\n- Asiento para una persona acompañante niño (sin mascota/ max. 14 años - certificar con DNI): S/ 270.00\r\n\r\n* Capacidad Limitada para Hospedaje de 17 Personas, 6 dormitorios en total, con baño completo\r\n\r\n?? INCLUYE:\r\n- Movilidad turística privada: Lima-Ica- Lima\r\n- Desayuno a Bordo día 1, Desayuno día 2, Almuerzos campestres para ambos días, Cena día 1  \r\n- KIT Travelcan Perú: comida hipoalergénica de cordero 200gr. para tu engreído + bolsitas de heces\r\n- Aplicación de Protector de Almohadillas y bloqueador para las patitas de nuestros engreídos\r\n- Uso de todas las Instalaciones del Lodge Ecólogico y equipos del lugar (Kayak, Paddles, tablas de Sanboarding, mesa de pin pong, minibotes, hamacas, etc.)\r\n- Médico Veterinario durante todo el evento para consultas y/o emergencias\r\n-Juegos interactivos con tu mascota y breve charla educativa con Médicos Veterinarios especializados en Conducta Canina.\r\n- Guías de Trekking y personal de apoyo\r\n- Botiquín de Primeros auxilios para ti y tu mascota\r\n- Las mejores fotografías con tu engreído\r\n- Noche de Fogata \r\n\r\n?QUÉ LLEVAR:\r\n- 01 Mochila resistente y con poco peso (solo cosas necesarias)\r\n- Ropa fresca y abrigadora para nuestros engreídos, así como toalla para secarlos.\r\n- Carpa y Sleeping para los que deseen acampar (NO INCLUYE) \r\n-OBLIGATORIO: Una toalla o manta para tu mascota (para cubrir el asiento)\r\n- Ropa deportiva, ropa de baño, sandalias, gorro, REPELENTE, lentes de sol, protector solar, una casaca, zapatillas y buzo  para la noche \r\n- Cámara fotográfica\r\n- Refrigerio adicional (El hospedaje es un refugio ecológico, no hay tiendas dentro ni a los alrededores)\r\n- Agua para ti y para tu mascota, platito y comida adicional de tu mascota\r\n- OBLIGATORIO: Pechera y su tiro para tu mascota\r\n- Cargador portátil (el lugar es ecológico no hay para cargar celulares)\r\n- Mantita para que duerma tu mascotita'),
(2, 'https://scontent.flim15-1.fna.fbcdn.net/v/t1.0-9/75398225_930349477322220_2310990634892132352_o.jpg?_nc_cat=103&_nc_oc=AQnw7Ybqa1iEIZRtqahV71V-f-MdQYuLPbs1fHw9WkPFC4NAnmOZty1tAvaxqIv0E9k&_nc_ht=scontent.flim15-1.fna&oh=9f337848732e3222ec30c8ae8bd5d758&oe=5E3E4164', 'Full Day Club Campestre - Domingo 8 de diciembre (FERIADO)', 'Lima | La Molina', 'Chaclayo | CLUB CAMPESTRE', 198, '0001-01-01 00:00:00.000000', 'FULL DAY CLUB CAMPESTRE CHACLACAYO  HEMOS ORGANIZADO UN EVENTO SÚPER ESPECIAL APTO PARA TODA LA FAMILIA PARA PASAR TODO EL DÍA FUERA DE LA RUTINA. POR ELLO NOS ESCAPAMOS CON DESTINO A CHACLACAYO DONDE EL SOL NUNCA NOS ABANDONA PARA DISFRUTAR DE UN CLUB CAMPESTRE DE MÁS DE 4000 m2 CON 2 PISCINAS, AMPLIA ÁREAS VERDES Y EXCLUSIVIDAD SOLAMENTE PARA NOSOTROS JUNTO A NUESTROS ENGREÍDOS DE 4PATITAS!  ¡AL ÚNICO ESTILO DE TRAVELCAN PERÚ!  ?FECHAS DISPONIBLES:  - DOMINGO 10 DE NOVIEMBRE (Exclusivo para perros chicos y/o medianos - Hasta 12 kg) - DOMINGO 8 DE DICIEMBRE - FERIADO (Exclusivo para perros medianos y grandes +13kg)  ? A TENER EN CUENTA:  - Apto para todas las razas y sus cruces - La mascota debe encontrarse en buen estado de salud (No mascotas con insuficiencia cardíaca, insuficiencia renal u otras enfermedades que podrían poner en riesgo la vida del animal) - No se permiten mascotas agresivas ni en celo - OBLIGATORIO: La mascota debe estar al día en su rol de vacunación y desparasitación (se adjuntará la tarjeta de vacunas junto con la inscripción)  - El dueño deberá supervisar y hacerse responsable de su mascota durante todo el desarrollo de nuestro Full Day Canino. - Se realizará la reserva de los cupos con el 50% de adelanto, el otro 50% se entregará al abordar la movilidad.  ? HORA Y LUGAR DE ENCUENTRO:  - 7:00 AM: MUNICIPALIDAD DE LOS OLIVOS (solo 10 minutos de tolerancia)  - 8:00 AM: ESTACIONAMIENTO KIA MOTORS REF. CRUCE  DE JAVIER PRADO CON PASEO PARODI - SAN ISIDRO (solo 10 minutos de tolerancia)  - 8:30 AM ESTADIO MONUMENTAL DE LA U (ATE - LA MOLINA) *No hay tole'),
(3, 'https://scontent.flim15-1.fna.fbcdn.net/v/t1.0-9/73539742_941684016188766_2076024012193923072_o.jpg?_nc_cat=102&_nc_oc=AQm9R5usi8Zqhoy8aDfuQkOvF5L61C1xkGgnCmjB231osMm7bof5hIGiq72R5sxtLyo&_nc_ht=scontent.flim15-1.fna&oh=98118d59a4f9796b6485f10f59525e17&oe=5E44D887', 'PLAYA DEL AMOR + ALBUFERA DE MEDIO MUNDO ', 'Lima | La Molina', 'Huaura|Playa del Amor', 130, '0001-01-01 00:00:00.000000', '?PLAYA DEL AMOR + ALBUFERA DE MEDIO MUNDO   *RUTA NUEVA Y EXCLUSIVA DE TRAVELCAN PERÚ  En esta oportunidad nos vamos a disfrutar de una hermosa  playa escondida en el norte chico, denominada la Playa del Amor por su incomparable belleza y armonía que caracteriza esta joya escondida, cuenta con una orilla grande para refrescarse tranquilamente. Asimismo, luego partiremos hacia las mágicas Albuferas de medio Mundo, que es un Área de Conservación Regional que se encuentra localizada en el distrito de Vegueta, dentro de la provincia de Huaura en la región de Lima. Esta presenta una extensión de 687. 71 hectáreas dentro de las cuales se comprende: una zona de laguna y una parte pantanosa. Dónde además tomaremos un hermoso paseo en bote en compañía de nuestros engreídos de 4patitas.   ? IMPORTANTE:  - Nivel de dificultad:  Básico -Apto para personas no sedentarias   ?FECHAS DISPONIBLE  - DOMINGO 17 DE NOVIEMBRE (EXCLUSIVO PARA PERRITOS PEQUEÑOS Y/O MEDIANOS HASTA LOS 13KG.)   ? A TENER EN CUENTA:  - Apto para todas las razas y sus cruces (Por ejm. tamaños tipo schnauzer, beagle, shihtzú, Yorkshire, pequinés, poodle, maltés, bichón, bulldog Inglés o francés, etc) - La mascota debe encontrarse en buen estado de salud (No mascotas con insuficiencia cardíaca, insuficiencia renal u otras enfermedades que podrían poner en riesgo la vida del animal) - No se permiten mascotas AGRESIVAS ni en CELO - OBLIGATORIO: La mascota debe estar al día en su rol de vacunación y desparasitación (se adjuntará la tarjeta de vacunación junto con su inscripción)  - El dueño deberá supervisar y hacerse responsable de su mascota durante todo el desarrollo de nuestro Full Day Canino. - Se realizará la reserva de los cupos con el 50% de adelanto  ? HORA Y LUGAR DE ENCUENTRO:  ?5:20 AM: Avenida Javier Prado Este 401 - KIA MOTORS (cruce de Javier Prado con Paseo Parodi) *Solo habrá 10 minutos de tolerancia por respeto a todos los participantes  ?5:45 AM Recojo Paradero Panamericana Norte de Megaplaza Los Olivos  (no hay tolerancia)   ?ITINERARIO:    -05:30 a.m. Salida con destino a la playa del amor  -09:30 a.m  Hora de inicio del Trekking para llegar a la playa  -10:00 a.m Hora aproximada de llegada a la playa. Momento de ponernos cómodos y relajarnos junto a nuestros engreídos de 4 patitas -12:30 p.m. Momento de alistarnos para ir hacia las Albuferas de Medio Mundo  -01:20 pm. Hora de Almuerzo en las Albuferas de Medio Mundo  (No Incluye)  -02:30 pm. Paseo en Bote en las Albuferas de Medio Mundo  -03: 00 pm. Tour guiado en las Albuferas de Medio Mundo  -04: 30 pm. Hora de partir a Lima -08:30 pm. Hora aproximada de llegada a Lima al mismo punto de encuentro.  ? PRECIO:   - S/. 130.00 POR PERSONA + UN (1) PERRITO que viaja cargado por su dueño en un asiento. - Asiento Exclusivo para tu perro: S/. 70.00 ADICIONAL (recomendado para perros medianos).   -Asiento para una persona acompañante (sin mascota): S/. 120.00   - Asiento para niños acompañantes hasta los 14 años: S/. 90.00   ? INCLUYE:  -Movilidad privada turística durante todo el recorrido / Soat turístico  -Desayuno a bordo  -Sorteo sorpresa en el bus durante el trayecto  -Paseo en bote (Albuferas de Medio mundo)  -Protector de Almohadillas para las patitas de nuestros engreídos y bloqueador - Guías de trekking con más de 5 años de experiencia y personal de apoyo - Médico Veterinario durante todo el evento  - Equipos de comunicación -Juegos dinámicos con tu engreído  - Botiquín de Primeros auxilios para ti y tu mascota - Las mejores fotografías con tu engreído - Comida hipoalergénica para tu perrito y bolsitas para heces  ?QUÉ LLEVAR: - 01 Mochila resistente y con poco peso (solo cosas necesarias) *llevar medias o zapatitos para tu mascotita (obligatorio para el tramo de Trekking hacia la playa para proteger sus patitas)  -Toalla para tu engreído de 4patitas -SOMBRILLA (no alquilan sombrillas en el lugar)  -OBLIGATORIO: Una toalla o manta para tu mascota (para cubrir el asiento) - Ropa deportiva, ropa de baño, sandalias, gorro, lentes de sol, protector solar y una casaca para la tarde - Zapatillas para caminar -REPELENTE - Cámara fotográfica - Una botella de agua para ti y otra para tu mascota, platito para agua y comida de tu mascota - OBLIGATORIO: Pechera o collar y su tiro para tu mascota   ?INSCRIPCIONES:  REALIZAR EL DEPÓSITO DEL 50% SOLO MEDIANTE AGENTES O TRANSFERENCIAS A LA SIGUIENTE CUENTA (NO depósitos en las mismas oficinas del Banco)'),
(5, 'https://scontent.flim15-1.fna.fbcdn.net/v/t1.0-9/75443097_944346182589216_6508802467826761728_o.jpg?_nc_cat=102&_nc_oc=AQkhAb7vohtgh4jm6XY_OLPO68lM5vPydm28pi8KsGKjJXJ2AzZmdeI8jRHqQHKSigw&_nc_ht=scontent.flim15-1.fna&oh=2d99a95b3ea53e30c3edee4b8e9b2481&oe=5E44F7BA', 'Playa La Caleta + Casa de Campo - Dom. 27 de Noviembre', 'Lima | La Molina', 'Mala |Playa la Caleta', 130, '0001-01-01 00:00:00.000000', 'De Mala, su Encanto: Una “Playa Caleta” y una “Casa de Campo” solo para ti y tu engreído de 4 patitas.\r\n\r\nEn esta oportunidad nos vamos a disfrutar de una hermosa “Playa Caleta” como también de una \"Casa de Campo\" muy acogedora en Mala. El distrito de Mala es uno de los 16 que integran la provincia de Cañete, se encuentra ubicada en la Costa Central del Perú, a 86 Km. de la ciudad de Lima (2 horas aprox.). Ven y disfruta al estilo único de Travelcan Perú de esta playa encantadora y escondida, así como de una riquísima comida en una casa de campo solo para nosotros, en donde tu engreído podrá correr libremente y disfrutar de una hermosa lagunita, pasarás un día lleno de mucha buena vibra y full adrenalina. \r\n\r\n? IMPORTANTE:\r\n\r\n- Nivel de dificultad: Básico\r\n\r\n?FECHA DISPONIBLE:\r\n\r\n- Domingo 17 de Noviembre (Exclusivo perros Medianos y grandes)\r\n- Domingo 01 de Diciembre (Exclusivo perros pequeños hasta 13kg)\r\n\r\n? A TENER EN CUENTA:\r\n\r\n- Apto para todas las razas y sus cruces de 13 kg a más Kg. (Leer requisitos adicionales en Términos y Condiciones de Servicios)\r\n- La mascota debe encontrarse en buen estado de salud (No mascotas con insuficiencia cardíaca, insuficiencia renal u otras enfermedades que podrían poner en riesgo la vida del animal)\r\n- No se permiten mascotas AGRESIVAS ni en celo\r\n- OBLIGATORIO: La mascota debe estar al día en su rol de vacunación y desparasitación (se adjuntará la tarjeta de vacunación junto con su inscripción) \r\n- El dueño deberá supervisar y hacerse responsable de su mascota durante todo el desarrollo de nuestro Full Day Canino.\r\n- Se realizará la reserva de los cupos con el 50% de adelanto\r\n\r\n? HORA Y LUGAR DE ENCUENTRO:\r\n\r\n•7:00 AM: Municipalidad de Los Olivos \r\n•8:00 AM: Avenida Javier Prado Este 401 San Isidro - KIA MOTORS (cruce de Javier Prado con Paseo Parodi)\r\n *Solo habrá 10 minutos de tolerancia por respeto a todos los participantes\r\n\r\n?ITINERARIO:\r\n\r\n- 08:10 am. Salida con destino a la playa “Caleta de Mala”\r\n-10:10 am. Hora aproximada de llegada a la playa. Momento de ponernos cómodos y relajarnos junto a nuestros engreídos de 4 patitas\r\n-12:30 pm. Momento de alistarnos para ir a almorzar en una casa de campo solo para nosotros\r\n-01:00 pm. Momento de integración, almuerzo (INCLUYE) y compartir con todo el grupo \r\n-02:00 pm. Breve charla e inicio de los juegos interactivos entre dueños y mascotas\r\n-03:00 pm. Nos podemos cómodos y disfrutamos de los ambientes de la casa de campo, toma de fotografías profesionales, sorteo de premios sorpresas\r\n-04:00 pm. Hora de partir a Lima\r\n-06:00 pm. Hora aproximada de llegada a Lima al Kia Motors - San Isidro\r\n-07:00 pm. Hora aproximada de llegada a la Municipalidad de los Olivos\r\n\r\n? PRECIO: \r\n\r\n- S/. 130.00 POR PERSONA + UN (1) PERRITO que viaja cargado por su dueño en un asiento. - Asiento Exclusivo para tu perro: S/. 70.00 ADICIONAL (recomendado para perros medianos). \r\n\r\n-Asiento para una persona acompañante (sin mascota): S/. 120.00 \r\n\r\n- Asiento para niños acompañantes hasta los 14 años: S/. 90.00 \r\n\r\n-Personas que lleguen al lugar con movilidad propia y requieran el guiado según nuestro itinerario: S/. 70.00 c/u (incluye todo a excepción de la movilidad)\r\n\r\n? INCLUYE:\r\n\r\n- Movilidad privada: Lima-Mala- Lima\r\n-Protector de Almohadillas para las patitas de nuestros engreídos y bloqueador\r\n- Guías de trekking con más de 5 años de experiencia y personal de apoyo\r\n- Médico Veterinario durante todo el evento para consultas y/o emergencias\r\n- Equipos de comunicación\r\n- Botiquín de Primeros auxilios para ti y tu mascota\r\n- Las mejores fotografías con tu engreído\r\n-Sorteo de premios sorpresas \r\n- Kit Travelcan Perú: Bebida, sándwich y/o similar\r\n- ALMUERZO: ¼ de pollo al cilindro, acompañado de unas deliciosas papitas y ensalada\r\n- Comida hipoalergénica para tu perrito y bolsitas para heces\r\n\r\n?QUÉ LLEVAR:\r\n\r\n- 01 Mochila resistente y con poco peso (solo cosas necesarias)\r\n-Ropa fresca y abrigadora para nuestros engreídos, así como toalla para secarlos\r\n-SOMBRILLA\r\n-OBLIGATORIO: Una toalla o manta para tu mascota (para cubrir el asiento)\r\n- Ropa deportiva, ropa de baño, sandalias, gorro, lentes de sol, protector solar y una casaca para la tarde\r\n- Zapatillas para caminar\r\n-REPELENTE\r\n- Cámara fotográfica\r\n- Una botella de agua para ti y otra para tu mascota, platito para agua y comida de tu mascota\r\n- OBLIGATORIO: Pechera o collar y su tiro para tu mascota ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20191111053748_BdInicial', '2.2.6-servicing-10079'),
('20191111123421_IncluidoReseñaUsuario', '2.2.6-servicing-10079'),
('20191111123803_IncluidoReseña', '2.2.6-servicing-10079'),
('20191111124354_IncluidoReseña1', '2.2.6-servicing-10079'),
('20191111170600_Correcion', '2.2.6-servicing-10079'),
('20191113225731_Correccion', '2.2.6-servicing-10079'),
('20191116160407_ReservCliente', '2.2.6-servicing-10079'),
('20191116163337_IdCliente', '2.2.6-servicing-10079'),
('20191116163634_CorreccionID', '2.2.6-servicing-10079'),
('20191116163743_CorreccionIdReserva', '2.2.6-servicing-10079'),
('20191116163942_CorreccionIdReser', '2.2.6-servicing-10079'),
('20191116165048_correc2', '2.2.6-servicing-10079'),
('20191116172150_correccion7', '2.2.6-servicing-10079'),
('20191116173504_Mejor', '2.2.6-servicing-10079'),
('20191116184636_arreglosTablasFechaYRegistroVIaje', '2.2.6-servicing-10079'),
('20191117040933_Tarjeta', '2.2.6-servicing-10079');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indices de la tabla `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indices de la tabla `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indices de la tabla `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indices de la tabla `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indices de la tabla `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indices de la tabla `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Clientes_PerroId` (`PerroId`);

--
-- Indices de la tabla `perros`
--
ALTER TABLE `perros`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `reservas`
--
ALTER TABLE `reservas`
  ADD PRIMARY KEY (`IdCliente`,`IdViaje`),
  ADD KEY `IX_Reservas_clientesId` (`clientesId`);

--
-- Indices de la tabla `reseñas`
--
ALTER TABLE `reseñas`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `tarjetas`
--
ALTER TABLE `tarjetas`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `viajes`
--
ALTER TABLE `viajes`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `perros`
--
ALTER TABLE `perros`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `reseñas`
--
ALTER TABLE `reseñas`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tarjetas`
--
ALTER TABLE `tarjetas`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `viajes`
--
ALTER TABLE `viajes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD CONSTRAINT `FK_Clientes_Perros_PerroId` FOREIGN KEY (`PerroId`) REFERENCES `perros` (`Id`);

--
-- Filtros para la tabla `reservas`
--
ALTER TABLE `reservas`
  ADD CONSTRAINT `FK_Reservas_Clientes_clientesId` FOREIGN KEY (`clientesId`) REFERENCES `clientes` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
