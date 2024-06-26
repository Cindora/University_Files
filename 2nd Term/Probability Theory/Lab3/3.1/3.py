import numpy as np
import matplotlib.pyplot as plt
from scipy.stats import norm

# Параметры нормального распределения
m = 4
s = 2

# Вероятность для интервала -3 < X < 3
prob_interval1 = norm.cdf(3, loc=m, scale=s) - norm.cdf(-3, loc=m, scale=s)

# Вероятность для интервала 0 < X < 5
prob_interval2 = norm.cdf(5, loc=m, scale=s) - norm.cdf(0, loc=m, scale=s)

print("Вероятность для интервала -3 < X < 3:", prob_interval1)
print("Вероятность для интервала 0 < X < 5:", prob_interval2)

# Создаем графики для обоих интервалов
x = np.linspace(-5, 10, 1000)

plt.figure(figsize=(12, 6))

# График для интервала -3 < X < 3
plt.subplot(1, 2, 1)
plt.plot(x, norm.pdf(x, loc=m, scale=s), label='N(4, 2)')
plt.fill_between(x, 0, norm.pdf(x, loc=m, scale=s), where=(x > -3) & (x < 3), alpha=0.3, color='g')
plt.title('Плотность вероятности для интервала -3 < X < 3')
plt.xlabel('X')
plt.ylabel('Плотность вероятности')
plt.legend()
plt.grid(True)

# График для интервала 0 < X < 5
plt.subplot(1, 2, 2)
plt.plot(x, norm.pdf(x, loc=m, scale=s), label='N(4, 2)')
plt.fill_between(x, 0, norm.pdf(x, loc=m, scale=s), where=(x > 0) & (x < 5), alpha=0.3, color='b')
plt.title('Плотность вероятности для интервала 0 < X < 5')
plt.xlabel('X')
plt.legend()
plt.grid(True)

# Показываем оба графика
plt.tight_layout()
plt.show()

# Метод Монте-Карло
n_samples = 1000000

# Генерация выборок из нормального распределения
samples = np.random.normal(m, s, n_samples)

# Подсчет вероятности для интервала -3 < X < 3
prob_1 = np.mean((-3 < samples) & (samples < 3))

# Подсчет вероятности для интервала 0 < X < 5
prob_2 = np.mean((0 < samples) & (samples < 5))

print("Метод Монте-Карло:")
print("Вероятность для интервала -3 < X < 3:", prob_1)
print("Вероятность для интервала 0 < X < 5:", prob_2)
