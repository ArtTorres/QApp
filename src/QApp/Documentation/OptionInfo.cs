﻿namespace QApp.Documentation
{
    public class OptionInfo
    {
        public string Name
        {
            get;
            set;
        }
        public string Alias
        {
            get;
            set;
        }
        public bool IfPresent
        {
            get;
            set;
        }
        public bool IsRequired
        {
            get;
            set;
        }

        public string DefaultValue
        {
            get;
            set;
        }

        public string ParseValues
        {
            get;
            set;
        }
    }
}
