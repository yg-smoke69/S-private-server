using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001E9")]
public class PeriodicRankData : CSRankData
{
	[Token(Token = "0x4000B74")]
	[FieldOffset(Offset = "0x40")]
	public uint GameMode;

	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x2DDF950", Offset = "0x2DDF950", VA = "0x2DDF950")]
	public PeriodicRankData()
	{
	}

	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x2DDF958", Offset = "0x2DDF958", VA = "0x2DDF958", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x2DDF9BC", Offset = "0x2DDF9BC", VA = "0x2DDF9BC")]
	public static string GetDataKey(uint gameMode, int rank)
	{
		return null;
	}

	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x2DDFAD8", Offset = "0x2DDFAD8", VA = "0x2DDFAD8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x2DDFC20", Offset = "0x2DDFC20", VA = "0x2DDFC20")]
	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x2DDFC28", Offset = "0x2DDFC28", VA = "0x2DDFC28")]
	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
