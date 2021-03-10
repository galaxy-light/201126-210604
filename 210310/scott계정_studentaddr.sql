-- 테이블 생성
--create table STUDENTADDR (id number not null, name VARCHAR(20) not null, age number not null, addr varchar(80) not null,
--CONSTRAINT pk_student_id primary key(id));

-- 생성된 모든 데이터의 행의 전체 개수
--select count(*) from STUDENTADDR;

-- 시퀀스를 생성하여 ID를 1부터 1씩 자동으로 증가하도록 처리
-- CREATE SEQUENCE ID INCREMENT BY 1 START WITH 1;

-- 시퀀스 삭제
--DROP SEQUENCE ID;

-- 쿼리 사용 예시
--INSERT INTO STUDENTADDR VALUES (SEQ_ID.nextval, '최길동', 100, '대구 달서구');

-- 테이블 정보 보기
--DESC STUDENTADDR;

-- 테이블 수정
--ALTER TABLE STUDENTADDR ADD (NAME2 VARCHAR(40)); -- 테이블에 새로운 컬럼 추가
--ALTER TABLE STUDENTADDR MODIFY (NAME2 VARCHAR(80)); -- 컬럼 정보 수정
--ALTER TABLE STUDENTADDR RENAME COLUMN NAME2 TO NAME4; -- 컬럼 이름 변경
--ALTER TABLE STUDENTADDR DROP COLUMN NAME4; -- 컬럼 삭제

-- 테이블 삭제
--DROP TABLE STUDENTADDR;

-- 테이블 생성후 PRIMARY KEY 지정
--create table STUDENTADDR (id number not null, name VARCHAR(20) not null, age number not null, addr varchar(80) not null);
--ALTER TABLE STUDENTADDR ADD CONSTRAINT pk_student_id primary key(id);

-- 데이터 추가(시퀀스를 추가하여 자동으로 ID값 증가하도록 처리
--INSERT INTO STUDENTADDR VALUES (SEQ_ID.nextval, '최길동', 100, '대구 달서구');
--INSERT INTO STUDENTADDR VALUES (SEQ_ID.nextval, '박길동', 99, '대구 동구');
--INSERT INTO STUDENTADDR VALUES (SEQ_ID.nextval, '홍길동', 98, '대구 북구');

-- 테이블에서 모든 데이터 가져오기
--SELECT * FROM STUDENTADDR;

-- 주어진 ID값에서 지정한 컬럼 정보만 가져오기
--SELECT NAME, AGE FROM STUDENTADDR WHERE ID = 1;

-- WHERE 검색 조건
--SELECT * FROM STUDENTADDR WHERE NAME IS NULL; -- NULL일 경우
--SELECT * FROM STUDENTADDR WHERE NAME LIKE '%길동'; --"길동"을 포함하는 이름

-- 데이터 정렬
--SELECT * FROM STUDENTADDR ORDER BY NAME; -- 오름차순 정렬
--SELECT * FROM STUDENTADDR ORDER BY NAME DESC; -- 내림차순 정렬
--SELECT * FROM STUDENTADDR WHERE NAME LIKE '%길동' ORDER BY ID DESC; -- 이름에 "길동"을 포함하고 ID로 내림차순 정렬

-- 데이터 삭제
--DELETE FROM STUDENTADDR WHERE AGE = '100'; -- 나이 100 데이터인 항목 삭제
--DELETE FROM STUDENTADDR WHERE ID = 25; -- ID 25 데이터인 항목 삭제

-- 데이터 수정
--update STUDENTADDR SET NAME = '박길동' WHERE NAME = '홍길동'; -- 홍길동을 박길동으로 변경
--update STUDENTADDR SET NAME = '최만두' WHERE ID = 24; -- ID 24인 항목 중 이름 데이터를 최만두로 변경
update STUDENTADDR SET NAME = '홍만두', AGE = 11, ADDR = '서울 강남 강남대로' WHERE ID = 27; -- ID 27인 항목 이름, 나이, 주소 데이터 변경