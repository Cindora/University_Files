package com.Lab4;

class Computer {
    private String type;
    private String name;
    private String processor;
    private String serialNumber;
    private boolean internetAccess;

    public Computer(String type, String name, String processor, String serialNumber, boolean internetAccess) {
        this.type = type;
        this.name = name;
        this.processor = processor;
        this.serialNumber = serialNumber;
        this.internetAccess = internetAccess;
    }

    public String getType() {
        return type;
    }

    public String getName() {
        return name;
    }

    public String getProcessor() {
        return processor;
    }

    public String getSerialNumber() {
        return serialNumber;
    }

    public boolean hasInternetAccess() {
        return internetAccess;
    }
}



