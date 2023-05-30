CREATE DATABASE dbKaryawan;
GO

USE dbKaryawan;
GO

CREATE TABLE tblKaryawan (
    IDKaryawan VARCHAR(30) PRIMARY KEY,
    NmKaryawan VARCHAR(30),
    TglMasukKerja DATETIME,
    Usia INT
);

INSERT INTO tblKaryawan (IDKaryawan, NmKaryawan, TglMasukKerja, Usia) VALUES ('001', 'Andi', '2012-03-02', 25);
INSERT INTO tblKaryawan (IDKaryawan, NmKaryawan, TglMasukKerja, Usia) VALUES ('002', 'Anto', '2013-06-02', 24);
INSERT INTO tblKaryawan (IDKaryawan, NmKaryawan, TglMasukKerja, Usia) VALUES ('003', 'Adi', '2000-05-21', 27);
INSERT INTO tblKaryawan (IDKaryawan, NmKaryawan, TglMasukKerja, Usia) VALUES ('004', 'Amin', '2018-08-05', 31);

