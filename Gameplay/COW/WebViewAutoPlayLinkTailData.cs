using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200026A")]
public class WebViewAutoPlayLinkTailData : CSVBaseData
{
	[Token(Token = "0x4000EB7")]
	[FieldOffset(Offset = "0x8")]
	public string URL;

	[Token(Token = "0x4000EB8")]
	[FieldOffset(Offset = "0xC")]
	public bool EnabelAutoPlay;

	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x21B8718", Offset = "0x21B8718", VA = "0x21B8718")]
	public WebViewAutoPlayLinkTailData()
	{
	}

	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x21B87E4", Offset = "0x21B87E4", VA = "0x21B87E4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x21B883C", Offset = "0x21B883C", VA = "0x21B883C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
