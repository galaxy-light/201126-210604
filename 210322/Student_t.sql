--CREATE TABLE Student_t
--(
--    s_id       INT             NOT NULL, 
--    s_name     VARCHAR2(20)    NOT NULL, 
--    s_major    VARCHAR2(20)    NOT NULL, 
--    CONSTRAINT STUDENT_T_PK PRIMARY KEY (s_id)
--);
--
--CREATE SEQUENCE Student_t_SEQ
--START WITH 1
--INCREMENT BY 1;
--
--CREATE TABLE Subject_t
--(
--    sub_id       INT             NOT NULL, 
--    sub_name     VARCHAR2(20)    NOT NULL, 
--    sub_score    VARCHAR2(20)    NOT NULL, 
--    CONSTRAINT SUBJECT_T_PK PRIMARY KEY (sub_id)
--);
--
--CREATE SEQUENCE Subject_t_SEQ
--START WITH 1
--INCREMENT BY 1;
--
--CREATE TABLE Add_t
--(
--    s_id      INT    NOT NULL, 
--    sub_id    INT    NOT NULL, 
--    CONSTRAINT ADD_T_PK PRIMARY KEY (s_id, sub_id)
--);
--
--ALTER TABLE Add_t
--    ADD CONSTRAINT FK_Add_t_s_id_Student_t_s_id FOREIGN KEY (s_id)
--        REFERENCES Student_t (s_id);
--
--ALTER TABLE Add_t
--    ADD CONSTRAINT FK_Add_t_sub_id_Subject_t_sub_ FOREIGN KEY (sub_id)
--        REFERENCES Subject_t (sub_id);

INSERT INTO Student_t (s_id, s_name, s_major) VALUES (STUDENT_T_SEQ.nextval, 's_name 1', 's_major 1');
INSERT INTO Student_t (s_id, s_name, s_major) VALUES (STUDENT_T_SEQ.nextval, 's_name 2', 's_major 2');
INSERT INTO Student_t (s_id, s_name, s_major) VALUES (STUDENT_T_SEQ.nextval, 's_name 3', 's_major 3');

INSERT INTO Student_t (s_id, s_name, s_major) VALUES (STUDENT_T_SEQ.nextval, '홍길동', '컴퓨터과');
INSERT INTO Student_t (s_id, s_name, s_major) VALUES (STUDENT_T_SEQ.nextval, '전우치', '전기과');
INSERT INTO Student_t (s_id, s_name, s_major) VALUES (STUDENT_T_SEQ.nextval, '신사임당', '관광과');
        
        