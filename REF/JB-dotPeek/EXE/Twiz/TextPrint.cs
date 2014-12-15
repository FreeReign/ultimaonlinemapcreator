// Decompiled with JetBrains decompiler
// Type: Twiz.TextPrint
// Assembly: Twiz, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: E1613E23-3BB0-4A6C-8984-26F63596D392
// Assembly location: W:\JetBrains\UOLandscaper\Twiz.exe

using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Drawing.Printing;

namespace Twiz
{
  public class TextPrint : PrintDocument
  {
    private Font fntPrintFont;
    private string strText;
    private int \u0024STATIC\u0024OnPrintPage\u002420111211\u0024intCurrentChar;

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

    public Font Font
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

    public TextPrint(string Text)
    {
      this.strText = Text;
    }

    protected override void OnBeginPrint(PrintEventArgs ev)
    {
      base.OnBeginPrint(ev);
      if (this.fntPrintFont != null)
        return;
      this.fntPrintFont = new Font("Times New Roman", 12f);
    }

    protected override void OnPrintPage(PrintPageEventArgs ev)
    {
      base.OnPrintPage(ev);
      PageSettings defaultPageSettings = this.DefaultPageSettings;
      int num1 = checked (defaultPageSettings.PaperSize.Height - defaultPageSettings.Margins.Top - defaultPageSettings.Margins.Bottom);
      int num2 = checked (defaultPageSettings.PaperSize.Width - defaultPageSettings.Margins.Left - defaultPageSettings.Margins.Right);
      int left = defaultPageSettings.Margins.Left;
      int top = defaultPageSettings.Margins.Top;
      if (this.DefaultPageSettings.Landscape)
      {
        int num3 = num1;
        num1 = num2;
        num2 = num3;
      }
      int num4 = checked ((int) Math.Round(unchecked ((double) num1 / (double) this.Font.Height)));
      RectangleF layoutRectangle = new RectangleF((float) left, (float) top, (float) num2, (float) num1);
      StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
      int charactersFitted;
      int linesFilled;
      ev.Graphics.MeasureString(Strings.Mid(this.strText, this.UpgradeZeros(this.\u0024STATIC\u0024OnPrintPage\u002420111211\u0024intCurrentChar)), this.Font, new SizeF((float) num2, (float) num1), stringFormat, out charactersFitted, out linesFilled);
      ev.Graphics.DrawString(Strings.Mid(this.strText, this.UpgradeZeros(this.\u0024STATIC\u0024OnPrintPage\u002420111211\u0024intCurrentChar)), this.Font, Brushes.Black, layoutRectangle, stringFormat);
      this.\u0024STATIC\u0024OnPrintPage\u002420111211\u0024intCurrentChar = checked (this.\u0024STATIC\u0024OnPrintPage\u002420111211\u0024intCurrentChar + charactersFitted);
      if (this.\u0024STATIC\u0024OnPrintPage\u002420111211\u0024intCurrentChar < this.strText.Length)
      {
        ev.HasMorePages = true;
      }
      else
      {
        ev.HasMorePages = false;
        this.\u0024STATIC\u0024OnPrintPage\u002420111211\u0024intCurrentChar = 0;
      }
    }

    public int UpgradeZeros(int Input)
    {
      if (Input == 0)
        return 1;
      else
        return Input;
    }
  }
}
