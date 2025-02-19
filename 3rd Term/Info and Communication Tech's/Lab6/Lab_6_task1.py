import pandas as pd
import matplotlib.pyplot as plt


# Загрузка данных с третьего листа
file_path = 'Lab_3.xlsx'
df = pd.read_excel(file_path, sheet_name=2)

# Преобразуем столбец с оценками, заменив "н/я" на NaN для удобства расчетов
df['Оценка'] = pd.to_numeric(df['Оценка'], errors='coerce')

# 1. Средняя оценка (без н/я)
average_grade = df['Оценка'].mean()
print("Средняя оценка:", average_grade)

# 2. Колчество студентов, не сдавших экзамен
count_not_pass = df['Оценка'].isna().sum() + df[df['Оценка'] < 60].shape[0]
print("Колчество студентов, не сдавших экзамен:", count_not_pass)

# 3. Гистограмма с фамилиями и оценками
plt.figure(figsize=(10, 6))
plt.bar(df['ФИО'], df['Оценка'], color='skyblue')
plt.xlabel('ФИО')
plt.ylabel('Оценка')
plt.title('Гистограмма оценок по фамилиям')
plt.xticks(rotation=90)
plt.tight_layout()
plt.show()
