# DN Global Kitchen Manual - Recipe Management System #

This modern C# .NET 9.0 console application is designed for organizing and managing global cuisine recipes with a strongly-typed ingredient categorization system and interface-driven architecture.

This application is still a work in progress. Future functionality includes command line interpretation and data persistence. 

## 🚀 Key Features

- **Modern .NET 9.0**: Built with the latest .NET framework and C# language features
- **Type-Safe Design**: Comprehensive enum system for ingredient categorization
- **Global Cuisine Support**: Designed to handle diverse international cooking ingredients

## 🏗️ Technical Architecture

### Object-Oriented Design
- **Interface Segregation**: `IRecipe` interface defines clear contracts for recipe objects
- **Enum-Based Classification**: Strongly-typed ingredient categories preventing runtime errors
- **Namespace Organization**: Proper C# namespace structure for scalability
- **Modern Project Format**: SDK-style project with nullable reference types enabled

### Ingredient Management System
- **Categorized Enums**: Separate enumerations for vegetables, meats, spices, liquids, and baking ingredients
- **Type Casting Support**: Enum to integer conversion for database persistence
- **Extensible Design**: Easy addition of new ingredient categories and types

### Data Modeling
- **Dictionary-Based Storage**: Efficient ingredient quantity management using `Dictionary<object, int>`
- **Flexible Typing**: Object keys allow for different ingredient type representations
- **Recipe Metadata**: Support for recipe names, descriptions, and categorization

## 💻 Technologies Used

- **.NET 9.0**: Latest Microsoft .NET framework with performance improvements
- **C# 13**: Modern C# with nullable reference types and latest language features
- **Visual Studio**: Professional IDE with solution and project management
- **Console Application**: Command-line interface for cross-platform compatibility

## 🔧 Technical Highlights

### Interface Design
```csharp
public interface IRecipe
{
    string Name { get; set; }
    string Description { get; set; }
    Dictionary<object, int> Ingredients { get; set; }
    
    // Future expansion for cooking methods, timing, etc.
}
```

### Strongly-Typed Ingredient System
```csharp
public enum Vegetable
{
    Onion = 1,
    Garlic = 2,
    Tomato = 3,
    Carrot = 4,
    Celery = 5,
    Potato = 6,
    BellPepper = 7
}

public enum Meat
{
    Chicken = 1,
    Beef = 2,
    Pork = 3,
    Fish = 4,
    Lamb = 5,
    Turkey = 6
}
```

### Extensible Enum Architecture
```csharp
public enum BakingIng
{
    Flour = 1,
    Sugar = 2,
    Butter = 3,
    Eggs = 4,
    BakingPowder = 5,
    BakingSoda = 6,
    Vanilla = 7,
    Salt = 8
}
```

### Future Recipe Implementation
```csharp
public class Recipe : IRecipe
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Dictionary<object, int> Ingredients { get; set; }
    
    public Recipe()
    {
        Ingredients = new Dictionary<object, int>();
    }
    
    // Methods for adding ingredients with type safety
    public void AddIngredient(Vegetable vegetable, int quantity)
    {
        Ingredients[vegetable] = quantity;
    }
    
    public void AddIngredient(Meat meat, int quantity)
    {
        Ingredients[meat] = quantity;
    }
}
```

## 🎯 Skills Demonstrated

- **Modern C# Programming**: Latest .NET 9.0 features and language constructs
- **Interface Design**: Clean interface definition with extensible contracts
- **Type Safety**: Enum-based design preventing runtime type errors
- **Object-Oriented Principles**: Proper encapsulation and abstraction
- **Domain Modeling**: Real-world problem modeling with appropriate abstractions

## 🚀 Getting Started

### Prerequisites
- .NET 9.0 SDK
- Visual Studio 2022 or higher (recommended)
- Alternative: VS Code with C# extension

### Installation & Running
```bash
# Clone the repository
git clone <repository>
cd DNGlobalKitchenManual

# Restore dependencies and build
dotnet restore
dotnet build

# Run the application
cd DNGKM
dotnet run
```

### Visual Studio
```bash
# Open solution in Visual Studio
start DNGKM.sln

# Or using Visual Studio Code
code .
```

## 🏗️ Project Structure

```
DNGlobalKitchenManual/
├── DNGKM.sln                 # Visual Studio solution file
├── DNGKM/                    # Main project directory
│   ├── DNGKM.csproj         # Modern .NET 9.0 project file
│   ├── Program.cs           # Application entry point
│   ├── Enums/               # Ingredient categorization
│   │   ├── Vegetable.cs     # Vegetable enumeration
│   │   ├── Meat.cs          # Meat enumeration
│   │   ├── Spice.cs         # Spice enumeration
│   │   ├── Liquid.cs        # Liquid enumeration
│   │   └── BakingIng.cs     # Baking ingredient enumeration
│   ├── Interfaces/          # Contract definitions
│   │   └── IRecipe.cs       # Recipe interface
│   ├── Recipes/             # Recipe implementations (future)
│   ├── bin/                 # Compiled binaries
│   └── obj/                 # Build artifacts
└── README.md                # This documentation
```

## 🔧 Future Enhancements

The foundation supports expansion into:

### CLI Recipe Management

### Database Integration

### Nutritional Information


## 📊 Design Benefits

- **Type Safety**: Compile-time verification of ingredient types
- **Intellisense Support**: Full IDE autocomplete for ingredient selection  
- **Maintainability**: Clear separation of concerns with organized structure
- **Extensibility**: Easy addition of new ingredient categories and recipe types
- **Performance**: Enum-based approach with minimal memory footprint

This project demonstrates modern C# development practices, object-oriented design principles, and the foundation for a scalable recipe management system. It showcases interface design, type safety, and project organization suitable for enterprise-level applications.
