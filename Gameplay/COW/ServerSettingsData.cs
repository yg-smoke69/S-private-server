using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200022A")]
public class ServerSettingsData : CSVBaseData
{
	[Token(Token = "0x4000D44")]
	public const string SBT_SERVER = "1";

	[Token(Token = "0x4000D45")]
	public const string LIVE_SERVER = "2";

	[Token(Token = "0x4000D46")]
	public const string IOS_SERVER = "3";

	[Token(Token = "0x4000D47")]
	public const string RCT_SERVER = "4";

	[Token(Token = "0x4000D48")]
	public const string PREVIEW_SERVER = "5";

	[Token(Token = "0x4000D49")]
	public const string BETA_SERVER = "6";

	[Token(Token = "0x4000D4A")]
	public const string EXP_SERVER = "7";

	[Token(Token = "0x4000D4B")]
	public const string ART_SERVER = "8";

	[Token(Token = "0x4000D4C")]
	public const string DESIGN_SERVER = "9";

	[Token(Token = "0x4000D4D")]
	public const string ACT_SERVER = "10";

	[Token(Token = "0x4000D4E")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000D4F")]
	[FieldOffset(Offset = "0xC")]
	public string ServerAdd;

	[Token(Token = "0x4000D50")]
	[FieldOffset(Offset = "0x10")]
	public string BillboardServerAdd;

	[Token(Token = "0x4000D51")]
	[FieldOffset(Offset = "0x14")]
	public bool IsIOSReview;

	[Token(Token = "0x4000D52")]
	[FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x4000D53")]
	[FieldOffset(Offset = "0x1C")]
	public bool Production;

	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x20DF2D8", Offset = "0x20DF2D8", VA = "0x20DF2D8")]
	public ServerSettingsData()
	{
	}

	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x20DF35C", Offset = "0x20DF35C", VA = "0x20DF35C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x20DF3C0", Offset = "0x20DF3C0", VA = "0x20DF3C0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
