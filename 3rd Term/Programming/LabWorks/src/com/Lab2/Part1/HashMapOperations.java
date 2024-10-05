package com.Lab2.Part1;

import java.util.HashMap;
import java.util.Map;

public class HashMapOperations {
    private final Map<String, Integer> countMap;

    public HashMapOperations() {
        countMap = new HashMap<>();
        countMap.put("positive", 0);
        countMap.put("negative", 0);
        countMap.put("zero", 0);
    }

    /**
     * Добавить в хэш-таблицу информацию о данном числе.
     *
     */
    public void addNumber(int number) {
        if (number > 0) {
            countMap.put("positive", countMap.get("positive") + 1);
        } else if (number < 0) {
            countMap.put("negative", countMap.get("negative") + 1);
        } else {
            countMap.put("zero", countMap.get("zero") + 1);
        }
    }



    /**
     * Получить строку с результатами хэш-таблицы.
     *
     */
    public String getFormattedCounts() {
        return "Положительные числа: " + countMap.get("positive") + "\n" +
                "Отрицательные числа: " + countMap.get("negative") + "\n" +
                "Нулевые значения: " + countMap.get("zero") + "\n";
    }
}

