﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlApp.Entities.Objects;
using ControlApp.ApiCore.Management;
using MetroFramework;
using static ControlApp.OnPremises.Program;

namespace ControlApp.OnPremises.Panels
{
    public partial class pnlDepartament : pnlSlider
    {
        DepartamentManagement ApiAccess = new DepartamentManagement();
        Departament ObjDpt = new Departament();
        string IdSession = MystaticValues.IdSession;
        public pnlDepartament(Form owner) : base(owner)
        {
            InitializeComponent();
            LoadDataGrid();
        }
        public void CleanFields()
        {
            txtName_Dpt.Text = "";
            txtRetrieveByName.Text = "";
        }
        private void LoadDataGrid()
        {
            try
            {
                dgvDpt.Rows.Clear();
                var ListDpt = ApiAccess.RetrieveAllDepartament<Departament>();
                foreach (Departament element in ListDpt)
                {
                    string[] RowDpt;
                    RowDpt = new string[] { element.ID_Dpt.ToString(), element.Name_Dpt };
                    dgvDpt.Rows.Add(RowDpt);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string NameDpt = txtName_Dpt.Text;
            if (Checkname(NameDpt) == true || NameDpt.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + NameDpt + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName_Dpt.Focus();
            }
            else
            {
                try
                {
                    ObjDpt.Name_Dpt = NameDpt;
                    ObjDpt.CreateBy = IdSession;
                    ApiAccess.CreateDepartament(ObjDpt);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private bool Checkname(string pDptName)
        {
            try
            {
                bool finded = false;
                ObjDpt.Name_Dpt = pDptName;
                var ListDpt = ApiAccess.SuperRetrieveAllByNameDepartament<Departament>(ObjDpt);
                foreach (Departament element in ListDpt)
                {
                    if (element.Name_Dpt == pDptName)
                    {
                        finded = true;
                        if (finded == true)
                        {
                            break;
                        }
                    }
                }
                return finded;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string NameDpt = txtName_Dpt.Text;
            if (NameDpt.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + NameDpt + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName_Dpt.Focus();
            }
            else
            {
                try
                {
                    ObjDpt.Name_Dpt = NameDpt;
                    ObjDpt.UpdateBy = IdSession;
                    ApiAccess.UpdateDepartament(ObjDpt);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Row = dgvDpt.CurrentRow.Index;
            string NameDpt = dgvDpt[1, Row].Value.ToString();
            if (dgvDpt[1, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Eliminar. \n Favor Intentelo Nuevamente", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvDpt.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar el Area de: " + NameDpt + "?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjDpt.ID_Dpt = Convert.ToInt32(dgvDpt[0, Row].Value);
                        ObjDpt.UpdateBy = IdSession;
                        ApiAccess.DeleteDepartament(ObjDpt);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    CleanFields();
                    LoadDataGrid();
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CleanFields();
            LoadDataGrid();
        }
        private void dgvDpt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row = dgvDpt.CurrentRow.Index;
                txtName_Dpt.Text = dgvDpt[1, Row].Value.ToString();
                btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
