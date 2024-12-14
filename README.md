# JWT Token Authentication API

## Overview

This is a `.NET 8 Web API` for JWT Token Authentication, Bike Rentals, and related entities.

### Base URL

```
https://bikerental-hpdca3d2ashje9h5.canadacentral-01.azurewebsites.net
```

---

## Authentication

The API uses **JWT Bearer Authentication**.

### Authorization Header

```
Authorization: Bearer <your-token>
```

---

## Endpoints

### **Authentification**

#### 1. Register a User

**POST** `/api/Authentification/register`

**Request Body:**

```json
{
  "username": "string",
  "email": "string",
  "password": "string",
  "role": 0
}
```

**Response:**

```json
{
  "id": 1,
  "username": "string",
  "accessToken": "string",
  "role": 0
}
```

#### 2. Login

**POST** `/api/Authentification/login`

**Request Body:**

```json
{
  "username": "string",
  "password": "string"
}
```

**Response:**

```json
{
  "id": 1,
  "username": "string",
  "accessToken": "string",
  "role": 0
}
```

---

### **Bike**

#### 1. Get All Bikes

**GET** `/api/Bike/GetAll`

#### 2. Get Bike by ID

**GET** `/api/Bike/GetById`

**Query Parameters:**

- `id` (integer): Bike ID

#### 3. Add a Bike

**POST** `/api/Bike/add`

**Request Body:**

```json
{
  "description": "string",
  "photoUrl": "string",
  "pricePerHour": 0.0,
  "bikeModelId": 1,
  "rentingCenterId": 1
}
```

#### 4. Delete a Bike

**DELETE** `/api/Bike/Delete`

**Query Parameters:**

- `id` (integer): Bike ID

#### 5. Update a Bike

**PUT** `/api/Bike/Update`

**Query Parameters:**

- `id` (integer): Bike ID

**Request Body:**

```json
{
  "description": "string",
  "photoUrl": "string",
  "pricePerHour": 0.0,
  "bikeModelId": 1,
  "rentingCenterId": 1
}
```

---

### **BikeModel**

#### 1. Get All Bike Models

**GET** `/api/BikeModel/GetAll`

#### 2. Get Bike Model by ID

**GET** `/api/BikeModel/GetById`

**Query Parameters:**

- `id` (integer): Bike Model ID

#### 3. Add a Bike Model

**POST** `/api/BikeModel/add`

**Request Body:**

```json
{
  "name": "string",
  "brandId": 1
}
```

#### 4. Delete a Bike Model

**DELETE** `/api/BikeModel/Delete`

**Query Parameters:**

- `id` (integer): Bike Model ID

#### 5. Update a Bike Model

**PUT** `/api/BikeModel/Update`

**Query Parameters:**

- `id` (integer): Bike Model ID

**Request Body:**

```json
{
  "name": "string",
  "brandId": 1
}
```

---

### **Brand**

#### 1. Get All Brands

**GET** `/api/Brand/GetAll`

#### 2. Get Brand by ID

**GET** `/api/Brand/GetById`

**Query Parameters:**

- `id` (integer): Brand ID

#### 3. Add a Brand

**POST** `/api/Brand/add`

**Request Body:**

```json
{
  "name": "string",
  "description": "string"
}
```

#### 4. Delete a Brand

**DELETE** `/api/Brand/Delete`

**Query Parameters:**

- `id` (integer): Brand ID

#### 5. Update a Brand

**PUT** `/api/Brand/Update`

**Query Parameters:**

- `id` (integer): Brand ID

**Request Body:**

```json
{
  "name": "string",
  "description": "string"
}
```

---

### **Order**

#### 1. Get All Orders

**GET** `/api/Order/GetAll`

#### 2. Get Order by ID

**GET** `/api/Order/GetById`

**Query Parameters:**

- `id` (integer): Order ID

#### 3. Get Orders by Bike ID

**GET** `/api/Order/GetByBikeId`

**Query Parameters:**

- `bikeId` (integer): Bike ID

#### 4. Add an Order

**POST** `/api/Order/add`

**Request Body:**

```json
{
  "toPay": 0.0,
  "userId": 1,
  "bikeId": 1
}
```

#### 5. Delete an Order

**DELETE** `/api/Order/Delete`

**Query Parameters:**

- `id` (integer): Order ID

#### 6. Update an Order

**PUT** `/api/Order/Update`

**Query Parameters:**

- `id` (integer): Order ID

**Request Body:**

```json
{
  "toPay": 0.0,
  "userId": 1,
  "bikeId": 1
}
```

---

### **RentingCenter**

#### 1. Get All Renting Centers

**GET** `/api/RentingCenter/GetAll`

#### 2. Get Renting Center by ID

**GET** `/api/RentingCenter/GetById`

**Query Parameters:**

- `id` (integer): Renting Center ID

#### 3. Get Available Centers by Bike ID

**GET** `/api/RentingCenter/AvailableCenters`

**Query Parameters:**

- `bikeId` (integer): Bike ID

#### 4. Add a Renting Center

**POST** `/api/RentingCenter/add`

**Request Body:**

```json
{
  "latitude": 0.0,
  "longitude": 0.0
}
```

#### 5. Delete a Renting Center

**DELETE** `/api/RentingCenter/Delete`

**Query Parameters:**

- `id` (integer): Renting Center ID

#### 6. Update a Renting Center

**PUT** `/api/RentingCenter/Update`

**Query Parameters:**

- `id` (integer): Renting Center ID

**Request Body:**

```json
{
  "latitude": 0.0,
  "longitude": 0.0
}
```

---

## Data Transfer Objects (DTOs)

### 1. CreateUserDTO

```json
{
  "username": "string",
  "email": "string",
  "password": "string",
  "role": 0
}
```

### 2. LoginUserDTO

```json
{
  "username": "string",
  "password": "string"
}
```

### 3. UserDTO

```json
{
  "id": 1,
  "username": "string",
  "accessToken": "string",
  "role": 0
}
```

### 4. CreateBikeDTO

```json
{
  "description": "string",
  "photoUrl": "string",
  "pricePerHour": 0.0,
  "bikeModelId": 1,
  "rentingCenterId": 1
}
```

### 5. CreateBikeModelDTO

```json
{
  "name": "string",
  "brandId": 1
}
```

### 6. CreateBrandDTO

```json
{
  "name": "string",
  "description": "string"
}
```

### 7. CreateOrderDTO

```json
{
  "toPay": 0.0,
  "userId": 1,
  "bikeId": 1
}
```

### 8. CreateRentingCenterDTO

```json
{
  "latitude": 0.0,
  "longitude": 0.0
}
```

---

## Security

- **JWT Bearer Token**: Add `Authorization: Bearer <token>` to the headers of secured endpoints.

---

### Notes

- Replace `<your-token>` with a valid JWT token for secured requests.
- Ensure all required fields in the DTOs are provided to avoid validation errors.

