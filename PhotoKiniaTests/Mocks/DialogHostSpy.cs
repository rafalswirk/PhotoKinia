﻿using MaterialDesignThemes.Wpf;
using PhotoKinia.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoKiniaTests.Mocks
{
    class DialogHostSpy : IDialogHostWrapper
    {
        public object PassedObject { get; private set; }
        public string DialogID { get; private set; }
        public int NumberOfCalls { get; private set; }

        public Task ShowAsync(object o, string dialogID, DialogOpenedEventHandler openedEventHandler, DialogClosingEventHandler closingEventHandler)
        {
            PassedObject = o;
            DialogID = dialogID;
            NumberOfCalls++;
            return Task.CompletedTask;
        }
    }
}