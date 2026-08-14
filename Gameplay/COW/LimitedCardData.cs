using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000172")]
public class LimitedCardData : CsvDataIndexedReading, _Attribute
{
	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x4000952")]
	[FieldOffset(Offset = "0xC")]
	public uint CardType;

	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x10")]
	public uint EffectedId;

	[Token(Token = "0x4000954")]
	[FieldOffset(Offset = "0x14")]
	public uint ExpireMins;

	[Token(Token = "0x4000955")]
	[FieldOffset(Offset = "0x18")]
	public uint LeftUseTimes;

	[Token(Token = "0x4000956")]
	[FieldOffset(Offset = "0x1C")]
	public uint DisCount;

	[Token(Token = "0x4000957")]
	[FieldOffset(Offset = "0x20")]
	public uint TakeGiftCount;

	[Token(Token = "0x600087D")]
	[Address(RVA = "0xEC1C38", Offset = "0xEC1C38", VA = "0xEC1C38")]
	public LimitedCardData()
	{
	}

	[Token(Token = "0x600087E")]
	[Address(RVA = "0xEC1C40", Offset = "0xEC1C40", VA = "0xEC1C40", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x600087F")]
	[Address(RVA = "0xEC1C98", Offset = "0xEC1C98", VA = "0xEC1C98", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000880")]
	[Address(RVA = "0xEC1CFC", Offset = "0xEC1CFC", VA = "0xEC1CFC", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000881")]
	[Address(RVA = "0xEC20B4", Offset = "0xEC20B4", VA = "0xEC20B4", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x6000882")]
	[Address(RVA = "0xEC2714", Offset = "0xEC2714", VA = "0xEC2714")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000883")]
	[Address(RVA = "0xEC271C", Offset = "0xEC271C", VA = "0xEC271C")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
