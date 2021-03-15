SELECT * FROM employee, department where employee.dno = department.dno;

SELECT e.ename, d.dname FROM employee e, department d where e.dno = 7788; -- e, d : 별칭

SELECT e.eno, e.ename, d.dname, dno from employee e join department d using(dno) where e.eno = 7788; -- 위와 동일한 결과값

SELECT e.eno, e.ename, d.dname, e.dno from employee e join department d on e.dno = d.dno where e.eno = 7788; -- 위와 동일한 결과값

SELECT e.ename, d.name, e.salary, s.grade FROM employee e, department d, salgrade s where e.dno = d.dno and e.salary
    BETWEEN s.losal and s.hisal;
    
