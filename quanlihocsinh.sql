﻿CREATE DATABASE QuanLyHocSinh
-- thực tập nhóm
--  đề tài quản lý học sinh 
GO
USE QUANLYHOCSINH
GO
CREATE TABLE GIAOVIEN
(
   MAGIAOVIEN CHAR(10),
   HOTEN NVARCHAR(50),
   GIOITINH NVARCHAR(5),
   NGAYSINH DATE,
   NOISINH NVARCHAR(50),
   CHUYENMON NVARCHAR(20),
   SODIENTHOAI NVARCHAR(11),
   CONSTRAINT pr_gv PRIMARY KEY(MAGIAOVIEN)
)
GO
CREATE TABLE LOP
(
   MALOP CHAR(10),
   TENLOP NVARCHAR(20),
   SISO INT,
   MA_GIAOVIENCHUNHIEM CHAR(10),
   CONSTRAINT PK_LOP PRIMARY KEY(MALOP)
)
GO
CREATE TABLE HOCSINH 
(
   MAHOCSINH CHAR(10),
   HOTEN NVARCHAR(50),
   GIOITINH NVARCHAR(5),
   NGAYSINH DATE,
   NOISINH NVARCHAR(50),
   CONSTRAINT pr_hs PRIMARY KEY(MAHOCSINH)
)
GO
CREATE TABLE MONHOC 
(
  MAMONHOC CHAR(10),
  TENMONHOC NVARCHAR(30),
  CONSTRAINT PK_MH PRIMARY KEY(MAMONHOC)
)
GO
CREATE TABLE LOP_MON 
(
  MAMONHOC CHAR(10),
  MALOP CHAR(10),
  MAGIAOVIEN CHAR(10),
  SOTIET INT,
  CONSTRAINT PK_LOP_MONHOC PRIMARY KEY(MAMONHOC,MALOP),
  CONSTRAINT FK_LMH_MH FOREIGN KEY(MAMONHOC) REFERENCES dbo.MONHOC(MAMONHOC),
  CONSTRAINT FK_LMH_LOP FOREIGN KEY(MALOP) REFERENCES dbo.LOP(MALOP),
  CONSTRAINT KF_LMH_GV FOREIGN KEY(MAGIAOVIEN) REFERENCES dbo.GIAOVIEN(MAGIAOVIEN)
)
GO
CREATE TABLE KETQUAHOCTAP
(
  MAHOCSINH CHAR(10),
  MALOP CHAR(10),
  DIEMTBKY1 FLOAT,
  DIEMTBKY2 FLOAT,
  DIEMTBCANAM FLOAT,
  CONSTRAINT PK_KQHT PRIMARY KEY(MAHOCSINH,MALOP),
  CONSTRAINT FK_KQHT_LOP FOREIGN KEY(MALOP) REFERENCES dbo.LOP(MALOP),
)
GO

INSERT dbo.HOCSINH( MAHOCSINH ,HOTEN , GIOITINH ,NGAYSINH ,NOISINH ) VALUES ('HS001', N'Nguyễn Văn Kiên', 'NAM',  '1997-2-3', N'PHÚ THỌ')
INSERT dbo.HOCSINH( MAHOCSINH ,HOTEN , GIOITINH ,NGAYSINH ,NOISINH ) VALUES ('HS002', N'Đinh Xuân Tùng', 'NAM',  '1998-2-3', N'BẮC GIANG')
INSERT dbo.HOCSINH( MAHOCSINH ,HOTEN , GIOITINH ,NGAYSINH ,NOISINH ) VALUES ('HS003', N'Ngô Nhật Minh', 'NAM',  '1997-10-2', N'HÀ TĨNH')
INSERT dbo.HOCSINH( MAHOCSINH ,HOTEN , GIOITINH ,NGAYSINH ,NOISINH ) VALUES ('HS004', N'Nguyễn Mạnh Sơn', 'NAM',  '1998-2-12', N'QUẢNG NAM')
INSERT dbo.HOCSINH( MAHOCSINH ,HOTEN , GIOITINH ,NGAYSINH ,NOISINH ) VALUES ('HS005', N'Trần Bảo Trí', 'NAM',  '1998-5-13', N'PHÚ THỌ')
INSERT dbo.HOCSINH( MAHOCSINH ,HOTEN , GIOITINH ,NGAYSINH ,NOISINH ) VALUES ('HS006', N'Trịnh Duy Khôi', 'NAM',  '1998-3-22', N'THANH HÓA')
INSERT dbo.HOCSINH( MAHOCSINH ,HOTEN , GIOITINH ,NGAYSINH ,NOISINH ) VALUES ('HS007', N'Đặng Trọng Tiến', 'NAM',  '1992-5-2', N'LÀO')
GO 
INSERT dbo.GIAOVIEN(MAGIAOVIEN, HOTEN ,GIOITINH ,NGAYSINH ,NOISINH ,CHUYENMON ,SODIENTHOAI) VALUES  ('GV001', N'Nguyễn Văn Kiên', N'NAM', '1993-12-4', N'NAM ĐỊNH', N'TOÁN HỌC', '24523412')
INSERT dbo.GIAOVIEN(MAGIAOVIEN, HOTEN ,GIOITINH ,NGAYSINH ,NOISINH ,CHUYENMON ,SODIENTHOAI) VALUES  ('GV002', N'Đinh Xuân Tùng', N'NAM', '1983-2-4', N'HẢI DƯƠNG', N'TIẾNG ANH', '325345')
INSERT dbo.GIAOVIEN(MAGIAOVIEN, HOTEN ,GIOITINH ,NGAYSINH ,NOISINH ,CHUYENMON ,SODIENTHOAI) VALUES  ('GV003', N'Ngô Nhật Minh', N'NAM', '1992-4-4', N'THANH HÓA', N'NGỮ VĂN', '23454325')
INSERT dbo.GIAOVIEN(MAGIAOVIEN, HOTEN ,GIOITINH ,NGAYSINH ,NOISINH ,CHUYENMON ,SODIENTHOAI) VALUES  ('GV004', N'Nguyễn Mạnh Sơn', N'NAM', '1994-5-4', N'NGHỆ AN', N'LỊCH SỬ', '3463452')
INSERT dbo.GIAOVIEN(MAGIAOVIEN, HOTEN ,GIOITINH ,NGAYSINH ,NOISINH ,CHUYENMON ,SODIENTHOAI) VALUES  ('GV005', N'Trần Bảo Trí', N'NỮ', '1991-2-14', N'NINH BÌNH', N'ĐỊA LÝ', '253432')
INSERT dbo.GIAOVIEN(MAGIAOVIEN, HOTEN ,GIOITINH ,NGAYSINH ,NOISINH ,CHUYENMON ,SODIENTHOAI) VALUES  ('GV006', N'Đặng Trọng Tiến', N'NAM', '1995-8-24', N'NAM ĐỊNH', N'TIN HỌC', '23523534')
GO 
INSERT LOP(MALOP, TENLOP, SISO, MA_GIAOVIENCHUNHIEM) VALUES ('ML01', N'LỚP 10A', '44', 'GV001')
INSERT LOP(MALOP, TENLOP, SISO, MA_GIAOVIENCHUNHIEM) VALUES ('ML02', N'LỚP 10B', '43', 'GV002')
INSERT LOP(MALOP, TENLOP, SISO, MA_GIAOVIENCHUNHIEM) VALUES ('ML03', N'LỚP 10C', '42', 'GV003')
INSERT LOP(MALOP, TENLOP, SISO, MA_GIAOVIENCHUNHIEM) VALUES ('ML04', N'LỚP 10D', '41', 'GV004')
INSERT LOP(MALOP, TENLOP, SISO, MA_GIAOVIENCHUNHIEM) VALUES ('ML05', N'LỚP 11A', '40', 'GV005')
INSERT LOP(MALOP, TENLOP, SISO, MA_GIAOVIENCHUNHIEM) VALUES ('ML06', N'LỚP 12A', '46', 'GV006')
GO 
INSERT dbo.MONHOC (MAMONHOC, TENMONHOC ) VALUES  ('MH01', N'TOÁN HỌC')
INSERT dbo.MONHOC (MAMONHOC, TENMONHOC ) VALUES  ('MH02', N'TIN HỌC')
INSERT dbo.MONHOC (MAMONHOC, TENMONHOC ) VALUES  ('MH03', N'TIẾNG ANH')
INSERT dbo.MONHOC (MAMONHOC, TENMONHOC ) VALUES  ('MH04', N'LỊCH SỬ')
INSERT dbo.MONHOC (MAMONHOC, TENMONHOC ) VALUES  ('MH05', N'ĐỊA LÝ')
INSERT dbo.MONHOC (MAMONHOC, TENMONHOC ) VALUES  ('MH06', N'NGỮ VĂN')
GO 
INSERT LOP_MON VALUES('MH01', 'ML01', 'GV001', '60')
INSERT LOP_MON VALUES('MH01', 'ML04', 'GV004', '60')
INSERT LOP_MON VALUES('MH02', 'ML02', 'GV006', '60')
INSERT LOP_MON VALUES('MH02', 'ML05', 'GV005', '60')
INSERT LOP_MON VALUES('MH02', 'ML06', 'GV003', '60')
INSERT LOP_MON VALUES('MH02', 'ML01', 'GV001', '60')
INSERT LOP_MON VALUES('MH04', 'ML01', 'GV001', '60')
INSERT LOP_MON VALUES('MH04', 'ML02', 'GV006', '60')
INSERT LOP_MON VALUES('MH04', 'ML03', 'GV002', '60')
INSERT LOP_MON VALUES('MH04', 'ML04', 'GV004', '60')
INSERT LOP_MON VALUES('MH04', 'ML05', 'GV005', '60')
INSERT LOP_MON VALUES('MH04', 'ML06', 'GV003', '60')
GO 
INSERT KETQUAHOCTAP VALUES ('HS001', 'ML01', 8.5, 7.5, 8)
INSERT KETQUAHOCTAP VALUES ('HS002', 'ML01', 8.6, 7.8, 8.2)
INSERT KETQUAHOCTAP VALUES ('HS003', 'ML02', 8.2, 7.8, 8)
INSERT KETQUAHOCTAP VALUES ('HS004', 'ML01', 8.8, 8.6, 8.7)
INSERT KETQUAHOCTAP VALUES ('HS005', 'ML04', 7.6, 7.5, 7.6)
INSERT KETQUAHOCTAP VALUES ('HS006', 'ML01', 9, 8.6, 8.8)
INSERT KETQUAHOCTAP VALUES ('HS007', 'ML06', 6, 5, 5.5)
