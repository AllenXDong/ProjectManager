using System.Collections.Generic;
using System.Windows.Forms;
using MainProject.Utils;
using MainProject.Beans;
using System;
using System.Drawing;

namespace MainProject.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            try
            { 
                if(verificationComponent1.Verification())
                {
                    int id = 0;
                    DataGridViewRow row = null;
                    ProjectInfo project = new ProjectInfo();
                    project.SubjectName = subjectNameInputText.Text;
                    project.SubjectId = subjectIdInputText.Text;
                    project.ProjectId = projectIdInputText.Text;
                    project.Engineer = engineerInputText.Text;
                    project.Review = reviewInputText.Text;
                    project.Process = processInputText.Text;
                    project.Standard = standardInputText.Text;
                    project.Approval = approvalInputText.Text;
                    project.IsCurrent = false;

                    if(isEdit)
                    {
                        if (this.dataGridView1.SelectedRows.Count > 0)
                        {
                            row = this.dataGridView1.SelectedRows[0];
                            id = (int)row.Cells[0].Value;
                            project.id = id;
                            LiteDBUtils.updateProjectInfo(project);

                        }
                    }
                    else
                    { 
                        id = LiteDBUtils.insertData(project);

                        int index = this.dataGridView1.Rows.Add();
                        row = this.dataGridView1.Rows[index];
                    }
                    row.Cells[0].Value = id;
                    row.Cells[1].Value = project.SubjectName;
                    row.Cells[2].Value = project.SubjectId;
                    row.Cells[3].Value = project.ProjectId;
                    row.Cells[4].Value = project.Engineer;
                    row.Cells[5].Value = project.Review;
                    row.Cells[6].Value = project.Process;
                    row.Cells[7].Value = project.Standard;
                    row.Cells[8].Value = project.Approval;

                

                    subjectNameInputText.Clear();
                    subjectIdInputText.Clear();
                    projectIdInputText.Clear();
                    engineerInputText.Clear();
                    reviewInputText.Clear();
                    processInputText.Clear();
                    standardInputText.Clear();
                    approvalInputText.Clear();

                    isEdit = false;
                    activeInputButtons(false);

                    HZH_Controls.Forms.FrmTips.ShowTipsSuccess(this, "修改成功");
                }
            }
            catch(Exception ex)
            {
                HZH_Controls.Forms.FrmDialog.ShowDialog(this, ex.Message);
                //HZH_Controls.Forms.FrmTips.ShowTipsError(this, ex.Message);
            }
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void NewButton_Click(object sender, System.EventArgs e)
        {
            activeInputButtons(true);
            subjectNameInputText.Focus();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                    if (row.DefaultCellStyle.BackColor == Color.Yellow)
                    {
                        HZH_Controls.Forms.FrmTips.ShowTipsWarning(this, "当前项目无法删除");
                    }
                    else
                    {
                        int id = (int)row.Cells[0].Value;

                        LiteDBUtils.deleteData(id);
                        this.dataGridView1.Rows.Remove(row);
                        HZH_Controls.Forms.FrmTips.ShowTipsSuccess(this, "删除成功");
                    }
                }
            }
            catch (Exception ex)
            {

                HZH_Controls.Forms.FrmDialog.ShowDialog(this, ex.Message);
                //HZH_Controls.Forms.FrmTips.ShowTipsError(this, ex.Message);
            }
        }

        private void loadDataView()
        {
            try
            {
                List<ProjectInfo> allProjectsInfo= LiteDBUtils.queryAll();
                foreach (ProjectInfo projectInfo in allProjectsInfo)
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells[0].Value = projectInfo.id;
                    this.dataGridView1.Rows[index].Cells[1].Value = projectInfo.SubjectName;
                    this.dataGridView1.Rows[index].Cells[2].Value = projectInfo.SubjectId;
                    this.dataGridView1.Rows[index].Cells[3].Value = projectInfo.ProjectId;
                    this.dataGridView1.Rows[index].Cells[4].Value = projectInfo.Engineer;
                    this.dataGridView1.Rows[index].Cells[5].Value = projectInfo.Review;
                    this.dataGridView1.Rows[index].Cells[6].Value = projectInfo.Process;
                    this.dataGridView1.Rows[index].Cells[7].Value = projectInfo.Standard;
                    this.dataGridView1.Rows[index].Cells[8].Value = projectInfo.Approval;
                    if(projectInfo.IsCurrent)
                    {
                        this.currentRow = this.dataGridView1.Rows[index];
                        currentRow.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
            catch (Exception ex)
            {

                HZH_Controls.Forms.FrmDialog.ShowDialog(this, ex.Message);
            }
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            try
            {
                loadDataView();
                ProjectInfo currentProject = LiteDBUtils.getCurrentProject();
                if(currentProject != null)
                {
                    projectIdCurrentText.Text = currentProject.ProjectId;
                    subjectIdCurrentText.Text = currentProject.SubjectId;
                    subjectNameCurrentText.Text = currentProject.SubjectName;
                    engineerCurrentText.Text = currentProject.Engineer;
                }
            }
            catch (Exception ex)
            {

                HZH_Controls.Forms.FrmDialog.ShowDialog(this, ex.Message);
            }
        }

        private void setCurrentButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                        DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                    int id = (int)row.Cells[0].Value;
                    ProjectInfo currentProject = LiteDBUtils.updateCurrentProject(id);

                    projectIdCurrentText.Text = currentProject.ProjectId;
                    subjectIdCurrentText.Text = currentProject.SubjectId;
                    subjectNameCurrentText.Text = currentProject.SubjectName;
                    engineerCurrentText.Text = currentProject.Engineer;
                    if(currentRow!=null)
                    {
                        currentRow.DefaultCellStyle.BackColor = Color.White;
                    }
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    currentRow = row;
                    HZH_Controls.Forms.FrmTips.ShowTipsSuccess(this,"设置成功");
                }
            }
            catch (Exception ex)
            {

                HZH_Controls.Forms.FrmDialog.ShowDialog(this, ex.Message);
            }
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                     DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                    int id = (int)row.Cells[0].Value;
                    ProjectInfo projectInfo = LiteDBUtils.queryOne(id);

                    subjectNameInputText.Text = projectInfo.SubjectName;
                    subjectIdInputText.Text = projectInfo.SubjectId;
                    projectIdInputText.Text = projectInfo.ProjectId;
                    engineerInputText.Text = projectInfo.Engineer;
                    reviewInputText.Text = projectInfo.Review;
                    processInputText.Text = projectInfo.Process;
                    standardInputText.Text = projectInfo.Standard;
                    approvalInputText.Text = projectInfo.Approval;

                    activeInputButtons(true);

                    isEdit = true;
                }
            }
            catch (Exception ex)
            {

                HZH_Controls.Forms.FrmDialog.ShowDialog(this, ex.Message);
            }
    }
        private void activeInputButtons(bool isAction)
        {
            subjectNameInputText.Enabled = isAction;
            subjectIdInputText.Enabled = isAction;
            projectIdInputText.Enabled = isAction;
            engineerInputText.Enabled = isAction;
            reviewInputText.Enabled = isAction;
            processInputText.Enabled = isAction;
            standardInputText.Enabled = isAction;
            approvalInputText.Enabled = isAction;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}