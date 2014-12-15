// Decompiled with JetBrains decompiler
// Type: TEdit.PrintTransition
// Assembly: TEdit, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: 17FAC474-4301-4029-AF6B-D3AA98301AC6
// Assembly location: W:\JetBrains\UOLandscaper\TEdit.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Ultima;

namespace TEdit
{
  public class PrintTransition
  {
    [AccessedThroughProperty("PrDoc")]
    private PrintDocument _PrDoc;
    private XmlDocument iXml;
    private Font mFont;
    private XmlElement iElement;
    private string iKey;
    private string iMapTile;
    private string iStaticTile;
    private float xPos;
    private float yPos;

    private virtual PrintDocument PrDoc
    {
      get
      {
        return this._PrDoc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PrDoc != null)
          this._PrDoc.PrintPage -= new PrintPageEventHandler(this.PrDoc_PrintPage);
        this._PrDoc = value;
        if (this._PrDoc == null)
          return;
        this._PrDoc.PrintPage += new PrintPageEventHandler(this.PrDoc_PrintPage);
      }
    }

    public PrintTransition()
    {
      this.iXml = new XmlDocument();
      this.PrDoc = new PrintDocument();
      this.mFont = new Font("Arial", 10f);
      this.iXml.Load(string.Format("{0}Data\\System\\2Way_Template.xml", (object) AppDomain.CurrentDomain.BaseDirectory));
      PrintDialog printDialog = new PrintDialog();
      printDialog.Document = this.PrDoc;
      this.iElement = (XmlElement) this.iXml.SelectSingleNode("//Wizard/Tile");
      if (printDialog.ShowDialog() != DialogResult.OK)
        return;
      this.PrDoc.Print();
    }

    private void PrDoc_PrintPage(object sender, PrintPageEventArgs e)
    {
      this.yPos = (float) e.MarginBounds.Top;
      Rectangle rectangle = e.MarginBounds;
      this.xPos = (float) rectangle.Left;
      Bitmap land1 = Art.GetLand(3);
      Bitmap land2 = Art.GetLand(22);
      double num1;
      double num2;
      do
      {
        this.iKey = this.iElement.GetAttribute("Pattern");
        this.iMapTile = this.iElement.GetAttribute("MapTile");
        this.iStaticTile = this.iElement.GetAttribute("StaticTile");
        Graphics graphics1 = e.Graphics;
        Bitmap bitmap1 = new Bitmap(28, 28);
        Graphics graphics2 = Graphics.FromImage((Image) bitmap1);
        byte num3 = (byte) 0;
        do
        {
          Rectangle rect;
          switch (num3)
          {
            case (byte) 0:
              rectangle = new Rectangle(0, 0, 7, 7);
              rect = rectangle;
              break;
            case (byte) 1:
              rectangle = new Rectangle(9, 0, 7, 7);
              rect = rectangle;
              break;
            case (byte) 2:
              rectangle = new Rectangle(18, 0, 7, 7);
              rect = rectangle;
              break;
            case (byte) 3:
              rectangle = new Rectangle(0, 9, 7, 7);
              rect = rectangle;
              break;
            case (byte) 4:
              rectangle = new Rectangle(9, 9, 7, 7);
              rect = rectangle;
              break;
            case (byte) 5:
              rectangle = new Rectangle(18, 9, 7, 7);
              rect = rectangle;
              break;
            case (byte) 6:
              rectangle = new Rectangle(0, 18, 7, 7);
              rect = rectangle;
              break;
            case (byte) 7:
              rectangle = new Rectangle(9, 18, 7, 7);
              rect = rectangle;
              break;
            case (byte) 8:
              rectangle = new Rectangle(18, 18, 7, 7);
              rect = rectangle;
              break;
          }
          string sLeft = Strings.Mid(this.iKey, checked ((int) num3 + 1), 1);
          if (StringType.StrCmp(sLeft, "A", false) == 0)
            graphics2.FillRectangle(Brushes.LightGray, rect);
          else if (StringType.StrCmp(sLeft, "B", false) == 0)
            graphics2.FillRectangle(Brushes.DarkGray, rect);
          ++num3;
        }
        while ((int) num3 <= 8);
        Bitmap bitmap2 = new Bitmap(134, 134);
        Graphics graphics3 = Graphics.FromImage((Image) bitmap2);
        byte num4 = (byte) 0;
        Point point1;
        do
        {
          Point point2;
          switch (num4)
          {
            case (byte) 0:
              point1 = new Point(44, 0);
              point2 = point1;
              break;
            case (byte) 1:
              point1 = new Point(66, 22);
              point2 = point1;
              break;
            case (byte) 2:
              point1 = new Point(88, 44);
              point2 = point1;
              break;
            case (byte) 3:
              point1 = new Point(22, 22);
              point2 = point1;
              break;
            case (byte) 4:
              point1 = new Point(44, 44);
              point2 = point1;
              break;
            case (byte) 5:
              point1 = new Point(66, 66);
              point2 = point1;
              break;
            case (byte) 6:
              point1 = new Point(0, 44);
              point2 = point1;
              break;
            case (byte) 7:
              point1 = new Point(22, 66);
              point2 = point1;
              break;
            case (byte) 8:
              point1 = new Point(44, 88);
              point2 = point1;
              break;
          }
          string sLeft = Strings.Mid(this.iKey, checked ((int) num4 + 1), 1);
          if (StringType.StrCmp(sLeft, "A", false) == 0)
            graphics3.DrawImage((Image) land1, point2);
          else if (StringType.StrCmp(sLeft, "B", false) == 0)
            graphics3.DrawImage((Image) land2, point2);
          ++num4;
        }
        while ((int) num4 <= 8);
        graphics1.DrawLine(new Pen(Color.Black), this.xPos, this.yPos, this.xPos + 600f, this.yPos);
        Graphics graphics4 = graphics1;
        Bitmap bitmap3 = bitmap2;
        point1 = new Point(checked ((int) Math.Round((double) this.xPos)), checked ((int) Math.Round((double) unchecked (this.yPos + 2f))));
        Point point3 = point1;
        graphics4.DrawImage((Image) bitmap3, point3);
        Graphics graphics5 = graphics1;
        Bitmap bitmap4 = bitmap1;
        point1 = new Point(checked ((int) Math.Round((double) unchecked (this.xPos + 150f))), checked ((int) Math.Round((double) unchecked (this.yPos + 2f))));
        Point point4 = point1;
        graphics5.DrawImage((Image) bitmap4, point4);
        graphics1.DrawString(this.iKey, this.mFont, Brushes.Black, this.xPos + 190f, this.yPos);
        graphics1.DrawString(string.Format("Map Tile:{0}", (object) this.iMapTile), this.mFont, Brushes.Black, this.xPos + 340f, this.yPos);
        graphics1.DrawString(string.Format("Static Tile:{0}", (object) this.iStaticTile), this.mFont, Brushes.Black, this.xPos + 340f, this.yPos + 20f);
        this.yPos = this.yPos + 140f;
        if (this.iElement.NextSibling != null)
          this.iElement = (XmlElement) this.iElement.NextSibling;
        num1 = (double) this.yPos;
        rectangle = e.MarginBounds;
        num2 = (double) checked (rectangle.Bottom - 140);
      }
      while (!(num1 > num2 | this.iElement.NextSibling == null));
      if (this.iElement.NextSibling == null)
        e.HasMorePages = false;
      else
        e.HasMorePages = true;
    }
  }
}
