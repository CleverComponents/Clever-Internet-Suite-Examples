Imports CleverComponents.InetSuite
Imports System.IO

Public Class Form1
	Private Sub LoadControls()
		edtTitle.Text = Rss1.Channel.Title
		edtLink.Text = Rss1.Channel.Link
		edtDescription.Text = Rss1.Channel.Description
		edtCopyright.Text = Rss1.Channel.Copyright
		edtLanguage.Text = Rss1.Channel.Language
		edtWebMaster.Text = Rss1.Channel.WebMaster
		edtGenerator.Text = Rss1.Channel.Generator

		edtImageUrl.Text = Rss1.Channel.Image.Url

		lbNews.Items.Clear()

		Dim item As RssItem
		For Each item In Rss1.Items
			lbNews.Items.Add(item.Title)
		Next item

		If lbNews.Items.Count > 0 Then
			lbNews.SelectedIndex = 0
		End If
	End Sub

	Private Sub SaveControls()
		Rss1.Channel.Title = edtTitle.Text
		Rss1.Channel.Link = edtLink.Text
		Rss1.Channel.Description = edtDescription.Text
		Rss1.Channel.Copyright = edtCopyright.Text
		Rss1.Channel.Language = edtLanguage.Text
		Rss1.Channel.WebMaster = edtWebMaster.Text
		Rss1.Channel.Generator = edtGenerator.Text

		Rss1.Channel.Image.Url = edtImageUrl.Text
		Rss1.Channel.Image.Title = edtTitle.Text
		Rss1.Channel.Image.Link = edtLink.Text

		Rss1.Channel.PubDate = DateTime.Now
		Rss1.Channel.LastBuildDate = DateTime.Now
	End Sub

	Private Sub SaveItem(ByVal dlg As EditItemForm, ByVal item As RssItem)
		item.Title = dlg.edtTitle.Text
		item.Link = dlg.edtLink.Text
		item.Description = dlg.edtDescription.Text
		item.Guid.Value = dlg.edtGuid.Text
		item.PubDate = dlg.edtPubDate.Value
	End Sub

	Private Sub LoadItem(ByVal dlg As EditItemForm, ByVal item As RssItem)
		dlg.edtTitle.Text = item.Title
		dlg.edtLink.Text = item.Link
		dlg.edtDescription.Text = item.Description
		dlg.edtGuid.Text = item.Guid.Value
		dlg.edtPubDate.Value = item.PubDate
	End Sub

	Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
		Using dlg As New EditItemForm
			dlg.edtPubDate.Value = DateTime.Now

			If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
				Dim item As New RssItem()
				Rss1.Items.Insert(0, item)
				SaveItem(dlg, item)
				lbNews.Items.Insert(0, item.Title)
				lbNews.SelectedIndex = 0
			End If
		End Using
	End Sub

	Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
		If (lbNews.SelectedIndex > -1) Then
			Rss1.Items.RemoveAt(lbNews.SelectedIndex)
			lbNews.Items.RemoveAt(lbNews.SelectedIndex)
		End If
	End Sub

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		If (MessageBox.Show("Do you wish to clean news feeds?", "Delete news", _
		 MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
			Rss1.Clear()
			LoadControls()
		End If
	End Sub

	Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
		If (openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
			Using stream As New FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read)
				Rss1.Load(stream)

				LoadControls()
			End Using
		End If
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		If (saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
			If ((Not File.Exists(saveFileDialog.FileName)) Or _
			 (MessageBox.Show("File " + saveFileDialog.FileName + " already exists. Do you want to replace?", "File exists", _
			 MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes)) Then
				Using stream As New FileStream(saveFileDialog.FileName, FileMode.Create)
					SaveControls()

					Rss1.Save(stream)

					MessageBox.Show("Done")
				End Using
			End If
		End If
	End Sub

	Private Sub lbNews_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbNews.DoubleClick
		If (lbNews.SelectedIndex > -1) Then
			Using dlg As New EditItemForm()
				Dim item As RssItem = Rss1.Items.Item(lbNews.SelectedIndex)

				LoadItem(dlg, item)

				If (dlg.ShowDialog() = Windows.Forms.DialogResult.OK) Then
					SaveItem(dlg, item)
				End If
			End Using
		End If
	End Sub
End Class
