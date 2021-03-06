using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils;

namespace ImageTextEdit
{
    public class CustomGridPainter : GridPainter
    {
        GridCellInfo nowDrawingCellInfo;
        public CustomGridPainter(GridView view) : base(view) { }

        public virtual new CustomGridView View { get { return (CustomGridView)base.View; } }
        protected override void DrawCellEdit(GridViewDrawArgs e, BaseEditViewInfo editInfo, GridCellInfo cell, AppearanceObject appearance, bool isSelectedCell)
        {
            IIconSelector iconSelector = cell.Editor as IIconSelector;
            if (iconSelector != null)
            {
                OnIconSelectionEventHandler EH = new OnIconSelectionEventHandler(iconSelector_OnIconSelection);
                iconSelector.OnIconSelection += EH;
                nowDrawingCellInfo = cell;
                try
                {
                    base.DrawCellEdit(e, editInfo, cell, appearance, isSelectedCell);
                }
                finally
                {
                    iconSelector.OnIconSelection -= EH;
                }
            }
            else
                base.DrawCellEdit(e, editInfo, cell, appearance, isSelectedCell);
        }
        void iconSelector_OnIconSelection(object sender, OnIconSelectionEventArgs e)
        {
            OnSmartIconSelectionEventArgs ee = new OnSmartIconSelectionEventArgs(e.ImageList, e.ImageIndex, nowDrawingCellInfo, false);
            View.RaiseOnSmartIconSelection(ee);
            e.ImageIndex = ee.ImageIndex;
        }
    }

}
