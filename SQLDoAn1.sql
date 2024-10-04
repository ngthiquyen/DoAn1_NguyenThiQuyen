create database DoAn1
go
use DoAn1
go

----TAO BANG----
create table NhaCC
(
	MaNCC nvarchar(10) primary key,
	TenNCC nvarchar(30) not null,
	Diachi nvarchar(50) not null,
	Sdt char(10) not null
	check (Sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Email nvarchar(30) null
)
drop table NhaCC
create table NhanVien
(
	MaNV nvarchar(10) primary key,
	Hoten nvarchar(30) not null,
	Gioitinh nvarchar(10) check (gioitinh=N'Nam' or gioitinh=N'Nữ' or gioitinh=N'Khác'),
	Ngaysinh date ,
	Diachinv nvarchar(50) not null,
	Email nvarchar(30) null ,
	Sdt char(10) not null
	check (Sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Luong float not null
)
drop table NhanVien

create table KhachHang
(
	MaKH nvarchar(10) primary key,
	TenKh nvarchar(30) not null,
	DiachiKH nvarchar(50) not null,
	Email nvarchar(30) null ,
	Sdt char(10) not null
	check (Sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Gioitinh nvarchar(10) check (gioitinh=N'Nam' or gioitinh=N'Nữ' or gioitinh=N'Khác'),
	Ngaysinh date 
)
drop table KhachHang
create table LoaiHang
(
	MaLH nvarchar(10) primary key,
	TenLH nvarchar(50) not null,
)
drop table LoaiHang

create table MatHang
(
	MaMH nvarchar(10) primary key,
	MaLH nvarchar(10) foreign key (MaLH) references LoaiHang(MaLH) ,
	TenMH nvarchar(30) not null,
	Donvi nvarchar(30) not null,
	SoLuong int not null,
	Mau nvarchar(30) not null,
	Gia float not null,
	Mota nvarchar(200) null,
	Size nvarchar(10) not null
)
drop table MatHang

create table DonHangNhap
(
	MaDHN nvarchar(10) primary key,	
	MaNV nvarchar(10) foreign key (MaNV) references NhanVien(MaNV),
	MaNCC nvarchar(10) foreign key (MaNCC) references NhaCC(MaNCC),
	Ngaynhap date not null,
	TongThanhToan float default 0
)
drop table Donhangnhap

create table ChiTietHDN
(
	MaDHN nvarchar(10) foreign key (MaDHN) references DonHangNhap(MaDHN),
	MaMH nvarchar(10) foreign key (MaMH) references MatHang(MaMh),
	SlNhap int not null,
	DongiaNhap float not null,
	TongTien float not null,
	primary key (madhn,mamh)
)
drop table ChiTietHDN

create table DonHangBan
(
	MaDHB nvarchar(10) primary key,	
	MaNV nvarchar(10) foreign key (MaNV) references NhanVien(MaNV),
	MaKH nvarchar(10) foreign key (MaKH) references KhachHang(MaKH),
	Ngayban date not null,
	TongThanhToan float default 0
)
drop table DonHangBan

create table ChiTietDHB
(
	MaDHB nvarchar(10) foreign key (MaDHB) references DonHangBan(MaDHB),
	MaMH nvarchar(10) foreign key (MaMH) references MatHang(MaMh),
	SlBan int not null,
	DongiaBan float not null,
	Tongtien float not null,
	primary key (MaDHB,MaMH)
)


drop table ChitietDHB

--create table TaiKhoan
--(
--	Tendn nvarchar(20) primary key,
--	Matkhau nvarchar(20) not null,
--	Quyenhan nvarchar(20) not null
--)
-- drop table TaiKhoan 

----- THEM DU LIEU -----
insert into TaiKhoan values ('admin','admin','Admin'),
							('user','user',N'Nhân viên'),
							

insert into NhaCC values ('NCC1',N'Vàng bạc Văn Ngân',N'Hoàn Kiếm, Hà Nội','0818266829','vannganjewelry@gmail.com'),
						('NCC2',N'Vàng bạc Đá quý Huy Thành',N'Hoàn Kiếm, Hà Nội','0392646569','cskh@htj.vn'),
						('NCC3',N'Vàng bạc Đá quý DOJI',N'Ba Đình,Hà Nội','0336622883','huan.dh@doji.vn'),
						('NCC4',N'Vàng bạc Duy Hiển',N'Phủ Lý,Hà Nam','0973632686','cskh@duyhien.vn'),
						('NCC5',N'Công ty Trang sức Việt Nam',N'Duy Tiên,Hà Nam','0358360037','sunny@sunnyjewel.net')

insert into NhanVien values ('NV1',N'Nguyễn Trọng Minh')

insert into LoaiHang values ('LH1',N'Dây chuyền'),
							('LH2',N'Vòng tay'),
							('LH3',N'Khuyên tai'),
							('LH4',N'Đồng hồ'),
							('LH5',N'Nhẫn')

insert into MatHang values ('MH1','LH1',N'Dây chuyền DCPTB 372',N'cái',150,N'Vàng',1530000,N'Dây chuyền tôn lên sự sang trọng của phái nữ',N'freesize'),
							('MH2','LH5',N'Nhẫn Ndino 286',N'chiếc',20,N'Bạc',500000,N'Nhẫn là vòng tròn kết nối mang ý nghãi của sự bền bỉ','2.1'),
							('MH3','LH2',N'Lắc tay LPTB 382',N'chiếc',55,N'Titan',750000,N'Lắc tay mang màu sắc titan tạo sự thoải mái nhưng cũng không kém phần sang trọng',N'freesize')
delete from mathang
INSERT INTO DonHangNhap( maDHN,maNV,maNCC,ngayNhap )
VALUES
     ('DHN01', 'NV1','NCC1',  '2024-05-14'),
     ('DHN02', 'NV1','NCC2',  '2024-05-15'),
     ('DHN03', 'NV1','NCC3',  '2024-05-16'),
     ('DHN05', 'NV1','NCC5',  '2024-05-18');
-- Thủ tục tăng số lượng hàng
CREATE PROCEDURE SoLuongTang
    @MaMH Nvarchar(10),
    @SoLuong INT
AS
BEGIN
-- cập nhật vào bảng MH
    UPDATE MatHang
	-- số lượng trong bảng MH = số lượng trong bảng MH + số lượng từ bảng chi tiết bán hoặc chi tiết nhập
    SET soLuong = soLuong + @SoLuong
    WHERE MaMH = @MaMH;
END
-----------------------------------------------------------------------------------------------------------------------------
-- giảm
CREATE PROCEDURE SoLuongGiam
     @MaMH nvarchar(10),
    @SoLuong INT
AS
BEGIN
-- cập nhật vào bảng MH
     UPDATE MatHang
	 -- số lượng trong bảng MH = số lượng trong bảng LT - số lượng từ bảng chi tiết bán hoặc chi tiết nhập
    SET soLuong = soLuong - @SoLuong
    WHERE MaMH = @MaMH;
END
-----------------------------------------------------------------------------------------------------------------------------
-- Thủ tục tính tổng thanh toán đơn hàng bán
CREATE PROCEDURE TongThanhToanHDB
    @maDHB nvarchar(10)
AS
BEGIN
    -- Tính tổng thành tiền từ bảng ChiTietDonHangBan
    DECLARE @TongThanhToan FLOAT;
    SELECT @TongThanhToan = SUM(TongTien)
    FROM ChiTietDHB
    WHERE maDHB = @maDHB;

    -- Cập nhật tổng tiền vào bảng DonHangBan
    UPDATE DonHangBan
    SET TongThanhToan = @TongThanhToan
    WHERE maDHB = @maDHB;
END
------------------------------------------------------------------------------------------------------------------------------
-- Thủ tục tính tổng thanh toán đơn hàng nhập
CREATE PROCEDURE TongThanhToanHDN
    @maDHN nvarchar(10)
AS
BEGIN
    -- Tính tổng thành tiền từ bảng ChiTietDonHangNhap
    DECLARE @TongThanhToan FLOAT;
    SELECT @TongThanhToan = SUM(TongTien)
    FROM ChiTietHDN
    WHERE maDHN = @maDHN;

    -- Cập nhật tổng tiền vào bảng DonHangNhap
    UPDATE DonHangNhap
    SET TongThanhToan = @TongThanhToan
    WHERE maDHN = @maDHN;
END
drop PROCEDURE TongThanhToanHDN 
------------------------------------------------------------------------------------------------------------------------------
--Thủ tục báo cáo doanh thu theo từng ngày trong khoảng thời gian fromdate và todate
CREATE PROCEDURE BaoCaoDoanhThu
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
    SELECT
	-- alldates : chọn ra tất cả các ngày trong khoảng thời gian nhập vào
        FORMAT(AllDates.Date, 'dd-MM-yyyy') AS 'Từ ngày',-- As là định dạnh tên của cột hiển thị
        @ToDate AS [Đến ngày],       
        SUM(DHB.TongThanhToan) AS N'Tổng bán',
        SUM(DHN.TongThanhToan) AS N'Tổng nhập',
        SUM(DHB.TongThanhToan - DHN.TongThanhToan) AS N'Tổng lãi',-- Tổng tiền ở bán - tổng tiền ở nhập = tổng lãi
		-- count tính số lượng, distinct để dùng cho tính số lượng không bị trùng lặp mã 
        COUNT(DISTINCT DHB.maDHB) AS 'Số lượng hóa đơn bán',
        COUNT(DISTINCT DHN.maDHN) AS 'Số lượng hóa đơn nhập'
    FROM (
        SELECT DATEADD(DAY, number, @FromDate) AS Date
        FROM master.dbo.spt_values --chứa số nguyên liên quan đến ngày và thời gian
        WHERE type = 'P'-- bỏ tất cả các số nguyên trong datetime
            AND DATEADD(DAY, number, @FromDate) <= @ToDate-- lấy ra số ngày trong datetime và <= ngày kết thúc
    ) AS AllDates
	-- kiểm tra ở 1 bảng xem ngày bán hoặc ngày nhập có trùng với tất cả các hiển thị trong khoảng thời gian nhập vào
    LEFT JOIN DonHangBan DHB ON AllDates.Date = DHB.ngayBan
    LEFT JOIN DonHangNhap DHN ON AllDates.Date = DHN.ngayNhap
    WHERE (DHB.ngayBan IS NOT NULL OR DHN.ngayNhap IS NOT NULL)-- điều kiện là chỉ hiển thị ra những ngày có đơn hàng bán hoặc nhập
    GROUP BY FORMAT(AllDates.Date, 'dd-MM-yyyy')-- gom nhóm các dòng thời gian cùng ngày lại với nhau (không tính thời gian)
    ORDER BY FORMAT(AllDates.Date, 'dd-MM-yyyy');-- sắp xếp kết quả theo ngày
END
----------------------------------------------------------------------------------------------------------------------------
-- Top 5 mặt hàng bán chạy nhất
CREATE PROCEDURE HangBanChay
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
-- lấy ra top 5 hàng bán nhiều nhất
	SELECT TOP 5
		mh.maMH,
	    mh.tenMH,
		-- sum truy vấn đến tổng số lượng trong bản
		SUM(CTB.slban) AS SoLuongBan
		FROM MatHang mh
		INNER JOIN ChiTietDHB CTB ON mh.maMH = CTB.maMH
		INNER JOIN DonHangBan DHB ON CTB.maDHB = DHB.maDHB
		-- ngày bán nằm trong khoảng thời gian nhập vào
		WHERE DHB.ngayBan BETWEEN @FromDate AND @ToDate
		GROUP BY mh.maMH, mh.tenMH
		ORDER BY SoLuongBan DESC;-- sắp xếp kết quả theo ngày, desc dùng để sắp xếp thứ tự giảm dần
END
---------------------------------------------------------------------------------------------------------------------------
-- Số lượng tồn kho
CREATE PROCEDURE HangTonKho
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
	SELECT
		mh.maMH,
		mh.tenMH,
		-- sum truy vấn đến tổng số lượng trong bảng
		-- is null : nếu tổng số lượng là null thì trả về 0 ở cuối cùng , nếu tổng số lượng khác null thì trả về giá trị tính được
	    mh.soLuong - ISNULL(SUM(CTB.slban), 0) AS SoLuongTonKho
		FROM MatHang mh
		INNER JOIN ChiTietDHB CTB ON mh.maMH = CTB.maMH
		INNER JOIN DonHangBan DHB ON CTB.maDHB = DHB.maDHB
		-- điều kiện chỉ hiển thị ra những mặt hàng tồn kho nhưng có mặt hàng trong bảng đơn hàng bán
		WHERE DHB.ngayBan BETWEEN @FromDate AND @ToDate
		GROUP BY mh.maMH,mh.tenMH,mh.soLuong
END
drop procedure HangTonKho
