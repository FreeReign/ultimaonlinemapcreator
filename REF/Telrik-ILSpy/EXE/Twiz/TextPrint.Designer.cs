using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Drawing.Printing;

namespace Twiz
{
	public class TextPrint : PrintDocument
	{
		private System.Drawing.Font fntPrintFont;

		private string strText;

		public System.Drawing.Font Font
		{
			get
			{
				return this.fntPrintFont;
			}
			set
			{
				this.fntPrintFont = value;
			}
		}

		public string Text
		{
			get
			{
				return this.strText;
			}
			set
			{
				this.strText = value;
			}
		}

		public TextPrint(string Text)
		{
			this.strText = Text;
		}

		protected override void OnBeginPrint(PrintEventArgs ev)
		{
			base.OnBeginPrint(ev);
			if (this.fntPrintFont == null)
			{
				this.fntPrintFont = new System.Drawing.Font("Times New Roman", 12f);
			}
		}

		protected override void OnPrintPage(PrintPageEventArgs ev)
		{
			int num;
			int num1;
			base.OnPrintPage(ev);
			PageSettings defaultPageSettings = base.DefaultPageSettings;
			int height = checked(checked(defaultPageSettings.PaperSize.Height - defaultPageSettings.Margins.Top) - defaultPageSettings.Margins.Bottom);
			int width = checked(checked(defaultPageSettings.PaperSize.Width - defaultPageSettings.Margins.Left) - defaultPageSettings.Margins.Right);
			int left = defaultPageSettings.Margins.Left;
			int top = defaultPageSettings.Margins.Top;
			defaultPageSettings = null;
			if (base.DefaultPageSettings.Landscape)
			{
				int num2 = height;
				height = width;
				width = num2;
			}
			int num3 = checked((int)Math.Round((double)height / (double)this.Font.Height));
			RectangleF rectangleF = new RectangleF((float)left, (float)top, (float)width, (float)height);
			StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
			Graphics graphics = ev.Graphics;
			string str = Strings.Mid(this.strText, this.UpgradeZeros(this.$STATIC$OnPrintPage$20111211$intCurrentChar));
			System.Drawing.Font font = this.Font;
			SizeF sizeF = new SizeF((float)width, (float)height);
			graphics.MeasureString(str, font, sizeF, stringFormat, out num, out num1);
			ev.Graphics.DrawString(Strings.Mid(this.strText, this.UpgradeZeros(this.$STATIC$OnPrintPage$20111211$intCurrentChar)), this.Font, Brushes.Black, rectangleF, stringFormat);
			this.$STATIC$OnPrintPage$20111211$intCurrentChar = checked(this.$STATIC$OnPrintPage$20111211$intCurrentChar + num);
			if (this.$STATIC$OnPrintPage$20111211$intCurrentChar >= this.strText.Length)
			{
				ev.HasMorePages = false;
				this.$STATIC$OnPrintPage$20111211$intCurrentChar = 0;
			}
			else
			{
				ev.HasMorePages = true;
			}
		}

		public int UpgradeZeros(int Input)
		{
			return (Input != 0 ? Input : 1);
		}
	}
}