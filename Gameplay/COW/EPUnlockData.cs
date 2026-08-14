using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2000125")]
internal class EPUnlockData : CsvDataIndexedReading
{
	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x8")]
	public uint EPEventID;

	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0xC")]
	public uint UnlockID;

	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x10")]
	public int RequireItemNum;

	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x14")]
	public uint FPAwardID;

	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x18")]
	public uint FPAwardNum;

	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x1C")]
	public uint FPAwardTime;

	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x20")]
	public uint EPAwardID;

	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x24")]
	public uint EPAwardNum;

	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x28")]
	public uint DisplayOrder;

	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x2C")]
	public uint EPAwardTime;

	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x30")]
	public EInventory.AwardType FPAwardType;

	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x34")]
	public EInventory.AwardType EPAwardType;

	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<EPUnlockData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6000726")]
	[Address(RVA = "0x251B268", Offset = "0x251B268", VA = "0x251B268")]
	public EPUnlockData()
	{
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x251B270", Offset = "0x251B270", VA = "0x251B270", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x251B2D4", Offset = "0x251B2D4", VA = "0x251B2D4", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x251B9EC", Offset = "0x251B9EC", VA = "0x251B9EC", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0x251C750", Offset = "0x251C750", VA = "0x251C750")]
	public static void GetUnlockDataListByEventID(uint eventID, out List<EPUnlockData> UnlockList)
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0x251CA70", Offset = "0x251CA70", VA = "0x251CA70")]
	public bool IsBigAward()
	{
		return default(bool);
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0x251CAE0", Offset = "0x251CAE0", VA = "0x251CAE0")]
	public bool IsExclusiveAward()
	{
		return default(bool);
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0x251CB50", Offset = "0x251CB50", VA = "0x251CB50")]
	private static int _003CGetUnlockDataListByEventID_003Em__0(EPUnlockData a, EPUnlockData b)
	{
		return default(int);
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0x251CB98", Offset = "0x251CB98", VA = "0x251CB98")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0x251CBA0", Offset = "0x251CBA0", VA = "0x251CBA0")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
