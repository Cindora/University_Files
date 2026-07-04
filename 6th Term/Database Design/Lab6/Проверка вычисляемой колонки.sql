SELECT inventory_id, actual_balance,
 (SELECT SUM(actual_quantity) FROM assortment WHERE  
                    assortment.inventory_id=b.inventory_id) calc
FROM inventory_book b
