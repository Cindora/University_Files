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
