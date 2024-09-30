CREATE DATABASE  IF NOT EXISTS `dbmcpms` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `dbmcpms`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: dbmcpms
-- ------------------------------------------------------
-- Server version	9.0.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tblallowance`
--

DROP TABLE IF EXISTS `tblallowance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblallowance` (
  `allowanceID` int NOT NULL AUTO_INCREMENT,
  `allowanceName` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`allowanceID`),
  UNIQUE KEY `allowanceID_UNIQUE` (`allowanceID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblallowance`
--

LOCK TABLES `tblallowance` WRITE;
/*!40000 ALTER TABLE `tblallowance` DISABLE KEYS */;
INSERT INTO `tblallowance` VALUES (1,'transpo','Active');
/*!40000 ALTER TABLE `tblallowance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbldepartment`
--

DROP TABLE IF EXISTS `tbldepartment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbldepartment` (
  `departmentID` int NOT NULL AUTO_INCREMENT,
  `departmentName` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`departmentID`),
  UNIQUE KEY `departmentID_UNIQUE` (`departmentID`),
  UNIQUE KEY `departmentName_UNIQUE` (`departmentName`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbldepartment`
--

LOCK TABLES `tbldepartment` WRITE;
/*!40000 ALTER TABLE `tbldepartment` DISABLE KEYS */;
INSERT INTO `tbldepartment` VALUES (1,'tite','Active'),(2,'etits','Active'),(3,'bulbol','Active');
/*!40000 ALTER TABLE `tbldepartment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblincentives`
--

DROP TABLE IF EXISTS `tblincentives`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblincentives` (
  `idtblincentives` int NOT NULL AUTO_INCREMENT,
  `incentiveName` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`idtblincentives`),
  UNIQUE KEY `idtblincentives_UNIQUE` (`idtblincentives`),
  UNIQUE KEY `incentiveName_UNIQUE` (`incentiveName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblincentives`
--

LOCK TABLES `tblincentives` WRITE;
/*!40000 ALTER TABLE `tblincentives` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblincentives` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbljoballowance`
--

DROP TABLE IF EXISTS `tbljoballowance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbljoballowance` (
  `jobAllowanceID` int NOT NULL AUTO_INCREMENT,
  `allowanceID` int NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`jobAllowanceID`),
  UNIQUE KEY `jobAllowanceID_UNIQUE` (`jobAllowanceID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbljoballowance`
--

LOCK TABLES `tbljoballowance` WRITE;
/*!40000 ALTER TABLE `tbljoballowance` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbljoballowance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblleave`
--

DROP TABLE IF EXISTS `tblleave`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblleave` (
  `leaveID` int NOT NULL AUTO_INCREMENT,
  `leaveType` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`leaveID`),
  UNIQUE KEY `idtblleave_UNIQUE` (`leaveID`),
  UNIQUE KEY `leaveType_UNIQUE` (`leaveType`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblleave`
--

LOCK TABLES `tblleave` WRITE;
/*!40000 ALTER TABLE `tblleave` DISABLE KEYS */;
INSERT INTO `tblleave` VALUES (1,'Sick','Active'),(2,'Maternity','Active');
/*!40000 ALTER TABLE `tblleave` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblpagibig`
--

DROP TABLE IF EXISTS `tblpagibig`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblpagibig` (
  `pagibigID` int NOT NULL AUTO_INCREMENT,
  `rate` int NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`pagibigID`),
  UNIQUE KEY `idtblpagibig_UNIQUE` (`pagibigID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblpagibig`
--

LOCK TABLES `tblpagibig` WRITE;
/*!40000 ALTER TABLE `tblpagibig` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblpagibig` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblphilhealth`
--

DROP TABLE IF EXISTS `tblphilhealth`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblphilhealth` (
  `philhealthID` int NOT NULL AUTO_INCREMENT,
  `rate` int NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`philhealthID`),
  UNIQUE KEY `philhealthID_UNIQUE` (`philhealthID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblphilhealth`
--

LOCK TABLES `tblphilhealth` WRITE;
/*!40000 ALTER TABLE `tblphilhealth` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblphilhealth` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblposition`
--

DROP TABLE IF EXISTS `tblposition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblposition` (
  `positionID` int NOT NULL AUTO_INCREMENT,
  `positionName` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  `departmentID` int NOT NULL,
  PRIMARY KEY (`positionID`),
  UNIQUE KEY `positionID_UNIQUE` (`positionID`),
  UNIQUE KEY `posiitonName_UNIQUE` (`positionName`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblposition`
--

LOCK TABLES `tblposition` WRITE;
/*!40000 ALTER TABLE `tblposition` DISABLE KEYS */;
INSERT INTO `tblposition` VALUES (1,'bulbol','Active',1);
/*!40000 ALTER TABLE `tblposition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblsss`
--

DROP TABLE IF EXISTS `tblsss`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblsss` (
  `sssID` int NOT NULL AUTO_INCREMENT,
  `minSalary` decimal(10,2) NOT NULL,
  `maxSalary` decimal(10,2) NOT NULL,
  `EE` decimal(10,2) DEFAULT NULL,
  `wisp` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`sssID`),
  UNIQUE KEY `sssID_UNIQUE` (`sssID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblsss`
--

LOCK TABLES `tblsss` WRITE;
/*!40000 ALTER TABLE `tblsss` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblsss` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltax`
--

DROP TABLE IF EXISTS `tbltax`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbltax` (
  `taxID` int NOT NULL AUTO_INCREMENT,
  `minSalary` decimal(10,2) NOT NULL,
  `maxSalary` decimal(10,2) NOT NULL,
  `fixedAmount` decimal(10,2) NOT NULL,
  `percentage` int NOT NULL,
  PRIMARY KEY (`taxID`),
  UNIQUE KEY `taxID_UNIQUE` (`taxID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltax`
--

LOCK TABLES `tbltax` WRITE;
/*!40000 ALTER TABLE `tbltax` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbltax` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-30 20:17:22
