using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000097")]
public class AgeVerifiedData : CsvDataIndexedReading
{
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x8")]
	public string Country;

	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0xC")]
	public uint Platform;

	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x10")]
	public uint Age;

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x14C2A98", Offset = "0x14C2A98", VA = "0x14C2A98")]
	public AgeVerifiedData()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x14C2AA0", Offset = "0x14C2AA0", VA = "0x14C2AA0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x14C2AF8", Offset = "0x14C2AF8", VA = "0x14C2AF8", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x14C2D00", Offset = "0x14C2D00", VA = "0x14C2D00", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x14C3038", Offset = "0x14C3038", VA = "0x14C3038")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x14C3040", Offset = "0x14C3040", VA = "0x14C3040")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
