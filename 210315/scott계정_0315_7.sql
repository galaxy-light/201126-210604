-- 쿼리는 항상 뒤에서부터 시작됨
SELECT ename, dno from employee where dno = (SELECT dno from employee where ename = 'SCOTT');