using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000F9")]
public class ControlModePlayerBuffAvatarData : CSVBaseData
{
	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x8")]
	private bool m_IsFemale;

	[Token(Token = "0x4000655")]
	[FieldOffset(Offset = "0xC")]
	private uint[] _003CClothIDs_003Ek__BackingField;

	[Token(Token = "0x17000115")]
	public uint[] ClothIDs
	{
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1C8011C", Offset = "0x1C8011C", VA = "0x1C8011C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1C80124", Offset = "0x1C80124", VA = "0x1C80124")]
		set
		{
		}
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x1C80098", Offset = "0x1C80098", VA = "0x1C80098")]
	public ControlModePlayerBuffAvatarData()
	{
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x1C8012C", Offset = "0x1C8012C", VA = "0x1C8012C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x1C80190", Offset = "0x1C80190", VA = "0x1C80190", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
