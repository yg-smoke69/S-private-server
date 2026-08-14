using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CE0")]
public sealed class UIVariableTable : MonoBehaviour
{
	[Token(Token = "0x4006851")]
	[FieldOffset(Offset = "0xC")]
	private UIVariable[] variables;

	[Token(Token = "0x4006852")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, UIVariable> m_varMap;

	[Token(Token = "0x4006853")]
	[FieldOffset(Offset = "0x14")]
	private UIMapVariableTable mapVarTable;

	[Token(Token = "0x4006854")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<UIVariable> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000820")]
	public UIMapVariableTable MapVarTable
	{
		[Token(Token = "0x60061B2")]
		[Address(RVA = "0x31693B8", Offset = "0x31693B8", VA = "0x31693B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000821")]
	public UIVariable[] Variables
	{
		[Token(Token = "0x60061B3")]
		[Address(RVA = "0x316946C", Offset = "0x316946C", VA = "0x316946C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60061B1")]
	[Address(RVA = "0x31693B0", Offset = "0x31693B0", VA = "0x31693B0")]
	public UIVariableTable()
	{
	}

	[Token(Token = "0x60061B4")]
	[Address(RVA = "0x3169474", Offset = "0x3169474", VA = "0x3169474")]
	private Dictionary<string, UIVariable> GetVariableMap()
	{
		return null;
	}

	[Token(Token = "0x60061B5")]
	[Address(RVA = "0x315E02C", Offset = "0x315E02C", VA = "0x315E02C")]
	public UIVariable FindVariable(string name)
	{
		return null;
	}

	[Token(Token = "0x60061B6")]
	[Address(RVA = "0x3169790", Offset = "0x3169790", VA = "0x3169790")]
	public void AddDefaultVariable()
	{
	}

	[Token(Token = "0x60061B7")]
	[Address(RVA = "0x31699D0", Offset = "0x31699D0", VA = "0x31699D0")]
	public string[] GetVariableNames()
	{
		return null;
	}

	[Token(Token = "0x60061B8")]
	[Address(RVA = "0x3169C00", Offset = "0x3169C00", VA = "0x3169C00")]
	public string[] GetOriginalVariableNames([Optional] List<UIVariableType> excludeTypes)
	{
		return null;
	}

	[Token(Token = "0x60061B9")]
	[Address(RVA = "0x3169E78", Offset = "0x3169E78", VA = "0x3169E78")]
	public void Sort()
	{
	}

	[Token(Token = "0x60061BA")]
	[Address(RVA = "0x3169F68", Offset = "0x3169F68", VA = "0x3169F68")]
	public void InitializeBinds()
	{
	}

	[Token(Token = "0x60061BB")]
	[Address(RVA = "0x315AC84", Offset = "0x315AC84", VA = "0x315AC84")]
	public UIVariable GetVariable(int index)
	{
		return null;
	}

	[Token(Token = "0x60061BC")]
	[Address(RVA = "0x3169F80", Offset = "0x3169F80", VA = "0x3169F80")]
	private static void InitVariableMap(Transform trans)
	{
	}

	[Token(Token = "0x60061BD")]
	[Address(RVA = "0x316A340", Offset = "0x316A340", VA = "0x316A340")]
	private static void DeepInitVariableBind(Transform trans)
	{
	}

	[Token(Token = "0x60061BE")]
	[Address(RVA = "0x316A770", Offset = "0x316A770", VA = "0x316A770")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60061BF")]
	[Address(RVA = "0x315CA1C", Offset = "0x315CA1C", VA = "0x315CA1C")]
	public void ResetVarMap()
	{
	}

	[Token(Token = "0x60061C0")]
	[Address(RVA = "0x316A7F4", Offset = "0x316A7F4", VA = "0x316A7F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60061C1")]
	[Address(RVA = "0x316A8CC", Offset = "0x316A8CC", VA = "0x316A8CC")]
	private static int _003CSort_003Em__0(UIVariable P_0, UIVariable P_1)
	{
		return default(int);
	}
}
