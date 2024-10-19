package com.Lab4;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

class ComputerManager {
    private List<Computer> computers;

    public ComputerManager() {
        computers = new ArrayList<>();
    }

    public void addComputer(Computer computer) {
        computers.add(computer);
    }

    public void sortByName() {
        computers.sort(Comparator.comparing(Computer::getName));
    }

    public void sortBySerial() {
        computers.sort(Comparator.comparing(Computer::getSerialNumber));
    }

    public List<Computer> getComputers() {
        return computers;
    }
}

