﻿namespace Kr4
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        DialogResult ShowExitMessage(string message);

        void ShowError(string error);

    }


    public class MessageService : IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowExitMessage(string message)
        {
            DialogResult result = MessageBox.Show(message,
               "Message",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
            return result;
        }
    }
}
