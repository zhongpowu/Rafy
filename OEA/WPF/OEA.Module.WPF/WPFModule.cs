/*******************************************************
 * 
 * 作者：胡庆访
 * 创建时间：20100326
 * 说明：当前工程所对应的模块类
 * 运行环境：.NET 3.5 SP1
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 胡庆访 20100326
 * 
*******************************************************/

using System;
using System.Data.SqlClient;
using Common;
using Itenso.Windows.Input;
using OEA.Library;
using OEA.MetaModel;

using OEA.MetaModel.View;
using OEA.WPF.Command;
using OEA.WPF;

namespace OEA.Module.WPF
{
    /// <summary>
    /// 当前工程所对应的模块类。
    /// </summary>
    internal class WPFModule : IModule
    {
        public ReuseLevel ReuseLevel
        {
            get { return ReuseLevel.Main; }
        }

        public void Initialize(IClientApp app)
        {
            //初始化命令列表
            WPFCommandNames.CustomizeUI = typeof(CustomizeUI);
            WPFCommandNames.FireQuery = typeof(QueryObjectCommand);
            WPFCommandNames.PopupAdd = typeof(PopupAddCommand);
            WPFCommandNames.Add = typeof(AddCommand);
            WPFCommandNames.SaveBill = typeof(SaveBillCommand);
            WPFCommandNames.SaveList = typeof(SaveListCommand);
            WPFCommandNames.Cancel = typeof(CancelCommand);
            WPFCommandNames.Refresh = typeof(RefreshCommand);
            WPFCommandNames.Delete = typeof(DeleteListObjectCommand);
            WPFCommandNames.Edit = typeof(EditDetailCommand);
            WPFCommandNames.ExportToExcel = typeof(ExportToExcelCommand);

            WPFCommandNames.MoveUp = typeof(MoveUpCommand);
            WPFCommandNames.MoveDown = typeof(MoveDownCommand);
            WPFCommandNames.LevelUp = typeof(LevelUpCommand);
            WPFCommandNames.LevelDown = typeof(LevelDownCommand);
            WPFCommandNames.InsertBefore = typeof(InsertBeforeCommand);
            WPFCommandNames.InsertChild = typeof(AddChildCommand);
            WPFCommandNames.ExpandAll = typeof(ExpandAllCommand);
            WPFCommandNames.ExpandOne = typeof(ExpandToLevelOneCommand);
            WPFCommandNames.ExpandTwo = typeof(ExpandToLevelTwoCommand);
            WPFCommandNames.ExpandThree = typeof(ExpandToLevelThreeCommand);
            WPFCommandNames.ExpandFour = typeof(ExpandToLevelFourCommand);

            WPFCommandNames.InitCommonCommands();

            app.Composed += (s, e) => App.Current.InitMainWindow();
            app.LoginSuccessed += (s, e) => App.Current.InitUIModuleList();
        }
    }
}