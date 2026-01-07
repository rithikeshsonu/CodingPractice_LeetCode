# Write your MySQL query statement below
SELECT m.employee_id
        ,m.name
        ,COUNT(m.employee_id) reports_count
        ,ROUND(AVG(e.age)) average_age 
FROM Employees e
LEFT JOIN Employees m ON e.reports_to = m.employee_id
WHERE m.employee_id IS NOT NULL
GROUP BY m.employee_id, m.name
ORDER BY employee_id