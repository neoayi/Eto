﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eto.Forms;

namespace Eto.Platform.Wpf.Forms.Controls
{
	public class ListBoxHandler : WpfControl<System.Windows.Controls.ListBox, ListBox>, IListBox
	{
		public ListBoxHandler ()
		{
			Control = new System.Windows.Controls.ListBox ();
			Control.DisplayMemberPath = "Text";
			
		}

		public override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);
			Control.ItemsSource = Widget.Items;
		}

		public void AddRange (IEnumerable<IListItem> collection)
		{
			//Control.UpdateLayout ();
		}

		public void AddItem (IListItem item)
		{
			//Control.UpdateLayout ();
		}

		public void RemoveItem (IListItem item)
		{
			//Control.UpdateLayout ();
		}

		public void RemoveAll ()
		{
			//Control.UpdateLayout ();
		}

		public int SelectedIndex
		{
			get { return Control.SelectedIndex; }
			set { Control.SelectedIndex = value; }
		}
	}
}
