﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class ListBoxMultiline : ListBox
    {
        TextFormatFlags flags = TextFormatFlags.WordBreak |
                                TextFormatFlags.PreserveGraphicsClipping |
                                TextFormatFlags.LeftAndRightPadding |
                                TextFormatFlags.ExpandTabs |
                                TextFormatFlags.VerticalCenter;

        public ListBoxMultiline() { this.DrawMode = DrawMode.OwnerDrawVariable; }

        protected override void OnDrawItem( DrawItemEventArgs e )
        {
            if(Items.Count == 0) return;
            if(e.State.HasFlag( DrawItemState.Focus ) || e.State.HasFlag( DrawItemState.Selected ))
            {
                using(var selectionBrush = new SolidBrush( Color.Orange ))
                {
                    e.Graphics.FillRectangle( selectionBrush, e.Bounds );
                }
            }
            else
            {
                e.DrawBackground();
            }

            TextRenderer.DrawText( e.Graphics, GetItemText( Items[e.Index] ), Font, e.Bounds, ForeColor, flags );

            if(e.Index != Items.Count - 1)
            {
                Point lineOffsetStart = new Point( e.Bounds.X, e.Bounds.Bottom - 1 );
                Point lineOffsetEnd = new Point( e.Bounds.Right, e.Bounds.Bottom - 1 );
                e.Graphics.DrawLine( Pens.LightGray, lineOffsetStart, lineOffsetEnd );
            }
            base.OnDrawItem( e );
        }

        protected override void OnMeasureItem( MeasureItemEventArgs e )
        {
            if(Items.Count == 0) return;
            var size = GetItemSize( e.Graphics, GetItemText( Items[e.Index] ) );
            e.ItemWidth = size.Width;
            e.ItemHeight = size.Height;
            base.OnMeasureItem( e );
        }

        private Size GetItemSize( Graphics g, string itemText )
        {
            var size = TextRenderer.MeasureText( g, itemText, Font, ClientSize, flags );
            size.Height = Math.Max( Math.Min( size.Height, 247 ), Font.Height + 8 ) + 8;
            return size;
        }
    }
}
