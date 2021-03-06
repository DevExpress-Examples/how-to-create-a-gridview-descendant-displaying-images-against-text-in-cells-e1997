<!-- default file list -->
*Files to look at*:

* [CustomAdvGridPainter.cs](./CS/ImageTextEdit/CustomGridControl/CustomAdvGridView/CustomAdvGridPainter.cs)
* [CustomAdvGridView.cs](./CS/ImageTextEdit/CustomGridControl/CustomAdvGridView/CustomAdvGridView.cs)
* [CustomGridControl.cs](./CS/ImageTextEdit/CustomGridControl/CustomGridControl.cs) (VB: [CustomGridControl.vb](./VB/ImageTextEdit/CustomGridControl/CustomGridControl.vb))
* [CustomGridInfoRegistrator.cs](./CS/ImageTextEdit/CustomGridControl/CustomGridInfoRegistrator.cs) (VB: [CustomGridInfoRegistrator.vb](./VB/ImageTextEdit/CustomGridControl/CustomGridInfoRegistrator.vb))
* [CustomGridPainter.cs](./CS/ImageTextEdit/CustomGridControl/CustomGridView/CustomGridPainter.cs)
* [CustomGridView.cs](./CS/ImageTextEdit/CustomGridControl/CustomGridView/CustomGridView.cs)
* [CustomIconTextEdit.cs](./CS/ImageTextEdit/CustomIconTextEdit/CustomIconTextEdit.cs) (VB: [CustomIconTextEdit.vb](./VB/ImageTextEdit/CustomIconTextEdit/CustomIconTextEdit.vb))
* [CustomIconTextEditViewInfo.cs](./CS/ImageTextEdit/CustomIconTextEdit/CustomIconTextEditViewInfo.cs) (VB: [CustomIconTextEditViewInfo.vb](./VB/ImageTextEdit/CustomIconTextEdit/CustomIconTextEditViewInfo.vb))
* [CustomIconTextPainter.cs](./CS/ImageTextEdit/CustomIconTextEdit/CustomIconTextPainter.cs) (VB: [CustomIconTextPainter.vb](./VB/ImageTextEdit/CustomIconTextEdit/CustomIconTextPainter.vb))
* [RepositoryItemCustomIconTextEdit.cs](./CS/ImageTextEdit/CustomIconTextEdit/RepositoryItemCustomIconTextEdit.cs) (VB: [RepositoryItemCustomIconTextEdit.vb](./VB/ImageTextEdit/CustomIconTextEdit/RepositoryItemCustomIconTextEdit.vb))
* **[Form1.cs](./CS/ImageTextEdit/Form1.cs) (VB: [Form1.vb](./VB/ImageTextEdit/Form1.vb))**
* [Program.cs](./CS/ImageTextEdit/Program.cs) (VB: [Program.vb](./VB/ImageTextEdit/Program.vb))
<!-- default file list end -->
# How to create a GridView descendant displaying images against text in cells


<p>This example shows how to create a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGridViewsGridGridViewtopic">GridView</a> descendant that will allow displaying  an image against text in cells and provide images based on the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGridViewsGridGridViewtopic">GridView </a> data.</p><p>The resulting descendant has an additional <strong>OnSmartIconSelection</strong> event that can be used to specify the index of an image that should be displayed in each cell. The event handler receives an argument of the <strong>OnSmartIconSelectionEventArgs</strong> type for providing data related to this event:<br />
<strong>OnSmartIconSelectionEventArgs.ImageList</strong> - gets an image source.<br />
<strong>OnSmartIconSelectionEventArgs.ImageIndex</strong> - gets or sets the index of the image that should be displayed.<br />
<strong>OnSmartIconSelectionEventArgs.CellInfo</strong> - gets a <strong>GridCelInfo</strong> object that represent information about current <a href="//">GridCell</a>.<br />
<strong>OnSmartIconSelectionEventArgs.IsActiveEditor</strong> - gets <i>True</i> value if the current <a href="//">GridCell</a> is active.<br />
You should assign the index of an image that you want to display to the <strong>OnSmartIconSelectionEventArgs.ImageIndex</strong> property.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/K18337">How to force a GridView to display images against text in specified cells or columns</a><br />
<a href="https://www.devexpress.com/Support/Center/p/K18336">How to force a TextEdit to display an image against the text </a></p>

<br/>


