using PostgreLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjekt
{
    public partial class FormView : Form, IPresentBuilder
    {
        public FormView()
        {
            InitializeComponent();
            this.Show();
        }

        private DataTable dataTable;
        private string InputEntityName;
        private int OfsetFromTop = 50;


        public void addCommandForQuery(IQuery query)
        {

            Button formButton = new Button();
            formButton.Left = 500;
            formButton.Top = OfsetFromTop;
            OfsetFromTop += 30;
            formButton.Text = query.GetType().ToString();
            formButton.Click += (s, e) =>
            {
                Entity fullEntity = createAFullEntity();
                fullEntity.name = InputEntityName;

                Postgre postgre = new Postgre();

                postgre.executeQuery(query.BuildQuery(fullEntity));
                UpdateTable(postgre);
            };
            this.Controls.Add(formButton);
        }

        private void UpdateTable(Postgre postre)
        {
            dataTable = postre.fetchAllDataFromTable(InputEntityName);
            ((DataGridView)(this.Controls["dataGridViewValues"])).DataSource = dataTable;
        }

        public void generateTextboxes(Entity entity)
        {
            int i = 1;
            int move = 0;
            foreach (var value in entity.entityValues)
            {


                Label label = new Label();
                label.Name = "label" + i;
                label.Text = value.Key;
                label.Top = 150 + move;
                label.Left = 500;
                label.Size = new Size(50, 16);
                this.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Name = "textbox" + i;
                textBox.Size = new Size(200, 16);
                textBox.Left = 550;
                textBox.Top = 150 + move;
                this.Controls.Add(textBox);
                i++;
                move += 30;
            }
        }

        public void generateDataGrid()
        {

            DataGridView dataGridView = new DataGridView();
            dataGridView.Name = "dataGridViewValues";

            this.Controls.Add(dataGridView);
        }


        private Entity createAFullEntity()
        {
            Entity entity = new Entity();
            List<string> listOfTextboxValues = new List<string>();
            List<string> listOfLabelValues = new List<string>();


            foreach (var textbox in this.Controls.OfType<TextBox>())
            {

                listOfTextboxValues.Add(textbox.Text.ToString());
            }

            foreach (var label in this.Controls.OfType<Label>())
            {
                listOfLabelValues.Add(label.Text.ToString());
            }


            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                entity.entityValues.Add(new KeyValuePair<string, string>(listOfLabelValues[i], listOfTextboxValues[i]));

            }


            return entity;
        }

        public void addPresentationView(Entity entity)
        {
            InputEntityName = entity.name;
            generateDataGrid();
            UpdateTable(new Postgre());
        }

        public void generateInsertables(Entity entity)
        {
            generateTextboxes(entity);
        }
    }
}

