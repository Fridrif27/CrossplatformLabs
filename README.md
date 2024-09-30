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

3. **Monitor Output**: Observe the terminal for any errors or warnings during the build and test processes.

### Building All Labs

To build and run all projects located in the `Lab` directories:

1. **Navigate to the root directory of the `CrossplatformLabs` project**

2. **Run the Following Command**:
   ```bash
   dotnet msbuild build.proj
