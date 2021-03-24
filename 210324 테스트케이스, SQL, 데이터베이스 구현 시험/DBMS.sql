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

INSERT INTO A (a_id, a_name, a_major) VALUES (A_SEQ.nextval, '�ƹ���', '������');
INSERT INTO A (a_id, a_name, a_major) VALUES (A_SEQ.nextval, '�����', '�濵�а�');
INSERT INTO A (a_id, a_name, a_major) VALUES (A_SEQ.nextval, '���ź�', '�����а�');

INSERT INTO B (b_id, b_name, b_major) VALUES (B_SEQ.nextval, 'ȫ�浿', '��ǻ�Ͱ�');
INSERT INTO B (b_id, b_name, b_major) VALUES (B_SEQ.nextval, '����ġ', '�����');
INSERT INTO B (b_id, b_name, b_major) VALUES (B_SEQ.nextval, '�̵η�', '������');
        
        