
create proc sp_musteriKayit
(
	@MusteriID int,
	@Isim nvarchar(50),
	@Soyisim nvarchar(50)
)
as

begin
insert into Musterim values(@MusteriID,@Isim,@Soyisim)
end
