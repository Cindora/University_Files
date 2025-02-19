import pandas as pd
import matplotlib.pyplot as plt

# 1 Загрузка данных до столбца "Черчение"
file_path = 'Lab_3.xlsx'
df = pd.read_excel(file_path, usecols=range(13))
df = df.replace("н/я", 0)

# 2 Добавление столбцов "Итоговые баллы" и "Средняя оценка"

df['Итоговые баллы'] = df.iloc[:, 3:8].mean(axis=1)
df['Средняя оценка'] = df.iloc[:, 8:13].mean(axis=1)

# 3 Диаграмма по столбцу "Средняя оценка"
plt.figure(figsize=(10, 6))
plt.plot(df['ФИО студента'], df['Средняя оценка'], marker='o', color='b')
plt.ylabel('Средняя оценка')
plt.title('Средняя оценка студентов')
plt.grid(True)
plt.xticks(rotation=90)
plt.tight_layout()
plt.show()
