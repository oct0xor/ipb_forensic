using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace NulledViewer
{
    public partial class MainForm : Form
    {
        private static string connectionString;
        private List<Forum> forumsList = new List<Forum>();
        private List<Message> messagesList = new List<Message>();
        private int privateMessagesLimit = 1000;
        private string[] privateMessagesFilter = { "Welcome to Nulled.IO", "Duplicate accounts detected", "Welcome to Nulled" };
        private int forumMessagesLimit = 100;

        public MainForm()
        {
            InitializeComponent();

            topicsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            topicsDataGridView.SelectionChanged += new EventHandler(TopicsDataGridView_SelectionChanged);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var connectionForm = new ConnectionForm();
            connectionForm.ShowDialog();

            if (connectionForm.ConnectionString == null)
                Environment.Exit(0);

            connectionString = connectionForm.ConnectionString;

            backgroundColorTextBox.Text = Properties.Settings.Default.background;
            textColorTextBox.Text = Properties.Settings.Default.color;

            ShowForums();

            ShowPrivateMessages(0, privateMessagesLimit, -1);
        }

        private void ShowForums()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            var dataSet = new DataSet();
            var mySqlDataAdapter = new MySqlDataAdapter("select id, topics, posts, name, description, parent_id from forums", conn);
            mySqlDataAdapter.Fill(dataSet, "forums");

            if (dataSet.Tables.Count == 1)
            {
                for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    var forum = new Forum();

                    forum.Id = int.Parse(dataSet.Tables[0].Rows[i]["id"].ToString());
                    forum.Topics = int.Parse(dataSet.Tables[0].Rows[i]["topics"].ToString());
                    forum.Posts = int.Parse(dataSet.Tables[0].Rows[i]["posts"].ToString());
                    forum.Name = dataSet.Tables[0].Rows[i]["name"].ToString();
                    forum.Description = dataSet.Tables[0].Rows[i]["description"].ToString();
                    forum.ParentId = int.Parse(dataSet.Tables[0].Rows[i]["parent_id"].ToString());

                    forum.Node = new TreeNode() { Name = forum.Id.ToString(), Text = forum.Name.ToString() };

                    forumsList.Add(forum);
                }
            }

            for (var i = 0; i < forumsList.Count; i++)
            {
                var parentId = forumsList[i].ParentId;

                if (parentId == -1)
                {
                    forumsTreeView.Nodes.Add(forumsList[i].Node);
                }
                else
                {
                    var parent = forumsList.Find(x => x.Id == parentId);

                    parent.Node.Nodes.Add(forumsList[i].Node);
                }
            }

            conn.Close();
        }

        private void ShowPrivateMessages(int start, int size, int userId)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            pmStatusLabel.Text = "Status: Waiting...";

            MySqlDataAdapter mySqlDataAdapter;
            if (userId == -1)
            { 
                mySqlDataAdapter = new MySqlDataAdapter("select mt_id, mt_date, mt_title, mt_replies from message_topics limit " + start.ToString() + ", " + size.ToString(), conn);
            }
            else
            {
                mySqlDataAdapter = new MySqlDataAdapter("select mt_id, mt_date, mt_title, mt_replies from message_topics where `mt_starter_id` = " + userId.ToString() + " or `mt_to_member_id` = " + userId.ToString(), conn);
            }

            var dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet, "message_topics");

            messagesList.Clear();

            if (dataSet.Tables.Count == 1)
            {
                for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    var badTopic = false;
                    var message = new Message();

                    message.Id = int.Parse(dataSet.Tables[0].Rows[i]["mt_id"].ToString());
                    message.Date = long.Parse(dataSet.Tables[0].Rows[i]["mt_date"].ToString());
                    message.Title = HttpUtility.HtmlDecode(dataSet.Tables[0].Rows[i]["mt_title"].ToString());
                    message.Replies = int.Parse(dataSet.Tables[0].Rows[i]["mt_replies"].ToString());

                    for (var j = 0; j < privateMessagesFilter.Count(); j++)
                    {
                        if (message.Title == privateMessagesFilter[j])
                            badTopic = true;
                    }

                    if (!CheckMessageHasUrl(message.Id))
                        badTopic = true;

                    if (!badTopic)
                        messagesList.Add(message);
                }
            }

            pmListBox.Items.Clear();

            for (var i = 0; i < messagesList.Count; i++)
            {
                pmListBox.Items.Add(messagesList[i].Id.ToString() + " - " + messagesList[i].Title);
            }

            pmStatusLabel.Text = "Status: Done";

            pmAllLabel.Text = "/" + messagesList.Count.ToString();

            conn.Close();
        }

        private void ForumsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            var forum = forumsList.Find(x => x.Node == e.Node);

            var dataSet = new DataSet();
            var mySqlDataAdapter = new MySqlDataAdapter("select tid, title from topics WHERE `forum_id` = " + forum.Id.ToString() + " ORDER BY tid", conn);
            mySqlDataAdapter.Fill(dataSet, "topics");

            topicsDataGridView.Rows.Clear();
            topicsDataGridView.Refresh();

            if (dataSet.Tables.Count == 1)
            {
                for (var i = dataSet.Tables[0].Rows.Count; i-- > 0;)
                {
                    topicsDataGridView.Rows.Add(int.Parse(dataSet.Tables[0].Rows[i]["tid"].ToString()), HttpUtility.HtmlDecode(dataSet.Tables[0].Rows[i]["title"].ToString()));
                }
            }

            topicsDataGridView.Refresh();

            conn.Close();
        }

        private void TopicsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (topicsDataGridView.SelectedRows.Count == 0)
                return;

            var conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            var topic = topicsDataGridView.Rows[topicsDataGridView.SelectedRows[0].Index].Cells[0].Value;

            var dataSet = new DataSet();
            var mySqlDataAdapter = new MySqlDataAdapter("select pid, author_name, post_date, post from posts WHERE `topic_id` = " + topic.ToString() + " limit " + forumMessagesLimit.ToString(), conn);
            mySqlDataAdapter.Fill(dataSet, "posts");

            var html = Html.GetStart();

            if (dataSet.Tables.Count == 1)
            {
                for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    var date = long.Parse(dataSet.Tables[0].Rows[i]["post_date"].ToString());
                    var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    var datetime = start.AddSeconds(date).ToLocalTime();

                    html += Html.GetElement(dataSet.Tables[0].Rows[i]["author_name"].ToString() + "<br>" + datetime.ToString("dd/MM/yyyy") + "<br>" + datetime.ToString("HH:mm:ss"), dataSet.Tables[0].Rows[i]["post"].ToString());
                }
            }

            html += Html.GetEnd();

            forumHtmlPanel.Text = html;

            conn.Close();
        }

        private void PmNextButton_Click(object sender, EventArgs e)
        {
            pmPageNumUpDown.Value += 1;
        }

        private void PmPrevButton_Click(object sender, EventArgs e)
        {
            if (pmPageNumUpDown.Value > 0)
            {
                pmPageNumUpDown.Value -= 1;
            }
        }

        private string GetUserName(int id)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            var dataSet = new DataSet();
            var mySqlDataAdapter = new MySqlDataAdapter("select name from members where `member_id` = " + id.ToString(), conn);
            mySqlDataAdapter.Fill(dataSet, "members");

            string name;
            if (dataSet.Tables.Count == 1)
            {
                if (dataSet.Tables[0].Rows.Count == 1)
                {
                    name = dataSet.Tables[0].Rows[0]["name"].ToString();
                }
                else
                {
                    name = "UNKNOWN NAME";
                }
            }
            else
            {
                name = "UNKNOWN NAME";
            }

            conn.Close();

            return name;
        }

        private int GetUserID(string name)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            var dataSet = new DataSet();
            var mySqlDataAdapter = new MySqlDataAdapter("select member_id from members where `name` = '" + name + "'", conn);
            mySqlDataAdapter.Fill(dataSet, "members");

            int id;
            if (dataSet.Tables.Count == 1)
            {
                if (dataSet.Tables[0].Rows.Count == 1)
                {
                    id = int.Parse(dataSet.Tables[0].Rows[0]["member_id"].ToString());
                }
                else
                {
                    id = 0;
                }
            }
            else
            {
                id = 0;
            }

            conn.Close();

            return id;
        }

        private void PmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            var regex = new Regex(@"^([\d]+)");
            var match = regex.Match(pmListBox.SelectedItem.ToString());

            var id = int.Parse(match.Value);

            var dataSet = new DataSet();
            var mySqlDataAdapter = new MySqlDataAdapter("select msg_post, msg_author_id from message_posts where `msg_topic_id` = " + id.ToString(), conn);
            mySqlDataAdapter.Fill(dataSet, "message_posts");

            var html = Html.GetStart();

            if (dataSet.Tables.Count == 1)
            {
                for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    html += Html.GetElement(GetUserName(int.Parse(dataSet.Tables[0].Rows[i]["msg_author_id"].ToString())), dataSet.Tables[0].Rows[i]["msg_post"].ToString());
                }
            }

            html += Html.GetEnd();

            pmHtmlPanel.Text = html;

            conn.Close();
        }

        private bool CheckMessageHasUrl(int id)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            var dataSet = new DataSet();
            var mySqlDataAdapter = new MySqlDataAdapter("select msg_post, msg_author_id from message_posts where `msg_topic_id` = " + id.ToString(), conn);
            mySqlDataAdapter.Fill(dataSet, "message_posts");

            var result = true;
            if (dataSet.Tables.Count == 1)
            {
                if (pmFilterCheckBox1.Checked && dataSet.Tables[0].Rows.Count == 1)
                    result = false;

                if (pmFilterCheckBox2.Checked)
                {
                    var hasUrl = false;

                    for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        var post = dataSet.Tables[0].Rows[i]["msg_post"].ToString();
                        var regex = new Regex(@"([a-z\.])\.([a-z\.]{2,6})([\/])");
                        var match = regex.Match(post);

                        if (match.Success)
                            hasUrl = true;
                    }

                    if (!hasUrl)
                        result = false;
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }

            conn.Close();

            return result;
        }

        private void PmPageNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            ShowPrivateMessages((int)pmPageNumUpDown.Value * privateMessagesLimit, privateMessagesLimit, -1);
        }

        private void PmFilterCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowPrivateMessages((int)pmPageNumUpDown.Value * privateMessagesLimit, privateMessagesLimit, -1);
        }

        private void PmFilterCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            ShowPrivateMessages((int)pmPageNumUpDown.Value * privateMessagesLimit, privateMessagesLimit, -1);
        }

        private void TopicGoButton_Click(object sender, EventArgs e)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            var dataSet = new DataSet();
            var mySqlDataAdapter = new MySqlDataAdapter("select pid, author_name, post_date, post from posts WHERE `topic_id` = " + topicNumUpDown.Value.ToString() + " limit " + forumMessagesLimit.ToString(), conn);
            mySqlDataAdapter.Fill(dataSet, "posts");

            var html = Html.GetStart();

            if (dataSet.Tables.Count == 1)
            {
                for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    var date = long.Parse(dataSet.Tables[0].Rows[i]["post_date"].ToString());
                    var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    var datetime = start.AddSeconds(date).ToLocalTime();

                    html += Html.GetElement(dataSet.Tables[0].Rows[i]["author_name"].ToString() + "<br>" + datetime.ToString("dd/MM/yyyy") + "<br>" + datetime.ToString("HH:mm:ss"), dataSet.Tables[0].Rows[i]["post"].ToString());
                }
            }

            html += Html.GetEnd();

            forumHtmlPanel.Text = html;

            conn.Close();
        }

        private void TopicSearchButton_Click(object sender, EventArgs e)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            var dataSet = new DataSet();
            var mySqlDataAdapter = new MySqlDataAdapter("select tid, title from topics WHERE `title` LIKE '%" + topicSearchTextBox.Text + "%' ORDER BY tid", conn);
            mySqlDataAdapter.Fill(dataSet, "topics");

            topicsDataGridView.Rows.Clear();
            topicsDataGridView.Refresh();

            if (dataSet.Tables.Count == 1)
            {
                for (var i = dataSet.Tables[0].Rows.Count; i-- > 0;)
                {
                    topicsDataGridView.Rows.Add(int.Parse(dataSet.Tables[0].Rows[i]["tid"].ToString()), HttpUtility.HtmlDecode(dataSet.Tables[0].Rows[i]["title"].ToString()));
                }
            }

            topicsDataGridView.Refresh();

            conn.Close();
        }

        private void UserPmSearchButton_Click(object sender, EventArgs e)
        {
            ShowPrivateMessages(0, 0, GetUserID(userPmSearchTextBox.Text));
        }

        private void ColorSetButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.background = backgroundColorTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void ColorSetButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.color = textColorTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void PickButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var color = string.Format("{0:X2}{1:X2}{2:X2}", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
                backgroundColorTextBox.Text = color;
                Properties.Settings.Default.background = color;
            }
        }

        private void PickButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var color = string.Format("{0:X2}{1:X2}{2:X2}", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
                textColorTextBox.Text = color;
                Properties.Settings.Default.color = color;
            }
        }
    }
}
