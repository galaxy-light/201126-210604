SELECT sum(salary) as "�޿��Ѿ�",
    avg(salary) as "�޿����",
    max(salary) as "�ִ�޿�",
    min(salary) as "�ּұ޿�" from employee;
    
SELECT count(*) as "��� ��" from employee;
SELECT count(DISTINCT job) as "���� ���� ����" from employee; -- DISTINCT : �ߺ� ����
SELECT dno as "�μ� ��ȣ", avg(salary) as "�޿� ���" from employee group by dno;

SELECT dno, job, count(*), sum(salary) from employee group by dno, job order by dno, job; -- ��������

SELECT dno, max(salary) from employee group by dno having max(salary) >= 3000;

SELECT * FROM employee, department where employee.dno = department.dno;