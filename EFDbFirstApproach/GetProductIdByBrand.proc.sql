create procedure GetProductIdByBrand (@BrandId int)
as begin

select * from Products where BrandID = @BrandId;

end
