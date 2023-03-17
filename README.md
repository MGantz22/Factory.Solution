# Factory Management 

#### By: Mitchell Gantz

An application to track machines and their engineers for a fictional factory.

## Technologies Used

* C#
* .Net 6
* ASP.Net EF Core 6
* SQL
* LINQ

## Project Requirements

  *  As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
  *  As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
  *  As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
  *  I should not be able to create an engineer or a machine if the form's fields are empty or contain invalid values.
  *  As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed.
  *  As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
  *  I should not be able to add a machine to an engineer if there are no machines. Likewise I should not be able to add an engineer to a machine if there are no engineers.
  *  When I access the application, I should see a splash page that lists all engineers and machines.

## Setup/Installation Requirements

#### To run this project, you will need:
* .NET 6.0
[https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

* .NET Core CLI
```
dotnet tool install --global dotnet-ef --version 6.0.0
```

1. Clone this repo to your workspace.

2. Navigate to the `Factory` directory.

3. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=root;pwd=epicodus;",
  }
}
```

4. Install dependencies within the `Factory` directory
```
$ dotnet restore
````

5. Build and run the program 
 ```
 $ dotnet run
 ```




## Known Bugs

- _If you find additional bugs not listed here, please email me at mgantz22@icloud.com with the subject_ **[_Repo Name_] Bug** _and include:_
  - BUG: _A brief description of the bug_
  - FIX: _Suggestion for solution (if you have one!)_
- _If you'd like to be credited, please also include your_ **_github user profile link_**

## Furture Implementations
- _Custom backgrounds for each page_
- _Interavtive page_
- _More styling_



## License

**MIT License**

Copyright (c) 2022 Mitchell Gantz

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.