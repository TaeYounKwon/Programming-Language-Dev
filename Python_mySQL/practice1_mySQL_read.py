import pymysql
import pandas as pd
import mysql.connector
from mysql.connector import errorcode

#Get it from Azure devop/ mySQL
config = {
  'host':'###',
  'user':'###',
  'password':'###',
  'database':'###'
}

# Construct connection string

try:
   conn = mysql.connector.connect(**config)
   print("Connection established")
except mysql.connector.Error as err:
  if err.errno == errorcode.ER_ACCESS_DENIED_ERROR:
    print("Something is wrong with the user name or password")
  elif err.errno == errorcode.ER_BAD_DB_ERROR:
    print("Database does not exist")
  else:
    print(err)
else:
  cursor = conn.cursor()

#Read data 
cursor.execute("""
               SELECT firstname, lastname, email
               FROM employees
               WHERE employeeNumber = 1056;
               """)
rows = cursor.fetchall()
print("Read",cursor.rowcount,"row(s) of data.")

# Print all rows
for row in rows:
  print("Data row = (%s, %s, %s)" %(str(row[0]), str(row[1]), str(row[2])))

# Cleanup
conn.commit()
cursor.close()
conn.close()
print("Done.")