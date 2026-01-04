Create database QL
go
use QL
go
--Bài 1 TH05 Winform
create table Category(
CategoryID int Primary key,
CategoryName nvarchar(50)
)
go
Create table Products(
ProductCode char(10) primary key,
Description nvarchar(50) not null,
UnitPrice decimal not null,
OnHandQuantity int not null,
CategoryID int REFERENCES Category(CategoryID)
)
go

INSERT INTO Category (CategoryID, CategoryName)
VALUES 
(1, N'Tiểu thuyết'),
(2, N'Sách khoa học'),
(3, N'Sách thiếu nhi'),
(4, N'Sách lịch sử'),
(5, N'Sách tự học');
GO

INSERT INTO Products (ProductCode, Description, UnitPrice, OnHandQuantity, CategoryID)
VALUES 
('B001', N'Tiểu thuyết lãng mạn', 150000, 120, 1),
('B002', N'Khám phá khoa học', 180000, 100, 2),
('B003', N'Truyện cổ tích', 120000, 200, 3),
('B004', N'Lịch sử Việt Nam', 200000, 80, 4),
('B005', N'Kỹ năng tự học', 170000, 150, 5);
GO


--Bài 2 và 3 TH05 Winform
create database QLSinhVien
go
USE QLSinhVien
GO


CREATE TABLE Khoa (
    MaKhoa VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(100)
);
GO

CREATE TABLE MonHoc (
    MaMH VARCHAR(10) PRIMARY KEY,
    TenMH NVARCHAR(100),
    SoTiet INT
);
GO
CREATE TABLE SinhVien (
    MaSV VARCHAR(10) PRIMARY KEY,
    HoSV NVARCHAR(50),
    TenSV NVARCHAR(50),
    NgaySinh DATE,
    MaKhoa VARCHAR(10),
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);
GO

CREATE TABLE KetQua (
    MaSV VARCHAR(10),
    MaMH VARCHAR(10),
    Diem FLOAT,
    PRIMARY KEY (MaSV, MaMH),
    FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
    FOREIGN KEY (MaMH) REFERENCES MonHoc(MaMH)
);
GO

INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES
('K001', N'Khoa CNTT'),
('K002', N'Khoa Toán học'),
('K003', N'Khoa Vật lý');
GO

INSERT INTO MonHoc (MaMH, TenMH, SoTiet) VALUES
('MH001', N'Toán', 45),
('MH002', N'Văn', 30),
('MH003', N'Lý', 45);
GO

INSERT INTO SinhVien (MaSV, HoSV, TenSV, NgaySinh, MaKhoa) VALUES
('SV001', N'Nguyễn', N'Văn A', '2000-01-01', 'K001'),
('SV002', N'Trần', N'Thị B', '2001-02-15', 'K001'),
('SV003', N'Lê', N'Văn C', '2000-07-20', 'K002');
GO

INSERT INTO KetQua (MaSV, MaMH, Diem) VALUES
('SV001', 'MH001', 8.5),
('SV001', 'MH002', 7.0),
('SV002', 'MH001', 6.5),
('SV002', 'MH003', 9.0),
('SV003', 'MH002', 5.5);
GO



--Bài 4 TH05 Winform
CREATE DATABASE StudentDB
GO
USE StudentDB
GO

CREATE TABLE StudentClass (
    classNo NVARCHAR(50) PRIMARY KEY,
    className NVARCHAR(30),
    totalStudents INT,
    homeroomTeacher NVARCHAR(50));
GO

CREATE TABLE Student (
    stuNo NVARCHAR(5) PRIMARY KEY,
    stuName NVARCHAR(50) NOT NULL,
    classNo NVARCHAR(50) NOT NULL,
    stuYear DATETIME,
    address NVARCHAR(100),
    FOREIGN KEY (classNo) REFERENCES StudentClass(classNo));
GO

INSERT INTO StudentClass (classNo, className, totalStudents, homeroomTeacher) VALUES
('C01', 'Class 10A1', 40, N'Nguyễn Văn A'),
('C02', 'Class 10A2', 35, N'Trần Thị B'),
('C03', 'Class 10A3', 38, N'Lê Văn C');
GO

INSERT INTO Student (stuNo, stuName, classNo, stuYear, address) VALUES
('001', N'Nguyễn Văn A', 'C01', '2024-09-01', N'123 Nguyễn Trãi, Hà Nội'),
('002', N'Trần Thị B', 'C02', '2024-09-01', N'456 Lê Lợi, Hà Nội'),
('003', N'Lê Văn C', 'C01', '2024-09-01', N'789 Trần Hưng Đạo, Hà Nội');
GO

