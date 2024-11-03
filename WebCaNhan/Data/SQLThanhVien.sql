IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'ThVien')
BEGIN
  CREATE DATABASE ThVien;
END;
GO

USE [ThVien]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE ThanhVien (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Ten NVARCHAR(50),
    MaSinhVien NVARCHAR(20),
    Email NVARCHAR(100),
    HinhAnh NVARCHAR(255)
);

INSERT INTO ThanhVien (Ten, MaSinhVien, Email, HinhAnh) VALUES 
('Nguyễn Quý Mạnh', '162001518', '16200151@dntu.edu.vn', 'Images/Main.jpg'),
('Đặng Đức Phi' ,'null', 'null', 'Images/Member.jpg');