using Autodesk.Revit.UI;
using System;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace ViewsAndSheetsSync
{
    /// <summary>
    /// The main entry point for the Revit Add-in. This class is responsible for
    /// setting up the custom Ribbon Tab, Panel, and Buttons when Revit starts.
    /// </summary>
    public class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            try
            {
                string tabName = "KAITECH-BD-R08";
                application.CreateRibbonTab(tabName);
                RibbonPanel ribbonPanel = application.CreateRibbonPanel(tabName, "General");
                string assemblyPath = Assembly.GetExecutingAssembly().Location;

                // --- Create the "Views Sync" Button, pointing to its own command ---
                var viewsButtonData = new PushButtonData(
                    "ViewsSyncButton", "Views Sync", assemblyPath, "ViewsAndSheetsSync.ViewsSyncCommand");
                viewsButtonData.ToolTip = "Sync View data with an Excel file.";
                viewsButtonData.LargeImage = new BitmapImage(new Uri($"pack://application:,,,/{Assembly.GetExecutingAssembly().GetName().Name};component/Resources/view_icon_32.png"));

                // --- Create the "Sheets Sync" Button, pointing to its own command ---
                var sheetsButtonData = new PushButtonData(
                    "SheetsSyncButton", "Sheets Sync", assemblyPath, "ViewsAndSheetsSync.SheetsSyncCommand");
                sheetsButtonData.ToolTip = "Sync Sheet data with an Excel file.";
                sheetsButtonData.LargeImage = new BitmapImage(new Uri($"pack://application:,,,/{Assembly.GetExecutingAssembly().GetName().Name};component/Resources/sheet_icon_32.png"));

                ribbonPanel.AddItem(viewsButtonData);
                ribbonPanel.AddItem(sheetsButtonData);

                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Error", $"Could not initialize add-in: {ex.Message}");
                return Result.Failed;
            }
        }

        public Result OnShutdown(UIControlledApplication application) => Result.Succeeded;
    }
}