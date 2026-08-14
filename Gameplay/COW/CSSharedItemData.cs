using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000109")]
public class CSSharedItemData : CsvDataIndexedReading, _Attribute
{
	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0xC")]
	public string description;

	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x10")]
	public uint iID;

	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID iconRes;

	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID bigIconRes;

	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x1C")]
	public byte itemType;

	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x1D")]
	public byte Rare;

	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x1E")]
	public bool isUnique;

	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0x1F")]
	public byte collectionType;

	[Token(Token = "0x17000116")]
	public byte subType
	{
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1826FC0", Offset = "0x1826FC0", VA = "0x1826FC0")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000117")]
	public string endTime
	{
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x182719C", Offset = "0x182719C", VA = "0x182719C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x1826EBC", Offset = "0x1826EBC", VA = "0x1826EBC")]
	public CSSharedItemData()
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x1826F68", Offset = "0x1826F68", VA = "0x1826F68", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x182737C", Offset = "0x182737C", VA = "0x182737C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x18273E0", Offset = "0x18273E0", VA = "0x18273E0", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x1827948", Offset = "0x1827948", VA = "0x1827948", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x182873C", Offset = "0x182873C", VA = "0x182873C")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x1828744", Offset = "0x1828744", VA = "0x1828744")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
