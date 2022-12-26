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
	FOREIGN KEY (id_jenis_mobil) REFERENCES jenis_mobil(id_jenis) ON DELETE CASCADE,
	tipe_mobil VARCHAR(100),
	tahun_pembuatan YEAR,
	kondisi VARCHAR(100),
	harga INT(12),
	garansi INT(5),
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
	FOREIGN KEY (id_mobil) REFERENCES mobil(id) ON DELETE CASCADE,
	id_pembeli INT(11),
	FOREIGN KEY (id_pembeli) REFERENCES pembeli(id_pembeli) ON DELETE CASCADE,
	harga_terjual INT(12),
	tanggal_penjualan DATE
);

INSERT
	INTO
	users(
		username,
		email,
		PASSWORD
	)
VALUES 
(
	'mawanrunner',
	'hilmawanfauzy77@gmail.com',
	'5f4dcc3b5aa765d61d8327deb882cf99'
),
(
	'promecarus',
	'haikusersusersalslipi@gmail.com',
	'5f4dcc3b5aa765d61d8327deb882cf99'
),
(
	'Dynavx',
	'haical31@gmail.com',
	'5f4dcc3b5aa765d61d8327deb882cf99'
),
(
	'Lowl16',
	'sandhi372@gmail.com',
	'5f4dcc3b5aa765d61d8327deb882cf99'
),
(
	'1',
	'satu@mail.com',
	'c4ca4238a0b923820dcc509a6f75849b'
);

INSERT
	INTO
	jenis_mobil(jenis)
VALUES 
('van'),
('suv'),
('pick up'),
('box');


INSERT
	INTO
	mobil(
		id_jenis_mobil,
		tipe_mobil,
		tahun_pembuatan,
		kondisi,
		harga,
		garansi,
		status_terjual,
		harga_default
	)
VALUES
(
	1,
	'Matic',
	2001,
	'Baik',
	200000000,
	2556,
	TRUE,
	200000000
),
(
	2,
	'Manual',
	2003,
	'Buruk',
	150000000,
	2191,
	TRUE,
	150000000
),
(
	3,
	'Manual',
	2007,
	'Baik',
	250000000,
	1826,
	TRUE,
	250000000
),
(
	4,
	'Manual',
	2008,
	'Baik',
	300000000,
	1461,
	TRUE,
	350000000
),
(
	1,
	'Manual',
	2005,
	'Sangat Baik',
	500000000,
	1095,
	TRUE,
	500000000
),
(
	2,
	'Matic',
	2004,
	'Baik',
	450000000,
	730,
	TRUE,
	450000000
),
(
	3,
	'Matic',
	2009,
	'Sangat Baik',
	300000000,
	365,
	TRUE,
	300000000
),
(
	4,
	'Matic',
	2008,
	'Baik',
	550000000,
	2556,
	TRUE,
	550000000
);



INSERT
	INTO
	pembeli(
		nik,
		nama,
		alamat
	)
VALUES 
(
	'2107411009',
	'Hilmawan Fauzy Wibowo',
	'Marrakash Blok B 7'
),
(
	'2107411022',
	'Heical Chandra Saputra',
	'Jakarta Pusat JL.Mangga'
),
(
	'2107411025',
	'Muhammad Haikal Al Rasyid',
	'Jakarta Pusat Slipi'
),
(
	'2107411007',
	'Sandhi Karunia Sugihartana',
	'Bogor JL.Sisingamangaraja'
);

INSERT
	INTO
	buku_penjualan(
		id_mobil,
		id_pembeli,
		harga_terjual,
		tanggal_penjualan
	)
VALUES
(
	1,
	1,
	250000000,
	'2022/02/12'
),
(
	2,
	2,
	200000000,
	'2022/07/12'
),
(
	3,
	3,
	300000000,
	'2022/08/23'
),
(
	4,
	4,
	350000000,
	'2022/09/07'
),
(
	5,
	1,
	550000000,
	'2022/09/16'
),
(
	6,
	2,
	500000000,
	'2022/10/17'
),
(
	7,
	3,
	350000000,
	'2022/10/26'
),
(
	8,
	4,
	600000000,
	'2022/11/29'
);
