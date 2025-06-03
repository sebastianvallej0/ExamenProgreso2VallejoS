using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace ExamenProgreso2VallejoS;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
