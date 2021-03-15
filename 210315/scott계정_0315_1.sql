DROP TABLE t_student;

CREATE TABLE t_student (
    sid INT,
    student_nm VARCHAR(10) NOT NULL,
    student_addr VARCHAR(50),
    lecture_nm VARCHAR(20) NOT NULL,
    PRIMARY KEY(sid));
    
INSERT INTO t_student (sid, student_nm, student_addr, lecture_nm)
    VALUES (100, '홍길동', '조선 한양 홍대감댁', '검술과');
INSERT INTO t_student (sid, student_nm, student_addr, lecture_nm)
    VALUES (101, '김길동', '조선 한양 김대감댁', '궁술과');
INSERT INTO t_student (sid, student_nm, student_addr, lecture_nm)
    VALUES (102, '이길동', '조선 한양 이대감댁', '창술과');
 
-- 트랙잭션 -> commit(DB에 영구적으로 반영) 
-- 롤백(rollback) -> 원상태로 복원
DROP TABLE t_lecture;

CREATE TABLE t_lecture (
    lecture_nm VARCHAR(30) NOT NULL PRIMARY KEY,
    class_location VARCHAR(30) NOT NULL);
    
INSERT INTO t_lecture (lecture_nm, class_location)
    VALUES ('검술과', '무예관 501호');
INSERT INTO t_lecture (lecture_nm, class_location)
    VALUES ('궁술과', '무예관 502호');
INSERT INTO t_lecture (lecture_nm, class_location)
    VALUES ('창술과', '무예관 503호');
    
DROP TABLE t_lecture;

CREATE TABLE t_grade (
    sid INTs,
    lecture_nm VARCHAR(20) NOT NULL,
    student_grade INT NOT NULL,
    PRIMARY KEY(sid, lecture_nm));
--    FOREIGN KEY(sid) REFERENCES t_student(sid),
--    FOREIGN KEY(lecture_nm) REFERENCES t_lecture(ltcture_nm));
    
INSERT INTO t_grade (sid, lecture_nm, student_grade)
    values (400, '궁술과', 3);
    
--DROP TABLE t_hobby;
--
--CREATE TABLE t_hobby (
--    sid INT,
--    hoddy VARCHAR(20) NOT NULL,
--    PRIMARY KEY(sid, hobby), -- 복합키
--    FOREIGN KEY(sid) REFERENCES t_student(sid));
--    
--INSERT INTO t_student (sid, student_nm, student_addr, lecture_nm)
--    VALUES (103, '최길동', '조선 한양 최대감댁', '창술과');
--INSERT INTO t_hobby (sid, hobby)
--    VALUES (300, '분신술과');
--INSERT INTO t_hobby (sid, hobby)
--    VALUES (301, '축지법과');

CREATE TABLE t_customer (
    i_customer INT,
    customer_nm VARCHAR(20) NOT NULL,
    PRIMARY KEY(i_customer));
    
INSERT INTO t_customer (i_coutomer, customer_nm)
    VALUES (100, '홍길동');
    
CREATE TABLE t_netflix (
    i_customer INTEGER,
    cus_watching VARCHAR(20) NOT NULL,
    watching_dt DATE DEFAULT NOW(),
    PRIMARY KEY(i_customer, cus_watching),
    FOREIGN KEY(i_customer) REFERENCES t_customer(i_customer));
    
INSERT INTO t_nexflix (i_customer, cus_watching)
    VALUES (200, '스위트 홈');