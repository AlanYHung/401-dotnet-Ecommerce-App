# Lab11-13 ERD Framework / API

## Authors: Alan Hung and David Dicken

### Getting Started
* Open Visual Studio
* Clone [Ecommerce-App Git Repository](https://github.com/AlanYHung/401-dotnet-Ecommerce-App.git)
* Click Run

### ERD Visual
![](./Asyn-Inn/401-dotnet-Ecommerce-App/assets/EcommerceERD.png)

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
    
* __Room Routes:__ "/api/Rooms"
	* CREATE/POST Routes:
		* "/" - Let's you add room objects to the database
	* READ/GET Routes:
		* "/" - Returns all room objects in the database
		* "/{Id}" - Returns the room object with a matching id
	* UPDATE/PUT:
		* "/{Id}" - Let's you modify the room object with the matching id
	* DELETE/DELETE:
		* "/{Id}" - Let's you remove the room object with the matching id

	*__Room Amenities:__ "/api/Rooms"
		* CREATE/POST Routes:
			* "/{amenityId}/{roomId}" - Let's you add roomamenity objects to the database
		* DELETE/DELETE:
			* "/{amenityId}/{roomId}" - Let's you remove the roomamenity object with the matching id


* __Amenities Routes:__ "/api/Amenities"
	* CREATE/POST Routes:
		* "/" - Let's you add Amenities objects to the database
	* READ/GET Routes:
		* "/" - Returns all Amenities objects in the database
		* "/{Id}" - Returns the Amenities object with a matching id
	* UPDATE/PUT:
		* "/{Id}" - Let's you modify the Amenities object with the matching id
	* DELETE/DELETE:
		* "/{Id}" - Let's you remove the Amenities object with the matching id

* __Identity Routes:__ "/api/Users"
	* CREATE/POST Routes:
		* "/Register" - Let's you add new user objects to the database
	* LOGIN/POST Routes:
		* "/Login" - Retrieves a user inputed object
	* ME/GET
		* /me - Gets and returns a user object

### Change Log
* 0.1.0 - 1/26/2021 3:15pm - Initial Repo and Project Setup
* 0.3.0 - 1/26/2021 3:50pm - Database & Models Added
* 0.6.0 - 1/26/2021 4:17pm - All Models Completed and Added
* 0.8.0 - 1/26/2021 5:05pm - All Models Seeded
* 1.0.0 - 1/26/2021 5:25pm - Controllers Added
* 1.0.5 - 1/27/2021 3:30pm - Dependence Injection Refactoring of Rooms
* 1.0.8 - 1/27/2021 4:22pm - Dependence Injection Refactoring of Hotel and Amenities
* 1.5.8 - 1/28/2021 6:30pm - Added RoomAmenities Navigation and Relationships
* 1.7.8 - 1/28/2021 9:00pm - Added HotelRoom Interface and Repository
* 2.0.8 - 1/29/2021 5:56pm - Added HotelRoom Controller and tested all methods
* 2.3.8 - 2/01/2021 10:00pm - DTO Refactoring completed of Hotels, Rooms, Amenities, and HotelRooms
* 2.4.8 - 2/02/2021 5:26pm - DTO Bugs Fixed all Tested and Working
* 2.5.8 - 2/03/2021 7:45pm - App Deployment
* 2.6.8 - 2/05/2021 12:00pm - Authorization and Authentication Completed

### Attribution
* [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/)
* [JSON to C# Class Constructor](https://json2csharp.com/)
