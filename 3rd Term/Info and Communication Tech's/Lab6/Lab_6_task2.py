import pandas as pd
import matplotlib.pyplot as plt

# Загрузка данных с третьего листа
file_path = 'Lab_3.xlsx'

df = pd.read_excel(file_path, sheet_name=0)

# 1. Количество студентов 3 степени обученности
count_3rd_degree = df[df['Степень обученности'] == '3 степень обученности'].shape[0]
print("\nКоличество студентов 3 степени обученности:", count_3rd_degree)

# 2. Средняя оценка больше 4
high_average_scores = df[df['Средняя оценка'] > 4]
print("\nСредняя оценка больше 4:")
print(high_average_scores)
input()
