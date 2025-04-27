using homework1.app;

List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries),
    new Product(24, "Sony WH-1000XM5", "Industry-leading noise canceling wireless headphones with premium sound and lightweight design.", 399, 4.8, 0, "Sony", ProductCategory.Smartphones)
};

// 1. Get all products that belong to the "Smartphones" category.
List<Product> smartphones = products.Where(p => p.Category == ProductCategory.Smartphones).ToList();
foreach(Product phone in smartphones)
{
    Console.WriteLine($"Name: ({phone.Title}), Brand: ({phone.Brand}), Price: ({phone.Price}$)");
}
Console.WriteLine($"=====================================================================");

// 2. Select the names (titles) of all products.
foreach (Product product in products)
{
    Console.WriteLine($"Title: ({product.Title})");
}
Console.WriteLine($"=====================================================================");

// 3. Get all products with a price greater than 1000.
List<Product> priceGreaterThan1000 = products.Where(p => p.Price >= 1000).ToList();
foreach(Product product in priceGreaterThan1000)
{
    Console.WriteLine($"Name: ({product.Title}), Price: ({product.Price})");
}
Console.WriteLine($"=====================================================================");

// 4. Select the brands of all skincare products.
List<Product> skincareProduct = products.Where(p => p.Category == ProductCategory.Skincare).ToList();
foreach(Product product in skincareProduct)
{
    Console.WriteLine($"Brand: ({product.Brand}), Category: ({product.Category})");
}
Console.WriteLine($"=====================================================================");

// 5. Get the first product that has a rating above 4.8.
Product firstProductThatHasARatingAbove48 = products.FirstOrDefault(p => p.Rating >= 4.8);
Console.WriteLine($"Title: ({firstProductThatHasARatingAbove48.Title}), Rating: ({firstProductThatHasARatingAbove48.Rating})");
Console.WriteLine($"=====================================================================");

// 6. Get all products that are out of stock (stock equal to 0).
List<Product> productsOutOfStock = products.Where(p => p.Stock == 0).ToList();
foreach(Product product in productsOutOfStock)
{
    Console.WriteLine($"Title: ({product.Title}), Stock: ({product.Stock}) - out of stock");
}
Console.WriteLine($"=====================================================================");

// 7. Select the prices of all fragrance products.
List<Product> fragrance = products.Where(p => p.Category == ProductCategory.Fragrances).ToList();
foreach(Product product in fragrance)
{
    Console.WriteLine($"Title: ({product.Title}), Category: ({product.Category}), Price: ({product.Price}$)");
}
Console.WriteLine($"=====================================================================");

// 8. Retrieve the description of the first product with a rating equal to 4.43.
List<Product> retrieveTheDescriptionRating43 = products.Where(p => p.Rating == 4.43).ToList();
foreach(Product product in retrieveTheDescriptionRating43)
{
    Console.WriteLine($"Title: ({product.Title}), Rating: ({product.Rating}), Description: ({product.Description})");
}
Console.WriteLine($"=====================================================================");

// 9. Get the title of the last Skincare product with a price under $50.
Product lastSkincareUnder50 = products.LastOrDefault(p => p.Category == ProductCategory.Skincare && p.Price < 50);
Console.WriteLine($"Title: ({lastSkincareUnder50.Title}), Category: ({lastSkincareUnder50.Category}), Price: ({lastSkincareUnder50.Price}$)");
Console.WriteLine($"=====================================================================");

// 10. Get the title of the first product in the Fragrances category with a price above $100.
Product firstProductFragrancesAbove100 = products.FirstOrDefault(p => p.Category == ProductCategory.Fragrances && p.Price >= 100);
Console.WriteLine($"Title: ({firstProductFragrancesAbove100.Title}), Category: ({firstProductFragrancesAbove100.Category}), Price: ({firstProductFragrancesAbove100.Price}$)");
Console.WriteLine($"=====================================================================");

// 11. Select the brand of the last product that has a stock lower than 40.
Product lastProductStockLowerThan40 = products.LastOrDefault(p => p.Stock < 40);
Console.WriteLine($"Brand: ({lastProductStockLowerThan40.Brand}), Stock: ({lastProductStockLowerThan40.Stock})");
Console.WriteLine($"=====================================================================");

// 12. Select the title of the first Laptop that has a stock greater than 80.
Product firstLaptopStockGreaterThan80 = products.FirstOrDefault(p => p.Category == ProductCategory.Laptops && p.Stock > 80);
Console.WriteLine($"Brand: ({firstLaptopStockGreaterThan80.Brand}), Stock: ({firstLaptopStockGreaterThan80.Stock})");
Console.WriteLine($"=====================================================================");

// 13. Retrieve the title of the first product that has a price above $1200.
Product firstProductAbove1200 = products.FirstOrDefault(p => p.Price > 1200);
Console.WriteLine($"Title: ({firstProductAbove1200.Title}), Price: ({firstProductAbove1200.Price}$)");
Console.WriteLine($"=====================================================================");

// 14. Select the stock count of the last product that belongs to the Smartphones category.
Product lastSmartphone = products.LastOrDefault(p => p.Category == ProductCategory.Smartphones);
Console.WriteLine($"Stock count: {lastSmartphone.Stock}");
Console.WriteLine($"=====================================================================");

// 15. Create new class ProductDetails with 3 properties: Id, Title and Price and map the existing product data to a collection of ProductDetails objects.
List<ProductDetails> productDetailsList = products.Select(p => new ProductDetails(p.Id, p.Title, p.Price)).ToList();
foreach (ProductDetails productDetails in productDetailsList)
{
    Console.WriteLine($"Id: ({productDetails.Id}), Title: ({productDetails.Title}), Price: ({productDetails.Price}$)");
}
Console.WriteLine($"=====================================================================");