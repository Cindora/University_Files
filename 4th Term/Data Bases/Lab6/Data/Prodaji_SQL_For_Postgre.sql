
CREATE SEQUENCE spokup_pokup_kod_seq;

CREATE TABLE Spokup (
                Pokup_kod INTEGER NOT NULL DEFAULT nextval('spokup_pokup_kod_seq'),
                Pokup_name VARCHAR(50) NOT NULL,
                City VARCHAR(40) NOT NULL,
                Phone VARCHAR(30) NOT NULL,
                CONSTRAINT spokup_pk PRIMARY KEY (Pokup_kod)
);


ALTER SEQUENCE spokup_pokup_kod_seq OWNED BY Spokup.Pokup_kod;

CREATE SEQUENCE sprod_prod_kod_seq;

CREATE TABLE Sprod (
                Prod_kod INTEGER NOT NULL DEFAULT nextval('sprod_prod_kod_seq'),
                Prod_name VARCHAR(50) NOT NULL,
                Cena NUMERIC(10,2) NOT NULL,
                Vid VARCHAR(30) NOT NULL,
                CONSTRAINT sprod_pk PRIMARY KEY (Prod_kod)
);


ALTER SEQUENCE sprod_prod_kod_seq OWNED BY Sprod.Prod_kod;

CREATE SEQUENCE book_book_id_seq;

CREATE TABLE Book (
                Book_id INTEGER NOT NULL DEFAULT nextval('book_book_id_seq'),
                Ndoc INTEGER NOT NULL,
                Dat DATE NOT NULL,
                Pokup_kod INTEGER NOT NULL,
                CONSTRAINT book_pk PRIMARY KEY (Book_id)
);


ALTER SEQUENCE book_book_id_seq OWNED BY Book.Book_id;

CREATE SEQUENCE kart_kart_id_seq;

CREATE TABLE Kart (
                Kart_id INTEGER NOT NULL DEFAULT nextval('kart_kart_id_seq'),
                Kol NUMERIC(10,2) NOT NULL,
                Cena NUMERIC(12,2) NOT NULL,
                Prod_kod INTEGER NOT NULL,
                Book_id INTEGER NOT NULL,
                CONSTRAINT kart_pk PRIMARY KEY (Kart_id)
);


ALTER SEQUENCE kart_kart_id_seq OWNED BY Kart.Kart_id;

ALTER TABLE Book ADD CONSTRAINT spokup_book_fk
FOREIGN KEY (Pokup_kod)
REFERENCES Spokup (Pokup_kod)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;

ALTER TABLE Kart ADD CONSTRAINT sprod_kart_fk
FOREIGN KEY (Prod_kod)
REFERENCES Sprod (Prod_kod)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;

ALTER TABLE Kart ADD CONSTRAINT book_kart_fk
FOREIGN KEY (Book_id)
REFERENCES Book (Book_id)
ON DELETE RESTRICT
ON UPDATE RESTRICT
NOT DEFERRABLE;
