/* USER */

INSERT INTO user (name, lastname, username, password, isAdmin) VALUES ("Elie", "Laloum", "e.laloum", "1234", "1");
INSERT INTO user (name, lastname, username, password, isAdmin) VALUES ("Fouad", "Tyr", "f.tyr", "1234", "1");
INSERT INTO user (name, lastname, username, password, isAdmin) VALUES ("Kamardine", "Chanfi", "k.chanfi", "1234", "1");
INSERT INTO user (name, lastname, username, password, isAdmin) VALUES ("Hadjer", "Daly", "h.daly", "1234", "1");
INSERT INTO user (name, lastname, username, password, isAdmin) VALUES ("Test", "Test", "test", "1234", "0");

/* PRODUCT */

INSERT INTO product (idCategory, libelle, price) VALUES ( 1 , "Category 1 Product 1", 19.25);
INSERT INTO product (idCategory, libelle, price) VALUES ( 1 , "Category 1 Product 2", 24.54);
INSERT INTO product (idCategory, libelle, price) VALUES ( 1 , "Category 1 Product 3", 15.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 1 , "Category 1 Product 4", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 1 , "Category 1 Product 5", 14.56);

INSERT INTO product (idCategory, libelle, price) VALUES ( 2 , "Category 2 Product 1", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 2 , "Category 2 Product 2", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 2 , "Category 2 Product 3", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 2 , "Category 2 Product 4", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 2 , "Category 2 Product 5", 14.56);

INSERT INTO product (idCategory, libelle, price) VALUES ( 3 , "Category 3 Product 1", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 3 , "Category 3 Product 2", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 3 , "Category 3 Product 3", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 3 , "Category 3 Product 4", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 3 , "Category 3 Product 5", 14.56);

INSERT INTO product (idCategory, libelle, price) VALUES ( 4 , "Category 4 Product 1", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 4 , "Category 4 Product 2", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 4 , "Category 4 Product 3", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 4 , "Category 4 Product 4", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 4 , "Category 4 Product 5", 14.56);

INSERT INTO product (idCategory, libelle, price) VALUES ( 5 , "Category 5 Product 1", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 5 , "Category 5 Product 2", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 5 , "Category 5 Product 3", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 5 , "Category 5 Product 4", 14.56);
INSERT INTO product (idCategory, libelle, price) VALUES ( 5 , "Category 5 Product 5", 14.56);

/* CATEGORY */

INSERT INTO category (libelle) VALUES ("Category 1");
INSERT INTO category (libelle) VALUES ("Category 2");
INSERT INTO category (libelle) VALUES ("Category 3");
INSERT INTO category (libelle) VALUES ("Category 4");
INSERT INTO category (libelle) VALUES ("Category 5");

/* STOCK */

INSERT INTO stock (idProduct, quantity) VALUES ( 1 , 25);
INSERT INTO stock (idProduct, quantity) VALUES ( 2 , 45);
INSERT INTO stock (idProduct, quantity) VALUES ( 3 , 95);
INSERT INTO stock (idProduct, quantity) VALUES ( 4 , 75);
INSERT INTO stock (idProduct, quantity) VALUES ( 5 , 65);

INSERT INTO stock (idProduct, quantity) VALUES ( 6 , 54);
INSERT INTO stock (idProduct, quantity) VALUES ( 7 , 78);
INSERT INTO stock (idProduct, quantity) VALUES ( 8 , 15);
INSERT INTO stock (idProduct, quantity) VALUES ( 9 , 65);
INSERT INTO stock (idProduct, quantity) VALUES ( 10 , 32);

INSERT INTO stock (idProduct, quantity) VALUES ( 11 , 20);
INSERT INTO stock (idProduct, quantity) VALUES ( 12 , 48);
INSERT INTO stock (idProduct, quantity) VALUES ( 13 , 34);
INSERT INTO stock (idProduct, quantity) VALUES ( 14 , 95);
INSERT INTO stock (idProduct, quantity) VALUES ( 15 , 21);

INSERT INTO stock (idProduct, quantity) VALUES ( 16 , 98);
INSERT INTO stock (idProduct, quantity) VALUES ( 17 , 34);
INSERT INTO stock (idProduct, quantity) VALUES ( 18 , 71);
INSERT INTO stock (idProduct, quantity) VALUES ( 19 , 19);
INSERT INTO stock (idProduct, quantity) VALUES ( 20 , 76);

INSERT INTO stock (idProduct, quantity) VALUES ( 21 , 14);
INSERT INTO stock (idProduct, quantity) VALUES ( 22 , 75);
INSERT INTO stock (idProduct, quantity) VALUES ( 23 , 34);
INSERT INTO stock (idProduct, quantity) VALUES ( 24 , 40);
INSERT INTO stock (idProduct, quantity) VALUES ( 25 , 28);

/* CART */

INSERT INTO cart (idUser) VALUES ( 1 );
INSERT INTO cart (idUser) VALUES ( 2 );
INSERT INTO cart (idUser) VALUES ( 3 );
INSERT INTO cart (idUser) VALUES ( 4 );
INSERT INTO cart (idUser) VALUES ( 5 );

/* CART_STORE */

INSERT INTO cart_store (idCart, idProduct) VALUES ( 1 , 6);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 1 , 3);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 1 , 18);

INSERT INTO cart_store (idCart, idProduct) VALUES ( 2 , 24);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 2 , 7);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 2 , 14);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 2 , 9);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 2 , 20);

INSERT INTO cart_store (idCart, idProduct) VALUES ( 3 , 17);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 3 , 5);

INSERT INTO cart_store (idCart, idProduct) VALUES ( 4 , 3);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 4 , 1);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 4 , 19);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 4 , 8);

INSERT INTO cart_store (idCart, idProduct) VALUES ( 5 , 14);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 5 , 25);
INSERT INTO cart_store (idCart, idProduct) VALUES ( 5 , 7);

/* PAYMENT */

INSERT INTO payment (idCart) VALUES (1);
INSERT INTO payment (idCart) VALUES (2);
INSERT INTO payment (idCart) VALUES (3);
INSERT INTO payment (idCart) VALUES (4);
INSERT INTO payment (idCart) VALUES (5);