using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace SendBadEmail
{
    public partial class FormSendCorruptMessages : Form
    {
        private static Random _Random = new Random();
        private static int _RecipientIndex = 0;
        private ListBox _logListBox;
        private LogViewer _logViewer = null;
        private ClassFormConfig _formConfig = null;

        public FormSendCorruptMessages(LogViewer logViewer)
        {
            InitializeComponent();
            _formConfig = new ClassFormConfig(this);

            UpdateRecipientButtons();
            _logListBox = logViewer.listBoxLog;
            _logViewer = logViewer;
            UpdateCredentials();
        }

        private void UpdateRecipientButtons()
        {
            if (String.IsNullOrEmpty(textBoxAddRecipient.Text))
            {
                buttonAddRecipient.Enabled = false;
            }
            else
            {
                string sAddRecipient = textBoxAddRecipient.Text;
                if (listBoxRecipients.Items.IndexOf(sAddRecipient) >= 0)
                {
                    buttonAddRecipient.Enabled = false;
                }
                else
                    buttonAddRecipient.Enabled = true;
            }
            buttonRemoveRecipient.Enabled = (listBoxRecipients.SelectedIndex >= 0);
        }

        private void UpdateSenderOptions()
        {
            if (radioButtonSpecificSender.Checked)
            {
            }
        }

        private void buttonAddRecipient_Click(object sender, EventArgs e)
        {
            listBoxRecipients.Items.Add(textBoxAddRecipient.Text);
            UpdateRecipientButtons();
        }

        private void textBoxAddRecipient_TextChanged(object sender, EventArgs e)
        {
            UpdateRecipientButtons();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxRecipients_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRecipientButtons();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int lInterval = (int)(numericUpDownSendDelay.Value * 1000);
            if (lInterval < 1) lInterval = 1;
            timerSend.Interval = 1; // Trigger the first send immediately
            timerSend.Start();
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerSend.Stop();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private string Subject()
        {
            return textBoxSubject.Text.Replace("%N", numericUpDownMessageNum.Value.ToString());
        }

        private string Sender()
        {
            if (radioButtonSpecificSender.Checked)
                return textBoxSpecificSender.Text;

            // Generate random sender email based on criteria specified
            string sDomain = textBoxSenderDomainTemplate.Text;
            string sUser = textBoxSenderUserTemplate.Text;
            return ReplaceWildcards(sUser) + "@" + ReplaceWildcards(sDomain);
        }

        private string ReplaceWildcards(String WildcardString)
        {
            // Replace the wildcards found in the string with random letters
            while (WildcardString.Contains("*"))
            {
                int i = WildcardString.IndexOf("*");
                if (i == 0)
                {
                    WildcardString = WildcardAsterisk() + WildcardString.Substring(i + 1);
                }
                else
                {
                    WildcardString = WildcardString.Substring(0, i) + WildcardAsterisk() + WildcardString.Substring(i + 1);
                }
            }
            return WildcardString;
        }

        private string WildcardAsterisk()
        {
            // Return a random string
            const string sSourceChars = "abcdefghijklmnopqrstuvwxyz";
            int iStringLength = _Random.Next(8) + 3;
            string sWildString = "";
            for (int i = 0; i < iStringLength; i++)
            {
                sWildString += sSourceChars[_Random.Next(sSourceChars.Length)];
            }
            return sWildString;
        }

        private void timerSend_Tick(object sender, EventArgs e)
        {
            // Send a message
            timerSend.Stop();
            SendMessage();
            int lInterval = (int)(numericUpDownSendDelay.Value * 1000);
            if (lInterval < 1) lInterval = 1;
            timerSend.Interval = lInterval;
            if (numericUpDownMessageNum.Value >= numericUpDownStopMessageNumber.Value)
            {
                // We've sent enough messages, so stop
                buttonStop_Click(this, null);
            }
            else
                timerSend.Start();
        }

        private string CreateMessageBody()
        {
            // Create the message body (depending upon what corruption we want).  The message body is always HTML.

            // We use HTML 4.01 as then we can use the <font> tag to create some bad HTML
            StringBuilder htmlBody = new StringBuilder("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01//EN/");
            htmlBody.AppendLine(" \"http://www.w3.org/TR/html4/strict.dtd\">");


            htmlBody.Append("<html><head>");

            // Add HTML <HEAD>
            
            htmlBody.Append("</head><body>");
            // Add HTML <BODY>

            if (checkBoxTooManyOpenTags.Checked)
            {
                htmlBody.AppendLine();
                htmlBody.Append("<p>The following block of numbers will trigger a MIME conversion error (too many open tags)</p><p>");
                StringBuilder closingTags = new StringBuilder();
                for (int i = 0; i < 10002; i++)
                {
                    htmlBody.Append("<font size=\"1\">");
                    closingTags.Append("</font>");
                    htmlBody.Append(i % 10);
                    if ((i % 100) == 0)
                        htmlBody.AppendLine();
                }
                htmlBody.Append(closingTags.ToString());
                htmlBody.AppendLine("</p>");
            }

            // Close HTML
            htmlBody.Append("</body></html>");
            return htmlBody.ToString();
        }

        private MailMessage CreateMessage()
        {
            // Create the messge that we are going to send

            // Check we have recipients
            if (listBoxRecipients.Items.Count < 1)
            {
                _logListBox.Items.Add("No recipients specified, cannot send message");
                return null;
            }
            // Build the message
            MailMessage oMessage = new MailMessage();
            oMessage.From = new MailAddress(this.Sender());
            if (radioButtonSendToEachRecipient.Checked)
            {
                // Send message to each recipient as we loop
                _logListBox.Items.Add("Sending " + this.Subject() + " to " + listBoxRecipients.Items[_RecipientIndex].ToString());
                oMessage.To.Add(new MailAddress(listBoxRecipients.Items[_RecipientIndex].ToString()));
                _RecipientIndex++;
                if (_RecipientIndex > listBoxRecipients.Items.Count - 1)
                    _RecipientIndex = 0;
            }
            else
            {
                // Send message to all recipients
                for (int i = 0; i < listBoxRecipients.Items.Count; i++)
                    oMessage.To.Add(new MailAddress(listBoxRecipients.Items[i].ToString()));
            }
            oMessage.Subject = this.Subject();
            oMessage.IsBodyHtml = true;
            oMessage.Body = CreateMessageBody();

            if (checkBoxAddAttachment.Checked)
            {
                // Add an attachment
                int iAttachSize = (int)numericUpDownAttachSize.Value;
                if (comboBoxAttachSizeUnit.SelectedIndex > 0)
                    iAttachSize = iAttachSize * (int)(System.Math.Pow((double)1024, (double)comboBoxAttachSizeUnit.SelectedIndex));

                byte[] bytAttach = new byte[iAttachSize];
                MemoryStream oAttachMS = new MemoryStream(bytAttach);

                Attachment oAttach = new Attachment(oAttachMS, "Attachment.txt", "text/plain");
                oMessage.Attachments.Add(oAttach);
            }

            return oMessage;
        }

        private void SendMessage()
        {
            MailMessage oMessage = CreateMessage();
            if (oMessage is null) return;

            SmtpClient oClient = new SmtpClient();
            oClient.Host = textBoxTargetSMTPServer.Text;
            oClient.Port = (int)numericUpDownSMTPPort.Value;
            oClient.EnableSsl = checkBoxSSL.Checked;

            if (checkBoxAuthenticate.Checked)
            {
                oClient.Credentials = new System.Net.NetworkCredential(textBoxUsername.Text, textBoxPassword.Text);
            }
            DateTime timeStart = DateTime.Now;

            try
            {
                oClient.Send(oMessage);
                TimeSpan sendTime = DateTime.Now.Subtract(timeStart);
                string logInfo = String.Format("Sent {0} in {1:hh\\:mm\\:ss}", this.Subject(), sendTime);
                _logListBox.Items.Add(logInfo);
            }
            catch (Exception ex)
            {
                string sError = "";
                if (ex is SmtpException)
                {
                    sError = (ex as SmtpException).StatusCode.ToString() + " " + ex.Message;
                }
                else
                {
                    sError = ex.Message;
                }
                System.Windows.Forms.MessageBox.Show(sError, "Failed to send message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            numericUpDownMessageNum.Value++;
        }

        private void UpdateCredentials()
        {
            textBoxUsername.Enabled = checkBoxAuthenticate.Checked;
            textBoxPassword.Enabled = checkBoxAuthenticate.Checked;
        }

        private void checkBoxAuthenticate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCredentials();
        }

        private void checkBoxSSL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSSL.Checked)
            {
                if ((int)numericUpDownSMTPPort.Value == 25)
                    numericUpDownSMTPPort.Value = 587;
            }
            else
            {
                if ((int)numericUpDownSMTPPort.Value == 587)
                    numericUpDownSMTPPort.Value = 25;
            }
        }

        private void buttonRemoveRecipient_Click(object sender, EventArgs e)
        {
            int i = listBoxRecipients.SelectedIndex;
            listBoxRecipients.Items.Remove(listBoxRecipients.SelectedItem);
            if (i > 0 && (i == listBoxRecipients.Items.Count))
                i--;
            if (i < listBoxRecipients.Items.Count)
                listBoxRecipients.SelectedIndex = i;
        }

        private void ButtonShowLog_Click(object sender, EventArgs e)
        {
            if (_logViewer.Visible)
            {
                _logViewer.Focus();
                return;
            }
            _logViewer.Show(this);
        }
    }
}
