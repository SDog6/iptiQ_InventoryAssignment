# iptiQ_InventoryAssignment

### Introduction
This project is in regards to the assignment given to me by iptiQ. The goal of this project is to make a simple inventory system. Exact requirements can be read below

Design and build a simple inventory service. The inventory stores items. Items should have a name,
a quantity, and a price. The service should be able to list all the items in the inventory and have
a way to add and remove items and to update their details. You need to develop an initial mock
implementation of the service using your preferred programming language.

----------------------------------------------------------------------------------------------------

As well as deliverables: 

Deliverables
Create a high-level overview diagram of the service and/or the code supporting your design. Add a
general description of the main features and capabilities. Prepare a list of questions that you would
like to discuss with the team that you will be working with on the implementation of your design.

### Explanation of finished project

With the finished design of the inventory system a user can:
1.Create an inventory item that will be stored in a local Sql database.
 - Item has an id (auto-generated),name,quantity and price.
 - Item's ID cannot be specifed upon creation and cannot be modified.
 - Item can only be created if quantity/price input are in integer/double format, respectively.
 - Item cannot be created if quantity/price input is below 0 but it is possible to be created if inputs are 0.
2.Get all of the inventory items currently stored in the local database. 
3.Update an item name/quantity/price by giving the specifing which item they want to update using item ID.
4.Delete an item by selecting it from the datagrid

NOTE: Upon closing of the project from the IDE the data stored in the local database get's deleted.
