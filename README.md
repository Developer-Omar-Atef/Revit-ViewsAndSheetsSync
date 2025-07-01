# ViewsAndSheetsSync for Revit

A C#/.NET add-in for Autodesk Revit that streamlines the management of View and Sheet parameters by enabling a bi-directional workflow with Microsoft Excel.

---

### 🎥 Demo

**(THIS IS THE MOST IMPORTANT PART!)**
*Create a 15-30 second GIF showing your tool in action and embed it here. Use a tool like ScreenToGif.*
*The GIF should show:
1.  Clicking the add-in button in the Revit ribbon.
2.  The WPF window appearing.
3.  Selecting "Sheets" and some parameters, then clicking "Export".
4.  Showing the generated Excel file.
5.  Changing a few values in the Excel file (e.g., "Drawn By", "Sheet Number").
6.  Going back to the tool and clicking "Import".
7.  Showing the updated parameters in the Revit properties panel.*

![ViewsAndSheetsSync Demo GIF](link_to_your_gif_once_uploaded.gif)

---

### 🎯 The Problem

In large-scale AEC projects, managing data across hundreds of sheets and views is a tedious and error-prone task. Manually updating parameters like "Drawn By", "Checked By", or custom revision information for each sheet is inefficient and does not scale.

### ✨ The Solution

ViewsAndSheetsSync provides a simple and intuitive interface to:

*   **Export Data:** Selectively export Views or Sheets and their chosen parameters to a clean, structured Excel file.
*   **Bulk Edit:** Use the power of Excel to quickly edit, fill down, and manage parameter data.
*   **Import Changes:** Import the modified Excel file back into Revit. The add-in will intelligently update the corresponding element parameters in the model.

---

### 🚀 Features

*   **Bi-directional Sync:** Export to Excel and import changes back into Revit.
*   **Element Support:** Works for both **Views** and **Sheets**.
*   **Dynamic Parameter Selection:** The tool automatically detects all available parameters for the selected element type.
*   **User-Friendly UI:** A clean WPF interface for a smooth user experience.
*   **Error Handling:** Provides feedback if imported data is invalid or if elements cannot be found.
*   **Safe Transactions:** Uses the Revit API's `TransactionGroup` to ensure that the entire import process is atomic (either all changes succeed, or none do).

---

### 🛠️ Tech Stack

*   **Languages & Frameworks:** C#, .NET Framework 4.8, WPF
*   **APIs & Libraries:** Revit API, **ClosedXML** for Excel manipulation
*   **Development Tools:** Visual Studio 2022, Git

---
