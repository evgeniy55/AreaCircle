SELECT p.productName, c.categoryName
FROM Product p
LEFT JOIN ProductCategories pc on p.Id = pc.IdProduct
LEFT JOIN Category c on pc.IdCategory = c.Id