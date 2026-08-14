using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000162")]
public class KeyActionSettingData : CSVBaseData
{
	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0xC")]
	public string KeyActionName;

	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x10")]
	public KeyCode DefaultKeyCode;

	[Token(Token = "0x40008F5")]
	[FieldOffset(Offset = "0x14")]
	public bool EnableModify;

	[Token(Token = "0x40008F6")]
	[FieldOffset(Offset = "0x15")]
	public bool ShowKeyCodeOnHud;

	[Token(Token = "0x6000852")]
	[Address(RVA = "0x1EE7A2C", Offset = "0x1EE7A2C", VA = "0x1EE7A2C")]
	public KeyActionSettingData()
	{
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0x1EE7AB0", Offset = "0x1EE7AB0", VA = "0x1EE7AB0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0x1EE7B14", Offset = "0x1EE7B14", VA = "0x1EE7B14", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
