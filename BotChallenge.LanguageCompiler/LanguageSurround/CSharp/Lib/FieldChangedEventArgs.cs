﻿using System;
using Bots.Models;

namespace Bots.Lib
{
    class FieldChangedEventArgs : EventArgs
    {
        public FieldChangedEventArgs(Field oldField, Field newField)
        {
            OldField = oldField;
            NewField = newField;
        }

        public Field OldField { get; set; }
        public Field NewField { get; set; }
    }
}
