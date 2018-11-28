using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RenameFiles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 修改扩展名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtensionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ExtensionRadioButton.Checked)
            {
                ExtensionSrcTextBox.Enabled = true;
                ExtensionTargetTextBox.Enabled = true;
            }
            else
            {
                ExtensionSrcTextBox.Enabled = false;
                ExtensionTargetTextBox.Enabled = false;
            }
        }

        /// <summary>
        /// 重命名文件名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RenameRadioButton.Checked)
            {
                RenameTextBox.Enabled = true;
            }
            else
            {
                RenameTextBox.Enabled = false;
            }
        }

        /// <summary>
        /// 删除指定关键字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteKeywordRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteKeywordRadioButton.Checked)
            {
                DeleteKeywordTextBox.Enabled = true;
            }
            else
            {
                DeleteKeywordTextBox.Enabled = false;
            }
        }
        /// <summary>
        /// 添加指定的前缀
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NewPreRadioButton.Checked)
            {
                NewPreTextBox.Enabled = true;
            }
            else
            {
                NewPreTextBox.Enabled = false;
            }
        }

        /// <summary>
        /// 浏览选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = false;
            dlg.Description = "请选择要操作的文件所在的父文件夹";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FolderPathTextBox.Text = dlg.SelectedPath;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (ExtensionRadioButton.Checked)//修改扩展名
            {
                if (ExtensionSrcTextBox.Text == "")
                {
                    MessageBox.Show("操作已取消\n\n您还没有指定文件原来的扩展名", "批量修改文件扩展名",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (ExtensionTargetTextBox.Text == "")
                {
                    MessageBox.Show("操作已取消\n\n您还没有指定文件的目标扩展名", "批量修改文件扩展名",
                           MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                string src = ExtensionSrcTextBox.Text;
                string target = ExtensionTargetTextBox.Text;
                string warning = "将把指定文件夹\n" + FolderPathTextBox.Text +
                    "\n下面的所有扩展名为\"" + src + "\"的文件的扩展名修改为\"" + target + "\"，是否继续";
                if (MessageBox.Show(warning, "批量修改文件扩展名", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.No)
                {
                    MessageBox.Show("操作已取消\n\n用户取消了修改文件扩展名的工作", "批量修改文件扩展名",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #region 修改文件扩展名主过程
                try
                {
                    DirectoryInfo root = new DirectoryInfo(FolderPathTextBox.Text);
                    FileInfo[] files = root.GetFiles("*" + src);
                    int failCount = 0;
                    foreach (var file in files)
                    {
                        try
                        {
                            file.MoveTo(file.Directory.FullName + "\\" + file.Name.Replace(src, target));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            failCount++;
                        }
                    }
                    if (failCount != 0)
                    {
                        MessageBox.Show("发生" + failCount + "次失败，其余修改文件扩展名工作已经完成", "批量修改文件扩展名",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("批量修改文件扩展名工作已经完成", "批量修改文件扩展名",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("批量修改文件扩展名失败\n\n指定文件夹不存在或无法访问", "批量修改文件扩展名",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
            else if (RenameRadioButton.Checked)//修改文件名前缀
            {
                string newName = RenameTextBox.Text;
                if (newName == "")
                {
                    MessageBox.Show("操作已取消\n\n您还没有指定文件名称的前缀", "批量重命名文件",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string warning = "将把指定文件夹\n" + FolderPathTextBox.Text +
                   "\n下面的所有文件的名称修改为以\"" + newName + "\"开头，并用数字编号这些文件，是否继续";
                if (MessageBox.Show(warning, "批量重命名文件", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                   == DialogResult.No)
                {
                    MessageBox.Show("操作已取消\n\n用户取消了修改文件扩展名的工作", "批量重命名文件",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #region 批量重命名文件主过程
                try
                {
                    DirectoryInfo root = new DirectoryInfo(FolderPathTextBox.Text);
                    string[] extensions = root.GetFiles().Select(v => v.Extension).ToArray();
                    int failCount = 0;
                    foreach (var extension in extensions)
                    {
                        int index = 1;
                        foreach (var file in root.GetFiles("*" + extension))
                        {
                            try
                            {
                                file.MoveTo(root.FullName + "\\" + newName + "_" + index.ToString() + extension);
                                index++;
                            }
                            catch (Exception)
                            {
                                failCount++;
                            }
                        }
                    }
                    if (failCount != 0)
                    {
                        MessageBox.Show("发生" + failCount + "次失败，其余重命名文件工作已经完成", "批量重命名文件",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("批量重命名文件工作已经完成", "批量重命名文件",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("批量重命名文件失败\n\n指定文件夹不存在或无法访问", "批量重命名文件",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
            else if (DeleteKeywordRadioButton.Checked)//删除指定关键字
            {
                string delKeyword = DeleteKeywordTextBox.Text;
                if (delKeyword == "")
                {
                    MessageBox.Show("操作已取消\n\n您还没有指定要删除的关键字", "批量删除关键字",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string warning = "将把指定文件夹\n" + FolderPathTextBox.Text +
                   "\n下面的所有文件的名称中的关键字\"" + delKeyword + "\"删除，是否继续";
                if (MessageBox.Show(warning, "批量删除关键字", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                   == DialogResult.No)
                {
                    MessageBox.Show("操作已取消\n\n用户取消了删除文件名称中某文字的工作", "批量删除关键字",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #region 删除指定关键字主过程
                try
                {
                    DirectoryInfo root = new DirectoryInfo(FolderPathTextBox.Text);
                    FileInfo[] files = root.GetFiles("*" + delKeyword + "*");
                    int failCount = 0;
                    foreach (var file in files)
                    {
                        try
                        {
                            file.MoveTo(file.Directory.FullName + "\\" + file.Name.Replace(delKeyword, ""));
                        }
                        catch (Exception)
                        {
                            failCount++;
                        }
                    }
                    if (failCount != 0)
                    {
                        MessageBox.Show("发生" + failCount + "次失败，其余删除关键字工作已经完成", "批量删除关键字",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("批量删除关键字工作已经完成", "批量删除关键字",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("批量删除关键字失败\n\n指定文件夹不存在或无法访问", "批量删除关键字",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
            else if (NewPreRadioButton.Checked)//添加文件前缀
            {
                string newPreWord = NewPreTextBox.Text;
                if (newPreWord == "")
                {
                    MessageBox.Show("操作已取消\n\n您还没有指定删要添加的前缀", "批量添加前缀",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string warning = "将把指定文件夹\n" + FolderPathTextBox.Text +
                   "\n下面的所有文件的名称添加前缀\"" + newPreWord + "，是否继续";
                if (MessageBox.Show(warning, "批量添加前缀", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                   == DialogResult.No)
                {
                    MessageBox.Show("操作已取消\n\n用户取消了在文件名称中添加前缀的工作", "批量添加前缀",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #region 添加前缀主过程
                try
                {
                    DirectoryInfo root = new DirectoryInfo(FolderPathTextBox.Text);
                    FileInfo[] files = root.GetFiles();
                    int failCount = 0;
                    foreach (var file in files)
                    {
                        try
                        {
                            file.MoveTo(file.Directory.FullName + "\\" + newPreWord + file.Name);
                        }
                        catch (Exception)
                        {
                            failCount++;
                        }
                    }
                    if (failCount != 0)
                    {
                        MessageBox.Show("发生" + failCount + "次失败，其余在文件名称中添加前缀字工作已经完成", "批量在文件名称中添加前缀",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("批量在文件名称中添加前缀工作已经完成", "批量在文件名称中添加前缀",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("批量删除关键字失败\n\n指定文件夹不存在或无法访问", "批量在文件名称中添加前缀",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
            else if (ReplacePreRadioButton.Checked)
            {
                if (ReplaceSrcTextBox.Text == "")
                {
                    MessageBox.Show("操作已取消\n\n您还没有指定需要原始替换的内容", "批量修改文件名",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (ReplaceTargetTextBox.Text == "")
                {
                    MessageBox.Show("操作已取消\n\n您还没有指定需要替换的最终内容", "批量修改文件名",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                string src = ReplaceSrcTextBox.Text;
                string target = ReplaceTargetTextBox.Text;
                string warning = "将把指定文件夹\n" + FolderPathTextBox.Text +
                                 "\n下面的所有内容为\"" + src + "\"的文件名修改为\"" + target + "\"，是否继续";
                if (MessageBox.Show(warning, "批量修改文件名", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    MessageBox.Show("操作已取消\n\n用户取消了修改文件名的工作", "批量修改文件名",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #region 修改文件名主过程
                try
                {
                    DirectoryInfo root = new DirectoryInfo(FolderPathTextBox.Text);
                    FileInfo[] files = root.GetFiles();
                    int failCount = 0;
                    foreach (var file in files)
                    {
                        try
                        {
                            file.MoveTo(file.Directory.FullName + "\\" + file.Name.Replace(src, target));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            failCount++;
                        }
                    }
                    if (failCount != 0)
                    {
                        MessageBox.Show("发生" + failCount + "次失败，其余修改文件名工作已经完成", "批量修改文件名",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("批量修改文件名工作已经完成", "批量修改文件名",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("批量修改文件名失败\n\n指定文件夹不存在或无法访问", "批量修改文件名",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
        }

        private void FolderPathTextBox_TextChanged(object sender, EventArgs e)
        {
            btStart.Enabled = FolderPathTextBox.Text != "";
        }

        private void FolderPathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] names = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (names.Count() == 1 && Directory.Exists(names[0]))
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void FolderPathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] names = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (names.Count() == 1 && Directory.Exists(names[0]))
                    FolderPathTextBox.Text = names[0];
            }
        }

        private void TopMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = TopMostCheckBox.Checked;
        }

        private void ReplacePreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ReplacePreRadioButton.Checked)
            {
                ReplaceSrcTextBox.Enabled = true;
                ReplaceTargetTextBox.Enabled = true;
            }
            else
            {
                ReplaceSrcTextBox.Enabled = false;
                ReplaceTargetTextBox.Enabled = false;
            }
        }
    }
}