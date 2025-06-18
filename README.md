# Traffic Light Simulation

A Windows Forms application that simulates a traffic light system at an intersection.

## Functionality

*   **Traffic Light Cycle:** The simulation displays a four-way intersection with traffic lights. Each light cycles through Red, Yellow, and Green states in a coordinated manner to manage traffic flow.
*   **Countdown Timers:** Each traffic light has an associated countdown timer displayed, showing the seconds remaining for the current light state.
*   **Car Movement:** Cars are simulated on the roads and will stop at red lights and proceed when the light turns green.
*   **Simulation Control:**
    *   **Start Button:** Initiates the traffic light cycles, countdown timers, and car movement.
    *   **Stop Button:** Pauses the traffic light cycles, timers, and car movement.
*   **Street Lights:** Includes a feature to turn street lights on and off, affecting the visibility of the road markings (simulated by changing image visibility).

## Technologies Used

*   C#
*   Windows Forms
*   .NET Framework

## How to Run the Project

1.  **Clone the repository or download the source code.**
2.  **Open the solution file (`Traiffic Light Project.sln`) in Visual Studio.** (Make sure you have a version of Visual Studio that supports .NET Framework development, e.g., Visual Studio 2017 or later).
3.  **Build the solution.** You can do this by right-clicking on the solution in the Solution Explorer and selecting "Build Solution" or by using the "Build" menu.
4.  **Run the application.** Press F5 or click the "Start" button in Visual Studio. This will launch the Traffic Light Simulation window.

## Project Structure

*   `Traiffic Light Project.sln`: The main solution file for Visual Studio.
*   `README.md`: This file.
*   `Traiffic Light Project/`: Contains the source code and resources for the application.
    *   `FormMain.cs`: The main window of the application, containing the UI logic and simulation controls.
    *   `FormMain.Designer.cs`: Auto-generated code for the UI design of `FormMain`.
    *   `Program.cs`: The main entry point for the application.
    *   `Traiffic Light Project.csproj`: The C# project file, defining project settings and dependencies.
    *   `Properties/`: Contains assembly information and project settings.
    *   `Resources/`: Contains image files used for the traffic lights, cars, road background, etc.
    *   `bin/`: Contains the compiled output (executables and libraries).
    *   `obj/`: Contains temporary object files generated during compilation.
*   `.vs/`: Directory containing Visual Studio specific user settings and temporary files (often excluded from version control).
