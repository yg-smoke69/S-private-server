using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E80")]
public class WorkShopSkillEditListData : CSVBaseData
{
	[Token(Token = "0x4011BE1")]
	[FieldOffset(Offset = "0x8")]
	private string _003CSkillType_003Ek__BackingField;

	[Token(Token = "0x4011BE2")]
	[FieldOffset(Offset = "0xC")]
	private bool _003CEnabled_003Ek__BackingField;

	[Token(Token = "0x17001425")]
	public string SkillType
	{
		[Token(Token = "0x60136B8")]
		[Address(RVA = "0x21BD9A4", Offset = "0x21BD9A4", VA = "0x21BD9A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60136B9")]
		[Address(RVA = "0x21BD9AC", Offset = "0x21BD9AC", VA = "0x21BD9AC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001426")]
	public bool Enabled
	{
		[Token(Token = "0x60136BA")]
		[Address(RVA = "0x21BD9B4", Offset = "0x21BD9B4", VA = "0x21BD9B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60136BB")]
		[Address(RVA = "0x21BD9BC", Offset = "0x21BD9BC", VA = "0x21BD9BC")]
		private set
		{
		}
	}

	[Token(Token = "0x60136B7")]
	[Address(RVA = "0x21BD920", Offset = "0x21BD920", VA = "0x21BD920")]
	public WorkShopSkillEditListData()
	{
	}

	[Token(Token = "0x60136BC")]
	[Address(RVA = "0x21BD9C4", Offset = "0x21BD9C4", VA = "0x21BD9C4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60136BD")]
	[Address(RVA = "0x21BDA1C", Offset = "0x21BDA1C", VA = "0x21BDA1C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
