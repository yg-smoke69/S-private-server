using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000153")]
public class HyperBookHiddenPageData : CSVBaseData
{
	[Token(Token = "0x4000888")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CAwardID_003Ek__BackingField;

	[Token(Token = "0x4000889")]
	[FieldOffset(Offset = "0xC")]
	private string _003CMaskIcon_003Ek__BackingField;

	[Token(Token = "0x400088A")]
	[FieldOffset(Offset = "0x10")]
	private ResourceID _003CContentMaskVFX_003Ek__BackingField;

	[Token(Token = "0x1700012A")]
	public uint AwardID
	{
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x2C6F204", Offset = "0x2C6F204", VA = "0x2C6F204")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x2C6F20C", Offset = "0x2C6F20C", VA = "0x2C6F20C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700012B")]
	public string MaskIcon
	{
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x2C6F214", Offset = "0x2C6F214", VA = "0x2C6F214")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x2C6F21C", Offset = "0x2C6F21C", VA = "0x2C6F21C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700012C")]
	public ResourceID ContentMaskVFX
	{
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x2C6F224", Offset = "0x2C6F224", VA = "0x2C6F224")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x2C6F22C", Offset = "0x2C6F22C", VA = "0x2C6F22C")]
		private set
		{
		}
	}

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x2C6F180", Offset = "0x2C6F180", VA = "0x2C6F180")]
	public HyperBookHiddenPageData()
	{
	}

	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x2C6F234", Offset = "0x2C6F234", VA = "0x2C6F234", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x2C6F2B0", Offset = "0x2C6F2B0", VA = "0x2C6F2B0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
