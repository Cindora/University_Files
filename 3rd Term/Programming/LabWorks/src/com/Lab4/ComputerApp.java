package com.Lab4;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class ComputerApp {
    private ComputerManager manager = new ComputerManager();
    private DefaultTableModel tableModel = new DefaultTableModel() {
        @Override
        public Class<?> getColumnClass(int columnIndex) {
            if (columnIndex == 4) {
                return Boolean.class;
            }
            return String.class;
        }
    };

    public ComputerApp() {
        setupInterface();
    }

    private void setupInterface() {
        JFrame frame = new JFrame("Computer Manager");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLayout(new BorderLayout());

        // Панель для ввода данных
        JPanel inputPanel = new JPanel();
        inputPanel.setLayout(new GridLayout(7, 2));

        JLabel typeLabel = new JLabel("Тип компьютера:");
        JTextField typeField = new JTextField();
        JLabel nameLabel = new JLabel("Название:");
        JTextField nameField = new JTextField();
        JLabel processorLabel = new JLabel("Процессор:");
        JTextField processorField = new JTextField();
        JLabel serialNumberLabel = new JLabel("Серийный номер:");
        JTextField serialNumberField = new JTextField();
        JLabel internetLabel = new JLabel("Доступ в интернет:");
        JCheckBox internetCheckBox = new JCheckBox();

        inputPanel.add(typeLabel);
        inputPanel.add(typeField);
        inputPanel.add(nameLabel);
        inputPanel.add(nameField);
        inputPanel.add(processorLabel);
        inputPanel.add(processorField);
        inputPanel.add(serialNumberLabel);
        inputPanel.add(serialNumberField);
        inputPanel.add(internetLabel);
        inputPanel.add(internetCheckBox);
        inputPanel.setBorder(BorderFactory.createEmptyBorder(5, 5, 5, 5));
        //

        // Таблица для отображения данных
        String[] columns = {"Тип", "Название", "Процессор", "Серийный номер", "Доступ в интернет"};
        tableModel.setColumnIdentifiers(columns);

        JTable table = new JTable(tableModel);

        JScrollPane scrollPane = new JScrollPane(table);
        scrollPane.setBorder(BorderFactory.createEmptyBorder(5, 5, 5, 5));
        //

        // Пример данных
        manager.addComputer(new Computer("Персональный", "CompOne",
                "Intel i7", "1205", false));
        manager.addComputer(new Computer("Ноутбук", "LapOne",
                "Intel i5", "5412", true));
        manager.addComputer(new Computer("Ноутбук", "LapTwo",
                "AMD Ryzen 6", "1252", true));
        manager.addComputer(new Computer("Персональный", "CompTwo",
                "Intel i5", "3047", false));

        for (Computer computer : manager.getComputers()) {
            tableModel.addRow(new Object[]{computer.getType(), computer.getName(),
                    computer.getProcessor(), computer.getSerialNumber(), computer.hasInternetAccess()});
        }
        //

        // Панель для кнопок
        JPanel buttonPanel = new JPanel();
        buttonPanel.setLayout(new FlowLayout());

        JButton addButton = new JButton("Добавить");
        buttonPanel.add(addButton);

        JButton sortByNameButton = new JButton("Сортировать по названию");
        buttonPanel.add(sortByNameButton);

        JButton sortBySerialButton = new JButton("Сортировать по серийному номеру");
        buttonPanel.add(sortBySerialButton);

        addButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String type = typeField.getText();
                String name = nameField.getText();
                String processor = processorField.getText();
                String serialNumber = serialNumberField.getText();
                boolean internetAccess = internetCheckBox.isSelected();

                if (!(type.isEmpty() || name.isEmpty() || processor.isEmpty() || serialNumber.isEmpty())) {
                    Computer computer = new Computer(type, name, processor, serialNumber, internetAccess);
                    manager.addComputer(computer);

                    Object[] currRow = new Object[] {
                                computer.getType(), computer.getName(), computer.getProcessor(),
                            computer.getSerialNumber(), computer.hasInternetAccess() };
                    tableModel.addRow(currRow);

                    // Очистить поля после добавления
                    typeField.setText("");
                    nameField.setText("");
                    processorField.setText("");
                    serialNumberField.setText("");
                    internetCheckBox.setSelected(false);
                } else {
                    JOptionPane.showMessageDialog(frame, "Заполните все поля",
                            "Ошибка", JOptionPane.ERROR_MESSAGE);
                }
            }
        });

        sortByNameButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                tableModel.setRowCount(0); // Очистить таблицу

                manager.sortByName();
                for (Computer computer : manager.getComputers()) {
                    tableModel.addRow(new Object[] {
                            computer.getType(), computer.getName(), computer.getProcessor(),
                            computer.getSerialNumber(), computer.hasInternetAccess()
                    } );
                }
            }
        });

        sortBySerialButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                tableModel.setRowCount(0); // Очистить таблицу

                manager.sortBySerial();
                for (Computer computer : manager.getComputers()) {
                    tableModel.addRow(new Object[] {
                            computer.getType(), computer.getName(), computer.getProcessor(),
                            computer.getSerialNumber(), computer.hasInternetAccess()
                    } );
                }
            }
        });
        //

        frame.add(scrollPane, BorderLayout.CENTER);
        frame.add(inputPanel, BorderLayout.NORTH);
        frame.add(buttonPanel, BorderLayout.SOUTH);

        frame.setSize(700, 400);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(ComputerApp::new);
    }
}
