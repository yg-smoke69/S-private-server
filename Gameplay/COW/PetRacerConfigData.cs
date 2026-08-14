using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001F8")]
internal class PetRacerConfigData : CSVBaseData
{
	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CPetID_003Ek__BackingField;

	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0xC")]
	private string _003CPetName_003Ek__BackingField;

	[Token(Token = "0x4000BC0")]
	[FieldOffset(Offset = "0x10")]
	private ResourceID _003CPetIngamePrafab_003Ek__BackingField;

	[Token(Token = "0x4000BC1")]
	[FieldOffset(Offset = "0x14")]
	private string _003CIdleAnim_003Ek__BackingField;

	[Token(Token = "0x4000BC2")]
	[FieldOffset(Offset = "0x18")]
	private string _003CRunAnim_003Ek__BackingField;

	[Token(Token = "0x4000BC3")]
	[FieldOffset(Offset = "0x1C")]
	private string _003CFalldownAnim_003Ek__BackingField;

	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0x20")]
	private string _003CIdleSprite_003Ek__BackingField;

	[Token(Token = "0x4000BC5")]
	[FieldOffset(Offset = "0x24")]
	private string _003CRunSprite_003Ek__BackingField;

	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0x28")]
	private ResourceID _003CIndicatorPrefab_003Ek__BackingField;

	[Token(Token = "0x17000155")]
	public uint PetID
	{
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x1BFDFBC", Offset = "0x1BFDFBC", VA = "0x1BFDFBC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x1BFDFC4", Offset = "0x1BFDFC4", VA = "0x1BFDFC4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000156")]
	public string PetName
	{
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1BFDFCC", Offset = "0x1BFDFCC", VA = "0x1BFDFCC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x1BFDFD4", Offset = "0x1BFDFD4", VA = "0x1BFDFD4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000157")]
	public ResourceID PetIngamePrafab
	{
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x1BFDFDC", Offset = "0x1BFDFDC", VA = "0x1BFDFDC")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1BFDFE4", Offset = "0x1BFDFE4", VA = "0x1BFDFE4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000158")]
	public string IdleAnim
	{
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1BFDFEC", Offset = "0x1BFDFEC", VA = "0x1BFDFEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x1BFDFF4", Offset = "0x1BFDFF4", VA = "0x1BFDFF4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000159")]
	public string RunAnim
	{
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1BFDFFC", Offset = "0x1BFDFFC", VA = "0x1BFDFFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x1BFE004", Offset = "0x1BFE004", VA = "0x1BFE004")]
		private set
		{
		}
	}

	[Token(Token = "0x1700015A")]
	public string FalldownAnim
	{
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1BFE00C", Offset = "0x1BFE00C", VA = "0x1BFE00C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x1BFE014", Offset = "0x1BFE014", VA = "0x1BFE014")]
		private set
		{
		}
	}

	[Token(Token = "0x1700015B")]
	public string IdleSprite
	{
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x1BFE01C", Offset = "0x1BFE01C", VA = "0x1BFE01C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x1BFE024", Offset = "0x1BFE024", VA = "0x1BFE024")]
		private set
		{
		}
	}

	[Token(Token = "0x1700015C")]
	public string RunSprite
	{
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1BFE02C", Offset = "0x1BFE02C", VA = "0x1BFE02C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1BFE034", Offset = "0x1BFE034", VA = "0x1BFE034")]
		private set
		{
		}
	}

	[Token(Token = "0x1700015D")]
	public ResourceID IndicatorPrefab
	{
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1BFE03C", Offset = "0x1BFE03C", VA = "0x1BFE03C")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x1BFE044", Offset = "0x1BFE044", VA = "0x1BFE044")]
		private set
		{
		}
	}

	[Token(Token = "0x6000A31")]
	[Address(RVA = "0x1BFDF38", Offset = "0x1BFDF38", VA = "0x1BFDF38")]
	public PetRacerConfigData()
	{
	}

	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x1BFE04C", Offset = "0x1BFE04C", VA = "0x1BFE04C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x1BFE0C8", Offset = "0x1BFE0C8", VA = "0x1BFE0C8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
