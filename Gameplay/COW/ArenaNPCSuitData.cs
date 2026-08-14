using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200009D")]
public class ArenaNPCSuitData : CSVBaseData
{
	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CID_003Ek__BackingField;

	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CHeadSlotItemID_003Ek__BackingField;

	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x10")]
	private uint _003CChestSlotItemID_003Ek__BackingField;

	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x14")]
	private uint _003CLegsSlotItemID_003Ek__BackingField;

	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x18")]
	private uint _003CFeetSlotItemID_003Ek__BackingField;

	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003CAvatarID_003Ek__BackingField;

	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x20")]
	private ResourceID _003CAnimatorID_003Ek__BackingField;

	[Token(Token = "0x17000099")]
	public uint ID
	{
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x14CC8CC", Offset = "0x14CC8CC", VA = "0x14CC8CC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x14CC8D4", Offset = "0x14CC8D4", VA = "0x14CC8D4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009A")]
	public uint HeadSlotItemID
	{
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x14CC8DC", Offset = "0x14CC8DC", VA = "0x14CC8DC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x14CC8E4", Offset = "0x14CC8E4", VA = "0x14CC8E4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009B")]
	public uint ChestSlotItemID
	{
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x14CC8EC", Offset = "0x14CC8EC", VA = "0x14CC8EC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x14CC8F4", Offset = "0x14CC8F4", VA = "0x14CC8F4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009C")]
	public uint LegsSlotItemID
	{
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x14CC8FC", Offset = "0x14CC8FC", VA = "0x14CC8FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x14CC904", Offset = "0x14CC904", VA = "0x14CC904")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009D")]
	public uint FeetSlotItemID
	{
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x14CC90C", Offset = "0x14CC90C", VA = "0x14CC90C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x14CC914", Offset = "0x14CC914", VA = "0x14CC914")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009E")]
	public uint AvatarID
	{
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x14CC91C", Offset = "0x14CC91C", VA = "0x14CC91C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x14CC924", Offset = "0x14CC924", VA = "0x14CC924")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009F")]
	public ResourceID AnimatorID
	{
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x14CC92C", Offset = "0x14CC92C", VA = "0x14CC92C")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x14CC934", Offset = "0x14CC934", VA = "0x14CC934")]
		private set
		{
		}
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x14CC848", Offset = "0x14CC848", VA = "0x14CC848")]
	public ArenaNPCSuitData()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x14CC93C", Offset = "0x14CC93C", VA = "0x14CC93C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x14CC9B8", Offset = "0x14CC9B8", VA = "0x14CC9B8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x14CCDE0", Offset = "0x14CCDE0", VA = "0x14CCDE0")]
	public static List<ArenaNPCSuitData> GetArenaNPCSuit()
	{
		return null;
	}
}
