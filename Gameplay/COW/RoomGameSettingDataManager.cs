using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E31")]
public class RoomGameSettingDataManager : SingletonModule<RoomGameSettingDataManager>
{
	[Token(Token = "0x4011AAE")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, List<uint>> m_ModeSettings;

	[Token(Token = "0x4011AAF")]
	[FieldOffset(Offset = "0x10")]
	private List<uint> m_CommonSettingList;

	[Token(Token = "0x4011AB0")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<RoomGameSettingData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6013527")]
	[Address(RVA = "0x2415C0C", Offset = "0x2415C0C", VA = "0x2415C0C")]
	public RoomGameSettingDataManager()
	{
	}

	[Token(Token = "0x6013528")]
	[Address(RVA = "0x2415C9C", Offset = "0x2415C9C", VA = "0x2415C9C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013529")]
	[Address(RVA = "0x2416168", Offset = "0x2416168", VA = "0x2416168", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601352A")]
	[Address(RVA = "0x24161BC", Offset = "0x24161BC", VA = "0x24161BC")]
	public List<uint> GetGameSettingListByGameMode(uint gameMode)
	{
		return null;
	}

	[Token(Token = "0x601352B")]
	[Address(RVA = "0x24162B0", Offset = "0x24162B0", VA = "0x24162B0")]
	private static bool _003COnInit_003Em__0(RoomGameSettingData d)
	{
		return default(bool);
	}
}
