using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class StringReference
{
    public bool UseConstant = true;
    public string ConstantValue;
    public StringVariable Variable;

    public StringReference() { }

    public StringReference(string value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    public string Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
    }
}