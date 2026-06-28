## Domain Models vs Data Models

- lives in the Domain layer, focused on business logic behavior.  they dont care if they are saved in postgreSQL or any file. They have no database attributes.

- Data Models - these live in the infrastructure layer, they are focused purely on Storage. They contain foreign keys, database column names, and are designed to map exactly to a SQL table. 
- Zero business logic

Data model also called persistence models.
