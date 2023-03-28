
create database cust


CREATE TABLE customers (
  id INT PRIMARY KEY,
  name VARCHAR(50),
  email VARCHAR(50)
);

insert into customers(id,name,email) values(1,'praveen','praveen@gmail.com')
select * from customers;
select * from orders;
select * from order_items;

CREATE TABLE orders (
  id INT PRIMARY KEY,
  customer_id INT,
  order_date DATE,
  amount DECIMAL(10, 2),
  FOREIGN KEY (customer_id) REFERENCES customers(id)
);
insert into orders(id,customer_id,order_date,amount) values(1,2,'2023-02-28',2000)
insert into orders(id,customer_id,order_date,amount) values(2,2,'2023-02-28',3456)


CREATE TABLE order_items (
  id INT PRIMARY KEY,
  order_id INT,
  product VARCHAR(50),
  price DECIMAL(10, 2),
  quantity INT,
  FOREIGN KEY (order_id) REFERENCES orders(id)
);

insert into order_items(id,order_id,product,price,quantity) values(1,1,'dust',2000,3);
insert into order_items(id,order_id,product,price,quantity) values(2,1,'rice',2000,3);
select customers.name,customers.email,orders.amount,orders.order_date,order_items.price FROM customers
INNER JOIN orders ON customers.id = orders.customer_id
INNER JOIN order_items ON orders.id = order_items.order_id
WHERE customers.id = 1;

DELETE customers
FROM customers
INNER JOIN orders ON customers.id = orders.customer_id
INNER JOIN order_items ON orders.id = order_items.order_id
WHERE customers.id = 1;

DELETE customers, orders, order_items
FROM customers
        INNER JOIN
    orders ON customers.id = orders.customer_id 
	INNER JOIN order_items ON orders.id = order_items.order_id
WHERE
    customers.id = 2 and orders.id=2;