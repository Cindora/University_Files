package com.Lab3;

import javax.swing.*;
import java.awt.*;

public class Frame extends JFrame {
    private JLabel label;

    public Frame(String title) {
        super(title);

        // Устанавливаем размеры и поведение по закрытию
        setSize(400, 300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null); // Центрируем окно

        // Создаем панель и метку
        JPanel panel = new JPanel();
        label = new JLabel("Выберите пункт меню");
        panel.add(label);
        add(panel, BorderLayout.CENTER);

        // Создаем меню
        JMenuBar menuBar = new JMenuBar();
        JMenu menu = new JMenu("Меню");

        // Создаем пункты меню
        String[] menuItems = {"Пункт 1", "Пункт 2", "Пункт 3", "Пункт 4"};
        for (String itemName : menuItems) {
            JMenuItem item = new JMenuItem(itemName);
            item.addActionListener(new MenuActionListener(label));
            menu.add(item);
        }

        menuBar.add(menu);
        setJMenuBar(menuBar);

        // Делаем окно видимым
        setVisible(true);
    }
}

