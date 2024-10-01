# CrossplatformLabs Project

This project consists of multiple labs, each with its own console application and unit tests. Follow the instructions below to build, test, and run the labs.

## Prerequisites

Before you begin, ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

## Building and Running Labs

### Building a Specific Lab

To build a specific lab, follow these steps:

1. **Open Terminal**: Navigate to the root directory of the `CrossplatformLabs` project.

2. **Run Build Command**:
   - To build **Lab1**:
     ```bash
     dotnet msbuild build.proj /p:SelectedLab=Lab1
     ```

   - To build **Lab2**:
     ```bash
     dotnet msbuild build.proj /p:SelectedLab=Lab2
     ```

   - To build **Lab3**:
        ```bash
        dotnet msbuild build.proj /p:SelectedLab=Lab3
        ```

3. **Monitor Output**: Observe the terminal for any errors or warnings during the build process.

### Running Unit Tests for a Specific Lab

To run the unit tests for a specific lab:

1. **Open Terminal**: Navigate to the root directory of the `CrossplatformLabs` project.

2. **Run Test Command**:
   - To test **Lab1**:
     ```bash
     dotnet msbuild build.proj /t:TestLab1
     ```

   - To test **Lab2**:
     ```bash
     dotnet msbuild build.proj /t:TestLab2
     ```

   - To test **Lab3**:
        ```bash
        dotnet msbuild build.proj /t:TestLab3
        ```

3. **Monitor Output**: Watch the terminal for the results of the unit tests.

### Running a Specific Lab Console Application

To run a specific lab’s console application:

1. **Open Terminal**: Navigate to the root directory of the `CrossplatformLabs` project.

2. **Run the Application Command**:
   - To run **Lab1**:
     ```bash
     dotnet msbuild build.proj /t:RunLab1
     ```

   - To run **Lab2**:
     ```bash
     dotnet msbuild build.proj /t:RunLab2
     ```

   - To run **Lab3**:
        ```bash
        dotnet msbuild build.proj /t:RunLab3
        ```


