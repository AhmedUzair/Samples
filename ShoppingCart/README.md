# Shopping Cart .NET Project

## Overview

This .NET core 6 project is a basic implementation of a shopping cart system. It allows users to browse products, add them to the cart, and proceed to checkout. It also includes the basic infrastructure of the following features:

## Authentication

1. The solution is integrated with AD Authentication
2. It is also equipped to Authenticate Requests based on Bearer tokens, we can also partially authenticate a request

## Logging

1. The system is integrated with Application Insights to log events across different flows

## Middleware/Fault Tolerance

1. The system consists of Middleware that can handle any sort of faults that may occur during the execution of requests. 

## Database

1. Any sort of data base can be incorporated with the integrated Repository Pattern

## Project Structure

### 1. **ShoppingCart.API**
   - **Description:** Main project folder, that container controllers for Product, Checkout and Cart.

### 2. **ShoppingCart.Core**
   - **Description:** Core library containing essential business logic.

### 3. **ShoppingCart.Persistance**
   - **Description:** Consists of Database core functionalities.

## Getting Started

1. Clone the repository.
2. Open `ShoppingCart.sln` in Visual Studio.

## Usage

1. List, add or update Products.
2. Add products to shopping cart.
3. List Items in Cart
3. Proceed to checkout.
