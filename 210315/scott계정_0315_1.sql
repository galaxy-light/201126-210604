DROP TABLE t_student;

CREATE TABLE t_student (
    sid INT,
    student_nm VARCHAR(10) NOT NULL,
    student_addr VARCHAR(50),
    lecture_nm VARCHAR(20) NOT NULL,
    PRIMARY KEY(sid));
    
INSERT INTO t_student (sid, student_nm, student_addr, lecture_nm)
    VALUES (100, 'ȫ�浿', '���� �Ѿ� ȫ�밨��', '�˼���');
INSERT INTO t_student (sid, student_nm, student_addr, lecture_nm)
    VALUES (101, '��浿', '���� �Ѿ� ��밨��', '�ü���');
INSERT INTO t_student (sid, student_nm, student_addr, lecture_nm)
    VALUES (102, '�̱浿', '���� �Ѿ� �̴밨��', 'â����');
 
-- Ʈ����� -> commit(DB�� ���������� �ݿ�) 
-- �ѹ�(rollback) -> �����·� ����
DROP TABLE t_lecture;

CREATE TABLE t_lecture (
    lecture_nm VARCHAR(30) NOT NULL PRIMARY KEY,
    class_location VARCHAR(30) NOT NULL);
    
INSERT INTO t_lecture (lecture_nm, class_location)
    VALUES ('�˼���', '������ 501ȣ');
INSERT INTO t_lecture (lecture_nm, class_location)
    VALUES ('�ü���', '������ 502ȣ');
INSERT INTO t_lecture (lecture_nm, class_location)
    VALUES ('â����', '������ 503ȣ');
    
DROP TABLE t_lecture;

CREATE TABLE t_grade (
    sid INTs,
    lecture_nm VARCHAR(20) NOT NULL,
    student_grade INT NOT NULL,
    PRIMARY KEY(sid, lecture_nm));
--    FOREIGN KEY(sid) REFERENCES t_student(sid),
--    FOREIGN KEY(lecture_nm) REFERENCES t_lecture(ltcture_nm));
    
INSERT INTO t_grade (sid, lecture_nm, student_grade)
    values (400, '�ü���', 3);
    
--DROP TABLE t_hobby;
--
--CREATE TABLE t_hobby (
--    sid INT,
--    hoddy VARCHAR(20) NOT NULL,
--    PRIMARY KEY(sid, hobby), -- ����Ű
--    FOREIGN KEY(sid) REFERENCES t_student(sid));
--    
--INSERT INTO t_student (sid, student_nm, student_addr, lecture_nm)
--    VALUES (103, '�ֱ浿', '���� �Ѿ� �ִ밨��', 'â����');
--INSERT INTO t_hobby (sid, hobby)
--    VALUES (300, '�нż���');
--INSERT INTO t_hobby (sid, hobby)
--    VALUES (301, '��������');

CREATE TABLE t_customer (
    i_customer INT,
    customer_nm VARCHAR(20) NOT NULL,
    PRIMARY KEY(i_customer));
    
INSERT INTO t_customer (i_coutomer, customer_nm)
    VALUES (100, 'ȫ�浿');
    
CREATE TABLE t_netflix (
    i_customer INTEGER,
    cus_watching VARCHAR(20) NOT NULL,
    watching_dt DATE DEFAULT NOW(),
    PRIMARY KEY(i_customer, cus_watching),
    FOREIGN KEY(i_customer) REFERENCES t_customer(i_customer));
    
INSERT INTO t_nexflix (i_customer, cus_watching)
    VALUES (200, '����Ʈ Ȩ');