using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20000CA")]
public class BundleData : CsvDataIndexedReading
{
	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0xC")]
	public uint AwardID;

	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x10")]
	public uint AwardNum;

	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x14")]
	public uint AwardTime;

	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x18")]
	public EInventory.AwardType AwardType;

	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsPreview;

	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x20")]
	public uint PreviewAvatar;

	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x24")]
	public string ImageUrl;

	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x28")]
	public EInventory.AwardType ReturnType;

	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x2C")]
	public uint ReturnID;

	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x30")]
	public uint ReturnNum;

	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x34")]
	public uint NoForcedOpen;

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x1813AA4", Offset = "0x1813AA4", VA = "0x1813AA4")]
	public BundleData()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x1813AAC", Offset = "0x1813AAC", VA = "0x1813AAC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x1813B10", Offset = "0x1813B10", VA = "0x1813B10", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x18140E4", Offset = "0x18140E4", VA = "0x18140E4", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x1814B2C", Offset = "0x1814B2C", VA = "0x1814B2C")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x1814B34", Offset = "0x1814B34", VA = "0x1814B34")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
