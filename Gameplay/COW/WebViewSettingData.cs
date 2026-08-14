using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200026B")]
public class WebViewSettingData : CSVBaseData
{
	[Token(Token = "0x4000EB9")]
	[FieldOffset(Offset = "0x8")]
	public string Url;

	[Token(Token = "0x4000EBA")]
	[FieldOffset(Offset = "0xC")]
	public bool UseWebPage;

	[Token(Token = "0x4000EBB")]
	[FieldOffset(Offset = "0xD")]
	public bool HardwareAcceleration;

	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x21B89D0", Offset = "0x21B89D0", VA = "0x21B89D0")]
	public WebViewSettingData()
	{
	}

	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x21B8A5C", Offset = "0x21B8A5C", VA = "0x21B8A5C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x21B8AB4", Offset = "0x21B8AB4", VA = "0x21B8AB4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
