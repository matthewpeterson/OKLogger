﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace OKLogger.Parsing.JObjects
{
    public class FloatJTokenFormatter : IJTokenFormatter
    {
        public Dictionary<string, string> Format(JToken item, int depth)
        {
            if (item == null) return new Dictionary<string, string>() { { string.Empty, string.Empty } };

            return new Dictionary<string, string>()
            {
                { string.Empty, item.ToString() }
            };
        }

        public bool Handles(JTokenType t)
        {
            return t == JTokenType.Float;
        }
    }
}
