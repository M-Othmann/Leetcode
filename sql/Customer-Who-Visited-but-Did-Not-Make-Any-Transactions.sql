# Write your MySQL query statement below



select customer_id, count(*) as count_no_trans
from visits v left outer join transactions t
on v.visit_id = t.visit_id
where t.visit_id is NULL
group by customer_id