SELECT sum(salary) as "급여총액",
    avg(salary) as "급여평균",
    max(salary) as "최대급여",
    min(salary) as "최소급여" from employee;
    
SELECT count(*) as "사원 수" from employee;
SELECT count(DISTINCT job) as "직업 종류 개수" from employee; -- DISTINCT : 중복 제거
SELECT dno as "부서 번호", avg(salary) as "급여 평균" from employee group by dno;

SELECT dno, job, count(*), sum(salary) from employee group by dno, job order by dno, job; -- 오름차순

SELECT dno, max(salary) from employee group by dno having max(salary) >= 3000;

SELECT * FROM employee, department where employee.dno = department.dno;