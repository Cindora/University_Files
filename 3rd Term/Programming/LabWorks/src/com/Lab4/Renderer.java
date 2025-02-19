package com.Lab4;

import javax.swing.*;
import javax.swing.table.DefaultTableCellRenderer;
import java.awt.*;

public class Renderer extends DefaultTableCellRenderer {

    @Override
    public Component getTableCellRendererComponent(JTable table, Object value,
                                                   boolean isSelected, boolean hasFocus, int row, int column) {
        Component cell = super.getTableCellRendererComponent(table, value, isSelected, hasFocus, row, column);


        if (column == 0 && value.equals("Ноутбук")) {
            cell.setBackground(Color.GREEN);
        } else if (column == 0 && value.equals("Персональный")) {
            cell.setBackground(Color.YELLOW);
        } else if (column == 0) {
            cell.setBackground(Color.RED);
        }
        else {
            cell.setBackground(Color.WHITE);
        }

        if (column == 2) {
            ((JLabel) cell).setHorizontalAlignment(SwingConstants.RIGHT);
        } else {
            ((JLabel) cell).setHorizontalAlignment(SwingConstants.CENTER);
        }

        return cell;
    }
}