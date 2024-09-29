package com.Lab1;

import com.Lab1.Abstract.*;

import com.Lab1.Interface.ExecutorForInterface;
import com.Lab1.Interface.InComputer;
import com.Lab1.Interface.InLaptop;
import com.Lab1.Interface.InPersonal;
import com.Lab1.Regular.Computers;
import com.Lab1.Regular.Executor;
import com.Lab1.Regular.Laptop;
import com.Lab1.Regular.Personal;
import org.junit.jupiter.api.Test;


public class ExecutorTest {
    Computers[] computers = new Computers[15];

    AComputer[] abstractComputers = new AComputer[15];

    InComputer[] interfaceComputers = new InComputer[15];
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
        computers[5] = new Personal("Personal-3",
                "Intel i7", "Windows",
                103, "User3");
        computers[6] = new Laptop("Laptop-4",
                "AMD Ryzen 5", "Linux",
                204, "04.04.2014");
        computers[7] = new Personal("Personal-4",
                "Intel i5", "Linux",
                104, "User4");
        computers[8] = new Laptop("Laptop-5",
                "Intel i7", "macOS",
                205, "05.05.2015");
        computers[9] = new Laptop("Laptop-6",
                "Intel i7", "Windows",
                206, "06.06.2016");
    }

    void setUpAbstract() {
        abstractComputers[0] = new APersonal("Personal-1",
                "Intel i7", "Windows",
                101, "User1");
        abstractComputers[1] = new ALaptop("Laptop-1",
                "AMD Ryzen 5", "Linux",
                201, "01.01.2010");
        abstractComputers[2] = new APersonal("Personal-2",
                "Intel i5", "Linux",
                102, "User3");
        abstractComputers[3] = new ALaptop("Laptop-2",
                "Intel i7", "macOS",
                202, "02.02.2012");
        abstractComputers[4] = new ALaptop("Laptop-3",
                "Intel i7", "Windows",
                203, "03.03.2013");
        abstractComputers[5] = new APersonal("Personal-3",
                "Intel i7", "Windows",
                103, "User3");
        abstractComputers[6] = new ALaptop("Laptop-4",
                "AMD Ryzen 5", "Linux",
                204, "04.04.2014");
        abstractComputers[7] = new APersonal("Personal-4",
                "Intel i5", "Linux",
                104, "User4");
        abstractComputers[8] = new ALaptop("Laptop-5",
                "Intel i7", "macOS",
                205, "05.05.2015");
        abstractComputers[9] = new ALaptop("Laptop-6",
                "Intel i7", "Windows",
                206, "06.06.2016");
    }


    void setUpInterface() {
        interfaceComputers[0] = new InPersonal("Personal-1",
                "Intel i7", "Windows",
                101, "User1");
        interfaceComputers[1] = new InLaptop("Laptop-1",
                "AMD Ryzen 5", "Linux",
                201, "01.01.2010");
        interfaceComputers[2] = new InPersonal("Personal-2",
                "Intel i5", "Linux",
                102, "User3");
        interfaceComputers[3] = new InLaptop("Laptop-2",
                "Intel i7", "macOS",
                202, "02.02.2012");
        interfaceComputers[4] = new InLaptop("Laptop-3",
                "Intel i7", "Windows",
                203, "03.03.2013");
        interfaceComputers[5] = new InPersonal("Personal-3",
                "Intel i7", "Windows",
                103, "User3");
        interfaceComputers[6] = new InLaptop("Laptop-4",
                "AMD Ryzen 5", "Linux",
                204, "04.04.2014");
        interfaceComputers[7] = new InPersonal("Personal-4",
                "Intel i5", "Linux",
                104, "User4");
        interfaceComputers[8] = new InLaptop("Laptop-5",
                "Intel i7", "macOS",
                205, "05.05.2015");
        interfaceComputers[9] = new InLaptop("Laptop-6",
                "Intel i7", "Windows",
                206, "06.06.2016");
    }

    @Test
    public void ComputerTest() {
        setUpComputer();

        System.out.println("\nComputerTest:");

        Executor.displayByProcessor(computers, "Intel i7");

        Executor.countWindowsComputers(computers);
    }

    @Test
    public void AbstractComputerTest() {
        setUpAbstract();

        System.out.println("\nAbstract ComputerTest:");

        ExecutorForAbstract.displayByProcessor(abstractComputers, "Intel i7");

        ExecutorForAbstract.countWindowsComputers(abstractComputers);
    }

    @Test
    public void InterfaceComputerTest() {
        setUpInterface();
        
        System.out.println("\nInterface ComputerTest:");

        ExecutorForInterface.displayByProcessor(interfaceComputers, "Intel i7");

        ExecutorForInterface.countWindowsComputers(interfaceComputers);
    }
}