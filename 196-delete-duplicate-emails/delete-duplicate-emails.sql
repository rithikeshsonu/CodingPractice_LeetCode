# Write your MySQL query statement below
WITH cte AS(
    SELECT id
,ROW_NUMBER() OVER (PARTITION BY email ORDER BY id) as row_num
FROM Person
)
DELETE FROM Person
WHERE ID IN
(SELECT ID FROM cte WHERE row_num > 1);