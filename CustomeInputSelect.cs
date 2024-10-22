﻿using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Validation.Component
{
    public class CustomeInputSelect<TValue>:InputSelect<TValue>
    {

        protected override bool TryParseValueFromString(string value, out TValue result, out string validationErrorMessage)
        {
            if(typeof(TValue)==typeof(int))
            {
                if(int.TryParse(value, out var resultInt))
                {
                    result = (TValue)(Object)resultInt;
                    validationErrorMessage = null;
                    return true;
                }
                else
                {
                    result = default;
                    validationErrorMessage = $"The selected value {value} is not a valid number.";
                    return false;
                }
            }
            else
            {
                return base.TryParseValueFromString(value, out result, out validationErrorMessage);
            }
        }

    }
}
