-- ������ �׻� �ڿ������� ���۵�
SELECT ename, dno from employee where dno = (SELECT dno from employee where ename = 'SCOTT');