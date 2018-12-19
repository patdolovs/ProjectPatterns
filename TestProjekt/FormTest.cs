using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostgreLib;

namespace TestProjekt
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostgreEntity entity = new PostgreEntity();

            entity.name = "test";

            
            entity.entityValues.Add(new KeyValuePair<string, string>("id", ""));
            entity.entityValues.Add(new KeyValuePair<string, string>("firstvalue", ""));
            entity.entityValues.Add(new KeyValuePair<string, string>("secondvalue", ""));
            entity.entityValues.Add(new KeyValuePair<string, string>("lastvalue", ""));
            Database database = new Database();
            database.addEntity(entity);

            AvailableItemQueries availableItems = new AvailableItemQueries(entity);
            availableItems.registerQueries(new InsertItemQuery());
            availableItems.registerQueries(new DeleteItemQuery());
            //availableItems.registerQueries(new PostgreUpdate());
            


            PresentationDirector presentationDirector = new PresentationDirector(new FormView());
            presentationDirector.buildPresentable(availableItems);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
