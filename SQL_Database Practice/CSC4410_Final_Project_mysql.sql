\! echo CSC4410-20739 W22 Final Project - Sakila database
 
\! echo 1. Put you name on the following line
\! echo Name: YourFirstName YourLastName
\! echo _

\! echo show databases
show databases; -- Do not remove this line.

\! echo Put any needed setup sql commands here

-- Replace this line with your code

\! echo ___ SAMPLE QUESTION ______________________ 
\! echo 0. Which actors have the first name 'Sandra'
\! echo.
\! echo The exected results is:
\! echo "+------------+-----------+"
\! echo "| first_name | last_name |"
\! echo "+------------+-----------+"
\! echo "| SANDRA     | KILMER    |"
\! echo "| SANDRA     | PECK      |"
\! echo "+------------+-----------+"
\! echo _______ Your result:

select first_name, last_name 
from actor 
where first_name='SANDRA'; -- Do not remove this line.

\! echo ___ END OF SAMPLE QUESTION _______________
\! echo ______________________
\! echo 2. Which actors have the last name 'Kilmer'

select first_name, last_name 
from actor 
where last_name='KILMER';

\! echo ______________________
\! echo 3. How many distinct actors last names are there? 

select count(DISTINCT last_name) 
from actor;

\! echo ______________________
\! echo 4. What are the 3 most common last names? 

select last_name
from actor
group by last_name
order by count(*)
desc limit 3;

\! echo ______________________
\! echo 5. What are the 4 most common first names? 

select first_name
from actor
group by first_name
order by count(*)
desc limit 4;

\! echo ______________________
\! echo 6. Which first names are not repeated? Alphabetize the list.

select first_name
from actor
group by first_name
having count(*) = 1
order by first_name asc;

\! echo ______________________
\! echo 7. How many unique first names are there?

select count(distinct first_name)
from actor;

\! echo ______________________
\! echo 8. Which last names appear more than once? Alphabetize the list.

select last_name
from actor
group by last_name
having count(*) > 1
order by last_name asc;

\! echo ______________________
\! echo 9. Which actor has appeared in the most films?

select actor.actor_id, actor.first_name, actor.last_name, count(actor_id) as count_film
from actor
    join film_actor using (actor_id)
group by actor_id
order by count_film desc limit 1;

\! echo ______________________
\! echo 10. Which rating has the most films?

select film.rating, count(film.rating) as count_rating
from film
group by film.rating
order by count_rating
desc limit 1;

\! echo ______________________
\! echo 11. Which country has the most customers?

select c.country as name_country, count(cust.customer_id) as count_customer
from country as c
join (city, address ad, customer cu)
on (c.country_id = city.country_id and city.city_id = ad.city_id and ad.address_id = cu.address_id)
group by name_country
order by count_customer desc limit 1;

\! echo ______________________
\! echo 12. How many documentaries are there?

select category.name as name_category, count(distinct f.film_id) as count_category
from film f
join (film_category f_c, category)
on (f.film_id = f_c.film_id and f_c.category_id = category.category_id and category.category_id = 6)
group by name_category;

\! echo ______________________
\! echo 13. What is that average replacement cost of all the films in the sakila DB? (ignoring inventory, $##.##)

select avg(replacement_cost) as avg_cost
from film;

\! echo ______________________
\! echo 14. What is that average repalcement cost of all the films in the sakila DB? (taking inventory into consideration, $##.##)

-- Replace this line with your code

\! echo ______________________
\! echo 15. What is the average replacement_cost of films by category? (ignoring inventory, $##.##)

-- Replace this line with your code

\! echo ______________________
\! echo 16. Insert a record to represent the film "Walt Disney Treasures: The Chronological Donald, Vol. 4 - 1951-1961 (Collector's Tin)", with a replacment cost of $397.97.

insert into film (title, language_id, replacement_cost)
values ('Walt Disney Treasures: The Chronological Donald, Vol. 4 - 1951-1961 (Collectors Tin)', 1, 397.97);

\! echo ______________________
\! echo 17. How many films are there now?

select count(film_id) as count_film
from film;

\! echo ______________________
\! echo 18. What is the new average replacement cost of all the films in the sakila DB? (ignoring inventory, $##.##)

select avg(replacement_cost) as new_avg_cost
from film;

\! echo ______________________
\! echo 19. Which film categories average longer that 2 hours? (no fractional minutes)

-- Replace this line with your code

\! echo ______________________
\! echo 20. How many copies of "Majestic Floats" are available for rent from Store 1?

select count(inventory_id) as count_copies
from rental
    inner join using(inventory_id)
where return_date IS NULL;

select country.country, count(city.country_id) as count_city
from country
    join city using(country_id)
group by country_id
order by count_city desc limit 1;


\! echo ______________________
\! echo 21. How many copies of that film are available for rent from Store 2?

-- Replace this line with your code

\! echo ______________________
\! echo 22. Answer the following question,
\! echo - prefacing each line of your answer with '\! echo ', so it shows up in the output.txt file.

\! echo Why does this query return the empty set, and no error?

select * from film natural join inventory; -- Do not remove this line.

\! echo Your answer
\! echo ... 
\! echo here.


\! echo ______________________
\! echo 23. Answer the following question,
\! echo - prefacing each line of your answer with '\! echo ', so it shows up in the output.txt file.

\! echo Which two questions/queries/reports in this list were the hardest? Why?

\! echo Your answer
\! echo ... 
\! echo here.

\! echo That is all.
\! echo ______________________ EOF
