using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2000261")]
public class VibrateSDKData : CSVBaseData
{
	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0xC")]
	public string effect_name;

	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0x10")]
	public int priority;

	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0x14")]
	public int seting_type;

	[Token(Token = "0x4000E7A")]
	[FieldOffset(Offset = "0x18")]
	public bool isSettingOpen;

	[Token(Token = "0x4000E7B")]
	[FieldOffset(Offset = "0x1C")]
	public float duration;

	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0x20")]
	public string vibrateContent;

	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0x24")]
	public int setting_type_Group;

	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0x28")]
	public int amplitude;

	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x2A6A100", Offset = "0x2A6A100", VA = "0x2A6A100")]
	public VibrateSDKData()
	{
	}

	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0x2A6A18C", Offset = "0x2A6A18C", VA = "0x2A6A18C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0x2A6A198", Offset = "0x2A6A198", VA = "0x2A6A198", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
