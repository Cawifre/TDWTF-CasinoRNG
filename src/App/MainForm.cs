using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win;

namespace App
{
	public partial class MainForm : Form
	{
		private RandomishNumberGenerator _rng = new RandomishNumberGenerator();
		private StringBuilder _cheatCode = new StringBuilder();

		public MainForm ()
		{
			InitializeComponent();
		}

		private void ultraToolbarsManager1_ToolClick ( object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e )
		{
			var keys = ModifierKeys;
			switch ( e.Tool.Key )
			{
				case "Exit":
					Close();
					break;
				case "Spin":
					Spin();
					break;
			}
		}

		private void Spin ()
		{
			var next = _rng.Next();
			var text = next == -1 ? "00" : next.ToString();
			labelNumber.Text = text;
		}

		private void Cheat ()
		{
			_rng.Cheat();
		}

		protected override void OnKeyPress ( KeyPressEventArgs e )
		{
			_cheatCode.Append( e.KeyChar );
			CheckCheatCode();
			base.OnKeyPress( e );
		}

		private void CheckCheatCode ()
		{
			const string magicWord = "rosebud";

			if ( !magicWord.StartsWith( _cheatCode.ToString() ) )
			{
				_cheatCode.Clear();
			}

			if ( magicWord == _cheatCode.ToString() )
			{
				Cheat();
			}
		}
	}
}
