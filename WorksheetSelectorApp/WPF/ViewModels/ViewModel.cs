//using System.Collections.Generic;
//using Jbpc.Common.Excel.Proxies;
//using Jbpc.Common.Excel.Proxies.Abstract;
//using WorksheetSelectorApp.Models;
//using ReactiveUI;

//namespace WorksheetSelectorApp.ViewModels
//{
//    public class ViewModel : ReactiveObject
//    {
//        private IWorkbook _workbook;
//        private IWorksheet _worksheet;
//        private List<string> _worksheats = new List<string>();
//        private SettingsJsonPersistence<WorksheetSelectorSettings> _workbookSelectorSettings;
//        public IWorkbook Workbook
//        {
//            get => _workbook;
//            set => this.RaiseAndSetIfChanged(ref _workbook, value);
//        }
//        public IWorksheet Worksheet
//        {
//            get => _worksheet;
//            set => this.RaiseAndSetIfChanged(ref _worksheet, value);
//        }
//        public List<string> WorksheetNames
//        {
//            get => _worksheats;
//            set => this.RaiseAndSetIfChanged(ref _worksheats, value);
//        }
//        public List<string> WorkbookSelectorSettings
//        {
//            get => _worksheats;
//            set => this.RaiseAndSetIfChanged(ref _worksheats, value);
//        }
//    }
//}
