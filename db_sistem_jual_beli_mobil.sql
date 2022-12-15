DROP DATABASE IF EXISTS db_sistem_jual_beli_mobil;

CREATE DATABASE db_sistem_jual_beli_mobil;

USE db_sistem_jual_beli_mobil;

CREATE TABLE users(
	id_user INT(11) PRIMARY KEY AUTO_INCREMENT,
	username VARCHAR(30) UNIQUE,
	email VARCHAR(100) UNIQUE,
	password VARCHAR(50)
);

