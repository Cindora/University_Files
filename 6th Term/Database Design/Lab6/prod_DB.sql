
CREATE TABLE prod.Size (
                Size VARCHAR(15) NOT NULL,
                CONSTRAINT size_pk PRIMARY KEY (Size)
);


CREATE SEQUENCE prod.inventory_book_inventory_id_seq;

CREATE TABLE prod.Inventory_book (
                Inventory_ID INTEGER NOT NULL DEFAULT nextval('prod.inventory_book_inventory_id_seq'),
                Inventory_date DATE NOT NULL,
                Akt_number INTEGER NOT NULL,
                Actual_balance INTEGER DEFAULT 0 NOT NULL,
                CONSTRAINT inventory_book_pk PRIMARY KEY (Inventory_ID)
);


ALTER SEQUENCE prod.inventory_book_inventory_id_seq OWNED BY prod.Inventory_book.Inventory_ID;

CREATE TABLE prod.Group_prod (
                Group_code INTEGER NOT NULL,
                Group_name VARCHAR(20) NOT NULL,
                CONSTRAINT group_prod_pk PRIMARY KEY (Group_code)
);


CREATE TABLE prod.Prod (
                Article INTEGER NOT NULL,
                Name VARCHAR NOT NULL,
                Unit VARCHAR(15) DEFAULT mm NOT NULL,
                Group_code INTEGER NOT NULL,
                Size VARCHAR(15) NOT NULL,
                CONSTRAINT prod_pk PRIMARY KEY (Article)
);


CREATE SEQUENCE prod.assortment_assortment_id_seq;

CREATE TABLE prod.Assortment (
                Assortment_ID INTEGER NOT NULL DEFAULT nextval('prod.assortment_assortment_id_seq'),
                Inventory_ID INTEGER NOT NULL,
                Sort VARCHAR(20) NOT NULL,
                Actual_quantity INTEGER NOT NULL,
                Size VARCHAR(15) NOT NULL,
                Article INTEGER NOT NULL,
                CONSTRAINT assortment_pk PRIMARY KEY (Assortment_ID)
);


ALTER SEQUENCE prod.assortment_assortment_id_seq OWNED BY prod.Assortment.Assortment_ID;

CREATE SEQUENCE prod.book_leftovers_leftover_id_seq;

CREATE TABLE prod.Book_leftovers (
                Leftover_ID INTEGER NOT NULL DEFAULT nextval('prod.book_leftovers_leftover_id_seq'),
                Sort VARCHAR(20) NOT NULL,
                Quantity_balances INTEGER NOT NULL,
                Size VARCHAR(15) NOT NULL,
                Room_code INTEGER NOT NULL,
                CONSTRAINT book_leftovers_pk PRIMARY KEY (Leftover_ID)
);


ALTER SEQUENCE prod.book_leftovers_leftover_id_seq OWNED BY prod.Book_leftovers.Leftover_ID;

ALTER TABLE prod.Assortment ADD CONSTRAINT size_assortment_fk
FOREIGN KEY (Size)
REFERENCES prod.Size (Size)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;

ALTER TABLE prod.Book_leftovers ADD CONSTRAINT size_book_leftovers_fk
FOREIGN KEY (Size)
REFERENCES prod.Size (Size)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;

ALTER TABLE prod.Prod ADD CONSTRAINT size_prod_fk
FOREIGN KEY (Size)
REFERENCES prod.Size (Size)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;

ALTER TABLE prod.Assortment ADD CONSTRAINT inventory_book_assortment_fk
FOREIGN KEY (Inventory_ID)
REFERENCES prod.Inventory_book (Inventory_ID)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;

ALTER TABLE prod.Prod ADD CONSTRAINT group_code_prod_fk
FOREIGN KEY (Group_code)
REFERENCES prod.Group_prod (Group_code)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;

ALTER TABLE prod.Book_leftovers ADD CONSTRAINT prod_book_leftovers_fk
FOREIGN KEY (Room_code)
REFERENCES prod.Prod (Article)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;

ALTER TABLE prod.Assortment ADD CONSTRAINT prod_assortment_fk
FOREIGN KEY (Article)
REFERENCES prod.Prod (Article)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;
