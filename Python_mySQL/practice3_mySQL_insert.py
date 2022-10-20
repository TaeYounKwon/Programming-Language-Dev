import pymysql
import pandas as pd
import mysql.connector
from mysql.connector import errorcode

#Get it from Azure devop/ mySQL
host_name = '###'
username = '###'
password = '###'
database_name = '###'

db = pymysql.connect(
    host=host_name,
    port=3306,
    user=username,
    passwd=password,
    db=database_name,
    charset='utf8',
    ssl={"fake_flag_to_enable_tls":True}
)

SQL = "INSERT INTO tempTable(user_name,phone) VALUES('Oh my girl','010-1111-1111')"
print(SQL)
cursor = db.cursor()
cursor.execute(SQL)
cursor.close()


SQL = 'SELECT * FROM tempTable'
df = pd.read_sql(SQL, db)
print(df)
#    id   user_name          phone
# 0   1  Oh my girl  010-1111-1111