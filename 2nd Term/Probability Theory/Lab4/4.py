import numpy as np
from scipy.stats import skew, kurtosis, t
import matplotlib.pyplot as plt

# Исходные данные выборки
data = [
    0.424,
    1.064,
    1.226,
    1.471,
    5.167,
    5.912,
    8.979,
    9.623,
    10.29,
    10.698,
    12.551,
    14.064,
    15.159,
    18.071,
    19.763,
    22.958,
    30.906,
    34.302,
    40.692,
    42.339
]

### 1. Преобразовать выборку в вариационный ряд

data = np.sort(data)

### 2. Вычислить точечные оценки МО, дисперсии, СКО, коэффициентов вариации, асимметрии и эксцесса

# Число элементов в выборке
n = len(data)

# Математическое ожидание
mean = np.mean(data)

# Дисперсия (смещённая)
variance = np.var(data, ddof=1)

# Среднеквадратическое отклонение
std_dev = np.sqrt(variance)

# Коэффициент вариации
coef_variation = (std_dev / mean) * 100

# Асимметрия
skewness = skew(data, bias=False)

# Эксцесс
kurt = kurtosis(data, bias=False)

print(f"Математическое ожидание: {mean:.6f}")
print(f"Дисперсия: {variance:.6f}")
print(f"Среднеквадратическое отклонение: {std_dev:.6f}")
print(f"Коэффициент вариации: {coef_variation:.2f}%")
print(f"Асимметрия: {skewness:.6f}")
print(f"Эксцесс: {kurt:.6f}")

### 3. Вычислить точечные оценки медианы и размаха

# Медиана
median = np.median(data)

# Размах
range_value = np.max(data) - np.min(data)

print(f"Медиана: {median:.6f}")
print(f"Размах: {range_value:.6f}")

### 4. Построить точечную оценку функции распределения

# Количество элементов в выборке
n = len(data)

# Вычисление Эмпирической функции распределения
F_n = np.arange(1, n + 1) / n

# Построение графика
plt.step(data, F_n, where='post', label='ЭФР')
plt.scatter(data, F_n, color='red', zorder=5)

# Оформление графика
plt.xlabel('x')
plt.ylabel('F(x)')
plt.title('Эмпирическая функция распределения')
plt.grid(True)
plt.legend()
plt.show()

### 5. Построить интервальные оценки для МО СВ при неизвестной дисперсии и для дисперсии с надежностью 0.9 

n = len(data) # Размер выборки

mean = np.mean(data) # Выборочное среднее
std = np.std(data, ddof=1) # Выборочное стандартное отклонение
confidence_level = 0.9 # Уровень доверия
t_value = t.ppf((1 + confidence_level) / 2, df=n - 1) # Критическое значение t-распределения
SE = std_dev / np.sqrt(n) # Размер стандартной ошибки

# Вычисляем доверительный интервал
margin_of_error = t_value * SE
lower_bound = mean - margin_of_error
upper_bound = mean + margin_of_error

print("Доверительный интервал для математического ожидания с уровнем доверия {}:".format(confidence_level))
print("Нижняя граница:", lower_bound)
print("Верхняя граница:", upper_bound)
