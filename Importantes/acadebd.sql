-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 09-06-2021 a las 02:00:36
-- Versión del servidor: 10.4.19-MariaDB
-- Versión de PHP: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `acadebd`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historial`
--

CREATE TABLE `historial` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `grado` text NOT NULL,
  `prueba` text NOT NULL,
  `calificacion` int(11) NOT NULL,
  `fecha` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `historial`
--

INSERT INTO `historial` (`id`, `id_usuario`, `grado`, `prueba`, `calificacion`, `fecha`) VALUES
(1, 3, '1ro', 'esp', 10, '07/05/2019'),
(2, 2, '3ro', 'mate', 8, '07/05/2019'),
(3, 2, '2do', 'ing', 5, '07/05/2019'),
(4, 2, '2do', 'ing', 10, '07/05/2019'),
(5, 2, '2do', 'ing', 7, '07/05/2019'),
(6, 2, '3ro', 'esp', 6, '07/05/2019'),
(7, 3, '3ro', 'mate', 9, '07/05/2019'),
(8, 2, '1ro', 'mate', 2, '13/05/2019'),
(9, 2, '1ro', 'esp', 1, '13/05/2019'),
(10, 3, '2do', 'esp', 10, '13/05/2019'),
(11, 3, '3ro', 'esp', 3, '13/05/2019'),
(12, 3, '1ro', 'ing', 4, '13/05/2019'),
(13, 3, '1ro', 'mate', 0, '13/05/2019'),
(14, 2, '1ro', 'mate', 5, '26/05/2019'),
(15, 2, '3ro', 'mate', 7, '26/05/2019'),
(16, 2, '2do', 'ing', 7, '26/05/2019'),
(17, 2, '2do', 'esp', 3, '04/06/2021'),
(18, 2, '1ro', 'esp', 2, '04/06/2021'),
(19, 2, '1ro', 'esp', 1, '04/06/2021'),
(20, 2, '1ro', 'esp', 6, '04/06/2021'),
(21, 2, '1ro', 'esp', 5, '04/06/2021'),
(22, 7, '1ro', 'esp', 6, '07/06/2021');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntasesp1`
--

CREATE TABLE `preguntasesp1` (
  `id` int(11) NOT NULL,
  `preg` varchar(300) NOT NULL,
  `a` varchar(200) NOT NULL,
  `b` varchar(100) NOT NULL,
  `c` varchar(100) NOT NULL,
  `d` varchar(100) NOT NULL,
  `Correcta` varchar(100) NOT NULL,
  `Explicacion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntasesp1`
--

INSERT INTO `preguntasesp1` (`id`, `preg`, `a`, `b`, `c`, `d`, `Correcta`, `Explicacion`) VALUES
(1, 'Elige el verbo adecuado y completa los adjetivos, Adam ......... rubi... y alt....', 'es,o,o', 'as,e,d', 'ab,s,e', 'la,e,c', 'a', 'adam es rubio y alto'),
(2, 'Elige el verbo adecuado y completa los adjetivos, Ella ............. el pelo cort.... y\n............ gafas', 'usa,c,rotas', 'tiene,o,usa', 'tiene,a,bonitas', 'tiene,e,usa', 'b', 'Ella tiene el pelo corto y usa gafas '),
(3, 'Elige el verbo adecuado y completa los adjetivos,Me llamo Sofia, . ............baj...\ny rubi....', 'usa,e,a', 'soy,e,e', 'soy,a,a', 'soy,a,e', 'c', 'Me llamo sofia soy bajita y rubia'),
(4, 'Elige el verbo adecuado y completa los adjetivos,Mi hermana .............. el pelo\nlarg.... y lis...', 'usa,a,tiene', 'mesa,a,a', 'tiene,a,carro', 'tiene,o,usa', 'd', 'Mi hermana tiene el pelo largo y usa gafas'),
(5, 'Elige el verbo adecuado y completa los adjetivos,Mi papa ............... alt....,\r\nmoren...... y ........... gafas', 'es,a,a,a', 'el,es,a,a', 'es,o,usa', 'tiene,usa,e,el', 'c', 'Mi papa es alto moreno y usa gafas'),
(6, 'Elige el verbo adecuado y completa los adjetivos, Mi mama ......... moren... y\r\ntambién ........ gafas', 'el,e,es', 'es,a,usa', 'es, el ,un', 'el,es,una', 'b', 'Mi mama es morena y también usa gafas'),
(7, 'Elige el verbo adecuado y completa los adjetivos, Mi perro es....', 'pequeño', 'grande', 'roto', 'verde', 'a', 'Mi perro es pequeño '),
(8, 'Elige el verbo adecuado y completa los adjetivos, Mi muñeca es color R...', 'amarrillo', 'Rosa', 'azul', 'rojo', 'b', 'Mi muñeca es color Rosa'),
(9, 'Elige el verbo adecuado y completa los adjetivos, Mi pantalon es color Neg..', 'morado', 'rosa', 'Negro', 'verde', 'c', 'Mi pantalon es color Negro'),
(10, 'Cuando hace frio me pongo un', 'zapatos', 'pantalon ', 'falda', 'Sueter', 'd', 'Cuando hace frio me pongo un sueter'),
(11, 'Completa la frase. Cuando hace ____ me pongo un pantalón corto', 'frio', 'nieve', 'calor', 'sol', 'c', 'Cuando hace calor me pongo un pantalón corto'),
(12, 'Completa la frase. Cuando____ llevo un paraguas.', 'sueter', 'llueve', 'pantalon', 'mochila', 'b', 'Cuando llueve llevo un paraguas'),
(13, 'Completa la frase. En verano me pongo ____', 'una camisa', 'verde', 'feo', 'bonito', 'a', 'En verano me pongo una camisa'),
(14, 'Completa la frase. El árbol es de color___', 'amarillo', 'rojo', 'anaranjado', 'rosa', 'b', 'El árbol es de color verde'),
(15, 'Completa la frase. En_____llevo gorro de lana.', 'invierno', 'verano', 'otoño', 'primavera', 'a', 'En invierno llevo gorro de lana'),
(16, 'Completa la frase. Cuando hace _____me pongo unos pantalones de pana.', 'calor', 'frio', 'verano', 'invierno', 'b', 'Cuando hace frio me pongo pantalones de pana '),
(17, 'Completa la frase. Cuando hace frio me pongo una_______', 'gorro', 'falta', 'bufanda', 'pantalon', 'c', 'Cuando hace frio me pongo una bufanda'),
(18, 'Completa la frase. Los platos sirven para ....', 'frio', 'sueño ', 'tirar', 'comer', 'd', 'Los platos sirven para comer'),
(19, 'Completa la frase. Los vasos sirven para...', 'jugar', 'servir', 'tomar agua', 'comer', 'c', 'Los vasos sirven para tomar agua '),
(20, 'Completa la frase. Las cucharas sirven para...', 'tirar', 'comer', 'romper', 'jugar', 'b', 'Las cucharas sirven para comer'),
(21, 'Completa la frase. La mesa sirve para...', 'comer', 'dormir', 'romper', 'subir', 'a', 'La mesa sirve para comer'),
(22, 'Completa la frase. Las sillas sirven para...', 'tirar', 'sentarse ', 'comer', 'dormir', 'b', 'Las sillas sirven para sentarse'),
(23, '¿Cuáles son las vocales?', 'a,e,i,o,u', 'e,s,f,g,e', 'a,v,s,g,w', 'a,b,v,t,d', 'a', 'a,e,i,o,u'),
(24, 'Completa la frase. El carro tiene 4 ___', 'patas', 'llantas', 'focos', 'ojos', 'b', 'El carro tiene 4 llantas'),
(25, 'Completa la frase. El agua es color ___', 'azul', 'verde', 'amarillo', 'rojo', 'a', 'El agua es color azul'),
(26, 'Completa la frase. El cielo es  color____', 'morado', 'azul', 'rosa', 'negro', 'b', 'El cielo es color azul'),
(27, 'Completa la frase. El perro tiene 4_____', 'manos', 'piernas', 'patas', 'bocas', 'c', 'El perro tiene 4 patas '),
(28, 'Completa la frase. Animal que vive en el agua____', 'caballo', 'perro', 'gato', 'pez', 'd', 'Animal que vive en el agua, pez'),
(29, 'Completa la frase. El árbol es de color___', 'azul', 'morado', 'verde', 'verde', 'c', 'El árbol es de color verde'),
(30, 'Completa la frase. El auto es ver__', 'rosa', 'verde', 'rojo', 'negro ', 'b', 'El auto es verde ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntasesp2`
--

CREATE TABLE `preguntasesp2` (
  `id` int(11) NOT NULL,
  `preg` varchar(300) NOT NULL,
  `a` varchar(200) NOT NULL,
  `b` varchar(100) NOT NULL,
  `c` varchar(100) NOT NULL,
  `d` varchar(100) NOT NULL,
  `Correcta` varchar(100) NOT NULL,
  `Explicacion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntasesp2`
--

INSERT INTO `preguntasesp2` (`id`, `preg`, `a`, `b`, `c`, `d`, `Correcta`, `Explicacion`) VALUES
(1, 'CORRER,CAMINAR Y BRINCAR SON ', 'Adjetivos', 'Adverbios ', 'Verbos', '...', 'c', 'es un vervo por que es una accion'),
(2, 'DURO ,BLANDO Y  PEQUE?O SON ', 'Adjetivos', 'Adverbios ', 'Verbos', '...', 'a', 'es un vervo por que es una accion'),
(3, 'Mucho\' es un adverbio de...', 'tiempo', 'cantidad ', 'lugar', '...', 'b', 'es un cantidad ya que se menciona el mucho'),
(4, 'Ayer\' es un adverbio de...', 'tiempo', 'cantidad ', 'lugar', '...', 'a', 'es de tiempo por que habla de dias'),
(5, 'Tal vez\' es un adverbio de...', 'tiempo', 'duda', 'lugar', '...', 'b', 'por que no sabes si si puede pasar o no'),
(6, 'Es de quien se habla una oracion:', 'sujeto  ', 'predicado ', 'verbo ', '...', 'a', 'el sujeto es la persona de la que se habla'),
(7, 'Promueve un producto o ser servicio  con inmagenes y un eslogan ', 'Nota informativa', 'anuncio Publicitario', '...', '...', 'b', 'el anuncio publicitario de dedica a hacer propaganda'),
(8, 'Es la persona que realiza las preguntas para  Obtener  informacion  en una entrevista', 'Entrevistador', 'Entrevistado', '...', '...', 'a', 'es quien hace las preguntas'),
(9, 'Es la persona que da respuestas a las preguntas en una entrevista ', 'Entrevistador', 'Entrevistado', '...', '...', 'b', 'es quien responde las preguntas'),
(10, 'Casa-Pala\' es una rima:', 'Consonate ', 'Asonante', '...', '...', 'b', 'es asonante por que solo se parece la ultima a en sonido'),
(11, 'Anillo-martillo  es una rima :', 'Consonate ', 'Asonante', '...', '...', 'a', 'por que son vervos similares'),
(12, 'cual de las sigueintes frases corresponde a una noticia ', 'Capitulo 2.las aventuras de tomas', 'escena 1predro entra corriendo  y gritando ', 'continuan las bajas temperaturas en el pais', '...', 'c', 'te informa de algo novedoso '),
(13, 'Palabra que termine con mer', 'Mercedes', 'comer', 'Comen', '...', 'b', 'por que termina con mer'),
(14, 'elige la opcion en la que el nombre y la cosa  comiencen con la misma  letra ', 'Lauta -tele', 'Lorenzo-libreta', 'Lapiz Claudia', '...', 'b', 'por que las dos empiezan con l'),
(15, 'elige la opcion en la que el nombre y la cosa  terminen con la misma  letra ', 'Lauta -tele', 'Lorenzo-moto', 'Lapiz Claudia', '...', 'b', 'por que las dos terminan con O'),
(16, 'Cuando do?a manuela dice \' antes teniamos nuestra agua\' a que se refiere?', 'a que casi no habia agua', 'a que habia mucha agua ', 'a que era facil comprar  ', 'todas las anteriores ', 'b', 'es por que antes tenian agua'),
(17, 'parte del reportaje se escrio por que  se entrevisto a la gente que tipo de funete es esta', 'material impreso', 'testimonio oral', 'internet', 'fotografias', 'b', 'por que  se pregunto a las personas'),
(18, 'que nombren reciben las  notas que  se realizan  en una investigacion  con los datos de la obra', 'tarjeta de presentacion ', 'postal de investigacion', ' bloque de notas', ' fichas de trabajo ', 'd', 'es por que se muestra toda la informaacion '),
(19, 'elena  entrevista a un bombero y este responde  con si o no que clase de preguntas son ', 'abiertas', 'importantes', 'cerradas', 'aburridas', 'c', 'por que solo hay dos tipo de respuestas'),
(20, 'cuando en un cuento de misterio o de teror hablamos de planteamineto, nudo y desenlace a que nos referimos', 'climax', 'personajess', 'estructura', 'psicologia', 'c', 'es como se estructura el cuento'),
(21, 'palabra que viene del griego y se refiere al personaje principal de una obra literario de una pelicula', 'antagonista ', 'actriz de reparto', 'actor secundario', 'protagonista', 'd', 'es el personaje que mas sale'),
(22, 'es el personaje que esta en contra del personaje principal de una pelicula', 'antagonista ', 'actriz de reparto', 'actor secundario', 'protagonista', 'a', 'es e que menos sale'),
(23, 'es un modo de expresion que busca presentar personas,animales,objetos o lugares por medio de palabras clave', 'narracion', 'situacion', 'descripcion', 'escenario', 'd', 'es por que de esta manera son palabras claves '),
(24, 'como es el escenario de un cuento de terror  o de misterio ', 'alegre y divertido', 'oscuro y desolado ', 'luminiso y espontaneo ', 'silencioso y tranquilo', 'b', 'es asi por que es de terror y como uno lo persibe'),
(25, 'Un_____________ es un texto que explica  paso a paso  como realizar cierta actividad', 'reglamento', 'procedimiento ', 'instructivo', 'graficas', 'c', 'es donde tiene instrucciones de como hacer algo '),
(26, 'los instructivos tiene una estructura  titulo, materiales y procedimientos', 'verdadero', ' falso ', '...', '...', 'a', 'por que en ellos nos dice paso a paso como hacer cada cosa'),
(27, 'cuales verbos estan en infinitivo ', 'sale,gana,pasa', 'acomodandolo,corriendo', 'cae,deben,continuan', 'colocar,agregar,tirar', 'd', 'por que terminan con ar'),
(28, 'tiempo  verbal que se emplea  al narrar  un relato  historico ', 'preterito  y copreterito', 'preterito y futuro perfecto', 'infinitivo y  copreterito ', 'infinitivo y futuro perfecto ', 'a', 'por que muestra la continuidad en la accion en el pasado'),
(29, 'la playa estaba repla de gente como estaba la playa', 'vacia', 'repleta', 'decierta', '...', 'b', 'por que la oracion dice que estaba repleta de gente'),
(30, 'que hacia la gente?', 'estaba en ropa', 'estaba sentada', 'estaba bañandose', '...', 'c', 'por que la oracion dice que estaban ba?andose');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntasesp3`
--

CREATE TABLE `preguntasesp3` (
  `id` int(11) NOT NULL,
  `preg` varchar(300) NOT NULL,
  `a` varchar(200) NOT NULL,
  `b` varchar(100) NOT NULL,
  `c` varchar(100) NOT NULL,
  `d` varchar(100) NOT NULL,
  `Correcta` varchar(100) NOT NULL,
  `Explicacion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntasesp3`
--

INSERT INTO `preguntasesp3` (`id`, `preg`, `a`, `b`, `c`, `d`, `Correcta`, `Explicacion`) VALUES
(1, 'Cual de las siguientes no es una caracteristicas de la autobiografia?', 'La narracion es escrita por la persona que va a contar su historia ', 'Esta escrita en tercera persona ', 'Narracion cronologica', 'Tiempos verbales en preterito', 'b', 'Una autobiografía es el relato de tu propia vida (hechos del pasado), narrada por ti mismo/a. En la autobiografía tu eres el protagonista y el narrador.'),
(2, 'La autobiografia esta escrita por: ', 'Los padres de los ni?os ', 'Los mejores amigos ', 'Los maestros del grupo', 'La propia persona esta narrando su historia ', 'd', 'Una autobiografia relata la vida de la persona que la esta contando.'),
(3, 'Que se necesita tener claro antes de escribir una autobiografía?', 'Las caracteristicas del texto', 'La CURP', 'Los sucesos mas importantes de la propia vida', 'Las fotos que se seleccionaran para ilustrar el trabajo', 'c', 'La autobiografía relata los hechos mas importantes del narrador'),
(4, 'Que palabras se utilizan para indicar la sucesión en la narración?', 'Aqui, alla, en tanto', 'Introducion, cierre, antes', 'Mientras, despues, primero, finalmente', 'Por lo tanto, porque, por eso mismo', 'c', 'Se utilizan palabras clave con las que podamos tener un flujo de la historia, para tener un inicio y un fin.'),
(5, 'Cual de las siguientes oraciones expresa claramente causas y consecuencias', 'No sali a jugar con mis amigas ayer ni hoy tampoco', 'Yo cante muy bonito en el coro', 'Ma?ana tendre una cita muy importante ', 'El equipo de futbol gano porque entreno muy duro', 'd', 'Ejemplo: Reprobé el examen de hoy(Causa), porque ayer no estudie(Consecuencia).'),
(6, 'Que es el periódico?', 'Es un medio de comunicacion que contiene noticias ficticas', 'Es un medio de comunicacion que contiene fabulas', 'Es un medio de comunicacion que contiene chismes de los famosos', 'Es un medio de comunicacion que contiene noticias de sucesos importantes', 'd', 'Los periódicos relatan los eventos o hechos importantes recientemente.'),
(7, 'Que parte de la noticia resume la información y llama la atención debido a que el tipo de letra que se muestra es mas grande?', 'El cuerpo de la noticia', 'El pie de foto', 'El encabezado', 'El resumen de la noticia', 'c', 'Es lo primero que se muestra al publico y esta en letras grandes'),
(8, 'Que letra corresponde al nombre del periódico?', 'Grande', 'Mediana', 'Peque?a', 'Ninguna de las anteriores', 'a', 'Es la letra mas grande ya que es el nombre del periódico'),
(9, 'Que letra corresponde al titular de una noticia o encabezado?', 'Grande', 'Mediana', 'Pequeña', 'Ninguna de las anteriores', 'b', 'Siempre es mas chica que el nombre del periódico pero mas grande que el cuerpo de la noticia'),
(10, 'Que letra corresponde al cuerpo de la noticia?', 'Grande ', 'Mediana', 'Pequeña', 'Ninguna de las anteriores', 'c', 'Es la letra mas pequeña ya que va mucho texto para narrar el suceso del que se menciona.'),
(11, 'Que tipo de texto es \"El principito\"?', 'Una fabula', 'Una noticia', 'Un articulo de divulgacion cientifica', 'Un relato historico', 'a', 'Una fabula relata una historia ficticia, en ese caso \"El principito\" es una fabula'),
(12, 'Que tipo de texto es \"Atrapan a 2 ladrones de bancos\"', 'Una fabula', 'Una noticia', 'Un articulo de divulgacion cientifica', 'Un relato historico', 'b', 'Es una noticia ya que relata un suceso importante y que ocurrio actualmente'),
(13, 'Que tipo de texto es \"Descubierta por casualidad una nueva especie de dinosaurio en Sudáfrica\"', 'Una fabula', 'Una noticia', 'Un articulo de divulgacion cientifica', 'Un relato historico', 'c', 'Es un articulo de divulgacion cientifica ya que el titulo relata informacion de una descubrimiento'),
(14, 'Que tipo de texto es \"Historia de mexico\"', 'Una fabula', 'Una noticia', 'Un articulo de divulgacion cientifica', 'Un relato historico', 'd', 'Es un relato historico ya que el titulo hace mencion a la hisotira de mexico'),
(15, 'Elige la frase escrita en discurso directo.', 'Cierto día los ratones se reunieron\r\npara idear un plan', 'Esto tiene que terminar. ¿Alguien\r\ntiene algún plan?', 'Celebraron con aplausos el nuevo plan', 'Estaban hartos de vivir huyendo', 'b', 'El emisor cita el discurso de otro emisor, pero no de forma literal, sino que lo interpreta y lo explica en su discurso, pudiendo modificar algunas expresiones.'),
(16, 'En que material puedes encontrar informacion sobre como nacen las mariposas?', 'En un libro de cuentos', 'En un libro de poesia', 'En un libro informativo', 'En el periodico', 'c', 'En los libros informativos puedes encontrar la informacion del tema que quieras saber.'),
(17, 'Que podrías encontrar en un libro\r\nllamado El príncipe valiente?', 'Una receta de cocina', 'Un cuento', 'Una noticia', 'Un instructivo', 'b', 'Los cuentos siempre tienen titulos llamativos y generalmente son ficticios'),
(18, 'Cual de las características no es de una obra de teatro?', 'Dicen las noticias de la semana', 'El texto esta escrito para que los actores digan sus dialagos', 'Hay acotaciones', 'Contiene una historia para ser representada por actores', 'a', 'Las obras de teatro no contienen noticias de la semana.'),
(19, 'Que opcion se puede encontrar en tu acta de nacimiento?', 'Mi nombre', 'Mi escuela', 'El nombre de mis amigos', 'Mi dulce favorito', 'a', 'En las actas de nacimiento se encuentran datos como (tu nombre, nombre de tus padres, nombre de tus abuelos y lugar de nacimiento)'),
(20, 'Que dato debe incluirse en una anuncio publicitario?', 'Producto o servicio que ofrece', 'Lugar de nacimiento', 'Nivel de estudios', 'Noticia de la semana ', 'a', 'Los anuncios publicitarios hacen publicidad a de productos que están ofreciendo y brindad otros datos como nombre de la empresa y numero de teléfono'),
(21, 'Que animales necesita alimentarse de plantas?', 'Cocodrilo, tiburon, perro', 'Gato, mapache, lombriz', 'Cuyo, caballo, vaca', 'Serpiente, foca, pinguino', 'c', 'Los animales herbívoros son los que se alimentan de la vegetación así como Vacas, caballos, pajaron, cuyos, etc...'),
(22, 'Cual de las opciones es una actividad recreativa?', 'Limpiar tu casa', 'Tender tu cama', 'Darse una ducha', 'Jugar en el parque', 'd', 'Son actividades en las que uno puede divertirse.'),
(23, 'Que estación del año es en donde hace mucho frio, casi no\r\nflorecen plantas, en algunos\r\nlugares cae nieve?', 'Verano', 'Invierno', 'Primavera', 'Otoño', 'b', 'El invierno es la estación mas fría de todas y donde en algunos lugares del planeta cae nieve.'),
(24, 'Que estación del año es en donde hace menos calor, las hojas\r\nde algunos árboles se\r\namarillean y caen. Llueve\r\ncon menos frecuencia?', 'Verano', 'Invierno', 'Primavera', 'Otoño', 'd', 'En el otoño hace menos calor que en el verano pero las platanas se vuelven amarillas.'),
(25, 'Que estación del año es en donde hace más calor y llueve\r\nmucho; las plantas crecen\r\nmas rápido?', 'Verano', 'Invierno', 'Primavera', 'Otoño', 'a', 'En el verano hace mucho calor y hay poca probabilidad de que llueva'),
(26, 'Que estación del año es en donde empieza a aumentar la\r\ntemperatura, algunas\r\nplantas florecen?\r\n', 'Verano', 'Invierno', 'Primavera', 'Otoño', 'c', 'En la primavera es cuando las flores empiezan a creecer.'),
(27, 'Que animal es nocturno?', 'Jirafa', 'Mariposa', 'Murcielago', 'Abeja', 'c', 'Los murciélagos tienen excelente vista cuando esta oscuro.'),
(28, 'Completa la frase con palabras que rimen: Naranja dulce, limón _______ dame un abrazo que yo te ____', 'Avieon, algodon', 'Partido, pido', 'Correr, saltar', 'Comer, descansar', 'b', 'Para hacer que una frase rime, la terminación de cada renglón tiene que ser la misma o similar.'),
(29, '¿Cuál es la actividad principal que puedes llevar a cabo en una biblioteca?', 'Narrar hechos acontecidos durante la temporada de lluvias', 'Consultar libros o material de interes', 'Donar libros para enriqueer su acervo', 'Hacer las tareas y esperar al profesor', 'b', 'En la biblioteca encontraras muchos libros de interés y puedes leer el que mas te apetesca'),
(30, 'Como se reconoce el discurso directo?', 'Cuando se repite lo que dice un personaje.', 'Cuando se indica con guiones largos lo que dice un personaje.', 'Cuando se incluyen signos de interrogaci?n en las preguntas de los personajes.', 'Cuando se escribe en otra l?nea lo que dice un personaje.', 'b', 'El discurso directo es el estilo en el que el hablante reproduce literalmente las palabras de otro. ?');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntasing1`
--

CREATE TABLE `preguntasing1` (
  `id` int(11) NOT NULL,
  `preg` varchar(300) NOT NULL,
  `a` varchar(100) NOT NULL,
  `b` varchar(100) NOT NULL,
  `c` varchar(100) NOT NULL,
  `d` varchar(100) NOT NULL,
  `Correcta` varchar(100) NOT NULL,
  `Explicacion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntasing1`
--

INSERT INTO `preguntasing1` (`id`, `preg`, `a`, `b`, `c`, `d`, `Correcta`, `Explicacion`) VALUES
(1, 'Como se dice yo en ingles', 'I', 'YOU', 'WE', 'THEY', 'a', 'Por que es en primera persona'),
(2, 'Como se dice tu en ingles', 'THEY', 'YOU', 'I', 'WE', 'b', 'por que es en segunda persona'),
(3, 'Como se dice ella en ingles', 'SHE', 'HE', 'WE', 'THEY', 'a', 'por que estamos hablando de ella'),
(4, 'como se dice el en ingles', 'SHE', 'WE', 'HE', 'THEY', 'c', 'por que estamos hablando de ella'),
(5, 'Como se dice nosotros en ingles', 'WE', 'THEY', 'I', 'YOU', 'a', 'por que estamos hablando de nosotros'),
(6, 'Como se dice aquellos en ingles', 'THEY ', 'I', 'WE', 'YOU', 'a', 'por que estamos hablando de ellos'),
(7, 'Como se dice aquello en ingles', 'THEY', 'WE ', 'YOU', 'IT', 'd', 'por que estamos hablando de una cosa '),
(8, 'como se escribe zapato', 'chus', 'SHUS', 'SHOES', 'CHU', 'c', 'por que estamos diciendo sapato en ingles'),
(9, 'como se dice blanco en ingles', 'WHITE', 'RED', 'BLACK', 'YELLOW', 'a', 'blanco se dice white'),
(10, '¿Cómo se escribe rojo en ingles?', 'BLUE', 'PINK', 'GRAY', 'RED', 'd', 'rojo se dice red'),
(11, '¿Cómo se escribe rosa en ingles?', 'PINK', 'RED', 'BLUE', 'GREEN', 'a', 'rosa se dice pink'),
(12, '¿Cómo se escribe azul en ingles?', 'YELLOW', 'PINK', 'ORANGE', 'BLUE', 'd', 'azul se dice blue'),
(13, '¿Cómo se escribe verde en ingles?', 'GREEN', 'RED', 'PINK', 'BLUE', 'a', 'verde se dice green'),
(14, '¿Cómo se escribe amarillo en ingles?', 'PURPLE', 'YELLOW', 'ORANGE', 'RED', 'b', 'amarillo se dice yellow'),
(15, '¿Cómo se escribe café en ingles?', 'RED', 'ORANGE', 'BROWN', 'VIOLET', 'c', 'cafe se dice brown'),
(16, '¿Cómo se escribe anaranjado en ingles?', 'ORANGE', 'PINK', 'BLUE', 'WHITE', 'a', 'anaranjado se dice orange'),
(17, '¿Cómo se escribe uno en ingles?', 'TWO', 'SEVEN', 'ONE', 'ELEVEN', 'c', 'uno se dice one'),
(18, '¿Cómo se escribe dos en ingles?', 'SIX', 'FOUR', 'THREE', 'TWO', 'd', 'dos en ingles se dice  two'),
(19, '¿Cómo se escribe tres en ingles?', 'THREE', 'SIX', 'ONE', 'FOUR', 'a', 'tres en ingles se dice  three'),
(20, '¿Cómo se escribe cuatro en ingles?', 'FIFTY', 'SIXTY', 'FOUR', 'ONE', 'c', 'cuatro en ingles se dice  fourt'),
(21, '¿Cómo se escribe cinco en ingles?', 'FIVE', 'SEVEN', 'SIX', 'ONE', 'a', 'cinco en ingles se dice  five'),
(22, '¿Cómo se escribe seis en ingles?', 'ONE', 'SIX', 'TWO', 'ELEVEN', 'b', 'seis en ingles se dice  six'),
(23, '¿Cómo se escribe siete en ingles?', 'SIXTEEN', 'EIGHT', 'SEVEN', 'SIX', 'c', 'siete en ingles se dice  seven'),
(24, '¿Cómo se escribe ocho en ingles?', 'TEN', 'NINE', 'ELEVEN', 'EIGHT', 'd', 'ocho en ingles se dice  eight'),
(25, '¿Cómo se escribe nueve en ingles?', 'ONE', 'TWELVE', 'NINE', 'SEVEN', 'c', 'nueve en ingles se dice nine'),
(26, '¿Cómo se escribe diez en ingles?', 'ONE', 'TEN', 'TWO', 'NINETEEN', 'b', 'diez en ingles se dice  ten'),
(27, '¿Cómo se escribe perro en ingles?', 'DOG', 'CAT', 'HEN', 'DUCK', 'a', 'perro se dice dog'),
(28, '¿Cómo se escribe mesa en ingles?', 'CHAIR', 'TABLE', 'HOME', 'PIG', 'b', 'mesa se dice table'),
(29, '¿Cómo se escribe gato en ingles?', 'PIG', 'RABBIT', 'CAT', 'DOG', 'c', 'gato se dice cat'),
(30, '¿Cómo se escribe casa en ingles?', 'COMPUTER', 'PENCIEL', 'DICTIONARY', 'HOUSE', 'd', 'casa se escribe house'),
(31, '¿Cómo se escribe silla en ingles?', 'GLOBE', 'BOOK', 'CHAIR', 'CRAYONS', 'c', 'silla se escribe char');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntasing2`
--

CREATE TABLE `preguntasing2` (
  `id` int(11) NOT NULL,
  `preg` varchar(300) NOT NULL,
  `a` varchar(200) NOT NULL,
  `b` varchar(100) NOT NULL,
  `c` varchar(100) NOT NULL,
  `d` varchar(100) NOT NULL,
  `Correcta` varchar(100) NOT NULL,
  `Explicacion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntasing2`
--

INSERT INTO `preguntasing2` (`id`, `preg`, `a`, `b`, `c`, `d`, `Correcta`, `Explicacion`) VALUES
(1, 'como se dice raton en ingles', 'mouse', 'bed', 'house', 'floor', 'a', 'raton en ingles se dice mouse'),
(2, 'como se dice cama en ingles', 'mouse', 'bed', 'house', 'floor', 'b', 'cama en ingles se dice bed'),
(3, 'como se dice casa en ingles', 'mouse', 'bed', 'house', 'floor', 'c', 'casa en ingles se dice house'),
(4, 'como se dice  piso en ingles ', 'mouse', 'bed', 'today', 'floor', 'd', 'piso en ingles se dice floor'),
(5, 'como se dice hoy en ingles ', 'mouse', 'bed', 'today', 'floor', 'c', 'hoy en ingles se dice today'),
(6, 'como se dice caja en ingles', 'mouse', 'box', 'today', 'floor', 'b', 'caja en ingles se dice box'),
(7, 'como se dice uno en ingles ', 'one', 'three', 'four', 'floor', 'a', 'uno en ingles se dice one '),
(8, ' como se dice dos en ingles ', 'two', 'three', 'four', 'floor', 'a', 'dos en ingles se dice  two'),
(9, 'como se dice tres en ingles ', 'six', 'three', 'four', 'floor', 'b', 'tres en ingles se dice  three'),
(10, ' como se dice cuatro en ingles ', 'six', 'seven', 'four', 'five', 'c', 'cuatro en ingles se dice  fourt'),
(11, 'como se dice cinco en ingles ', 'six', 'seven', 'eight', 'five', 'd', 'cinco en ingles se dice  five'),
(12, ' como se dice seis en ingles ', 'six', 'seven', 'eight', 'five', 'a', 'seis en ingles se dice  six'),
(13, ' como se dice siete en ingles ', 'six', 'seven', 'eight', 'five', 'b', 'siete en ingles se dice  seven'),
(14, 'como se dice ocho en ingles ', 'six', 'seven', 'eight', 'five', 'c', 'ocho en ingles se dice  eight'),
(15, ' como se dice nueve en ingles ', 'six', 'seven', 'eight', 'nine', 'd', 'nueve en ingles se dice nine'),
(16, ' como se dice 10 en ingles ', 'six', 'seven', 'ten', 'one', 'c', 'diez en ingles se dice  ten'),
(17, 'como queda ordenada la palabra correctamente : ngki', 'king', 'gnki', 'kng', 'kign', 'a', 'rey en ingles se escribe king'),
(18, 'como queda ordenada la palabra correctamente :gtlhi', 'light', 'ligth', 'lihgt', 'gilht', 'a', 'luz en ingles se escribe light'),
(19, ' como queda ordenada la palabra correctamente :osume', 'osemu', 'mouse', 'muose', 'meuse', 'b', 'raton en ingles se dice mouse'),
(20, 'como queda ordenada la palabra correctamente :obx', 'obx', 'xob', 'bxo', 'box', 'd', 'caja en ingles se dice box'),
(21, 'como queda ordenada la palabra correctamente :etre', 'tree', 'eret', 'tere', 'rete', 'a', 'arbol en ingles se escribe tree'),
(22, 'como queda ordenada la palabra correctamente : oxf', 'xof', 'fox', 'xfo', 'oxf', 'b', 'zorro en ingles se dice fox'),
(23, 'que rima con con car', 'jar', 'eje', 'star', ' swing', 'c', 'por que temina con la misma las mismas dos letras'),
(24, 'que rima con ring', 'king', 'doll', ' swing', 'skete', 'a', 'por que temina con la misma las mismas dos letras'),
(25, 'que rima con gate', 'plate ', 'nail', 'skete', 'star', 'c', 'por que temina con la misma las mismas dos letras'),
(26, 'como se dice perro en ingles', 'finger', 'dog', 'hi/hello', 'foot', 'b', 'perro en ingles se dice dog'),
(27, 'como se dice hola en ingles', 'finger', 'dog', 'hi/hello', 'foot', 'c', 'hola en ingles se puede decir hi o hello'),
(28, 'como se dice pie en ingles', 'finger', 'dog', 'hi/hello', 'foot', 'd', 'pie en ingles se dice  foot'),
(29, 'como se dice mano en ingles', 'finger', 'dog', 'hi/hello', 'hand', 'd', 'mano en ingles se dice  se dice heand'),
(30, 'como se dice dedo en ingles', 'finger', 'dog', 'hi/hello', 'foot', 'a', 'dedo en ingles se dice  finger');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntasing3`
--

CREATE TABLE `preguntasing3` (
  `id` int(11) NOT NULL,
  `preg` varchar(300) NOT NULL,
  `a` varchar(200) NOT NULL,
  `b` varchar(100) NOT NULL,
  `c` varchar(100) NOT NULL,
  `d` varchar(100) NOT NULL,
  `Correcta` varchar(100) NOT NULL,
  `Explicacion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntasing3`
--

INSERT INTO `preguntasing3` (`id`, `preg`, `a`, `b`, `c`, `d`, `Correcta`, `Explicacion`) VALUES
(1, 'Como se dice \"como estas?\" en ingles', 'How are you?', 'My name is..', 'How old are you?', 'What is your favorite colour?', 'a', 'Para preguntar como esta una persona se dice, How are you?'),
(2, 'Como se dice en \"Estoy bien, gracias\" en ingles', 'Im 10 years old', 'My favorite sport is soccer', 'Im good, thanks', 'Thank you', 'c', 'Para decir que estas bien y agradecer, se dice, Im good thanks'),
(3, 'Como preguntar \"Cuando es tu cumpleaños\" en ingles', 'How are you?', 'When is your birthday?', 'My names is Juan', 'i have 2 dogs', 'b', 'Para preguntar cuando es el cumpleaños de alguien, se dice When is your birthday?'),
(4, 'Como preguntar \"Cual es tu numero de teléfono\" en ingles', 'Who is she?', 'Who is he?', 'What is your phone number?', 'What is your car?', 'c', 'Para preguntar por el numero telefónico de una persona se dice, What is your phone?'),
(5, 'Como preguntar \"de quien es esto\" en ingles ', 'Whose dog is it?', 'How old are you ', 'What is your phone number?', 'Whose is this?', 'd', 'Para preguntar de quien es esto se dice, Whose dog is it?'),
(6, 'Como se dice lunes en ingles', 'Monday', 'Sunday', 'Friday', 'Saturday', 'a', 'Lunes se dice Monday'),
(7, 'Como se dice Martes en ingles', 'Monday', 'Tuesday', 'Thursday', 'Friday', 'b', 'Martes se dice Tuesday'),
(8, 'Como se dice Miércoles en ingles', 'Wednesday', 'Monday', 'Tuesday', 'Saturday', 'a', 'Miércoles se dice Wednesday'),
(9, 'Como se dice Jueves en ingles', 'Wednesday', 'Saturday', 'Sunday', 'Thursday', 'd', 'Jueves se dice Thursday'),
(10, 'Como se dice Viernes en ingles', 'Thursday', 'Tuesday', 'Friday', 'Wednesday', 'c', 'Viernes se dice Friday'),
(11, 'Como se dice Sábado en ingles', 'Monday', 'Saturday', 'Sunday', 'Thursday', 'b', 'Sábado se dice Saturday'),
(12, 'Como se dice Domingo en ingles', 'Sunday', 'Monday', 'Tuesday', 'Friday', 'a', 'Domingo se dice Sunday'),
(13, 'Como se escribe enero en ingles', 'June', 'January', 'April', 'March', 'b', 'Enero se dice January'),
(14, 'Como se escribe febrero en ingles', 'January', 'February', 'June', 'April', 'b', 'Febrero se dice February'),
(15, 'Como se escribe marzo en ingles', 'March', 'September', 'February', 'December', 'a', 'Marzo se dice March'),
(16, 'Como se escribe abril en ingles', 'March', 'April', 'October', 'November', 'b', 'Abril se dice April'),
(17, 'Como se escribe mayo en ingles', 'October', 'June', 'September', 'May', 'd', 'Mayo se dice May'),
(18, 'Como se escribe junio en ingles', 'June', 'July', 'February', 'August', 'a', 'Junio se dice June'),
(19, 'Como se escribe julio en ingles', 'December', 'November', 'July', 'May', 'b', 'Julio se dice July'),
(20, 'Como se escribe agosto en ingles', 'May', 'October', 'September', 'August', 'd', 'Agosto se dice August'),
(21, 'Como se escribe septiembre en ingles', 'January', 'September', 'September', 'December', 'b', 'Septiembre se dice September'),
(22, 'Como se escribe octubre en ingles', 'January', 'October', 'July', 'May', 'b', 'Octubre se dice October'),
(23, 'Como se escribe noviembre en ingles', 'May', 'October', 'November', 'October', 'c', 'Noviembre se dice November'),
(24, 'Como se escribe diciembre en ingles', 'December', 'May', 'November', 'April', 'a', 'December se dice Diciembre'),
(25, 'Completa la frase, English ________ an important language.', 'very', 'is', 'two', 'are', 'b', 'Es=Is'),
(26, 'Completa la frase, ________ we crazy?\n', 'are', 'Monday', 'years', 'Whose is this?', 'a', 'Estan=Are'),
(27, 'Completa la frase, She ________ my best friend.', 'who', 'April', 'is', 'he', 'c', 'Es=Is'),
(28, 'Completa la frase, Where ________ you from?', 'is', 'are', 'April', 'Monday', 'b', 'Eres=Are'),
(29, 'Completa la frase,  ________ they your cousins?', 'one', 'Name', 'are', 'Today', 'c', 'Eres/son=Are'),
(30, 'Completa la frase, George ________ in England this summer.', 'Go to', 'Monday', 'April', 'old', 'a', 'Ira=Go to');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntasmate1`
--

CREATE TABLE `preguntasmate1` (
  `id` int(11) NOT NULL,
  `preg` varchar(300) NOT NULL,
  `a` varchar(200) NOT NULL,
  `b` varchar(200) NOT NULL,
  `c` varchar(200) NOT NULL,
  `d` varchar(200) NOT NULL,
  `correcta` varchar(200) NOT NULL,
  `explicacion` varchar(350) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntasmate1`
--

INSERT INTO `preguntasmate1` (`id`, `preg`, `a`, `b`, `c`, `d`, `correcta`, `explicacion`) VALUES
(1, '¿Cuál es la representación numérica de veinte?', '200', '2', '20', '2000', 'c', 'Un dos con un cero'),
(2, '¿Cuál es el número anterior a 10?', '8', '7', '6', '9', 'd', 'El numero anterior al 10 es 9, se aplica una resta 10-1'),
(3, 'Cálculo mental rápido: cuanto es 12 menos 7', '5', '2', '4', '7', 'a', 'El total de la resta es 5'),
(4, 'Cálculo mental rápido: cuanto es 14 menos 10', '8', '4', '2', '7', 'b', 'El total de la resta 4'),
(5, 'Cuántos minutos tiene una hora', '60', '40', '30', '20', 'a', 'Una hora tiene 60 minutos '),
(6, 'En la nevera de Andrés hay 15 helados. Esta semana se ha comido 7. ¿Cuántos helados le quedan?', '2', '10', '8', '9', 'c', '15 helados menos 7 queda un total de 8 helados'),
(7, 'En una piscina hay 16 niños y se salen 12. ¿Cuántos niños quedan en la piscina?', '4', '2', '7', '1', 'a', '16 niños menos 12 queda un total de 4 niños '),
(8, 'Si tengo 4 perros, 5 gatos y 12 gallinas, ¿Cuántos animales tengo en total?', '10', '15', '21', '13', 'c', '4 perros + 5 gatos + 12 gallinas da un total de 21 animales'),
(9, 'En el gimnasio de mi colegio hay 14 balones de fútbol y 15 de baloncesto. ¿Cuántos balones hay en total?', '20', '22', '21', '29', 'd', '14 balones de futbol + 15 balones de baloncesto dan un total de 29 balones'),
(10, 'Juan tiene 28 magdalenas. Tiene 12 amigos y le da una magdalena a cada uno, y otra para el. ¿Cuántas manzanas quedan?', '12', '28', '16', '14', 'c', '28 magdalenas menos 12 amigos que tiene queda un total de 16 magdalenas'),
(11, 'Si tengo 23 peras, yo me he comido 5 y mi amigo Luis se ha comido 7. ¿Cuántas quedan?', '11', '10', '9', '15', 'a', 'Tengo un total de 23 peras menos y que se comió mi amigo y menos 7 que me comí yo da un total restante de 11 peras'),
(12, 'En un aparcamiento hay 22 coches. Han llegado otros 12 más. ¿Cuántos coches hay ahora?', '10', '34', '12', '13', 'b', 'Tengo un total de 22 coches + 12 más que llegaron da un total de 34 coches'),
(13, 'Tengo una cesta con 17 manzanas. He ido a la frutería y he comprado 8 plátanos y 6 melocotones. ¿Cuánta fruta tengo?', '7', '15', '20', '31', 'd', 'Tengo un total de 17 manzanas mas 8 plátanos y 6 melocotones da un total de 31 frutas'),
(14, 'En mi jardín hay 7 rosas rojas, 24 margaritas y 8 claveles. Quiero hacer un ramo de flores. ¿Cuántas flores tengo para hacer el ramo?', '19', '18', '78', '39', 'd', 'Tengo un total de 7 rosas m?s 24 margaritas m?s 8 claveles da un total de 39 rosas'),
(15, 'Si en un edificio hay 50 ventanas, y 36 ventanas están abiertas. ¿Cuántas están cerradas?', '4', '14', '10', '8', 'b', 'Tenemos un total de 50 ventanas menos 36 ventanas abiertas dan un total de 14 ventanas cerradas'),
(16, 'En una frutería hay 42 naranjas. Solo quedan 12. ¿Cuántas se han vendido ya?', '30', '29', '45', '23', 'a', 'Tenemos un total de 42 naranjas menos 12 da un total de 30 naranjas vendidas'),
(17, 'Si en un aparcamiento hay 45 coches rojos, 63 coches blancos y 7 azules. ¿Cuántos coches hay en el aparcamiento?', '90', '70', '115', '159', 'c', 'Tenemos 45 + 63 + 7 da un total de 115 coches'),
(18, 'En un bosque había 32 pájaros. Ahora hay 45. ¿Cuántos pájaros han nacido?', '10', '77', '80', '90', 'b', 'Tenemos 32 + 45 da un total de 77 pájaros'),
(19, 'He invitado a 36 amigos a mi fiesta de cumpleaños. Ya han llegado 21. ¿Cuántos faltan por llegar?', '1', '5', '10', '15', 'd', 'Tenemos 36 -21 da un total de 15 invitados faltantes'),
(20, 'Sandra tiene 27 Pesos. Ha comprado unos lápices y se ha gastado 5 Pesos. ¿Cuánto dinero le queda?', '22', '59', '14', '19', 'a', 'Tenemos 27 -5 da un total de 22 pesos'),
(21, 'Pablo ha comprado una camiseta que le ha costado 65, y una sudadera que le ha costado 45, ¿Cuánto dinero se ha gastado?', '120', '110', '130', '140', 'b', 'Tenemos 65 + 45 da un total de 110 pesos'),
(22, 'Marta y su prima han ido a una helader?a. Si un helado cuesta 12 pesos y se han comido uno cada una, ¿Cuánto les ha costado?', '24', '12', '6', '4', 'a', 'Tenemos 12 pesos por helado y si son 2 da un total de 24 pesos'),
(23, 'Si un caramelo cuesta 5 céntimos, y una piruleta cuesta 7. He comprado 6 caramelos y 3 piruletas. ¿Cuánto dinero me ha costado?', '51', '52', '53', '54', 'a', 'Tenemos 5 centésimos por 6 caramelos da un total de 30 centésimos, 7 centésimos por 3 piruletas dan un total de 21 centésimos, sumamos los totales y nos da 51 centésimos'),
(24, 'Un trozo de tarta cuesta 5. Si la tarta entera tiene 8 trozos, ¿Cuánto cuesta la tarta?', '5', '15', '25', '40', 'd', 'Tenemos 5 x 8 da un total de 40 pesos'),
(25, 'Una hamburguesa cuesta 35, y un refresco cuesta 15 ¿Cuánto me he gastado en total?', '12', '83', '50', '12', 'c', 'Tenemos 35 + 15 da un total de 50 pesos'),
(26, 'Mario tiene 50 en su bolsa. Se ha comprado un robot de juguete que cuesta 35 ¿Cuánto dinero le queda?', '15', '16', '17', '18', 'a', 'Tenemos 50 - 35 da un total de 15 pesos'),
(27, 'Pedro tiene 5 pelotas. Si pierde 2 ¿Cuantas le quedan?', '1', '2', '3', '4', 'C', 'Tenemos 5 - 2 quedan 3 pelotas'),
(28, 'Tania tiene 2 muñecas, su mama le compra 2 ¿Cuántas muñecas tiene?', '4', '3', '2', '1', 'a', 'Tenemos 2 + 2 da un total de 4 muñecas'),
(29, 'Mayra compro 2 manzanas y 3 peras ¿Cuántas frutas hay en total?', '5', '7', '9', '10', 'a', 'Tenemos 2 + 3 da un total de 5 frutas'),
(30, 'Un helado cuesta 5 .Si compro dos ¿Cuánto es? ', '10', '15', '20', '30', 'a', '5 + 5 =10');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntasmate2`
--

CREATE TABLE `preguntasmate2` (
  `id` int(11) NOT NULL,
  `preg` varchar(300) NOT NULL,
  `a` varchar(200) NOT NULL,
  `b` varchar(100) NOT NULL,
  `c` varchar(100) NOT NULL,
  `d` varchar(100) NOT NULL,
  `Correcta` varchar(100) NOT NULL,
  `Explicacion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntasmate2`
--

INSERT INTO `preguntasmate2` (`id`, `preg`, `a`, `b`, `c`, `d`, `Correcta`, `Explicacion`) VALUES
(1, 'En un tren viajaban 46 personas. Si subieron 47 personas más, ¿Cuántas viajan ahora?', '2', '3', '44', '93', 'd', '46 + 47 = 93'),
(2, 'Compré unas botas de fútbol que costaban 74 euros y unos calcetines. Si me gasté 85 euros, ¿Cuánto dinero costaron los calcetines?', '10', '20', '11', '12', 'c', '85 - 74 = 11'),
(3, 'Candela quiere comprar un videojuego que cuesta 95 euros y una muñeca que cuesta 37 euros, ¿Cuánto dinero tendrá que pagar?', '70', '132', '100', '98', 'b', '95 + 37 =132'),
(4, 'Mi padre compró un ventilador que costaba 135 euros y una lavadora cuyo precio era 428?. ¿Cuánto dinero pagó?', '563', '400', '800', '759', 'a', '135 + 428 =563'),
(5, 'Entre mi abuelo y mi tío tienen 100 años, si mi abuelo tiene 78 años, ¿Cuántos años tiene mi tío?', '10', '15', '22', '30', 'c', '100 - 78 =22'),
(6, 'Tengo 7 años y mi hermano tiene 1 año más.', '8', '4', '5', '7', 'a', '7 + 1 =8'),
(7, 'Rosario pesa 18 kilogramos y su prima pesa 2 kilogramos menos', '8', '15', '10', '16', 'd', '18 - 2 = 16'),
(8, 'Quiero comprarme un ordenador que cuesta 573 euros, pero no tengo suficiente dinero. Me lo podría comprar si costara 89 euros menos ¿Cuánto dinero tengo?', '500', '4890', '484', '500', 'b', '573 - 89=484'),
(9, 'Un televisor cuesta 354 euros, ¿Cuánto cuestan 2 televisores iguales?', '800', '708', '209', '505', 'b', '354 x 2=708'),
(10, 'Para mi fiesta de cumpleaños compré 2 bolsas de caramelos. Si cada bolsa contiene 243 caramelos, ¿Cuántos habrá en las dos bolsas?', '700', '809', '201', '486', 'd', '243 x 2= 486'),
(11, 'En una caja hay 344 clips, Cuántos habrá en 2 cajas iguales?', '688', '198', '255', '700', 'a', '344 x 2=688'),
(12, 'Tengo ahorrados 382 euros y mi hermano ha ahorrado el doble que yo ¿Cuánto dinero ha ahorrado mi hermano?', '189', '764', '900', '500', 'b', '382 x 2=764'),
(13, 'Mi padre tiene dos caballos. Cada uno come 2 kilogramos de paja al día ¿Cuántos kilogramos comerán los dos caballos a lo largo de 243 días?', '187', '900', '972', '800', 'c', '243 x 2 x 2 = 972'),
(14, 'Me compré una bicicleta que costaba 487 euros. Después de comprarla me quedaban aún 125 euros ¿Cuánto dinero tenía antes de comprarla?', '362', '154', '495', '888', 'a', '487 - 125 = 362'),
(15, 'Mi abuelo me ha regalado 55 euros por mi cumpleaños . He metido ese dinero en la hucha y ya tengo 314 euros ahorrados, ¿Cuánto dinero tenía antes?', '234', '598', '487', '259', 'd', '314 - 55= 259'),
(16, 'Un agricultor carga 289 kilogramos de patatas en el remolque de su tractor. Si el remolque cargado con las patatas pesa 761 kilogramos, ¿cuánto pesaba antes de cargarlo?', '198', '472', '147', '987', 'b', '761 - 289 =472'),
(17, 'En una granja hay 57 ovejas y 43 vacas, ¿Cuántas ovejas más que vacas hay en la granja?', '10', '14', '12', '13', 'b', '57 - 43 =14'),
(18, 'Un televisor cuesta 450 euros y una lavadora 397 euros, ¿Cuánto cuesta el televisor más que la lavadora?', '15', '87', '61', '53', 'd', '450 - 397 =53'),
(19, 'En una tienda de ropa se vendieron, en un mes, 456 camisetas y 285 pantalones, ¿Cuántas camisetas más que pantalones se vendieron?', '647', '134', '171', '984', 'c', '456 - 285 = 171'),
(20, 'Leonor fue capaz de dar 213 botes seguidos con la pelota de baloncesto, Carmen dio 359 botes ¿Cuántos botes más que Leonor fue capaz de dar Carmen?', '159', '122', '146', '147', 'c', '359 - 213 =146'),
(21, 'En la primera planta de un hospital hay 265 enfermos y en la segunda planta, 314 ¿Cuántos enfermos tienen que abandonar la segunda planta para que en esta haya los mismos que en la primera?', '49', '46', '47', '48', 'a', '314 -265 =49'),
(22, 'Un viaje a Disney cuesta 675 euros y otro a Port Aventura 590, ¿Cuánto tienen que abaratar el precio del viaje a Disney para que cueste lo mismo que el de Port Aventura?', '90', '85', '48', '15', 'b', '675 - 590 =85'),
(23, 'Mi padre gana 423 euros a la semana y mi tío 450, ¿Cuántos euros le tienen que subir a mi padre el sueldo, a la semana, para que gane lo mismo que mi tío?', '30', '29', '20', '27', 'd', '450 - 423 =27'),
(24, 'Mi abuela tiene una granja donde cría gallinas. Un día nos pusimos a contar huevos y a meterlos en cestas. Mi abuela metió en su cesta 423 huevos. Yo metí en la mía 286, ¿Cuántos huevos más tuve que meter en mi cesta para que hubiese los mismos huevos que en la de mi abuela?', '187', '159', '137', '200', 'c', '423 -286 =137'),
(25, 'En mi barriada han montado un circo. El sábado asistieron 358 personas y ,hoy domingo, han entrado hasta ahora 286, ¿Cuántas más tienen que entrar para que asistan las mismas personas que el sábado?', '77', '12', '75', '72', 'd', '358 - 286 = 72'),
(26, 'En el huerto del abuelo de José Ramon hay un limonero y un naranjo. El limonero tiene 487 limones y el naranjo 628 naranjas, ¿Cuántos limones tienen que coger para que los dos árboles queden con el mismo número de frutos?', '141', '139', '495', '128', 'a', '487 - 628 =141'),
(27, 'Rosario ha dado 257 saltos con la comba. Adán lleva dados 168 y sigue saltando, ¿Cuántos saltos más tiene que dar para que empate con Rosario con el mismo número de saltos?', '89', '48', '99', '78', 'a', '257 - 168 =89'),
(28, 'Mi tío compró una bicicleta a cada uno de mis primos. Si cada bicicleta costó 125 euros y tengo 3 primos, ¿Cuánto dinero se gastó mi tío?', '159', '297', '498', '375', 'd', '125 x 3= 375'),
(29, 'En una caja hay 251 alfileres, ¿Cuántos habrá en 4 cajas iguales?', '1005', '200', '1004', '500', 'c', '251 x 4 =1004'),
(30, 'El padre de mi vecino es pastor de cabras. Su rebaño tiene 96 animales, si cada una come 7 kilos de pienso cada semana, ¿Cuántos kilos comerán las 96 cabras en una semana?', '64512', '23789', '16794', '5555', 'a', '96 x 7 x 96 = 64512');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntasmate3`
--

CREATE TABLE `preguntasmate3` (
  `id` int(11) NOT NULL,
  `preg` varchar(300) NOT NULL,
  `a` varchar(200) NOT NULL,
  `b` varchar(100) NOT NULL,
  `c` varchar(100) NOT NULL,
  `d` varchar(100) NOT NULL,
  `Correcta` varchar(100) NOT NULL,
  `Explicacion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntasmate3`
--

INSERT INTO `preguntasmate3` (`id`, `preg`, `a`, `b`, `c`, `d`, `Correcta`, `Explicacion`) VALUES
(1, 'En una fabrica se empacaron clavos en presentaciones de (1500, 200, 55, 6)', '6121', '2165', '1761', '1526', 'C', '1500+200+55+6=1761'),
(2, 'En una ferreter?a se venden argollas en bolsas de 20, 50 y 100 piezas. Si Rogelio compr? un millar de argollas, ?cu?ntas bolsas de cada presentaci?n le dieron?', 'Seis bolsas de 100 piezas, tres bolsas de 50 piezas y una bolsa de 20 piezas.', 'Cuatro bolsas de 100 piezas, una bolsa de 50 piezas y una bolsa de 20 piezas.', 'Siete bolsas de 100 piezas, cuatro bolsas de 50 piezas y cinco bolsas de 20 piezas.', 'Cinco bolsas de 100 piezas, cinco bolsas de 50 piezas y cinco bolsas de 20 piezas.', 'C', 'Se multiplican las bolcas por el numero de piezas, y el total tiene que dar el millar (1000 unidades)'),
(3, 'Que opcion completra la operacion 579-__=529', '100', '50', '29', '5', 'B', '579-50=529'),
(4, '?Qu? procedimiento facilitar?a la resta 578 ? 276 = 302?', 'Redondear 276 y sumar la cantidad redondeada a 302', 'Descomponer 276 en centenas, decenas y unidades, y restarlas.', 'Complementar 276 hasta llegar a 578.', 'Efectuar la operaci?n n?mero por n?mero.', 'B', 'Descompnemos la operacion en centenas, decenas y unidades y restamos.'),
(5, 'En una peleter?a usan charolas de dos tama?os para hacer hielo (3x6 y 2x7), Si se necesitan 210 hielos, ?con qu? operaciones se obtiene esta cantidad?', '3 ? 18 y 8 ? 12', '5 ? 18 y 10 ? 12', '4 ? 18 y 8 ? 12', '10 ? 18 y 10 ?12', 'B', '5x18= 90, 10x12=120, 90+120=210'),
(6, '?Qu? multiplicaci?n resuelve la suma (700 + 700 + 700 + 700 + 700 + 700)?', '6 ? 7 y se agregan dos ceros', '6 ? 7 y se agregan siete ceros.', '6 ? 7 y se agregan doce ceros.', '6 ? 7 y se agregan seis ceros.', 'A', '6x7=42, se le agregan 2 ceros, 4200'),
(7, 'En una sala de cine hay 12 filas de 10 butacas cada una. ?Cu?ntas butacas hay en total?', '100', '22', '120', '10', 'C', '12x10=120'),
(8, '?Cu?l es el resultado de multiplicar 9 ? 200?', '1 900', '1 800', '190', '180', 'B', '9x200=1800'),
(9, '?Cu?l es el resultado de multiplicar 5 ? 100?', '500', '1500', '450', '750', 'A', '5x100=500'),
(10, 'Un autob?s sali? de la Ciudad de M?xico a las 5:00 a. m. rumbo a Zacatecas y lleg? a las 11:20 a. m. ?Cu?nto tiempo dur? el viaje?', '18 horas y 30 minutos.', '16 horas y 20 minutos.', '8 horas y 30 minutos.', '6 horas y 20 minutos.', 'D', 'Ir sumando horas hasta llegar a la hora de llegada y porm ultimo sumas los minutos que faltan.'),
(11, 'Un avion sali? de tijuana a las 12:00 a. m. rumbo a Ciudad de Mexico y lleg? a las 2 a. m. ?Cu?nto tiempo dur? el viaje?', '5 horas', '2 horas', '2 horas y 30 minutos', '40 minutos', 'B', 'Ir sumando horas hasta llegar a la hora de llegada'),
(12, 'Armando tiene cuatro tarjetas en las que aparecen los n?meros 2, 4, 7, 9. ?Cu?l es el n?mero menor y el mayor que pueden formarse?', '2749 y 9472', '2479 y 9742', '9749 y 2749', '2942 y 9247', 'B', 'Poner los numeros menores al principio para formar una cifra menor y para una cifra mayor poner los numeros mas altos al inicio'),
(13, '. ?Cu?l es la descomposici?n aditiva de ocho mil ciento setenta y tres?', '80 + 1 000 + 700 + 3', '8 000 + 100 + 70 + 3', '800 + 1 000 + 70 + 3', '8 000 + 10 + 70 + 3', 'B', 'Ocho mil (8000) + Ciento (100) + Setenta (70) + y tres (3)'),
(14, '?Cu?l es la descomposici?n aditiva en unidades y millares de doce mil veinticinco?', '1 200 + 25', '120 + 25', '12 000 + 125', '12 000 + 25', 'D', 'Millar (12000) + unidad (25)'),
(15, 'En una cafeter?a venden un paquete con una dona y un chocolate por $25. ?Cu?l es el costo de 10 paquetes?', '$2 500', '$25', '$25 000', '$250', 'D', '25x10= 250'),
(16, 'Heriberto tiene 15 cajas con seis caramelos cada una y Sonia, 13 cajas con nueve\ncaramelos cada una. ?Con qu? operaciones se sabe de manera r?pida qui?n de los\ndos tiene m?s caramelos?', '15 ? 6 y 13 ? 9', '15 + 6 y 13 + 9', '15 ? 13 y 9 ? 7', '15 ? 13 y 9 ? 7', 'B', 'Heriberto(15 cajas x 6 caramelos) y Sonia(13 cajas x 9 caramelos)'),
(17, 'Si hay 7 cajas con 4 melones adentro, cuantos melones hay en total?', '28', '50', '55', '10', 'A', '7x4=28'),
(18, 'Si hay 5 charolas 10 galletas, cuantas gallateas hay en total?', '45', '20', '47', '50', 'D', '5x10=50'),
(19, 'Si hay 10 racimos de 3 platanos, cuantos platanos hay en total?', '15', '12', '30', '27', 'C', '10x3=30'),
(20, 'En un mercado venden naranja a $6 por pieza, sandia $7 por pieza y pi?a $12 por pieza, Si Jos? compr? 2 naranjas 1 sandias\ny 2 pi?as, cuanto pago en total?', '43', '30', '8', '36', '43', '2 naranajas x 6 = 12, 1 sandia x 7= 7, 2 pi?as x 14 = 22, 12+7+24=43'),
(21, '?Cu?nto le falta a 25 para 100?', '5', '75', '60', '54', 'B', '100-25=75'),
(22, '?Cu?nto es 1000 menos 400?', '600', '500', '480', '260', 'A', '1000-400=600'),
(23, '?Cu?nto le falta a 800 para 1000?', '450', '370', '200', '100', 'C', '1000-800=200'),
(24, '?Cu?nto es 100 menos 50?', '45', '40', '50', '60', 'C', '100-50=50'),
(25, 'Cual es la cifra mas grande con los numeros (0,9,6,7)?', '9760', '6907', '7096', '9076', 'A', 'Los numeros mayores se colocan al principio de la cifra para formar un numero grande.'),
(26, 'Cual es la cifra mas peque?a con los numeros (3,1,0,2)', '3102', '123', '2130', '3210', 'B', 'Los numeros menores se colocan al incio para fomar una cifra peque?a.'),
(27, 'Si voy a la escuela a las 8:am y regreso a mi casa 12:00pm, cuanto tiempom estoy en la escuela?', '5 horas', '12 horas ', '3 horas', '4 horas', 'D', 'Ir sumando horas hasta llegar a la hora deseada 8 + 1 + 1 + 1 +1= 12, se sumaron 4 horas, entonces 4 horas son las que estamos en la escuela'),
(28, 'Cuantos vertices tiene un triangulo?', '3', '4', '5', '6', 'A', 'El triangulo tiene 3 angulos en consecuencia tiene 3 vertices.'),
(29, 'Tres amigas fueron por tortillas cada una compro lo siguiente (Blanca 1/2 kilo. Emilia 1/4 de kilo y Pilar 2/4 de kilo), quienes compraron lo mismo?', 'Blanca y Emilia', 'Blanca y Pilar', 'Pilar y Emilia', 'Ninguna', 'B', 'Blanca compro 1/2 y pilar 2/4 lo que equivale a 1/2, entonces blanca y pilar compraron lo mismo.'),
(30, 'En el cumplea?os de Sofia le dieron a Maria 1/4 de pastel, a juagn 1/8 y a Daniel 2/4 de pastel. A quien le dieron mas pastel?', 'Maria', 'Juan', 'Daniel', 'Le dieron lo mismo', 'C', '2/4 es mayor que 1/8 y 1/4.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `correo` varchar(45) NOT NULL,
  `contra` varchar(25) NOT NULL,
  `admin` tinyint(1) NOT NULL,
  `nombreusu` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `nombre`, `correo`, `contra`, `admin`, `nombreusu`) VALUES
(1, 'Administrador', 'admin@gmail.com', '321', 1, 'ADMIN'),
(2, 'Alberto Medina', 'alberto@gmail.com', '123', 0, 'Alberto_0'),
(3, 'Javier Paramo', 'javierpara10@gmail.com', '664', 0, 'Javier_10'),
(4, 'Oscar Hernandez', 'oscar663@gmail.com', '663', 0, 'Oscar_663'),
(5, 'Karen Valdez', 'karfenva20@gmail.com', '664', 0, 'Karen_2'),
(6, 'Enrique Leon', 'enrique32@gmail.com', '663', 0, 'Enrique_09'),
(7, 'Sara', 'asd', '321', 0, 'Sara_08');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `historial`
--
ALTER TABLE `historial`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `preguntasesp1`
--
ALTER TABLE `preguntasesp1`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `preguntasesp2`
--
ALTER TABLE `preguntasesp2`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `preguntasesp3`
--
ALTER TABLE `preguntasesp3`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `preguntasing1`
--
ALTER TABLE `preguntasing1`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `preguntasing2`
--
ALTER TABLE `preguntasing2`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `preguntasing3`
--
ALTER TABLE `preguntasing3`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `preguntasmate1`
--
ALTER TABLE `preguntasmate1`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `preguntasmate2`
--
ALTER TABLE `preguntasmate2`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `preguntasmate3`
--
ALTER TABLE `preguntasmate3`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `historial`
--
ALTER TABLE `historial`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT de la tabla `preguntasesp1`
--
ALTER TABLE `preguntasesp1`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `preguntasesp2`
--
ALTER TABLE `preguntasesp2`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `preguntasesp3`
--
ALTER TABLE `preguntasesp3`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `preguntasing1`
--
ALTER TABLE `preguntasing1`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT de la tabla `preguntasing2`
--
ALTER TABLE `preguntasing2`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `preguntasing3`
--
ALTER TABLE `preguntasing3`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `preguntasmate1`
--
ALTER TABLE `preguntasmate1`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `preguntasmate2`
--
ALTER TABLE `preguntasmate2`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;

--
-- AUTO_INCREMENT de la tabla `preguntasmate3`
--
ALTER TABLE `preguntasmate3`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
