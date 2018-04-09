#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: User
#------------------------------------------------------------

CREATE TABLE User(
        idUser     int (11) Auto_increment  NOT NULL ,
        nomUser    Varchar (255) ,
        prenomUser Varchar (255) ,
        login      Varchar (255) ,
        password   Varchar (255) ,
        isAdmin    Bool NOT NULL ,
        PRIMARY KEY (idUser )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Stock
#------------------------------------------------------------

CREATE TABLE Stock(
        idStock       int (11) Auto_increment  NOT NULL ,
        libelleStock  Varchar (255) ,
        quantiteStock Int ,
        idProduit     Int NOT NULL ,
        PRIMARY KEY (idStock )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Produit
#------------------------------------------------------------

CREATE TABLE Produit(
        idProduit      int (11) Auto_increment  NOT NULL ,
        libelleProduit Varchar (255) ,
        prixProduit    Float ,
        idCategorie    Int NOT NULL ,
        idStock        Int NOT NULL ,
        PRIMARY KEY (idProduit )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Commande
#------------------------------------------------------------

CREATE TABLE Commande(
        idCommande Varchar (25) NOT NULL ,
        idPanier   Int NOT NULL ,
        PRIMARY KEY (idCommande )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Panier
#------------------------------------------------------------

CREATE TABLE Panier(
        idPanier   int (11) Auto_increment  NOT NULL ,
        idCommande Varchar (25) NOT NULL ,
        idUser     Int NOT NULL ,
        PRIMARY KEY (idPanier )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Categorie
#------------------------------------------------------------

CREATE TABLE Categorie(
        idCategorie      int (11) Auto_increment  NOT NULL ,
        libelleCategorie Varchar (255) ,
        PRIMARY KEY (idCategorie )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: ajouter
#------------------------------------------------------------

CREATE TABLE ajouter(
        idPanier  Int NOT NULL ,
        idProduit Int NOT NULL ,
        PRIMARY KEY (idPanier ,idProduit )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: gererS
#------------------------------------------------------------

CREATE TABLE gererS(
        idStock Int NOT NULL ,
        idUser  Int NOT NULL ,
        PRIMARY KEY (idStock ,idUser )
)ENGINE=InnoDB;

ALTER TABLE Stock ADD CONSTRAINT FK_Stock_idProduit FOREIGN KEY (idProduit) REFERENCES Produit(idProduit);
ALTER TABLE Produit ADD CONSTRAINT FK_Produit_idCategorie FOREIGN KEY (idCategorie) REFERENCES Categorie(idCategorie);
ALTER TABLE Produit ADD CONSTRAINT FK_Produit_idStock FOREIGN KEY (idStock) REFERENCES Stock(idStock);
ALTER TABLE Commande ADD CONSTRAINT FK_Commande_idPanier FOREIGN KEY (idPanier) REFERENCES Panier(idPanier);
ALTER TABLE Panier ADD CONSTRAINT FK_Panier_idCommande FOREIGN KEY (idCommande) REFERENCES Commande(idCommande);
ALTER TABLE Panier ADD CONSTRAINT FK_Panier_idUser FOREIGN KEY (idUser) REFERENCES User(idUser);
ALTER TABLE ajouter ADD CONSTRAINT FK_ajouter_idPanier FOREIGN KEY (idPanier) REFERENCES Panier(idPanier);
ALTER TABLE ajouter ADD CONSTRAINT FK_ajouter_idProduit FOREIGN KEY (idProduit) REFERENCES Produit(idProduit);
ALTER TABLE gererS ADD CONSTRAINT FK_gererS_idStock FOREIGN KEY (idStock) REFERENCES Stock(idStock);
ALTER TABLE gererS ADD CONSTRAINT FK_gererS_idUser FOREIGN KEY (idUser) REFERENCES User(idUser);
