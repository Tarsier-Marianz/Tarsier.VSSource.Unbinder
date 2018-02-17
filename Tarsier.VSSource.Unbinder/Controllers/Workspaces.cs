using Tarsier.VSSource.Unbinder.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Tarsier.Config;
using Tarsier.Extensions;
using Tarsier.UI;

namespace Tarsier.VSSource.Unbinder.Controllers {
    public class Workspaces {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "workspace";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public Workspaces(string filename) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }

        public void CreateTable(string tableName) {
            defaultTable = tableName;
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("Name", ColType.Text));
            table.AddColumn(new SQLiteColumn("WorkspaceTable", ColType.Text));
            table.AddColumn(new SQLiteColumn("FileCount", ColType.Integer));
            table.AddColumn(new SQLiteColumn("ValidFiles", ColType.Integer));
            table.AddColumn(new SQLiteColumn("Directory", ColType.Text));
            table.AddColumn(new SQLiteColumn("Code", ColType.Text));
            table.AddColumn(new SQLiteColumn("Comment", ColType.Text));
            table.AddColumn(new SQLiteColumn("LastDateUnbind", ColType.Text));
            sqlite.CreateTable(table);
        }
        public bool ClearWorkspaces() {
            try {
                if(sqlite.IsTableExist(defaultTable)) {
                    sqlite.DropTable(defaultTable);
                    return true;
                }
            } catch {
            }
            return false;
        }
        public DataTable GetDataTable(string filter) {
            if(string.IsNullOrEmpty(defaultTable)) {
                return null;
            }
            return sqlite.GetDataTable(defaultTable);
        }

        public List<Workspace> GetProfiles() {
            List<Workspace> profs = new List<Workspace>();
            DataTable dt = GetDataTable(string.Empty);
            if(dt.Rows.Count > 0) {
                foreach(DataRow dr in dt.Rows) {
                    Workspace pro = new Workspace() {
                        ID = dr["ID"].ToSafeInteger(),
                        Name = dr["Name"].ToSafeString(),
                        WorkspaceTable = dr["WorkspaceTable"].ToSafeString(),
                        FileCount = dr["FileCount"].ToSafeInteger(),
                        ValidFiles = dr["ValidFiles"].ToSafeInteger(),
                        Directory = dr["Directory"].ToSafeString(),
                        Comment = dr["Comment"].ToSafeString(),
                        LastDateUnbind = dr["LastDateUnbind"].ToSafeString()
                    };
                    profs.Add(pro);
                }
            }
            return profs;
        }
        public void Add(Workspace pro) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            string code = pro.Directory.RemoveNonAlphaNumeric().ToLower();
            string workspaceTable = string.IsNullOrEmpty(pro.WorkspaceTable) ? (pro.Name.RemoveNonAlphaNumeric() +code.GetHashCode()).ToLower(): pro.WorkspaceTable;
            string dateUploaded = string.IsNullOrEmpty(pro.LastDateUnbind) ? DateTime.Now.ToShortDateString() : pro.LastDateUnbind;
            data.Add("Name", pro.Name);
            data.Add("WorkspaceTable", workspaceTable);
            data.Add("FileCount", pro.FileCount);
            data.Add("ValidFiles", pro.ValidFiles);
            data.Add("Directory", pro.Directory);
            data.Add("Code", code);
            data.Add("Comment", pro.Comment);
            data.Add("LastDateUnbind", dateUploaded);
            if(sqlite.IsExist(defaultTable, "Code", code.ToStringType())) {
                sqlite.Update(defaultTable, data, "Code", code);
            } else {
                sqlite.Insert(defaultTable, data);
            }
        }
        public string GetPath(string name) {
            if(string.IsNullOrEmpty(name)) {
                return string.Empty;
            }
            return sqlite.GetColumnValue(defaultTable, "Path", string.Format("Name ='{0}'", name));
        }
        public Workspace GetProfile(string name) {
            if(string.IsNullOrEmpty(name)) {
                throw new ArgumentNullException("name");
            }
            DataTable dt = sqlite.Select(string.Format(Queries.SELECT_TABLE_WHERE_LIMIT1, defaultTable, string.Format("Name ='{0}'", name)));
            if(dt != null) {
                if(dt.Rows.Count > 0) {
                    foreach(DataRow dr in dt.Rows) {
                        return new Workspace() {
                            ID = dr["ID"].ToSafeInteger(),
                            Name = dr["Name"].ToSafeString(),
                            WorkspaceTable = dr["WorkspaceTable"].ToSafeString(),
                            FileCount = dr["FileCount"].ToSafeInteger(),
                            ValidFiles = dr["ValidFiles"].ToSafeInteger(),
                            Directory = dr["Directory"].ToSafeString(),
                            Comment = dr["Comment"].ToSafeString(),
                            LastDateUnbind = dr["LastDateUnbind"].ToSafeString()
                        };
                    }
                }
            }
            return null;
        }
        public void Initialize(ListBox list) {
            if(list != null) {
                list.Items.Clear();
                List<Workspace> profs = GetProfiles();
                if(profs.Count > 0) {
                    foreach(Workspace p in profs) {
                        list.Items.Add(p.Name);
                    }
                }
            }
        }
        public void Initialize(MessageListBox list) {
            if(list != null) {
                list.Items.Clear();
                List<Workspace> profs = GetProfiles();
                if(profs.Count > 0) {
                    foreach(Workspace p in profs) {
                        list.Items.Add(new ParseMessageEventArgs(ParseMessageType.Profile, p.Name, p.Directory, "workspace" + p.ID, p.LastDateUnbind));
                    }
                } else {
                    list.Items.Add(new ParseMessageEventArgs(ParseMessageType.Info, "No workspace found!", "Add folder to create new workspace.", "0", string.Empty));
                }
                list.Invalidate();
            }
        }
        
    }
}