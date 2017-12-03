-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2016-05-26 06:46:49.713

-- tables
-- Table: CHITIETHD
CREATE TABLE CHITIETHD (
    TENSP ntext  NOT NULL,
    MAHD nvarchar  NULL,
    NGAYHD datetime  NULL,
    SOLUONGSP int  NULL,
    DONGIA money  NULL,
    CONSTRAINT CHITIETHD_pk PRIMARY KEY  (TENSP)
);

-- Table: HOADON
CREATE TABLE HOADON (
    MAHD nvarchar  NOT NULL,
    MALOAI datetime  NULL,
    MASANPHAM int  NULL,
    CONSTRAINT HOADON_pk PRIMARY KEY  (MAHD)
);

-- Table: KHACHHANG
CREATE TABLE KHACHHANG (
    MAKH nvarchar  NOT NULL,
    TENKH ntext  NULL,
    EMAIL ntext  NULL,
    SODT int  NULL,
    DIACHI ntext  NULL,
    CONSTRAINT KHACHHANG_pk PRIMARY KEY  (MAKH)
);

-- Table: LOAISANPHAM
CREATE TABLE LOAISANPHAM (
    MALOAI nvarchar  NOT NULL,
    TENLOAI ntext  NULL,
    NGAYNHAP datetime  NULL,
    SOLUONG int  NULL,
    CONSTRAINT LOAISANPHAM_pk PRIMARY KEY  (MALOAI)
);

-- Table: SANPHAM
CREATE TABLE SANPHAM (
    MASP nvarchar  NOT NULL,
    TENSP ntext  NULL,
    SOLUONGSP int  NULL,
    DONGIA money  NULL,
    MALOAI int  NOT NULL,
    CONSTRAINT SANPHAM_pk PRIMARY KEY  (MASP)
);

-- End of file.

