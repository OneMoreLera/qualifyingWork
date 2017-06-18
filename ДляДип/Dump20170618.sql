-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: mysqldip
-- ------------------------------------------------------
-- Server version	5.7.18-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `answer`
--

DROP TABLE IF EXISTS `answer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `answer` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `answer` text,
  `true_variant` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `answer`
--

LOCK TABLES `answer` WRITE;
/*!40000 ALTER TABLE `answer` DISABLE KEYS */;
INSERT INTO `answer` VALUES (16,'Целостность',1),(17,'Аутентификация',0),(18,'Конфиденциальность',1),(19,'Доступность',1),(20,'Инкапсуляция',0),(21,'реализацию права на доступ к информации»',1),(22,'соблюдение норм международного права в сфере информационной безопасности',0),(23,'обеспечение защиты информации от неправомерного доступа, уничтожения, модифицирования, блокирования, копирования, предоставления, распространения, а также от иных неправомерных действий в отношении такой информации',1),(24,'соблюдение конфиденциальности информации ограниченного доступа',1),(25,'выявление нарушителей и привлечение их к ответственности',0),(26,'разработку методов и усовершенствование средств информационной безопасности',0),(27,'непреднамеренная утрата носителя информации',0),(28,'несанкционированный процесс переноса информации от источника к злоумышленнику',1),(29,'процесс уничтожения информации',0),(30,'процесс раскрытия секретной информации',0),(31,'внедрения агрессивного программного кода в рамках активных объектов Web-страниц',0),(32,'вмешательства в личную жизнь',0),(33,'несанкционированного управления удаленным компьютером',1),(34,'перехвата или подмены данных на путях транспортировки',0),(35,'поставки неприемлемого содержания',0),(36,'активная',0),(37,'пассивная',1);
/*!40000 ALTER TABLE `answer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aquser`
--

DROP TABLE IF EXISTS `aquser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aquser` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ID_group` bigint(20) DEFAULT NULL,
  `ID_info` bigint(20) DEFAULT NULL,
  `passwd` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_USER_USER_GROU_GROUP` (`ID_group`),
  KEY `FK_USER_USER_USER_USER_INF` (`ID_info`),
  CONSTRAINT `FK_USER_USER_GROU_GROUP` FOREIGN KEY (`ID_group`) REFERENCES `usergroup` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_USER_USER_USER_USER_INF` FOREIGN KEY (`ID_info`) REFERENCES `user_info` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aquser`
--

LOCK TABLES `aquser` WRITE;
/*!40000 ALTER TABLE `aquser` DISABLE KEYS */;
INSERT INTO `aquser` VALUES (1,1,1,'b59c67bf196a4758191e42f76670ceba'),(2,2,2,'d41d8cd98f00b204e9800998ecf8427e'),(3,0,4,'d41d8cd98f00b204e9800998ecf8427e');
/*!40000 ALTER TABLE `aquser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `fullusersinfo`
--

DROP TABLE IF EXISTS `fullusersinfo`;
/*!50001 DROP VIEW IF EXISTS `fullusersinfo`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `fullusersinfo` AS SELECT 
 1 AS `ID`,
 1 AS `Фамилия`,
 1 AS `Имя`,
 1 AS `Отчество`,
 1 AS `Группа`,
 1 AS `Роль`,
 1 AS `Чтение`,
 1 AS `Запись`,
 1 AS `Полный доступ`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `group_info`
--

DROP TABLE IF EXISTS `group_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `group_info` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` char(25) DEFAULT NULL,
  `Description` text,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `group_info`
--

LOCK TABLES `group_info` WRITE;
/*!40000 ALTER TABLE `group_info` DISABLE KEYS */;
INSERT INTO `group_info` VALUES (0,'Администраторы','Группа администраторов системы'),(1,'Преподаватели','Группа преподавателей'),(2,'ПКС-41(ЩПКО-01-13)','Программирование в компьютерных системах');
/*!40000 ALTER TABLE `group_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `groupinfoview`
--

DROP TABLE IF EXISTS `groupinfoview`;
/*!50001 DROP VIEW IF EXISTS `groupinfoview`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `groupinfoview` AS SELECT 
 1 AS `ID`,
 1 AS `Название(код)`,
 1 AS `Описание`,
 1 AS `Роль`,
 1 AS `Чтение`,
 1 AS `Запись`,
 1 AS `Полный доступ`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `loginusers`
--

DROP TABLE IF EXISTS `loginusers`;
/*!50001 DROP VIEW IF EXISTS `loginusers`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `loginusers` AS SELECT 
 1 AS `ID`,
 1 AS `Surname`,
 1 AS `Name`,
 1 AS `Patronym`,
 1 AS `passwd`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `qs_ar`
--

DROP TABLE IF EXISTS `qs_ar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `qs_ar` (
  `ID_Q` bigint(20) NOT NULL,
  `ID_A` bigint(20) NOT NULL,
  PRIMARY KEY (`ID_Q`,`ID_A`),
  KEY `FK_QS_AR_REF_A_ANSWER` (`ID_A`),
  CONSTRAINT `FK_QS_AR_REF_AR_QUESTION` FOREIGN KEY (`ID_Q`) REFERENCES `questions` (`ID`),
  CONSTRAINT `FK_QS_AR_REF_A_ANSWER` FOREIGN KEY (`ID_A`) REFERENCES `answer` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `qs_ar`
--

LOCK TABLES `qs_ar` WRITE;
/*!40000 ALTER TABLE `qs_ar` DISABLE KEYS */;
INSERT INTO `qs_ar` VALUES (6,16),(6,17),(6,18),(6,19),(6,20),(7,21),(7,22),(7,23),(7,24),(7,25),(7,26),(8,27),(8,28),(8,29),(8,30),(9,31),(9,32),(9,33),(9,34),(9,35),(10,36),(10,37);
/*!40000 ALTER TABLE `qs_ar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `questions`
--

DROP TABLE IF EXISTS `questions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `questions` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ID_subject` bigint(20) DEFAULT NULL,
  `Question` text,
  PRIMARY KEY (`ID`),
  KEY `FK_QUEST_QUEST_QUEST_SUBJECT_idx` (`ID_subject`),
  CONSTRAINT `FK_QUEST_QUEST_QUEST_SUBJECT` FOREIGN KEY (`ID_subject`) REFERENCES `subject` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `questions`
--

LOCK TABLES `questions` WRITE;
/*!40000 ALTER TABLE `questions` DISABLE KEYS */;
INSERT INTO `questions` VALUES (6,4,'Отметьте три составляющие информационной безопастности'),(7,4,'В соответствии с нормами российского законодательства защита информации представляет собой принятие правовых, организационных и технических мер, направленных на …'),(8,4,'Утечка информации – это …'),(9,4,'Под угрозой удаленного администрирования в компьютерной сети понимается угроза …'),(10,4,'Вид угрозы действия, направленного на несанкционированное использование информационных ресурсов, не оказывающего при этом влияния на её функционирование – … угроза');
/*!40000 ALTER TABLE `questions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roles` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` char(25) DEFAULT NULL,
  `allowRead` tinyint(4) DEFAULT NULL,
  `allowWrite` tinyint(4) DEFAULT NULL,
  `Admin` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (0,'Полный доступ',1,1,1),(1,'Чтение',1,0,0),(2,'Чтение и запись',1,1,0);
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subject` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES (4,'Инф. безопастность','Информационная безопастность'),(5,'АИС','Автоматизация информационных систем');
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `test`
--

DROP TABLE IF EXISTS `test`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `test` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ID_info` bigint(20) DEFAULT NULL,
  `ID_subject` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_TEST_TEST_TEST_TEST_INF` (`ID_info`),
  KEY `FK_TEST_TEST_TEST_SUBJECT` (`ID_subject`),
  CONSTRAINT `FK_TEST_TEST_TEST_SUBJECT` FOREIGN KEY (`ID_subject`) REFERENCES `subject` (`ID`),
  CONSTRAINT `FK_TEST_TEST_TEST_TEST_INF` FOREIGN KEY (`ID_info`) REFERENCES `test_info` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `test`
--

LOCK TABLES `test` WRITE;
/*!40000 ALTER TABLE `test` DISABLE KEYS */;
INSERT INTO `test` VALUES (1,1,4),(2,3,4);
/*!40000 ALTER TABLE `test` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `test_info`
--

DROP TABLE IF EXISTS `test_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `test_info` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Amount` int(11) DEFAULT NULL,
  `Availble` tinyint(4) DEFAULT '1',
  `Description` text,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `test_info`
--

LOCK TABLES `test_info` WRITE;
/*!40000 ALTER TABLE `test_info` DISABLE KEYS */;
INSERT INTO `test_info` VALUES (1,5,1,'Тест по информационной безопастности'),(3,3,1,'ывф');
/*!40000 ALTER TABLE `test_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `test_pool`
--

DROP TABLE IF EXISTS `test_pool`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `test_pool` (
  `ID_test` bigint(20) NOT NULL,
  `ID_question` bigint(20) NOT NULL,
  PRIMARY KEY (`ID_test`,`ID_question`),
  KEY `FK_TEST_POO_Q_P_QUESTION` (`ID_question`),
  CONSTRAINT `FK_TEST_POO_Q_P_QUESTION` FOREIGN KEY (`ID_question`) REFERENCES `questions` (`ID`),
  CONSTRAINT `FK_TEST_POO_T_Q_TEST` FOREIGN KEY (`ID_test`) REFERENCES `test` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `test_pool`
--

LOCK TABLES `test_pool` WRITE;
/*!40000 ALTER TABLE `test_pool` DISABLE KEYS */;
INSERT INTO `test_pool` VALUES (1,6),(2,6),(1,7),(2,7),(1,8),(2,8),(1,9),(1,10);
/*!40000 ALTER TABLE `test_pool` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_info`
--

DROP TABLE IF EXISTS `user_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_info` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` char(50) DEFAULT NULL,
  `Surname` char(50) DEFAULT NULL,
  `Patronym` char(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_info`
--

LOCK TABLES `user_info` WRITE;
/*!40000 ALTER TABLE `user_info` DISABLE KEYS */;
INSERT INTO `user_info` VALUES (1,'Преподаватель','Иванов','Иванович'),(2,'Гаганова','Валерия','Сергеевна'),(4,'А','Ещеадминь','Дмин');
/*!40000 ALTER TABLE `user_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_result`
--

DROP TABLE IF EXISTS `user_result`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_result` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ID_user` bigint(20) DEFAULT NULL,
  `ID_test` bigint(20) DEFAULT NULL,
  `end_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  KEY `FK_USER_RES_T_R_TEST` (`ID_test`),
  KEY `FK_USER_RES_U_R_USER` (`ID_user`),
  CONSTRAINT `FK_USER_RES_T_R_TEST` FOREIGN KEY (`ID_test`) REFERENCES `test` (`ID`),
  CONSTRAINT `FK_USER_RES_U_R_USER` FOREIGN KEY (`ID_user`) REFERENCES `aquser` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_result`
--

LOCK TABLES `user_result` WRITE;
/*!40000 ALTER TABLE `user_result` DISABLE KEYS */;
INSERT INTO `user_result` VALUES (1,2,1,'2017-06-18 06:45:49'),(2,2,2,'2017-06-18 08:49:10');
/*!40000 ALTER TABLE `user_result` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usergroup`
--

DROP TABLE IF EXISTS `usergroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usergroup` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ID_info` bigint(20) DEFAULT NULL,
  `ID_role` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_GROUP_GROUP_GRO_GROUP_IN` (`ID_info`),
  KEY `FK_GROUP_ROLES_GRO_ROLES` (`ID_role`),
  CONSTRAINT `FK_GROUP_GROUP_GRO_GROUP_IN` FOREIGN KEY (`ID_info`) REFERENCES `group_info` (`ID`),
  CONSTRAINT `FK_GROUP_ROLES_GRO_ROLES` FOREIGN KEY (`ID_role`) REFERENCES `roles` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usergroup`
--

LOCK TABLES `usergroup` WRITE;
/*!40000 ALTER TABLE `usergroup` DISABLE KEYS */;
INSERT INTO `usergroup` VALUES (0,0,0),(1,1,2),(2,2,1);
/*!40000 ALTER TABLE `usergroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `userrole`
--

DROP TABLE IF EXISTS `userrole`;
/*!50001 DROP VIEW IF EXISTS `userrole`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `userrole` AS SELECT 
 1 AS `ID`,
 1 AS `allowRead`,
 1 AS `allowWrite`,
 1 AS `Admin`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `usertestdetails`
--

DROP TABLE IF EXISTS `usertestdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usertestdetails` (
  `ID_user_result` bigint(20) NOT NULL,
  `ID_questions` bigint(20) NOT NULL,
  `ID_Answer` bigint(20) NOT NULL,
  PRIMARY KEY (`ID_user_result`,`ID_questions`,`ID_Answer`),
  KEY `fk_UserTestDetails_answer1_idx` (`ID_Answer`),
  KEY `fk_UserTestDetails_questions1_idx` (`ID_questions`),
  CONSTRAINT `fk_UserTestDetails_answer` FOREIGN KEY (`ID_Answer`) REFERENCES `answer` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_UserTestDetails_questions` FOREIGN KEY (`ID_questions`) REFERENCES `questions` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_UserTestDetails_user_result` FOREIGN KEY (`ID_user_result`) REFERENCES `user_result` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usertestdetails`
--

LOCK TABLES `usertestdetails` WRITE;
/*!40000 ALTER TABLE `usertestdetails` DISABLE KEYS */;
INSERT INTO `usertestdetails` VALUES (1,6,16),(2,6,16),(2,6,18),(2,7,21),(1,7,22),(2,7,23),(1,7,24),(1,8,27),(1,8,28),(2,8,28),(2,8,30),(1,9,33),(1,9,34),(1,10,37);
/*!40000 ALTER TABLE `usertestdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mysqldip'
--

--
-- Dumping routines for database 'mysqldip'
--
/*!50003 DROP PROCEDURE IF EXISTS `selectedTest` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `selectedTest`(IN idTest bigint(20))
BEGIN
	select 
		a.ID_Q as idQuestion,
		a.ID_A as idAnswer,
		b.Question as Question,
        b.ID_subject as idSubject,
		c.answer as answer,
		c.true_variant as isTrue
	from
		qs_ar as a
		JOIN questions as b ON b.ID = a.ID_Q
		join answer as c ON c.ID = a.ID_A
	WHERE a.ID_Q IN
				(select a.id_question from 
					test_pool as a where a.ID_test = idTest);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `fullusersinfo`
--

/*!50001 DROP VIEW IF EXISTS `fullusersinfo`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `fullusersinfo` AS select `a`.`ID` AS `ID`,`b`.`Surname` AS `Фамилия`,`b`.`Name` AS `Имя`,`b`.`Patronym` AS `Отчество`,`d`.`Name` AS `Группа`,`e`.`Name` AS `Роль`,if((`e`.`allowRead` = 1),'Да','Нет') AS `Чтение`,if((`e`.`allowWrite` = 1),'Да','Нет') AS `Запись`,if((`e`.`Admin` = 1),'Да','Нет') AS `Полный доступ` from ((((`aquser` `a` join `user_info` `b` on((`b`.`ID` = `a`.`ID_info`))) join `usergroup` `c` on((`c`.`ID` = `a`.`ID_group`))) join `group_info` `d` on((`d`.`ID` = `c`.`ID_info`))) join `roles` `e` on((`e`.`ID` = `c`.`ID_role`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `groupinfoview`
--

/*!50001 DROP VIEW IF EXISTS `groupinfoview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `groupinfoview` AS select `a`.`ID` AS `ID`,`b`.`Name` AS `Название(код)`,`b`.`Description` AS `Описание`,`c`.`Name` AS `Роль`,if((`c`.`allowRead` = 1),'Да','Нет') AS `Чтение`,if((`c`.`allowWrite` = 1),'Да','Нет') AS `Запись`,if((`c`.`Admin` = 1),'Да','Нет') AS `Полный доступ` from ((`usergroup` `a` join `group_info` `b` on((`b`.`ID` = `a`.`ID_info`))) join `roles` `c` on((`c`.`ID` = `a`.`ID_role`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `loginusers`
--

/*!50001 DROP VIEW IF EXISTS `loginusers`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `loginusers` AS select `a`.`ID` AS `ID`,`b`.`Surname` AS `Surname`,`b`.`Name` AS `Name`,`b`.`Patronym` AS `Patronym`,`a`.`passwd` AS `passwd` from (`aquser` `a` join `user_info` `b` on((`b`.`ID` = `a`.`ID_info`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `userrole`
--

/*!50001 DROP VIEW IF EXISTS `userrole`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `userrole` AS select `a`.`ID` AS `ID`,`b`.`allowRead` AS `allowRead`,`b`.`allowWrite` AS `allowWrite`,`b`.`Admin` AS `Admin` from ((`aquser` `a` join `usergroup` `c` on((`c`.`ID` = `a`.`ID_group`))) join `roles` `b` on((`b`.`ID` = `c`.`ID_role`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-06-18 12:59:35
