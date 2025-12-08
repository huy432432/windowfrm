Create database QuanLyThuVien
Go
Use QuanLyThuVien
Go

CREATE TABLE Khoa (
    MaKhoa INT PRIMARY KEY,
    TenKhoa NVARCHAR(50),
    DiaChi NVARCHAR(50),
    SDT VARCHAR(10)
);
Go
CREATE TABLE DocGia (
    MaDocGia INT PRIMARY KEY,
    HoTen NVARCHAR(50),
    NgaySinh DATE,
    MaKhoa INT FOREIGN KEY REFERENCES Khoa(MaKhoa),
    ViTri NVARCHAR(50),
    DiaChi NVARCHAR(50),
    NgayLapThe DATE
);
Go
CREATE TABLE Sach (
    Masach INT PRIMARY KEY,
    Nhande NVARCHAR(50),
    SoTrang INT,
    SoLuong INT,
    NamXB INT,
    LanXB INT,
    SoLanMuon INT,
    LoaiSach NVARCHAR(50),
    NXB NVARCHAR(50),
    TacGia NVARCHAR(50),
    NgayNhap DATE
);
Go
CREATE TABLE NhanVien (
    MaNhanVien INT PRIMARY KEY,
    HoTen NVARCHAR(50),
    DiaChi NVARCHAR(50),
    TenDangNhap NVARCHAR(50) UNIQUE,
    MatKhau NVARCHAR(50),
    QuyenHan NVARCHAR(50)
);
Go
CREATE TABLE PhieuMuon (
    MaPhieuMuon INT PRIMARY KEY,
    MaDocGia INT FOREIGN KEY REFERENCES DocGia(MaDocGia),
    TheThucMuon NVARCHAR(50),
    NgayMuon DATE,
    MaSach INT FOREIGN KEY REFERENCES Sach(MaSach),
    MaNhanVien INT FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    SoLuong INT
);
Go

