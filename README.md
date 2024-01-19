# Person List with ArrayList

This program creates a simple list of people using the `ArrayList` class in C#. 
Each person is represented by a name and age and is stored in an instance of the `Person` class. 
The user will be prompted to enter the name and age for three individuals, 
and the program will then print out the information about these people.

## Usage

1. Run the program.
2. Follow the prompts to enter the name and age for each of the three individuals.

## Code Structure

### `Person` Class

- `Name`: Property holding the person's name.
- `Age`: Property holding the person's age.
- `Person(string name, int age)`: Constructor to create a new instance of the person with the specified name and age.
- `ToString()`: Overridden method returning a string representation of the person.

### `Main` Method

- Creates an empty list (`ArrayList`) to store person objects.
- Uses a loop to prompt the user to enter the name and age for three people, adding them to the list.
- Prints out the list of people.
