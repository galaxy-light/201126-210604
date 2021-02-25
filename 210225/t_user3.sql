-- 한줄 주석
/*
	여러 줄 주석
*/

-- 테이블의 모든 테이터를 삭제
-- DELETE FROM t_user;

-- 테이블 자체를 삭제
-- DROP table t_user;

-- 16번 행만 삭제
-- DELETE FROM t_user WHERE i_user = 16;

-- 이순규라는 이름 데이터를 가진 행 삭제
-- DELETE FROM t_user WHERE user_nm = '이순규';

-- 김순자라는 이름 데이터를 홍길동으로 변경
-- WHERE : 특정 정보를 삭제할 때 사용
-- UPDATE t_user SET user_nm = '홍길동' WHERE user_nm = '김순자';

-- 데이터 검색
-- SELECT : 컬럼을 불러오는 명령어
-- SELECT user_nm, user_age, r_dt FROM t_user;

-- 모든 컬럼의 정보 검색
-- SELECT * FROM t_user;

-- 데이터 추가
-- INSERT INTO t_user VALUES (0, '홍길동', 100, 'hong@naver.com', '010-2589-4567', '조선 한양 홍대감댁', NOW());

-- ORDER BY : 출력 순서
-- 조건 검색(DESC : 내림차순 정렬)
-- SELECT i_user, user_nm, user_age FROM t_user WHERE user_age > 20 AND user_age < 130 ORDER BY user_age DESC;

-- 조건 검색(ASC : 오름차순 정렬 : 기본 값이 오름차순 정렬이기 때문에 생략 가능)
-- SELECT i_user, user_nm, user_age FROM t_user WHERE user_age > 20 AND user_age < 130 ORDER BY user_age ASC;
-- SELECT i_user, user_nm, user_age FROM t_user WHERE user_age > 20 AND user_age < 130 ORDER BY user_age;

-- AS "나이(세)" : 항목 이름 변경
-- SELECT i_user, user_nm, user_age AS "나이(세)" FROM t_user WHERE user_age > 20 AND user_age < 130 ORDER BY user_age ASC;

-- SELECT i_user, user_nm, user_age AS "나이(세)" FROM t_user WHERE user_age > 20 AND user_age <= 130 ORDER BY user_age ASC;

-- 나이 : 20, 22, 100 값, i_user 값에 의해 정렬(오름차순)
-- SELECT i_user, user_nm, user_age FROM t_user WHERE user_age IN (20, 22, 100) ORDER BY i_user;

-- 나이 : 20, 22, 100 값, 내림차순 / 이름 : 오름차순
-- SELECT i_user, user_nm, user_age FROM t_user WHERE user_age IN (20, 22, 100) ORDER BY user_age DESC, user_nm ASC;

-- 항목명 변경, 이름 오름차순
-- SELECT user_nm AS "성명", user_age AS "나이" FROM t_user WHERE user_age IN (20, 22, 100) ORDER BY i_user DESC;

-- 20보다 크고 100보다 작은 데이터 / i_user DESC : 가장 최신 데이터부터 출력
-- SELECT user_nm AS "성명", user_age AS "나이" FROM t_user WHERE user_age BETWEEN 20 AND 100 ORDER BY i_user DESC;
-- SELECT user_nm AS "성명", user_age AS "나이" FROM t_user WHERE user_age >= 20 AND user_age <= 100 ORDER BY i_user DESC;

-- %동 : 맨 끝이 동자로 끝나는 정보 / 이름순으로 내림차순
-- SELECT user_nm AS "성명", user_age AS "나이" FROM t_user WHERE user_nm LIKE '%동' ORDER BY user_nm DESC;

-- 홍__ : 홍자로 시작하는 모든 이름 데이터
-- SELECT user_nm AS "성명", user_age AS "나이" FROM t_user WHERE user_nm LIKE '홍__' ORDER BY user_nm DESC;

-- __홍 : 홍자로 끝나는 모든 이름 데이터
-- SELECT user_nm AS "성명", user_age AS "나이" FROM t_user WHERE user_nm LIKE '__홍' ORDER BY user_nm DESC;

-- 김% : 김으로 시작하는 모든 이름 데이터
-- SELECT user_nm AS "성명", user_age AS "나이" FROM t_user WHERE user_nm LIKE '김%' ORDER BY user_nm DESC;

-- mysql 함수
-- SELECT SUM(user_age) AS '나이의 총합계' FROM t_user;
-- SELECT MAX(user_age) AS '가장 나이가 많은 사람' FROM t_user;
-- SELECT MIN(user_age) AS '가장 나이가 적은 사람' FROM t_user;
-- SELECT AVG(user_age) AS '나이 평균' FROM t_user;
SELECT COUNT(i_user) AS '데이터 개수' FROM t_user;



