using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000262")]
public class VibrateSettingData : CSVBaseData
{
	[Token(Token = "0x4000E7F")]
	public const string MATCHSUCCESS = "1";

	[Token(Token = "0x4000E80")]
	public const string GROUPINVITE = "2";

	[Token(Token = "0x4000E81")]
	public const string PARACHUTING = "3";

	[Token(Token = "0x4000E82")]
	public const string KNOCKDOWNENEMY = "4";

	[Token(Token = "0x4000E83")]
	public const string STARTUPVEHICLE = "5";

	[Token(Token = "0x4000E84")]
	public const string VEHICLEHIT = "6";

	[Token(Token = "0x4000E85")]
	public const string HITED = "7";

	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0xC")]
	public uint[] vibrateInfo;

	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x10")]
	public bool isAsusOnly;

	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x21A0414", Offset = "0x21A0414", VA = "0x21A0414")]
	public VibrateSettingData()
	{
	}

	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0x21A0498", Offset = "0x21A0498", VA = "0x21A0498", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0x21A04FC", Offset = "0x21A04FC", VA = "0x21A04FC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
