﻿using System;
using Terminal.Gui;
using System.Collections.Generic;
using MyMessanger;

namespace ConsoleMessengerWithGUI
{
    class Program
    {
        // Очередь сообщений
        private static List<Message> messages = new List<Message>();
        private static MessangerClientAPI API = new MessangerClientAPI();

        private static MenuBar menu;
        private static Window winMain;
        private static Window winMessages;
        private static Label labelUser;
        private static TextField fieldUsername;
        private static Label labelMessage;
        private static TextField fieldMessage;
        private static Button btnSend;

        static void Main(string[] args)
        {

        }
    }
}