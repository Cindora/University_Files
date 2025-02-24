import java.util.Scanner;

class BytovayaTekhnika {
    private String name;
    private double price;

    public BytovayaTekhnika(String name, double price) {
        this.name = name;
        this.price = price;
    }

    public String getName() {
        return name;
    }

    public double getPrice() {
        return price;
    }

    public void applyDiscount(double discountPercentage) {
        price -= price * (discountPercentage / 100);
    }

    @Override
    public String toString() {
        return "Бытовая техника: " + name + ", Цена: " + price;
    }
}

class KukhonnayaPlita extends BytovayaTekhnika {
    private boolean isGas;

    public KukhonnayaPlita(String name, double price, boolean isGas) {
        super(name, price);
        this.isGas = isGas;
    }

    public boolean isGas() {
        return isGas;
    }

    @Override
    public String toString() {
        return "Кухонная плита: " + getName() + ", Цена: " + getPrice() + ", Газовая: " + (isGas ? "Да" : "Нет");
    }
}

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Создаем массив бытовой техники
        BytovayaTekhnika[] tekhnika = new BytovayaTekhnika[5];
        tekhnika[0] = new KukhonnayaPlita("Газовая плита 1", 15000, true);
        tekhnika[1] = new KukhonnayaPlita("Электрическая плита 1", 12000, false);
        tekhnika[2] = new KukhonnayaPlita("Газовая плита 2", 16000, true);
        tekhnika[3] = new KukhonnayaPlita("Электрическая плита 2", 14000, false);
        tekhnika[4] = new KukhonnayaPlita("Газовая плита 3", 17000, true);

        // Запрашиваем процент скидки
        System.out.print("Введите процент скидки для газовых плит: ");
        double discountPercentage = scanner.nextDouble();

        // Применяем скидку для газовых плит
        for (BytovayaTekhnika item : tekhnika) {
            if (item instanceof KukhonnayaPlita && ((KukhonnayaPlita) item).isGas()) {
                item.applyDiscount(discountPercentage);
            }
        }

        // Выводим информацию о бытовой технике
        for (BytovayaTekhnika item : tekhnika) {
            System.out.println(item);
        }

        scanner.close();
    }
}