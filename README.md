# Simple CRUD Operations with .Net Core and MongoDB

## Installation
Create your database environment-independent with Docker
1.
```bash
docker pull mongo:latest
```
2. Run the container default port
```bash
docker run -d -p 27017:27017 --name=mongo-example mongo:latest
```
After cloning the repository and creating your database, adjust your connection string in appsettings.json
```C#
"ConnectionString": "mongodb://localhost:27017",
```
