-- INSERT INTO 0225ta VALUES('0', '고길동', '010-1111-1111');
-- INSERT INTO 0225ta VALUES('0', '우길동', '010-2222-2222');
-- INSERT INTO 0225ta VALUES('0', '홍길동', '010-3333-3333');
-- INSERT INTO 0225ta VALUES('0', '최길동', '010-4444-4444');
-- INSERT INTO 0225ta VALUES('0', '이길동', '010-5555-5555');
-- INSERT INTO 0225ta VALUES('0', '박길동', '010-6666-6666');

-- SELECT * FROM 0225ta;
-- SELECT * FROM 0225ta WHERE NAME = '고길동';
-- SELECT NAME, phone FROM 0225ta where id = '15' AND phone = '010-3333-3333';
-- SELECT NAME, phone FROM 0225ta WHERE id = '15';
-- SELECT * FROM 0225ta;
-- SELECT * FROM 0225ta WHERE id = 13;
-- SELECT * FROM 0225ta WHERE name is NULL;
-- SELECT * FROM 0225ta WHERE NAME LIKE '%길동';
-- SELECT * FROM 0225ta WHERE NAME LIKE '%길';
-- SELECT * FROM 0225ta WHERE NAME LIKE '%이%';
-- SELECT * FROM 0225ta WHERE NAME LIKE '%길%' AND NAME LIKE '박%';
-- SELECT * FROM 0225ta WHERE NAME LIKE '%길' OR NAME LIKE '%개'; 
-- SELECT * FROM 0225ta WHERE NAME LIKE '%길%' OR NAME LIKE '%개'; 
-- SELECT * FROM 0225ta WHERE NOT NAME LIKE '%개';
-- SELECT * FROM 0225ta WHERE id < 15;
-- SELECT * FROM 0225ta WHERE id > 15 AND id < 18; 
-- SELECT * FROM 0225ta WHERE id >= 15 AND id <= 18; 

-- SELECT * FROM 0225ta WHERE id >= 15 AND id <= 18 ORDER BY name asc;
-- SELECT * FROM 0225ta WHERE id >= 15 AND id <= 17 ORDER BY NAME;
-- SELECT * FROM 0225ta WHERE id >= 15 AND id < 18 ORDER BY NAME desc;

-- SELECT * FROM 0225ta JOIN 0225tb;
-- SELECT * FROM 0225ta JOIN 0225tb WHERE 0225ta.name=0225tb.name;
UPDATE 0225ta JOIN 0225tb ON 0225ta.name=0225tb.name SET 0225tb.name ='홍길동' WHERE 0225tb.name='이길동' AND 0225tb.phone='1';


