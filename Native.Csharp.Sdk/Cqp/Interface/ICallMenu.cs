﻿using Native.Csharp.Sdk.Cqp.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Sdk.Cqp.Interface
{
	/// <summary>
	/// 酷Q调用菜单事件接口
	/// </summary>
	public interface ICallMenu
	{
		/// <summary>
		/// 当在派生类中重写时, 处理 酷Q调用菜单事件 回调
		/// </summary>
		/// <param name="sender">事件来源对象</param>
		/// <param name="e">附加的事件参数</param>
		void CallMenu (object sender, CQMenuEventArgs e);
	}
}