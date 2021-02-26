-- INSERT INTO namecard VALUES('0', '김수한', '010-1111-1111', '서울시');
-- INSERT INTO namecard VALUES('0', '무거북', '010-2222-2222', '대전시');
-- INSERT INTO namecard VALUES('0', '이와두', '010-3333-3333', '목포시');
-- INSERT INTO namecard VALUES('0', '루미삼', '010-4444-4444', '광양시');
-- INSERT INTO namecard VALUES('0', '천갑자', '010-5555-5555', '포항시');
-- INSERT INTO namecard VALUES('0', '동박사', '010-6666-6666', '대구시');
-- INSERT INTO namecard VALUES('0', '홍길동', '010-7777-7777', '부산시');
-- INSERT INTO namecard VALUES('0', '김이박', '010-8888-8888', '창원시');
-- INSERT INTO namecard VALUES('0', '최권임', '010-9999-9999', '강릉시');
-- INSERT INTO namecard VALUES('0', '강백오', '010-1234-1234', '춘천시');
-- INSERT INTO namecard VALUES('0', '이미루', '010-8521-1478', '울릉군');

-- id 5번 검색
-- SELECT * FROM namecard where id = '5';
-- 이름 중간 글자검색, 내림차순
-- SELECT * FROM namecard WHERE NAME LIKE '%미%' ORDER BY name desc;
-- id 7번 삭제
-- DELETE FROM namecard WHERE id = '7';
-- 특정인물 phone 값 변경
-- UPDATE namecard SET phone = '010-3698-4561' WHERE NAME = '김이박';

-- SELECT * FROM namecard JOIN userinfo; -- 교차곱
SELECT * FROM namecard JOIN userinfo WHERE namecard.name=userinfo.name;