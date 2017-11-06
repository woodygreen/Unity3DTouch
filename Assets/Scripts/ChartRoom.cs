using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartRoom 
{
	static ChartRoom _Instance = null;
	static string _ChartText = null;

	public static ChartRoom GetInstance ()
	{
		if (null == _Instance) 
		{
			_Instance = new ChartRoom ();
		}
		return _Instance;
	}

	ChartRoom()
	{
		_ChartText = "";

		return;
	}

	public string GetChartText()
	{
		return _ChartText;
	}

	public void AppendChartText(string chartText)
	{
		_ChartText = _ChartText + "\n" + chartText;

		return;
	}

	public void ClearChartText()
	{
		_ChartText = "";

		return;
	}
}
