# ViewsAndSheetsSync for Revit

A C#/.NET add-in for Autodesk Revit that streamlines the management of View and Sheet parameters by enabling a bi-directional workflow with Microsoft Excel.

---

### 🎥 Demo

![ViewsAndSheetsSync Demo GIF]([Promotional Video.gif](https://github.com/Developer-Omar-Atef/Revit-ViewsAndSheetsSync/blob/main/Promotional%20Video.gif))

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
