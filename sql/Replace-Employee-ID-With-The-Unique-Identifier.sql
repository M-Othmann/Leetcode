# Write your MySQL query statement below

select unique_id, name 
from EmployeeUNI emp Right outer join  Employees emps
on emps.id = emp.id 