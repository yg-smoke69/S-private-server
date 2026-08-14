using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F33")]
public abstract class CsvDataIndexedReading : CSVBaseData
{
	[Token(Token = "0x17001C22")]
	public override bool UsingIndexedParseData
	{
		[Token(Token = "0x6019BA8")]
		[Address(RVA = "0x308A4A8", Offset = "0x308A4A8", VA = "0x308A4A8", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6019BA6")]
	[Address(RVA = "0x308A420", Offset = "0x308A420", VA = "0x308A420")]
	protected CsvDataIndexedReading()
	{
	}

	[Token(Token = "0x6019BA7")]
	[Address(RVA = "0x308A4A4", Offset = "0x308A4A4", VA = "0x308A4A4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6019BA9")]
	[Address(RVA = "0x308A4B0", Offset = "0x308A4B0", VA = "0x308A4B0", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6019BAA")]
	[Address(RVA = "0x308A4B8", Offset = "0x308A4B8", VA = "0x308A4B8", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}
}
