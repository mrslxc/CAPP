﻿Public Class FrmProduits
    Private Sub APP_ProduitBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APP_ProduitBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub FrmProduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_CategorieProduit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_CategorieProduitTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_CategorieProduit)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.

        Me.APP_ProduitTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Produit)
        Debug.WriteLine(BDD_TurbotDataSet.APP_Produit.Rows.Count)
        txtNmbProduits.Text = APP_ProduitDataGridView.Rows.Count
    End Sub

    Private Sub Categorie_nomTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Categorie_nomLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAfficherTout_Click(sender As Object, e As EventArgs) Handles btnAfficherTout.Click
        APP_ProduitBindingSource.Filter = ""
        'If btnAfficherTout.Enabled Then
        txtNmbProduits.Text = APP_ProduitDataGridView.Rows.Count

        'End If
    End Sub

    'Private Sub CategorieProduitNomComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategorieProduitNomComboBox.SelectedIndexChanged
    '    If CategorieProduitNomComboBox.SelectedIndex <> -1 Then
    '        MessageBox.Show("La catégorie sélectionnée est " & CategorieProduitNomComboBox.SelectedValue)
    '        'APP_ProduitBindingSource.Filter = "Categorie_nom = '" & CategorieProduitNomComboBox.SelectedValue & "'"
    '        'txtNmbProduits.Text = APP_ProduitDataGridView.Rows.Count
    '        APP_ProduitBindingSource.Filter = "Categorie_nom = '" & TextBox1.Text & "'"
    '        txtNmbProduits.Text = APP_ProduitDataGridView.Rows.Count

    '    End If
    'End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            'MessageBox.Show("La catégorie sélectionnée est " & ListBox1.SelectedValue)
            'APP_ProduitBindingSource.Filter = "Categorie_nom = '" & CategorieProduitNomComboBox.SelectedValue & "'"
            'txtNmbProduits.Text = APP_ProduitDataGridView.Rows.Count
            APP_ProduitBindingSource.Filter = "Categorie_nom = '" & ListBox1.SelectedValue & "'"
            txtNmbProduits.Text = APP_ProduitDataGridView.Rows.Count

        End If
    End Sub

    Private Sub btnGoHome_Click(sender As Object, e As EventArgs) Handles btnGoHome.Click
        Me.Hide()
        FrmAccueil.Show()
    End Sub
End Class