using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameRecorder
{
    public partial class Nrmain : Form
    {
        public Nrmain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectVoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void selectKhzButton_Click(object sender, EventArgs e)
        {

        }

        private void treeSelectionPanel_Paint(object sender, PaintEventArgs e)
        {
            treeSelectionPanel.AutoScroll = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void mainViewPanel_Paint(object sender, PaintEventArgs e)
        {
            mainViewPanel.AutoScroll = true;
            mainViewPanel.Visible = false;

        }

        private void addListButton_Click(object sender, EventArgs e)
        {

        }

        private void editListButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteListButton_Click(object sender, EventArgs e)
        {

        }


    }

    class DataManager
    {
        // Holds connection with the database
        SQLiteConnection m_dbConnection;

        void Main(string[] args)
        {
            DataManager dMan = new DataManager();
        }

        public DataManager()
        {
            createNewDatabase();
            connectToDatabase();
            createTables();
            fillTable();
            printNames();
            
        }

        // Creates an empty database file
        void createNewDatabase()
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
        }

        // Creates a connection with database file. 
        void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        // Create tables
        void createTables()
        {
            //to do
            string sqluniqname = "create table unique_name (reference_name text, unique_name_id int)";
            SQLiteCommand command = new SQLiteCommand(sqluniqname, m_dbConnection);
            command.ExecuteNonQuery();

            string sqlrec = "create table recordings (rec_id int, unique_name_id from unique_name, sample_rate int, rec_voice_id from recorder_voices, timestamp datetime, filepath text)";
            command = new SQLiteCommand(sqlrec, m_dbConnection);
            command.ExecuteNonQuery();

            string sqlallname = "create table all_names (reference_name text, id int)";
            command = new SQLiteCommand(sqlallname, m_dbConnection);
            command.ExecuteNonQuery();

            string sqlrecvoice = "create table recorder_voices (rec_voice_id int ,voice_name text)";
            command = new SQLiteCommand(sqlrecvoice, m_dbConnection);
            command.ExecuteNonQuery();
        }
        
        // Inserts some test values in a table - duplicate code solve later
        void fillTable()
        {
            //to do
            string sql = "insert into unique_name (reference_name, unique_name_id) values ('Jack', 1)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "insert into unique_name (reference_name, unique_name_id) values ('Jane', 2)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "insert into unique_name (reference_name, unique_name_id) values ('Joe', 3)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        // Writes names to the console sorted in descending order.
        void printNames()
        {
            string sql = "select * from unique_name order by unique_name_id desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["reference_name"] + "\tId: " + reader["unique_name_id"]);
            Console.ReadLine();

        }

        // method to add recorder
        void addRecorder(string name)
        {
            // to do
        }

        // method to add recording
        void addRecording(int nameID, int sample_rate, int recorderVoiceID, string filepath)
        {
            // to do
        }

        void addAlternateNameSpelling(int parentNameID, string name, bool isLastName)
        {
            // to do
        }

        void adduniquePronunciation(string name)
        {
            // to do
        }

        void getAllPronunciations()
        {
            //to do
        }

        void getAllRecordingsForName(int name_id)
        {
            // to do
        }

        void getRecorderInfo(int recorder_id)
        {
            // to do
        }

        void getAllNamesWitParent(int parent_name_id)
        {
            // to do
        }


    }
}
   