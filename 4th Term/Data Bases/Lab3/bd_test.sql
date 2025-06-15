
CREATE TABLE prod.Customer (
                Buyer_Code INTEGER NOT NULL,
                FullName VARCHAR(50) NOT NULL,
                EMail VARCHAR(30) NOT NULL,
                Source VARCHAR(30) NOT NULL,
                CONSTRAINT customer_pk PRIMARY KEY (Buyer_Code)
);


CREATE TABLE prod.Type (
                Type_Code INTEGER NOT NULL,
                Type_Name VARCHAR(50) NOT NULL,
                CONSTRAINT type_pk PRIMARY KEY (Type_Code)
);


CREATE TABLE prod.Products (
                Prod_Code INTEGER NOT NULL,
                Prod_Name VARCHAR(50) NOT NULL,
                Prod_Type_Code INTEGER NOT NULL,
                CONSTRAINT products_pk PRIMARY KEY (Prod_Code)
);


CREATE SEQUENCE prod.sale_sale_id_seq;

CREATE TABLE prod.Sale (
                Sale_ID INTEGER NOT NULL DEFAULT nextval('prod.sale_sale_id_seq'),
                ID INTEGER NOT NULL,
                Price NUMERIC(10,2) NOT NULL,
                Count INTEGER NOT NULL,
                Date_of_Sale DATE NOT NULL,
                Sale_Prod_Code INTEGER NOT NULL,
                Sale_Buyer_Code INTEGER NOT NULL,
                CONSTRAINT sale_pk PRIMARY KEY (Sale_ID)
);
COMMENT ON COLUMN prod.Sale.Sale_ID IS 'Идентификатор продажи';


ALTER SEQUENCE prod.sale_sale_id_seq OWNED BY prod.Sale.Sale_ID;

ALTER TABLE prod.Sale ADD CONSTRAINT customer_sale_fk
FOREIGN KEY (Sale_Buyer_Code)
REFERENCES prod.Customer (Buyer_Code)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;

ALTER TABLE prod.Products ADD CONSTRAINT type_products_fk
FOREIGN KEY (Prod_Type_Code)
REFERENCES prod.Type (Type_Code)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;

ALTER TABLE prod.Sale ADD CONSTRAINT products_sale_fk
FOREIGN KEY (Sale_Prod_Code)
REFERENCES prod.Products (Prod_Code)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;
