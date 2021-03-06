﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的常规信息通过以下
// 特性集控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("Grace的书籍管理")]
[assembly: AssemblyDescription(@"用四种书籍数量变更的方式（购入，归还，销售，领用）对书籍进行简单的管理，其中销售的书籍可以单独导出列表。
2014.06.11更改了控件的排列，修复在过小的屏幕上不显示按钮的问题。 
2014.07.11增加了批量领取书籍，以及书单的操作。
2015.01.20增加的批量售书的功能，修正书单在XP系统下显示不全的问题。添加操作记录列表下的右键菜单。方便删除操作记录。

2018.02.07修改了读写数据库的时间处理方式，由于Windows10系统时间格式改变导致无法操作。

公众号：Hansi-zt 寒思爱折腾
网址：http://ztiii.net
程序设计:@麦田呱呱
日期:2018年02月07日")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Grace软件")]
[assembly: AssemblyProduct("BooksManageSystem")]
[assembly: AssemblyCopyright("Copyright © 2014-2018")]
[assembly: AssemblyTrademark("AssemblyTrademark")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 使此程序集中的类型
// 对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型，
// 则将该类型上的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("59f47d6c-8e1c-472c-90b5-c091e224fea6")]

// 程序集的版本信息由下面四个值组成:
//
//      主版本
//      次版本 
//      生成号
//      修订号
//
// 可以指定所有这些值，也可以使用“生成号”和“修订号”的默认值，
// 方法是按如下所示使用“*”:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.5.0.0")]
[assembly: AssemblyFileVersion("1.5.0.0")]
