﻿using System;
using System.Collections.Generic;
using System.Text;
using VVVV.DataTypes;
using VVVV.PluginInterfaces.V1;
using VVVV.PluginInterfaces.V2;
using System.Data.Odbc;

namespace VVVV.Nodes
{
    public class OdbcExecBatchNode : AbstractQueryBatchNode<OdbcConnectionDbDataType, OdbcConnection>, IPlugin
    {
        private static IPluginInfo FPluginInfo;
        public static IPluginInfo PluginInfo
        {
            get
            {
                if (FPluginInfo == null)
                {
                    FPluginInfo = new PluginInfo();
                    FPluginInfo.Name = "QueryBatch";
                    FPluginInfo.Category = "Odbc";
                    FPluginInfo.Version = "Network";
                    FPluginInfo.Author = "vux, microdee";
                    FPluginInfo.Help = "Executes a batch of queries on a ODBC database";
                    FPluginInfo.Tags = "database";
                    FPluginInfo.Credits = "";
                    FPluginInfo.Bugs = "";
                    FPluginInfo.Warnings = "";

                    //leave below as is
                    System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(true);
                    System.Diagnostics.StackFrame sf = st.GetFrame(0);
                    System.Reflection.MethodBase method = sf.GetMethod();
                    FPluginInfo.Namespace = method.DeclaringType.Namespace;
                    FPluginInfo.Class = method.DeclaringType.Name;
                    //leave above as is
                }
                return FPluginInfo;
            }
        }

    }
}
