using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BA4")]
public class LibraryData
{
	[Token(Token = "0x4006203")]
	[FieldOffset(Offset = "0x8")]
	private EBlockCategory _003CBlockCategory_003Ek__BackingField;

	[Token(Token = "0x4006204")]
	[FieldOffset(Offset = "0xC")]
	public readonly List<BlockData> BlockDataList;

	[Token(Token = "0x4006205")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<BlockData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000713")]
	public EBlockCategory BlockCategory
	{
		[Token(Token = "0x6005837")]
		[Address(RVA = "0x2F4DCF8", Offset = "0x2F4DCF8", VA = "0x2F4DCF8")]
		get
		{
			return default(EBlockCategory);
		}
		[Token(Token = "0x6005838")]
		[Address(RVA = "0x2F4DCF0", Offset = "0x2F4DCF0", VA = "0x2F4DCF0")]
		private set
		{
		}
	}

	[Token(Token = "0x6005836")]
	[Address(RVA = "0x2F4DC5C", Offset = "0x2F4DC5C", VA = "0x2F4DC5C")]
	public LibraryData(EBlockCategory blockCategory)
	{
	}

	[Token(Token = "0x6005839")]
	[Address(RVA = "0x2F4DD00", Offset = "0x2F4DD00", VA = "0x2F4DD00")]
	public void AddItem(BlockData blockData)
	{
	}

	[Token(Token = "0x600583A")]
	[Address(RVA = "0x2F4DDCC", Offset = "0x2F4DDCC", VA = "0x2F4DDCC")]
	public void Sort()
	{
	}

	[Token(Token = "0x600583B")]
	[Address(RVA = "0x2F4DF18", Offset = "0x2F4DF18", VA = "0x2F4DF18")]
	private static int _003CSort_003Em__0(BlockData a, BlockData b)
	{
		return default(int);
	}
}
