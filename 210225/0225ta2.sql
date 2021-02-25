-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        8.0.22 - MySQL Community Server - GPL
-- 서버 OS:                        Win64
-- HeidiSQL 버전:                  11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- test0225 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `test0225` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `test0225`;

-- 테이블 test0225.0225tb 구조 내보내기
CREATE TABLE IF NOT EXISTS `0225tb` (
  `id` int NOT NULL,
  `name` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `position` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `phone` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 test0225.0225tb:~0 rows (대략적) 내보내기
DELETE FROM `0225tb`;
/*!40000 ALTER TABLE `0225tb` DISABLE KEYS */;
INSERT INTO `0225tb` (`id`, `name`, `position`, `phone`) VALUES
	(1, '김수한무', '투수', '010-1111-1111'),
	(2, '거북이', '타자', '010-2222-2222'),
	(3, '두루미', '포수', '010-3333-3333'),
	(4, '삼천갑자', '내야수', '010-4444-4444'),
	(5, '동방삭', '외야수', '010-5555-5555'),
	(6, '홍길동', '유격수', '010-6666-6666'),
	(7, '이길동', '감독', '010-7777-7777');
/*!40000 ALTER TABLE `0225tb` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
