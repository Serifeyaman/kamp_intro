-- SQL -- ANSII standartında
-- select : veri kaynağındaki datayı çekmek için kullanılır
Select * from Customers   -- * ile tüm kolonlar listelenir
Select ContactName, CompanyName, City from Customers  -- fromdan önce yazılan kolon isimlerine göre kolonları listeler
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers  -- kolon isimlerinden bazılarını alians vererek listeledi

-- where : filtreleme
Select * from Customers where City='Berlin'  -- metinler ' ' içinde yazılır

-- case insensitive : Büyük küçük harfe duyarsız.
sELECT * from Products

-- where, koşula göre data getirir
select * from Products where CategoryId=1 or CategoryId=3 
Select * from Products where CategoryID=1 and UnitPrice>=10 

-- order by verilen parametreye göre sıralar
select * from Products order by ProductName  -- ProductName e göre sıralar(a dan z ye)
select * from Products order by CategoryID   -- 1 den başlar

-- categoryID ye göre sıralar onlarıda(kendi içinde aynı olanlarıda ) productName e göre sıralar
select * from Products order by CategoryID,ProductName

-- order by: sıralar
-- asc: artan, dec: düşen olarak sıralar
select * from Products order by UnitPrice asc   --ascending
select * from Products order by UnitPrice desc  --descending

-- koşula göre filtrele sonra azalan olarak sırala
select * from Products where CategoryID=1 order by UnitPrice desc
 
-- count(): satır sayısını verir
select count(ProductName) from Products  -- ürün sayısını verir
select count(*) from Products where CategoryID=2

-- hangi üründen kaç tane var? kolon olarak verir 
select count(*) Adet from Products  -- gelen sayıyı alians ile adrandırır

-- Hangi kategoride kaç farklı ürün var?
-- group by kullanırken select edilen kolon, sadece gruplanan kolon olabilir
-- her bir grup için sayı ayrı ayrı hesaplanır
select CategoryID,count(*) Adet from Products group by CategoryID

-- having : kümülatif dataya (örneğin count ile gelen değerler) uygulanan koşulu ifade eder
-- içerisinde 10 taneden az ürün çeşidi olan kategorileri ver
select CategoryID,count(*) Adet from Products group by CategoryID having count(*)<10

-- fiyatı 20 den az olan ve 10 dan az olan kategorileri versin
-- where data üzerinde koşul sağlar, having kümülatif üzerinde koşul sağlar
select CategoryID,count(*) Adet from Products  where UnitPrice>20
group by CategoryID having count(*)<10

-- inner join: iki farklı tabloyu "on" ifadesiyle verilen koşula göre birleştir
-- inner join iki tabloda sadece eşleşenleri birleştirir
-- fiyatı 10 dan büyük olanları listeler
select products.ProductID , Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories   -- iki tablonun bir araya gelmesidir
on Products.CategoryID = Categories.CategoryID  -- bir araya gelme koşulu "on" ile yazılır, ikisi eşit olduğunda birleştir 
where Products.UnitPrice<10
 
-- DTO: Data Transformation Object --> c# da inner join 

-- left join : solda(p tablosu) olup sağda(od tablosu) olmayanları da getir
-- right join
select * from Products p left join [Order Details] od -- p: Products aliansı, od: order details aliansı
on p.ProductID=od.ProductID

-- üye olup hiç ürün almayan müşterileri bul ( müşteride olacak, siparişte olmayacak)
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null  -- hiç ürün almayan olamayan
