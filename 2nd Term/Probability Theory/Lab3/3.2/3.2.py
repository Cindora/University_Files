import numpy as np
import matplotlib.pyplot as plt

# Функция плотности вероятности
def f(x):
    if x <= 0:
        return 0
    elif 0 < x <= 1:
        return x**2
    else:
        return 1

# Значения X для построения графика
x_values = np.linspace(-0.5, 1.5, 1000)
y_values = [f(x) for x in x_values]

# Построение графика
plt.plot(x_values, y_values, label='f(x)')
plt.xlabel('X')
plt.ylabel('Плотность вероятности')
plt.title('Плотность вероятности X')
plt.legend()
plt.grid(True)
plt.show()


# Метод Монте-Карло
def generate_random_variable(): # Вычисление случайного значения
    return np.random.uniform(0, 1)
    
def is_in_interval(x): # Определить, что число входит в искомый интервал
    return 0.25 <= x <= 0.75

def monte_carlo(trials):
    count_of_3_in_interval = 0
    for _ in range(trials):
        sample = [generate_random_variable() for _ in range(4)] # Создание списка из 4-х случайных значений
        count_in_interval = sum(is_in_interval(x) for x in sample) # Подсчёт количества значений, вошедших в интервал
        if count_in_interval == 3:
            count_of_3_in_interval += 1
    return count_of_3_in_interval / trials

# Количество запусков
n_samples = 100000

probability = monte_carlo(n_samples)
print(f"Вероятность(Монте-Карло): {probability:.6f}")
