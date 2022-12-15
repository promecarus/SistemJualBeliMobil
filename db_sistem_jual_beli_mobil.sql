DROP DATABASE IF EXISTS db_sistem_jual_beli_mobil;

CREATE DATABASE db_sistem_jual_beli_mobil;

USE db_sistem_jual_beli_mobil;

CREATE TABLE users(
	id_user INT(11) PRIMARY KEY AUTO_INCREMENT,
	username VARCHAR(30) UNIQUE,
	email VARCHAR(100) UNIQUE,
	password VARCHAR(50)
);

CREATE TABLE jenis_mobil(
	id_jenis INT(11) PRIMARY KEY AUTO_INCREMENT,
	jenis VARCHAR(100) UNIQUE
);

CREATE TABLE mobil(
	id INT(11) PRIMARY KEY AUTO_INCREMENT,
	id_jenis_mobil INT(11),
	FOREIGN KEY (id_jenis_mobil) REFERENCES jenis_mobil(id_jenis),
	tipe_mobil VARCHAR(100),
	tahun_pembuatan YEAR,
	kondisi VARCHAR(100),
	harga INT(12),
	garansi TIME,
	status_terjual BOOLEAN DEFAULT FALSE,
	harga_default INT(12)
);

CREATE TABLE pembeli(
	id_pembeli INT(11) PRIMARY KEY AUTO_INCREMENT,
	nik VARCHAR(16),
	nama VARCHAR(100),
	alamat VARCHAR(100)
);

