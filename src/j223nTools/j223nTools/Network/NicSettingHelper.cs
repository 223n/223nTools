using System;
using System.Collections.Generic;
using System.Data;

namespace j223nTools.Network
{
    /// <summary>
    /// NIC Setting Helper
    /// </summary>
    public class NicSettingHelper : IDisposable
    {

        #region Property

        /// <summary>
        /// List
        /// </summary>
        public List<NicSetting> List { get; private set; } = new List<NicSetting>();

        /// <summary>
        /// Table
        /// </summary>
        public DataTable Table { get; private set; }

        /// <summary>
        /// Disposed
        /// </summary>
        public bool Disposed { get; private set; } = false;

        #endregion

        #region Initialize

        /// <summary>
        /// Constructor
        /// </summary>
        public NicSettingHelper() => InitializeTable();

        /// <summary>
        /// Initialize Table
        /// </summary>
        private void InitializeTable()
        {
            if (Table != null) Table.Dispose();
            Table = new DataTable("NicSettingTable");
            Table.Columns.Add("Id", typeof(string));
            Table.Columns.Add("Name", typeof(string));
            Table.Columns.Add("NetworkInterfaceType", typeof(int));
            Table.Columns.Add("ActiveIPv4IsDHCP", typeof(bool));
            Table.Columns.Add("ActiveIPv4Address", typeof(string));
            Table.Columns.Add("ActiveIPv4Mask", typeof(string));
            Table.Columns.Add("ActiveDNS", typeof(string));
            Table.PrimaryKey = new DataColumn[] { Table.Columns["Id"] };
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Destructor
        /// </summary>
        ~NicSettingHelper() => Dispose(false);

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing">Dispose managed resource</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    if (List != null)
                    {
                        List.Clear();
                        List = null;
                    }
                    if (Table != null)
                    {
                        Table.Clear();
                        Table.Dispose();
                        Table = null;
                    }
                }
                Disposed = true;
            }
        }

        #endregion

    }
}
