﻿using System.Collections.Generic;

namespace DbTool
{
    /// <summary>
    /// 数据库信息
    /// </summary>
    public class DbEntity
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// 数据库描述
        /// </summary>
        public string DatabaseDescription { get; set; }

        /// <summary>
        /// 表信息
        /// </summary>
        public List<TableEntity> Tables { get; set; }

        public DbEntity()
        {
            Tables = new List<TableEntity>();
        }
    }

    /// <summary>
    /// 表信息
    /// </summary>
    public class TableEntity
    {
        /// <summary>
        /// 表名称
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 表描述
        /// </summary>
        public string TableDescription { get; set; }

        /// <summary>
        /// 表架构 scheme
        /// </summary>
        public string TableSchema { get; set; } = "dbo";

        /// <summary>
        /// 列信息
        /// </summary>
        public List<ColumnEntity> Columns { get; set; }

        public TableEntity()
        {
            Columns = new List<ColumnEntity>();
        }
    }

    /// <summary>
    /// 列信息
    /// </summary>
    public class ColumnEntity
    {
        /// <summary>
        /// 列名称
        /// </summary>
        public string ColumnName { get; set; }

        private string columnDescription;

        /// <summary>
        /// 列描述
        /// </summary>
        public string ColumnDescription
        {
            get => columnDescription;
            set => columnDescription = !string.IsNullOrEmpty(value) ? value : "";
        }

        /// <summary>
        /// 是否可以为空
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// 是否是主键列
        /// </summary>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// 字段长度
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public object DefaultValue { get; set; }
    }
}
