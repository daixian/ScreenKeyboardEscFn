using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ScreenKeyboardEscFn
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
		private NotifyIconWrapper wrapperIconNotify;

		/// <summary>
		/// System.Windows.Application.Startup イベント を発生させます。
		/// </summary>
		/// <param name="e">イベントデータ を格納している StartupEventArgs</param>
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			this.ShutdownMode = ShutdownMode.OnExplicitShutdown;
			this.wrapperIconNotify = new NotifyIconWrapper();
		}

		/// <summary>
		/// System.Windows.Application.Exit イベント を発生させます。
		/// </summary>
		/// <param name="e">イベントデータ を格納している ExitEventArgs</param>
		protected override void OnExit(ExitEventArgs e)
		{
			base.OnExit(e);
			this.wrapperIconNotify.Dispose();
		}
	}
}
