Create Database Project_CHBS
Go
Use Project_CHBS
Go
Create Table KhachHang(
	MaKH char(10) Not Null,
	TenKH nvarchar(30) Not Null,
	DienThoai int,
	DiaChi nvarchar(30) Not Null,
	TinhTrang nvarchar(20) Not Null, -- Thân Thiết, Quan Tâm, Tiềm Năng
	Constraint pk_KhachHang_MaKH Primary Key (MaKH),
	Constraint rb_KhachHang_TinhTrang Check(TinhTrang in (N'Thân Thiết',N'Quan Tâm',N'Tiềm Năng'))
	-- Khách Hàng thân thiết có số lượng mua >= 20 quyển, Quan Tâm >= 10, Tiềm Năng >= 1
)
Go
Create Table Sach(
	MaS char(10) Not Null,
	TieuDe nvarchar(50) Not Null,
	TacGia nvarchar(30) Not Null,
	NhaXB nvarchar(30) Not Null,
	SoLuong int, -- Tổng số lượng còn trong cửa hàng 
	GiaBan money,
	Constraint pk_Sach_MaS Primary Key (MaS)
)
Go
Create Table NhanVien(
	MaNV char(10) Not Null,
	TenNV nvarchar(30) Not Null,
	NgaySinh date,
	NgayLamViec date,
	DiaChi nvarchar(30) Not Null,
	DienThoai int,
	LuongCoBan money,
	PhuCap money,
	Constraint pk_NhanVien_MaNV Primary Key (MaNV)
)
Go
Create Table HoaDon(
	SoHD char(10) Not Null,
	NgayMua date,
	NgayHetHanBaoHanh date,
	MaS char(10) Not Null,
	MaKH char(10) Not Null,
	MaNV char(10) Not Null,
	MucGiamGia float, -- Mức giảm giá vd: 0.1 = 10%, 0.01 = 1%
	GiaBan money, -- Giá bán sau khi đã giảm giá (=Sach.GiaBan-Sach.GiaBan*MucGiamGia)
	SoLuong int, -- Số lượng bán
	Constraint pk_HoaDon_SoHD Primary Key (SoHD),
	Constraint fk_HoaDon_MaS Foreign Key(MaS) References Sach(MaS)
		On Delete Cascade On Update Cascade,
	Constraint fk_HoaDon_MaKH Foreign Key(MaS) References KhachHang(MaKH)
		On Delete Cascade On Update Cascade,
	Constraint fk_HoaDon_MaNV Foreign Key(MaNV) References NhanVien(MaNV)
		On Delete Cascade On Update Cascade
)
Go

