# Crypto Coinic

## Overview
This is an MVC application designed to consume an API and monitor different cryptocurrency rates. The application provides real-time updates..

## Features
- Real-time cryptocurrency rate monitoring
- Customizable alerts for rate changes

## Technologies Used
- ASP.NET MVC

## Building the Solution

To build this solution you can use **MSBuild**, which is included with Visual Studio or the .NET SDK.

### Prerequisites
- Ensure that **MSBuild** is installed.  
  - It comes with **Visual Studio** (2019 or later).  
  - Alternatively, you can install **[Build Tools for Visual Studio](https://visualstudio.microsoft.com/downloads/)** if you don’t want the full IDE.
- Make sure that MSBuild is in your PATH.

### Build Instructions
1. Open a **command prompt** or **PowerShell**.
2. Navigate to the directory where your `.sln` file is located:
```
cd path\to\your\solution
```
3. Run the following command to build the solution in **Release** mode:
```
msbuild CryptoCoinic.sln /p:Configuration=Release
```
- To build in **Debug** mode, replace `Release` with `Debug`:

## Running the application
- Once the solution is built, you can find the executable file in the project folder.
```
.\CryptoCoinic.View.WindowsForms\bin\Release\CryptoCoinic.View.WindowsForms.exe
```