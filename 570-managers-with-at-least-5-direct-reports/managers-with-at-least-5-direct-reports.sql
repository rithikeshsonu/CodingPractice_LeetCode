-- # Write your MySQL query statement below
-- SELECT m.name
-- FROM Employee e
-- LEFT JOIN Employee m
-- ON m.id = e.managerId
-- GROUP BY m.name, m.id
-- Having Count(m.name) >= 5

select e1.name 
from employee e1 join employee e2 on e1.id=e2.managerId
group by e1.id having count(*) >= 5