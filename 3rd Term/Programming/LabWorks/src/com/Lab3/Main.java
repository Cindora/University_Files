package com.Lab3;

public class Main {
    public static void main(String[] args) {
        javax.swing.SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                new Frame("Frame Lab_3");
            }
        });
    }
}
