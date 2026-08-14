using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DFF")]
public class NewPlayerMissionDataManager : SingletonModule<NewPlayerMissionDataManager>
{
	[Token(Token = "0x4011A08")]
	private const int NEW_PLAYER_EVENT_DAYS = 7;

	[Token(Token = "0x4011A09")]
	[FieldOffset(Offset = "0xC")]
	private List<NewPlayerSevenDaysData> missionTable;

	[Token(Token = "0x4011A0A")]
	[FieldOffset(Offset = "0x10")]
	private List<NewPlayerSevenDaysAwardData> awardTable;

	[Token(Token = "0x6013468")]
	[Address(RVA = "0x28B2570", Offset = "0x28B2570", VA = "0x28B2570")]
	public NewPlayerMissionDataManager()
	{
	}

	[Token(Token = "0x6013469")]
	[Address(RVA = "0x28B2670", Offset = "0x28B2670", VA = "0x28B2670", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601346A")]
	[Address(RVA = "0x28B275C", Offset = "0x28B275C", VA = "0x28B275C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601346B")]
	[Address(RVA = "0x28B2944", Offset = "0x28B2944", VA = "0x28B2944")]
	public int GetDayIndexById(uint id)
	{
		return default(int);
	}

	[Token(Token = "0x601346C")]
	[Address(RVA = "0x28B2BD0", Offset = "0x28B2BD0", VA = "0x28B2BD0")]
	public uint[] GetSubMissionsById(uint id)
	{
		return null;
	}

	[Token(Token = "0x601346D")]
	[Address(RVA = "0x28B2DCC", Offset = "0x28B2DCC", VA = "0x28B2DCC")]
	public NewPlayerSevenDaysAwardData GetMissionTodayById(uint id)
	{
		return null;
	}

	[Token(Token = "0x601346E")]
	[Address(RVA = "0x28B2FC4", Offset = "0x28B2FC4", VA = "0x28B2FC4")]
	public NewPlayerSevenDaysData GetMissionById(uint id)
	{
		return null;
	}
}
