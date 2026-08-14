using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200009E")]
public class ArenaShowCaseData : CSVBaseData
{
	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CID_003Ek__BackingField;

	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0xC")]
	private ResourceID _003CItemPrefabID_003Ek__BackingField;

	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x10")]
	private bool _003CRotateBottom_003Ek__BackingField;

	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x11")]
	private bool _003CRotateItem_003Ek__BackingField;

	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x12")]
	private bool _003CEffectOn_003Ek__BackingField;

	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x14")]
	private string _003CIntroTitle_003Ek__BackingField;

	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x18")]
	private string _003CIntroTxt_003Ek__BackingField;

	[Token(Token = "0x170000A0")]
	public uint ID
	{
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x14CDBAC", Offset = "0x14CDBAC", VA = "0x14CDBAC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x14CDBB4", Offset = "0x14CDBB4", VA = "0x14CDBB4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000A1")]
	public ResourceID ItemPrefabID
	{
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x14CDBBC", Offset = "0x14CDBBC", VA = "0x14CDBBC")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x14CDBC4", Offset = "0x14CDBC4", VA = "0x14CDBC4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000A2")]
	public bool RotateBottom
	{
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x14CDBCC", Offset = "0x14CDBCC", VA = "0x14CDBCC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x14CDBD4", Offset = "0x14CDBD4", VA = "0x14CDBD4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000A3")]
	public bool RotateItem
	{
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x14CDBDC", Offset = "0x14CDBDC", VA = "0x14CDBDC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x14CDBE4", Offset = "0x14CDBE4", VA = "0x14CDBE4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000A4")]
	public bool EffectOn
	{
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x14CDBEC", Offset = "0x14CDBEC", VA = "0x14CDBEC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x14CDBF4", Offset = "0x14CDBF4", VA = "0x14CDBF4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000A5")]
	public string IntroTitle
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x14CDBFC", Offset = "0x14CDBFC", VA = "0x14CDBFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x14CDC04", Offset = "0x14CDC04", VA = "0x14CDC04")]
		private set
		{
		}
	}

	[Token(Token = "0x170000A6")]
	public string IntroTxt
	{
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x14CDC0C", Offset = "0x14CDC0C", VA = "0x14CDC0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x14CDC14", Offset = "0x14CDC14", VA = "0x14CDC14")]
		private set
		{
		}
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x14CDB28", Offset = "0x14CDB28", VA = "0x14CDB28")]
	public ArenaShowCaseData()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x14CDC1C", Offset = "0x14CDC1C", VA = "0x14CDC1C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x14CDC98", Offset = "0x14CDC98", VA = "0x14CDC98", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x14CE1D8", Offset = "0x14CE1D8", VA = "0x14CE1D8")]
	public static ArenaShowCaseData GetArenaShowCaseData(uint dataID)
	{
		return null;
	}
}
