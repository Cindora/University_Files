import tkinter as tk

# Создание окна приложения
root = tk.Tk()
root.title("Canvas Drawing")

# Задание размеров холста
canvas_width = 500
canvas_height = 500
canvas = tk.Canvas(root, width=canvas_width, height=canvas_height, bg="white")
canvas.pack()

# Рисование на холсте: солнце, облака и дерево

# Солнце
canvas.create_oval(350, 50, 450, 150, fill="yellow", outline="orange", width=3)

# Облака
canvas.create_oval(100, 50, 200, 100, fill="lightblue", outline="blue", width=2)
canvas.create_oval(150, 30, 250, 80, fill="lightblue", outline="blue", width=2)

# Дерево: ствол и крона
canvas.create_rectangle(200, 300, 240, 450, fill="brown")
canvas.create_oval(150, 200, 290, 350, fill="green", outline="darkgreen")

# Трава
for x in range(0, canvas_width, 20):
    canvas.create_line(x, 480, x + 10, 450, fill="green", width=2)

root.title('Nature')
root.geometry(f"{canvas_width}x{canvas_height}")

# Запуск основного цикла
root.mainloop()
