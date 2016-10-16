using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XmlContentTranslator.Git;

namespace XmlContentTranslator
{
    public partial class GitPullRequestForm : Form
    {
        private readonly CommandLineRunner _cliRunner;
        /// <summary>
        /// Full git.exe file path.
        /// </summary>
        private readonly string _gitPath;
        private string _workingDirectory;

        public GitPullRequestForm(string workingDir, string gitpath)
        {
            InitializeComponent();
            _workingDirectory = workingDir;
            _gitPath = gitpath;
            _cliRunner = new CommandLineRunner();
        }

        /// <summary>
        /// TODO: oauth authentificatoin is required.
        /// </summary>
        /// <param name="commitMessage"></param>
        private void SendPullRequest(string commitMessage)
        {
            // TODO: Handle specific file.
            // TODO: Handle if there are file other than language files modified.

            // Commit changes
            string arguments = $"commit -a -m \"{commitMessage}\"";
            _cliRunner.RunCommandAndGetOutput(_gitPath, arguments, _workingDirectory);

            // Send to origin repository
            //string result = _cliRunner.Result;
            //arguments = "push origin HEAD:patch-lang";
            //_cliRunner.RunCommandAndGetOutput(_gitPath, arguments, string.Empty);

            // Send pull-request
            // (git request-pull v1.0 https://git.ko.xz/project master:for-linus)
            // git request-pull origin/master myfork
            //arguments = "request-pull remote/master patch-lang";
            arguments = "request-pull remote/master origin patch-lang";
            _cliRunner.RunCommandAndGetOutput(_gitPath, arguments, string.Empty);
        }

        private void buttonSendPR_Click(object sender, EventArgs e)
        {
            // TODO: Validation.
            SendPullRequest(textBoxCommitMessage.Text);
        }
    }
}
