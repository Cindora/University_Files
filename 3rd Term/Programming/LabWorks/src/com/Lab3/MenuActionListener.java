package com.Lab3;

import javax.swing.*;
import java.awt.event.*;

public class MenuActionListener implements ActionListener {
    private JLabel label;

    public MenuActionListener(JLabel label) {
        this.label = label;
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        String menuItemName = e.getActionCommand();
        // Обновляем текст метки
        label.setText(menuItemName);
        // Выводим в консоль
        System.out.println("Вы выбрали: " + menuItemName);
    }
}
