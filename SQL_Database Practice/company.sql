CREATE DATABASE IF NOT EXISTS company;

USE company;

DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS Department;

CREATE TABLE Employee (
   ID SMALLINT UNSIGNED,
   Name VARCHAR(60),
   Salary DECIMAL(7,2) NOT NULL,
   PRIMARY KEY(ID)
);

CREATE TABLE Department (
   Code    TINYINT UNSIGNED AUTO_INCREMENT,
   Name    VARCHAR(20) NOT NULL,
   Manager SMALLINT UNSIGNED,
   PRIMARY KEY (Code)
);

INSERT INTO Employee VALUES 
   (2538, 'Lisa Ellison', 45000),
   (5384, 'Sam Snead', 32000),
   (6381, 'Maria Rodriguez', 95000),
   (7343, 'Gary Smith', 24500),
   (8392, 'Anna Watson', 41000);

INSERT INTO Department VALUES
   (44, 'Engineering', 2538),
   (82, 'Sales', 6381),
   (12, 'Marketing', 6381),
   (99, 'Technical support', NULL);