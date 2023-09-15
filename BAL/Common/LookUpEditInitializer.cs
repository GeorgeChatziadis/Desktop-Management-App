using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace BAL.Common
{
    public static partial class LookUpEditInitializer
    {
        private static void SetProperties(RepositoryItemLookUpEdit lookUpEditGroup, string displayMember, string valueMember, string columnFieldName, string columnTitle)
        {
            lookUpEditGroup.DisplayMember = displayMember;
            lookUpEditGroup.ValueMember = valueMember;
            lookUpEditGroup.Columns.Clear();
            lookUpEditGroup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(columnFieldName, columnTitle) { AllowSort = DevExpress.Utils.DefaultBoolean.True, SortOrder = DevExpress.Data.ColumnSortOrder.Ascending });
            lookUpEditGroup.SortColumnIndex = 0;
            lookUpEditGroup.NullText = string.Empty;
        }

        public static void SetLookUpEdit(RepositoryItemLookUpEdit lookUpEditGroup, List<LookUpEditModel> dataSource)
        {
            lookUpEditGroup.DataSource = dataSource;
            SetProperties(lookUpEditGroup, "Designation", "ID", "Designation", "Ονομασία");
        }
    }
}
