/*
SQLyog Community v12.4.0 (64 bit)
MySQL - 10.4.32-MariaDB : Database - db_barang
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_barang` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci */;

USE `db_barang`;

/*Table structure for table `databarang` */

DROP TABLE IF EXISTS `databarang`;

CREATE TABLE `databarang` (
  `id_barang` varchar(45) NOT NULL,
  `merk_barang` varchar(45) NOT NULL,
  `tipe_barang` varchar(45) NOT NULL,
  `tahun_produksi_barang` int(11) NOT NULL,
  `harga_barang` double NOT NULL,
  `stok_barang` varchar(45) NOT NULL,
  PRIMARY KEY (`id_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

/*Data for the table `databarang` */

insert  into `databarang`(`id_barang`,`merk_barang`,`tipe_barang`,`tahun_produksi_barang`,`harga_barang`,`stok_barang`) values 
('BRG0001','ASUS ','TUF GAMING',2024,12000000,'200'),
('BRG0002','ASUS','VIVOBOOK ',2024,9000000,'300'),
('BRG0003','LENOVO','LOQ GAMING',2023,15000000,'200'),
('BRG0004','LENOVO','IDEAPAD GAMING',2024,12000000,'200'),
('BRG0005','ADVAN','WORKSTATION',2024,6000000,'350'),
('BRG0006','LENOVO','THINKPAD',2020,5000000,'400');

/*Table structure for table `histori_transaksi` */

DROP TABLE IF EXISTS `histori_transaksi`;

CREATE TABLE `histori_transaksi` (
  `id_barang` varchar(45) NOT NULL,
  `merk_barang` varchar(45) NOT NULL,
  `tipe_barang` varchar(45) NOT NULL,
  `tahun_produksi_barang` varchar(45) NOT NULL,
  `harga_barang` varchar(45) NOT NULL,
  `harga_total` varchar(45) NOT NULL,
  `id_transaksi` varchar(45) NOT NULL,
  `kuantitas` varchar(11) NOT NULL,
  `waktu_transaksi` varchar(45) NOT NULL,
  `garansi_barang` varchar(45) NOT NULL,
  `nama_pegawal_kasir` varchar(45) NOT NULL,
  `nominal_bayar` varchar(45) NOT NULL,
  `nominal_kembalian` varchar(45) NOT NULL,
  `nominal_total_keseluruhan` varchar(45) NOT NULL,
  `nama_pembeli` varchar(45) NOT NULL,
  `no_telepon_pembeli` varchar(45) NOT NULL,
  `alamat_pembeli` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

/*Data for the table `histori_transaksi` */

insert  into `histori_transaksi`(`id_barang`,`merk_barang`,`tipe_barang`,`tahun_produksi_barang`,`harga_barang`,`harga_total`,`id_transaksi`,`kuantitas`,`waktu_transaksi`,`garansi_barang`,`nama_pegawal_kasir`,`nominal_bayar`,`nominal_kembalian`,`nominal_total_keseluruhan`,`nama_pembeli`,`no_telepon_pembeli`,`alamat_pembeli`) values 
('BRG0004','LENOVO','IDEAPAD GAMING','2024','12000000','36000000','TRS0001','3','26/10/2024 18:04:37','26/10/2024 18:04:29','Budi Antoro','2000000000','1958000000','42000000','Ilham ','08930303030','Goa Lamtau'),
('BRG0005','ADVAN','WORKSTATION','2024','6000000','6000000','TRS0001','1','26/10/2024 18:04:42','26/10/2024 18:04:29','Budi Antoro','2000000000','1958000000','42000000','Ilham ','08930303030','Goa Lamtau'),
('BRG0005','ADVAN','WORKSTATION','2024','6000000','18000000','TRS0002','3','26/10/2024 18:07:23','26/10/2024 18:07:18','Ilham Anjay','19000000','1000000','18000000','Dara','08142152317','Bandung');

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `nama` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

/*Data for the table `users` */

insert  into `users`(`username`,`password`,`nama`) values 
('budi123','budi123','Budi Antoro'),
('Admin123','Admin123','Admin'),
('narendra12','narendra12','Narendra '),
('Ilham32','Ilhan32','Ilham Anjay');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
