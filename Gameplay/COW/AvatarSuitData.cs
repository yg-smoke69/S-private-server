using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000B2")]
public class AvatarSuitData : CSVBaseData
{
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CSuitID_003Ek__BackingField;

	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0xC")]
	private string _003CSuitName_003Ek__BackingField;

	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x10")]
	private string _003CSuitDesc_003Ek__BackingField;

	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x14")]
	private ResourceID _003CSuitIcon_003Ek__BackingField;

	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x18")]
	private uint _003CHeadSlotItemID_003Ek__BackingField;

	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003CChestSlotItemID_003Ek__BackingField;

	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x20")]
	private uint _003CLegsSlotItemID_003Ek__BackingField;

	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x24")]
	private uint _003CFeetSlotItemID_003Ek__BackingField;

	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x28")]
	private uint _003CHeadAdditiveItemID_003Ek__BackingField;

	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003CAvatarID_003Ek__BackingField;

	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x30")]
	private bool _003CIsDefault_003Ek__BackingField;

	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x34")]
	private ResourceID _003CSuitAnimation_003Ek__BackingField;

	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x38")]
	private uint _003CSkillID_003Ek__BackingField;

	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x3C")]
	private ResourceID _003CSuitAnimationEffect_003Ek__BackingField;

	[Token(Token = "0x170000EF")]
	public uint SuitID
	{
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x234EB94", Offset = "0x234EB94", VA = "0x234EB94")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2360A9C", Offset = "0x2360A9C", VA = "0x2360A9C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F0")]
	public string SuitName
	{
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2360AA4", Offset = "0x2360AA4", VA = "0x2360AA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2360AAC", Offset = "0x2360AAC", VA = "0x2360AAC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F1")]
	public string SuitDesc
	{
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2360AB4", Offset = "0x2360AB4", VA = "0x2360AB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2360ABC", Offset = "0x2360ABC", VA = "0x2360ABC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F2")]
	public ResourceID SuitIcon
	{
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2360AC4", Offset = "0x2360AC4", VA = "0x2360AC4")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2360ACC", Offset = "0x2360ACC", VA = "0x2360ACC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F3")]
	public uint HeadSlotItemID
	{
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2360AD4", Offset = "0x2360AD4", VA = "0x2360AD4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2360ADC", Offset = "0x2360ADC", VA = "0x2360ADC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F4")]
	public uint ChestSlotItemID
	{
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2360AE4", Offset = "0x2360AE4", VA = "0x2360AE4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2360AEC", Offset = "0x2360AEC", VA = "0x2360AEC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F5")]
	public uint LegsSlotItemID
	{
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2360AF4", Offset = "0x2360AF4", VA = "0x2360AF4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2360AFC", Offset = "0x2360AFC", VA = "0x2360AFC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F6")]
	public uint FeetSlotItemID
	{
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2360B04", Offset = "0x2360B04", VA = "0x2360B04")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2360B0C", Offset = "0x2360B0C", VA = "0x2360B0C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F7")]
	public uint HeadAdditiveItemID
	{
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2360B14", Offset = "0x2360B14", VA = "0x2360B14")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2360B1C", Offset = "0x2360B1C", VA = "0x2360B1C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F8")]
	public uint AvatarID
	{
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x234EB84", Offset = "0x234EB84", VA = "0x234EB84")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2360B24", Offset = "0x2360B24", VA = "0x2360B24")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F9")]
	public bool IsDefault
	{
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x234EB9C", Offset = "0x234EB9C", VA = "0x234EB9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2360B2C", Offset = "0x2360B2C", VA = "0x2360B2C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000FA")]
	public ResourceID SuitAnimation
	{
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2360BB0", Offset = "0x2360BB0", VA = "0x2360BB0")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2360BB8", Offset = "0x2360BB8", VA = "0x2360BB8")]
		private set
		{
		}
	}

	[Token(Token = "0x170000FB")]
	public uint SkillID
	{
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2360BC0", Offset = "0x2360BC0", VA = "0x2360BC0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2360BC8", Offset = "0x2360BC8", VA = "0x2360BC8")]
		private set
		{
		}
	}

	[Token(Token = "0x170000FC")]
	public ResourceID SuitAnimationEffect
	{
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2360BD0", Offset = "0x2360BD0", VA = "0x2360BD0")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x2360BD8", Offset = "0x2360BD8", VA = "0x2360BD8")]
		private set
		{
		}
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x2360A18", Offset = "0x2360A18", VA = "0x2360A18")]
	public AvatarSuitData()
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x2360B34", Offset = "0x2360B34", VA = "0x2360B34", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x2360BE0", Offset = "0x2360BE0", VA = "0x2360BE0")]
	public uint[] GetClothesIDs()
	{
		return null;
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x2360D58", Offset = "0x2360D58", VA = "0x2360D58", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
