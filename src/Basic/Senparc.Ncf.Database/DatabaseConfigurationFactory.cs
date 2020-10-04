﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.DependencyInjection;
using Senparc.Ncf.Database.SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Ncf.Database
{
    public class DatabaseConfigurationFactory
    {
        #region 单例

        DatabaseConfigurationFactory() { }

        /// <summary>
        /// DatabaseConfigurationFactory 的全局单例
        /// </summary>
        public static DatabaseConfigurationFactory Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            static Nested() { }

            internal static readonly DatabaseConfigurationFactory instance = new DatabaseConfigurationFactory();
        }

        #endregion

        //TODO:如果是分布式，需要存储到缓存中

        private IDatabaseConfiguration _currentDatabaseConfiguration;

        public IDatabaseConfiguration CurrentDatabaseConfiguration
        {
            get
            {
                if (_currentDatabaseConfiguration == null)
                {
                    //如果未配置，则默认使用 SQLiteDatabaseConfiguration 内存数据库
                    _currentDatabaseConfiguration = new SQLiteMemoryDatabaseConfiguration();
                }
                return _currentDatabaseConfiguration;
            }
            set
            {
                _currentDatabaseConfiguration = value;
            }
        }


        ///// <summary>
        ///// 给 design time（设计时）操作数据库（如migration）使用。指定当前正在操作的 XNCF 数据库信息（如果是直接继承自 DbContext 的类，需要模拟此参数）
        ///// </summary>
        //public XncfDatabaseData CurrentXncfDatabaseData { get; set; }
    }
}