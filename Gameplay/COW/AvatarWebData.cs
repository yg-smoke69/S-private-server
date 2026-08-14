using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DAB")]
public class AvatarWebData : CSVBaseData
{
	[Token(Token = "0x4011881")]
	[FieldOffset(Offset = "0x8")]
	public uint AvatarID;

	[Token(Token = "0x4011882")]
	[FieldOffset(Offset = "0xC")]
	public string WebLink;

	[Token(Token = "0x4011883")]
	private const string REGION_DEFAULT = "default";

	[Token(Token = "0x4011884")]
	private const string LANGUAGE_DEFAULT = "default";

	[Token(Token = "0x4011885")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<uint, Dictionary<string, Dictionary<string, AvatarWebData>>> _Data;

	[Token(Token = "0x4011886")]
	[FieldOffset(Offset = "0x10")]
	private string _003CRegion_003Ek__BackingField;

	[Token(Token = "0x4011887")]
	[FieldOffset(Offset = "0x14")]
	private string _003CLanguageAbbr_003Ek__BackingField;

	[Token(Token = "0x17001398")]
	public string Region
	{
		[Token(Token = "0x60131EE")]
		[Address(RVA = "0x236C1BC", Offset = "0x236C1BC", VA = "0x236C1BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60131EF")]
		[Address(RVA = "0x236C1C4", Offset = "0x236C1C4", VA = "0x236C1C4")]
		private set
		{
		}
	}

	[Token(Token = "0x17001399")]
	public string LanguageAbbr
	{
		[Token(Token = "0x60131F0")]
		[Address(RVA = "0x236C1CC", Offset = "0x236C1CC", VA = "0x236C1CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60131F1")]
		[Address(RVA = "0x236C1D4", Offset = "0x236C1D4", VA = "0x236C1D4")]
		private set
		{
		}
	}

	[Token(Token = "0x60131EC")]
	[Address(RVA = "0x236BEB4", Offset = "0x236BEB4", VA = "0x236BEB4")]
	public AvatarWebData()
	{
	}

	[Token(Token = "0x60131ED")]
	[Address(RVA = "0x236BF38", Offset = "0x236BF38", VA = "0x236BF38")]
	public static AvatarWebData Get(uint avatarid, string region, string language)
	{
		return null;
	}

	[Token(Token = "0x60131F2")]
	[Address(RVA = "0x236C1DC", Offset = "0x236C1DC", VA = "0x236C1DC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60131F3")]
	[Address(RVA = "0x236C2FC", Offset = "0x236C2FC", VA = "0x236C2FC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
