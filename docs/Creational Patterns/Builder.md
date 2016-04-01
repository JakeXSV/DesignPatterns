# Builder

* Separate the construction of a complex object from its representation so that the same construction process can create different representations.

### Structure
![My image](./BuilderStructure.png)

### Participants
* Abstract Builder
* Concrete Builders
* Director - class using the builder
* Product

### System example
![My image](./BuilderConfiguration.png)

### When To Use


### Pros
* Finer control over construction process
* Isolates complexities of construction away from client that doesn't care

### Cons
* Create new builder or update a builder when a products internal representation changes
