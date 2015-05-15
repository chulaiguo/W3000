using System.Data;
using Cheke.IExcelService;

namespace W3000.FacadeService
{
    public class BizExcelService : ServiceBase
    {
        public BizExcelService(Cheke.SecurityToken token)
            : base(token)
        {
        }

        public System.Data.DataTable GetSchemaTable(System.Byte[] data)
        {
            return this.Excel.GetSchemaTable(data);
        }

        public System.String[] GetExcelSheetsList(System.Byte[] data)
        {
            return this.Excel.GetExcelSheetsList(data);
        }

        public DataTable LoadIntoDataTable(byte[] data, string sheet, bool header)
        {
            return this.Excel.LoadIntoDataTable(data, sheet, header);
        }

        public DataSet LoadIntoDataSet(byte[] data, bool header)
        {
            return this.Excel.LoadIntoDataSet(data, header);
        }

        private IExcelServiceFactory Excel
        {
            get { return (IExcelServiceFactory)Cheke.ClassFactory.ClassBuilder.GetFactory("ExcelServiceFactory"); }
        }
    }
}
