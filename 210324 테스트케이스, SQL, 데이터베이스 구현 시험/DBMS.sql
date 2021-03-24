CREATE TABLE A
(
    a_id       INT             NOT NULL, 
    a_name     VARCHAR2(20)    NOT NULL, 
    a_major    VARCHAR2(20)    NOT NULL, 
    CONSTRAINT A_PK PRIMARY KEY (a_id)
);

CREATE SEQUENCE A_SEQ
START WITH 1
INCREMENT BY 1;

CREATE TABLE B
(
    b_id       INT             NOT NULL, 
    b_name     VARCHAR2(20)    NOT NULL, 
    b_major    VARCHAR2(20)    NOT NULL, 
    CONSTRAINT B_PK PRIMARY KEY (b_id)
);

CREATE SEQUENCE B_SEQ
START WITH 1
INCREMENT BY 1;

INSERT INTO A (a_id, a_name, a_major) VALUES (A_SEQ.nextval, '아무개', '조리과');
INSERT INTO A (a_id, a_name, a_major) VALUES (A_SEQ.nextval, '김수한', '경영학과');
INSERT INTO A (a_id, a_name, a_major) VALUES (A_SEQ.nextval, '무거북', '행정학과');

INSERT INTO B (b_id, b_name, b_major) VALUES (B_SEQ.nextval, '홍길동', '컴퓨터과');
INSERT INTO B (b_id, b_name, b_major) VALUES (B_SEQ.nextval, '전우치', '전기과');
INSERT INTO B (b_id, b_name, b_major) VALUES (B_SEQ.nextval, '이두루', '관광과');
        
        