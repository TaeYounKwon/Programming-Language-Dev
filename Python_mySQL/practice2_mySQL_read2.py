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

SQL = 'SELECT * FROM employees'
df = pd.read_sql(SQL, db)
# print(type(df))
# # <class 'pandas.core.frame.DataFrame'>
# print(df)
#     employeeNumber   lastName firstName  ... officeCode reportsTo              jobTitle
# 0             1002     Murphy     Diane  ...          1       NaN             President
# 1             1056  Patterson      Mary  ...          1    1002.0              VP Sales
# 2             1076   Firrelli      Jeff  ...          1    1002.0          VP Marketing
# 3             1088  Patterson   William  ...          6    1056.0  Sales Manager (APAC)
# 4             1102     Bondur    Gerard  ...          4    1056.0   Sale Manager (EMEA)
# 5             1143        Bow   Anthony  ...          1    1056.0    Sales Manager (NA)
# 6             1165   Jennings    Leslie  ...          1    1143.0             Sales Rep
# 7             1166   Thompson    Leslie  ...          1    1143.0             Sales Rep
# 8             1188   Firrelli     Julie  ...          2    1143.0             Sales Rep
# 9             1216  Patterson     Steve  ...          2    1143.0             Sales Rep
# 10            1286      Tseng  Foon Yue  ...          3    1143.0             Sales Rep
# 11            1323     Vanauf    George  ...          3    1143.0             Sales Rep
# 12            1337     Bondur      Loui  ...          4    1102.0             Sales Rep
# 13            1370  Hernandez    Gerard  ...          4    1102.0             Sales Rep
# 14            1401   Castillo    Pamela  ...          4    1102.0             Sales Rep
# 15            1501       Bott     Larry  ...          7    1102.0             Sales Rep
# 16            1504      Jones     Barry  ...          7    1102.0             Sales Rep
# 17            1611     Fixter      Andy  ...          6    1088.0             Sales Rep
# 18            1612      Marsh     Peter  ...          6    1088.0             Sales Rep
# 19            1619       King       Tom  ...          6    1088.0             Sales Rep
# 20            1621      Nishi      Mami  ...          5    1056.0             Sales Rep
# 21            1625       Kato   Yoshimi  ...          5    1621.0             Sales Rep
# 22            1702     Gerard    Martin  ...          4    1102.0             Sales Rep
