List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Name = "Apparel",
        Id = 1
    },
    new ProductType()
    {
        Name = "Potions",
        Id = 2
    },
    new ProductType()
    {
        Name = "Enchanted Objects",
        Id = 3
    },
    new ProductType()
    {
        Name = "Wands",
        Id = 4
    }
};

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Cursed Chicken Nugget",
        Price = 2999.99M,
        IsAvailable = true,
        ProductTypeId = 3
    },
    new Product()
    {
        Name = "Holly, 11\"",
        Price = 44.99M,
        IsAvailable = true,
        ProductTypeId = 4
    },
    new Product()
    {
        Name = "Greater Flask of Smooth Sack",
        Price = 29.99M,
        IsAvailable = true,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Chocolate Tissue-Paper Cowl",
        Price = 24.99M,
        IsAvailable = false,
        ProductTypeId = 1
    }
};

Console.Clear();
Console.WriteLine("Welcome to Reductio & Absurdum!");

// User Menu
string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"-- Choose an option:
        0. Exit
        1. View all products
        2. Add product to inventory
        3. Delete product from inventory
        4. Update product details
        5. Filter by product type"
    );

    choice = Console.ReadLine();
    Console.Clear();
    if (choice == "0")
    {
        Console.WriteLine("Goodbye!");
    }
    else if (choice == "1")
    {
        ListProducts();
    }
    else if (choice == "2")
    {
        AddProduct();
    }
    else if (choice == "3")
    {
        DeleteProduct();
    }
    else if (choice == "4")
    {
        UpdateProduct();
    }
    else if (choice == "5")
    {
        FilterByProductType();
    }
    else 
    {
        Console.WriteLine("Invalid Input!");
    }
}   

void ListProducts()
{
    Console.WriteLine("Products:");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name} -- {productTypes[products[i].ProductTypeId - 1].Name} -- {products[i].Price}");
    }
}

void AddProduct()
{
    Console.WriteLine("-- Please enter the product name:");
    string nameRes = Console.ReadLine();

    Console.Clear();
    Console.WriteLine("-- Please enter the product price:");
    decimal priceRes = decimal.Parse(Console.ReadLine().Trim());

    Console.Clear();
    Console.WriteLine("-- Please select product type:");
    foreach (ProductType productType in productTypes)
    {
        Console.WriteLine($"{productType.Id}. {productType.Name}");
    }
    int typeRes = int.Parse(Console.ReadLine().Trim());

    Product newProduct = new Product()
    {
        Name = nameRes,
        Price = priceRes,
        IsAvailable = true,
        ProductTypeId = typeRes,
    };
    products.Add(newProduct);
    Console.Clear();
    Console.WriteLine($"{newProduct.Name} listed for sale!");

}

void DeleteProduct()
{
    Console.WriteLine("Please select a product to delete:");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name} -- {productTypes[products[i].ProductTypeId - 1].Name} -- {products[i].Price}");
    }
    int delistChoice = int.Parse(Console.ReadLine().Trim()) - 1;
    Console.WriteLine(delistChoice);
    products.RemoveAt(delistChoice);
    Console.Clear();
    Console.WriteLine($"Product deleted!");
}

void UpdateProduct()
{
    throw new NotImplementedException();
}

void FilterByProductType()
{
    throw new NotImplementedException();
}

