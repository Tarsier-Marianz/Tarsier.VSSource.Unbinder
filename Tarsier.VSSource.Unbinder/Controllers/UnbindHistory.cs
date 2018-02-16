using Tarsier.VSSource.Unbinder.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Tarsier.Config;
using Tarsier.Extensions;
using Tarsier.UI;

namespace Tarsier.VSSource.Unbinder.Controllers {
    public class UnbindHistory {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "history";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public UnbindHistory(string filename) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }

        public void CreateTable(string tableName) {
            defaultTable = tableName;
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("FileCount", ColType.Text));
            table.AddColumn(new SQLiteColumn("Code", ColType.Text));
            table.AddColumn(new SQLiteColumn("DateUnbind", ColType.Text));
            table.AddColumn(new SQLiteColumn("TimeUnbind", ColType.Text));
            sqlite.CreateTable(table);
        }

        public DataTable GetDataTable(bool orderDesc) {
            if(string.IsNullOrEmpty(defaultTable)) {
                return null;
            }
            if(orderDesc) {
                return sqlite.Select(string.Format(Queries.SELECT_TABLE_DESC, defaultTable,"ID"));
            }
            return sqlite.GetDataTable(defaultTable);
        }

        public List<History> GetHistories() {
            List<History> profs = new List<History>();
            DataTable dt = GetDataTable(true);
            if(dt.Rows.Count > 0) {
                foreach(DataRow dr in dt.Rows) {
                    History pro = new History() {
                        ID = dr["ID"].ToSafeInteger(),
                        FileCount = dr["FileCount"].ToSafeInteger(),
                        Code = dr["Code"].ToSafeString(),
                        DateUnbind = dr["DateUnbind"].ToSafeString(),
                        TimeUnbind = dr["TimeUnbind"].ToSafeString()
                    };
                    profs.Add(pro);
                }
            }
            return profs;
        }
        public void Add(History h) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            
            string dateUploaded = string.IsNullOrEmpty(h.DateUnbind) ? DateTime.Now.ToShortDateString() : h.DateUnbind;
            string timeUploaded = string.IsNullOrEmpty(h.TimeUnbind) ? DateTime.Now.ToString("hh:mm:ss tt") : h.TimeUnbind;
            string code=( dateUploaded+ timeUploaded).RemoveNonAlphaNumeric().ToLower();
            data.Add("FileCount", h.FileCount);
            data.Add("Code", code);
            data.Add("DateUnbind", dateUploaded);
            data.Add("TimeUnbind", timeUploaded);
            if(sqlite.IsExist(defaultTable, "Code", code.ToStringType())) {
                sqlite.Update(defaultTable, data, "Code", code);
            } else {
                sqlite.Insert(defaultTable, data);
            }
        }

        public void Add(Workspace pro) {
            if(pro != null) {
                History hist = new History() {
                    FileCount = pro.FileCount,
                    DateUnbind = DateTime.Now.ToShortDateString(),
                     TimeUnbind= DateTime.Now.ToString("hh:mm:ss tt")
                };
                Add(hist);
            }
        }

        public History GetHistory(string version) {
            if(string.IsNullOrEmpty(version)) {
                throw new ArgumentNullException("version");
            }
            DataTable dt = sqlite.Select(string.Format(Queries.SELECT_TABLE_WHERE_LIMIT1, defaultTable, string.Format("Version ='{0}'", version)));
            if(dt != null) {
                if(dt.Rows.Count > 0) {
                    foreach(DataRow dr in dt.Rows) {
                        return new History() {
                            ID = dr["ID"].ToSafeInteger(),
                            FileCount = dr["FileCount"].ToSafeInteger(),
                            Code = dr["Code"].ToSafeString(),
                            DateUnbind = dr["DateUnbind"].ToSafeString(),
                            TimeUnbind = dr["TimeUnbind"].ToSafeString()
                        };
                    }
                }
            }
            return null;
        }

        public void Initialize(ListView list, string table) {
            defaultTable = table;
            if(!sqlite.IsTableExist(table.Trim())) {
                return;
            }
            List<History> histories = GetHistories();
            if(histories.Count > 0) {
                foreach(History h in histories) {
                    ListViewItem item = new ListViewItem(h.FileCount.ToSafeString(), 5);
                    item.UseItemStyleForSubItems = false;
                    item.SubItems.Add(h.DateUnbind);
                    item.SubItems.Add(h.TimeUnbind);
                    item.SubItems[1].ForeColor = Color.DarkGray;
                    item.SubItems[2].ForeColor = Color.Gray;
                    item.SubItems[3].ForeColor = Color.Gray;
                    if(list.InvokeRequired) {
                        list.Invoke((MethodInvoker)delegate () {
                            list.Items.Add(item);
                        });
                    } else {
                        list.Items.Add(item);
                    }
                }
            }
        }

    }
}
