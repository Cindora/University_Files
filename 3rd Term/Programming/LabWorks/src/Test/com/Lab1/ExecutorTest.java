package com.Lab1;

import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeEach;

import static com.Lab1.Executor.countWindowsComputers;
import static com.Lab1.Executor.displayByProcessor;

public class ExecutorTest {
    Computers[] computers = new Computers[10];

    @BeforeEach
    void setUp() {
        computers[0] = new Personal("Personal-1",
                "Intel i7", "Windows",
                101, "User1");
        computers[1] = new Laptop("Laptop-1",
                "AMD Ryzen 5", "Linux",
                201, "01.01.2010");
        computers[2] = new Personal("Personal-2",
                "Intel i5", "Windows",
                102, "User3");
        computers[3] = new Laptop("Laptop-2",
                "Intel i7", "macOS",
                202, "02.02.2012");
    }

    @Test
    public void executorTest() {

        displayByProcessor(computers, "Intel i7");

        countWindowsComputers(computers);
    }
}