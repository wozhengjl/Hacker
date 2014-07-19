using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Factory
/// </summary>
public class Factory<T>
{
    private Factory<T> instance;

	public Factory()
	{
	}

    public virtual T BuildModel(Dictionary<string,string> options)
    {
        T model = (T)Activator.CreateInstance(typeof(T));

        foreach (var key in options.Keys)
        {
            if (string.Compare(key, "Identity") != 0)
            {
                typeof(T).GetProperty(key).SetValue(model, Convert.ChangeType(options[key], typeof(T).GetProperty(key).PropertyType));
            }
        }

        return model;
    }
}