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

CREATE TABLE buku_penjualan(
	id_penjualan INT(11) PRIMARY KEY AUTO_INCREMENT,
	id_mobil INT(11),
	FOREIGN KEY (id_mobil) REFERENCES mobil(id),
	id_pembeli INT(11),
	FOREIGN KEY (id_pembeli) REFERENCES pembeli(id_pembeli),
	harga_terjual INT(12),
	tanggal_penjualan DATE
);


INSERT INTO users(username,email,PASSWORD) 
VALUES 
('mawanrunner','hilmawanfauzy77@gmail.com','password'),
('promecarus','haikusersusersalslipi@gmail.com','password'),
('Dynavx','haical31@gmail.com','password'),
('Lowl16','sandhi372@gmail.com','password');

INSERT INTO pembeli(nik,nama,alamat) 
VALUES 
('2107411009','Hilmawan Fauzy Wibowo','Marrakash Blok B 7'),
('2107411022','Heical Chandra Saputra','Jakarta Pusat JL.Mangga'),
('2107411025','Muhammad Haikal Al Rasyid','Jakarta Pusat Slipi'),
('2107411007','Sandhi Karunia Sugihartana','Bogor JL.Sisingamangaraja');

INSERT INTO jenis_mobil(jenis) 
VALUES 
('van'),
('suv'),
('pick up'),
('box');







