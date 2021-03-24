-- 테이블 생성
-- CREATE TABLE namecard(
--	id INT NOT NULL,
--	name VARCHAR(10) NOT NULL AUTO_INCREMENT,
--	tel VARCHAR(20) NOT NULL,
--	email VARCHAR(30) NULL,
--	address VARCHAR(50) NOT NULL
--	PRIMARY KEY(id));	namecard

-- 데이터 추가
-- INSERT INTO `namecard` (`id`, `name`, `tel`, `email`, `address`) VALUES
--  (1, '홍길동', 01011111111, 'hong@naver.com', '서울 성동구 행당동'),
--  (2,'김길동', 01022222222, 'kim@naver.com', '창원 성산구 사파동'),
--  (3,'박길동', 01033333333, 'park@naver.com', '부산 북구 화명동');  
-- INSERT INTO `namecard` (`id`, `NAME`, `tel`, `email`, `address`) VALUES
--	(0, '홍길동', '01014785236', 'hong@daum.net', '서울시 동작구'),
--	(0, '김길동', '01085237894', 'kim@naver.com', '서울시 구로구'),
--	(0, '박길동', '01096324571', 'park@gmail.com', '서울시 강남구');

-- '동'으로 끝나는 이름을 검색하고 id 기준 내림차순 정렬
-- SELECT * FROM namecard WHERE NAME LIKE '%%동' ORDER BY id desc;

-- 김길동의 이름을 전우치로 변경하고 name 기준 오름차순 정렬
-- update namecard SET NAME = '전우치' WHERE NAME = '김길동';
-- SELECT * FROM namecard ORDER BY NAME;

-- 전우치 이름 삭제
-- DELETE FROM namecard WHERE NAME = '전우치';

-- 김길동 데이터 추가
-- INSERT INTO `namecard` (`id`, `name`, `tel`, `email`, `address`) VALUES
--	(0, '김길동', '01045647891', 'kim@naver.com', '서울시 구로구');

-- namecard_copy 복사, 김길동 데이터만 복사
CREATE TABLE namecard_copy AS
SELECT * FROM namecard WHERE NAME = '김길동';