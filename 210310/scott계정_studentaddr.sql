-- ���̺� ����
--create table STUDENTADDR (id number not null, name VARCHAR(20) not null, age number not null, addr varchar(80) not null,
--CONSTRAINT pk_student_id primary key(id));

-- ������ ��� �������� ���� ��ü ����
--select count(*) from STUDENTADDR;

-- �������� �����Ͽ� ID�� 1���� 1�� �ڵ����� �����ϵ��� ó��
-- CREATE SEQUENCE ID INCREMENT BY 1 START WITH 1;

-- ������ ����
--DROP SEQUENCE ID;

-- ���� ��� ����
--INSERT INTO STUDENTADDR VALUES (SEQ_ID.nextval, '�ֱ浿', 100, '�뱸 �޼���');

-- ���̺� ���� ����
--DESC STUDENTADDR;

-- ���̺� ����
--ALTER TABLE STUDENTADDR ADD (NAME2 VARCHAR(40)); -- ���̺� ���ο� �÷� �߰�
--ALTER TABLE STUDENTADDR MODIFY (NAME2 VARCHAR(80)); -- �÷� ���� ����
--ALTER TABLE STUDENTADDR RENAME COLUMN NAME2 TO NAME4; -- �÷� �̸� ����
--ALTER TABLE STUDENTADDR DROP COLUMN NAME4; -- �÷� ����

-- ���̺� ����
--DROP TABLE STUDENTADDR;

-- ���̺� ������ PRIMARY KEY ����
--create table STUDENTADDR (id number not null, name VARCHAR(20) not null, age number not null, addr varchar(80) not null);
--ALTER TABLE STUDENTADDR ADD CONSTRAINT pk_student_id primary key(id);

-- ������ �߰�(�������� �߰��Ͽ� �ڵ����� ID�� �����ϵ��� ó��
--INSERT INTO STUDENTADDR VALUES (SEQ_ID.nextval, '�ֱ浿', 100, '�뱸 �޼���');
--INSERT INTO STUDENTADDR VALUES (SEQ_ID.nextval, '�ڱ浿', 99, '�뱸 ����');
--INSERT INTO STUDENTADDR VALUES (SEQ_ID.nextval, 'ȫ�浿', 98, '�뱸 �ϱ�');

-- ���̺��� ��� ������ ��������
--SELECT * FROM STUDENTADDR;

-- �־��� ID������ ������ �÷� ������ ��������
--SELECT NAME, AGE FROM STUDENTADDR WHERE ID = 1;

-- WHERE �˻� ����
--SELECT * FROM STUDENTADDR WHERE NAME IS NULL; -- NULL�� ���
--SELECT * FROM STUDENTADDR WHERE NAME LIKE '%�浿'; --"�浿"�� �����ϴ� �̸�

-- ������ ����
--SELECT * FROM STUDENTADDR ORDER BY NAME; -- �������� ����
--SELECT * FROM STUDENTADDR ORDER BY NAME DESC; -- �������� ����
--SELECT * FROM STUDENTADDR WHERE NAME LIKE '%�浿' ORDER BY ID DESC; -- �̸��� "�浿"�� �����ϰ� ID�� �������� ����

-- ������ ����
--DELETE FROM STUDENTADDR WHERE AGE = '100'; -- ���� 100 �������� �׸� ����
--DELETE FROM STUDENTADDR WHERE ID = 25; -- ID 25 �������� �׸� ����

-- ������ ����
--update STUDENTADDR SET NAME = '�ڱ浿' WHERE NAME = 'ȫ�浿'; -- ȫ�浿�� �ڱ浿���� ����
--update STUDENTADDR SET NAME = '�ָ���' WHERE ID = 24; -- ID 24�� �׸� �� �̸� �����͸� �ָ��η� ����
update STUDENTADDR SET NAME = 'ȫ����', AGE = 11, ADDR = '���� ���� �������' WHERE ID = 27; -- ID 27�� �׸� �̸�, ����, �ּ� ������ ����