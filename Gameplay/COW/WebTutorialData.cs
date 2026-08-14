using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000269")]
public class WebTutorialData : CsvDataIndexedReading
{
	[Token(Token = "0x4000EB1")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x4000EB2")]
	[FieldOffset(Offset = "0xC")]
	public string WebLink;

	[Token(Token = "0x4000EB3")]
	[FieldOffset(Offset = "0x10")]
	public int Type;

	[Token(Token = "0x4000EB4")]
	[FieldOffset(Offset = "0x14")]
	public int SubType;

	[Token(Token = "0x4000EB5")]
	[FieldOffset(Offset = "0x18")]
	public int MatchType;

	[Token(Token = "0x4000EB6")]
	[FieldOffset(Offset = "0x1C")]
	public int ShowInNewVersion;

	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x21ABCF4", Offset = "0x21ABCF4", VA = "0x21ABCF4")]
	public WebTutorialData()
	{
	}

	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x21ABCFC", Offset = "0x21ABCFC", VA = "0x21ABCFC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x21ABDD4", Offset = "0x21ABDD4", VA = "0x21ABDD4", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x21AC120", Offset = "0x21AC120", VA = "0x21AC120", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x21AC6C0", Offset = "0x21AC6C0", VA = "0x21AC6C0")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0x21AC6C8", Offset = "0x21AC6C8", VA = "0x21AC6C8")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
