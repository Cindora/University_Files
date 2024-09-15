package com.Lab1;

import com.Lab1.Abstract.*;

import org.junit.jupiter.api.Test;


public class ExecutorTest {
    Computers[] computers = new Computers[10];

    AComputer[] abstractComputers = new AComputer[10];
    void setUpComputer() {
        computers[0] = new Personal("Personal-1",
                "Intel i7", "Windows",
                101, "User1");
        computers[1] = new Laptop("Laptop-1",
                "AMD Ryzen 5", "Linux",
                201, "01.01.2010");
        computers[2] = new Personal("Personal-2",
                "Intel i5", "Linux",
                102, "User3");
        computers[3] = new Laptop("Laptop-2",
                "Intel i7", "macOS",
                202, "02.02.2012");
        computers[4] = new Laptop("Laptop-3",
                "Intel i7", "Windows",
                203, "03.03.2013");
    }

    void setUpAbstractAndInterface() {
        abstractComputers[4] = new APersonal("Personal-1",
                "Intel i7", "Windows",
                101, "User1");
        abstractComputers[3] = new ALaptop("Laptop-1",
                "AMD Ryzen 5", "Linux",
                201, "01.01.2010");
        abstractComputers[2] = new APersonal("Personal-2",
                "Intel i5", "Linux",
                102, "User3");
        abstractComputers[1] = new ALaptop("Laptop-2",
                "Intel i7", "macOS",
                202, "02.02.2012");
        abstractComputers[0] = new ALaptop("Laptop-3",
                "Intel i7", "Windows",
                203, "03.03.2013");
    }

    @Test
    public void ComputerTest() {
        setUpComputer();

        System.out.println("\nComputerTest:");

        Executor.displayByProcessor(computers, "Intel i7");

        Executor.countWindowsComputers(computers);
    }

    @Test
    public void AbstractAndInterfaceComputerTest() {
        setUpAbstractAndInterface();

        System.out.println("\nAbstract And Interface ComputerTest:");

        ExecutorForAbstract.displayByProcessor(abstractComputers, "Intel i7");

        ExecutorForAbstract.countWindowsComputers(abstractComputers);
    }
}