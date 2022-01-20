-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.4.22-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for pergudangan
CREATE DATABASE IF NOT EXISTS `pergudangan` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `pergudangan`;

-- Dumping structure for table pergudangan.barang
CREATE TABLE IF NOT EXISTS `barang` (
  `id_barang` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `Id_jenis_barang` int(11) NOT NULL,
  `barang` varchar(255) NOT NULL DEFAULT '0',
  `stock` int(11) DEFAULT 0,
  `dir_gambar_barang` text NOT NULL,
  `deskripsi` longtext NOT NULL,
  `tahun_pembuatan` year(4) NOT NULL,
  `tanggal_masuk_barang` date NOT NULL,
  `tanggal_terakhir_diperbarui` date NOT NULL,
  `lokasi_penyimpanan` varchar(255) NOT NULL DEFAULT '0',
  `kualitas` varchar(50) NOT NULL DEFAULT '0',
  `target_pasar` varchar(50) DEFAULT '0',
  PRIMARY KEY (`id_barang`),
  KEY `FK_barang_jenisbarang` (`Id_jenis_barang`),
  CONSTRAINT `FK_barang_jenisbarang` FOREIGN KEY (`Id_jenis_barang`) REFERENCES `jenis_barang` (`id_jenis_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table pergudangan.barang_masuk
CREATE TABLE IF NOT EXISTS `barang_masuk` (
  `id_barang_masuk` int(11) NOT NULL AUTO_INCREMENT,
  `id_order` int(11) NOT NULL,
  `jumlah_masuk` int(11) NOT NULL,
  PRIMARY KEY (`id_barang_masuk`),
  KEY `FK_barangmasuk_order` (`id_order`),
  CONSTRAINT `FK_barang_masuk_table_order` FOREIGN KEY (`id_order`) REFERENCES `table_order` (`id_order`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table pergudangan.jenis_barang
CREATE TABLE IF NOT EXISTS `jenis_barang` (
  `id_jenis_barang` int(11) NOT NULL AUTO_INCREMENT,
  `jenis_barang` varchar(255) NOT NULL DEFAULT '',
  `satuan` varchar(255) NOT NULL DEFAULT '',
  `catatan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_jenis_barang`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table pergudangan.table_order
CREATE TABLE IF NOT EXISTS `table_order` (
  `id_order` int(11) NOT NULL AUTO_INCREMENT,
  `id_barang` int(11) unsigned NOT NULL,
  `jumlah_order` int(11) NOT NULL DEFAULT 0,
  `tanggal_order` date NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Tidak Terpenuhi',
  PRIMARY KEY (`id_order`),
  KEY `FK_id_barang` (`id_barang`),
  CONSTRAINT `FK_id_barang` FOREIGN KEY (`id_barang`) REFERENCES `barang` (`id_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table pergudangan.users
CREATE TABLE IF NOT EXISTS `users` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `email` varchar(255) NOT NULL DEFAULT '0',
  `password` varchar(255) DEFAULT NULL,
  `registered_at` date DEFAULT NULL,
  `dir_foto` text NOT NULL,
  `id_pegawai` int(255) NOT NULL DEFAULT 0,
  `nama_pegawai` varchar(255) NOT NULL DEFAULT '0',
  `jabatan` varchar(255) NOT NULL DEFAULT '0',
  `kode_akses` varchar(255) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
