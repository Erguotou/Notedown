﻿using System;
using Eto;
using Eto.Forms;
using MonoMac.AppKit;
using MonoMac.Foundation;

namespace Notedown
{
    class Startup
    {
        static void Main(string[] args)
        {
            Style.Add("ListNative", (w) => { var v = w.ControlObject as NSScrollView; var c = v.DocumentView as NSTableView;
                v.BorderType = NSBorderType.NoBorder;
                c.SelectionHighlightStyle = NSTableViewSelectionHighlightStyle.SourceList;
            });
            Style.Add("TextConsole", (w) => { var v = w.ControlObject as NSScrollView; var c = v.DocumentView as NSTextView;
                v.BorderType = NSBorderType.NoBorder;
                c.RichText = false;
            });
            
            var generator = new Eto.Platform.Mac.Generator();
            var app = new Program(generator);
            app.Run();
        }
	}
}