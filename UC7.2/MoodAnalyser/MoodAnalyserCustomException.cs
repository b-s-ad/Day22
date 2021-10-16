﻿    using System;
using System.Reflection;
using MoodAnalyser;
using System.Collections.Generic;
using System.Text;


namespace MoodAnalyser  // 7.2
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType   //Enum
        {
            NULL_MESSAGE, EMPTY_MESSAGE,

            NO_SUCH_FIELD, NO_SUCH_METHOD,

            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE

        }
        private readonly ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }

}
