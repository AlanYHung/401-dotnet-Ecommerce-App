# Lab26 Ecommercec-App

## Authors: Alan Hung and David Dicken

### Getting Started
* Open Visual Studio
* Clone [Ecommerce-App Git Repository](https://github.com/AlanYHung/401-dotnet-Ecommerce-App.git)
* Click Run

### ERD Visual
![](./401-dotnet-Ecommerce-App/assets/EcommerceERD.png)

### Explanation of Tables:
- **Category Table**: contains the differnt categories for the corals and holds the name of each category.
- **Product Table**: contains the prices, and the names of each coral for sale.
- **CategoryProduct Table**: contains the keys to items in the  Category and Product tables as a composite key. CategoryProduct table is a pure joint table.

### Explanation of Relationships:
-  *Category Table*:
   - Many:Many relationship w/ CategoryProduct table in order to get all the products in a category
- *CategoryProduct Table(joint entity table)*:
  - Many:Many w/ Category table so it can match the products for each category
  - Many:Many w/ Product table so that all products can be found for each category
- *Product Table* 
  - Many:Many w/ Category table in order to get price, and coral names found for each category

### API Routes
* __Category Routes:__ "/api/Category"
	* CREATE/POST Routes:
		* "/" - Let's you add Category objects to the database
	* READ/GET Routes:
		* "/" - Returns all Category objects in the database
		* "/{id}" - Returns the Category object with a matching id
	* UPDATE/PUT:
		* "/{id}" - Let's you modify the Category object with the matching id
	* DELETE/DELETE:
		* "/{id}" - Let's you remove the Category object with the matching id

* __Product Routes:__ "/api/Product"
	* CREATE/POST Routes:
		* "/" - Let's you add Product objects to the database
	* READ/GET Routes:
		* "/" - Returns all Product objects in the database
		* "/{ProductId}" - Returns the Category object with a matching id
	* UPDATE/PUT:
		* "/{id}" - Let's you modify the Product object with the matching id
	* DELETE/DELETE:
		* "/{id}" - Let's you remove the Product object with the matching id
    
### Change Log
* 0.1.0 - 2/15/2021 3:15pm - Initial Repo and Project Setup
* 0.3.0 - 2/15/2021 4:17pm - Added Models 
* 0.5.0 - 2/15/2021 5:25pm - Home Controller Added
* 0.6.0 - 2/15/2021 7:30pm - Added views

### Attribution
