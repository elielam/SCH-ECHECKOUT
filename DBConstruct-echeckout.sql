#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: user
#------------------------------------------------------------

CREATE TABLE user(
        id       int (11) Auto_increment  NOT NULL ,
        name     Varchar (25) NOT NULL ,
        lastname Varchar (25) NOT NULL ,
        username Varchar (25) NOT NULL ,
        password Varchar (25) NOT NULL ,
        isAdmin  Bool NOT NULL ,
        PRIMARY KEY (id )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: stock
#------------------------------------------------------------

CREATE TABLE stock(
        id        int (11) Auto_increment  NOT NULL ,
        idProduct Int NOT NULL ,
        quantity  Double NOT NULL ,
        PRIMARY KEY (id )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: product
#------------------------------------------------------------

CREATE TABLE product(
        id         int (11) Auto_increment  NOT NULL ,
        idCategory Int NOT NULL ,
        libelle    Varchar (25) NOT NULL ,
        price      Float NOT NULL ,
        PRIMARY KEY (id )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: category
#------------------------------------------------------------

CREATE TABLE category(
        id      int (11) Auto_increment  NOT NULL ,
        libelle Varchar (25) NOT NULL ,
        PRIMARY KEY (id )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: cart
#------------------------------------------------------------

CREATE TABLE cart(
        id     int (11) Auto_increment  NOT NULL ,
        idUser Int ,
        PRIMARY KEY (id )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: payment
#------------------------------------------------------------

CREATE TABLE payment(
        id     int (11) Auto_increment  NOT NULL ,
        idCart Int NOT NULL ,
        PRIMARY KEY (id )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: cart_store
#------------------------------------------------------------

CREATE TABLE cart_store(
        id        int (11) Auto_increment  NOT NULL ,
        idCart    Int NOT NULL ,
        idProduct Int NOT NULL ,
        PRIMARY KEY (id )
)ENGINE=InnoDB;

