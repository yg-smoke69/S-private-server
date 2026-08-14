using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003340")]
public class TrainingMiniGameDataManager : SingletonModule<TrainingMiniGameDataManager>
{
	[Token(Token = "0x4013879")]
	[FieldOffset(Offset = "0xC")]
	private TrainingShootingGameData m_ShootingGameData;

	[Token(Token = "0x401387A")]
	[FieldOffset(Offset = "0x10")]
	private TrainingIceWallPracticeData m_IceWallPracticeData;

	[Token(Token = "0x401387B")]
	[FieldOffset(Offset = "0x14")]
	private TrainingGrenadePracticeData m_GrenadePracticeData;

	[Token(Token = "0x401387C")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, ServerMiniGameData> m_ServerMiniGameDataDict;

	[Token(Token = "0x401387D")]
	[FieldOffset(Offset = "0x1C")]
	private TrainingBillBoardData m_BillBoardData;

	[Token(Token = "0x6015C5B")]
	[Address(RVA = "0x232CBA0", Offset = "0x232CBA0", VA = "0x232CBA0")]
	public TrainingMiniGameDataManager()
	{
	}

	[Token(Token = "0x6015C5C")]
	[Address(RVA = "0x232CC64", Offset = "0x232CC64", VA = "0x232CC64", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6015C5D")]
	[Address(RVA = "0x232CD24", Offset = "0x232CD24", VA = "0x232CD24", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6015C5E")]
	[Address(RVA = "0x232D518", Offset = "0x232D518", VA = "0x232D518")]
	public TrainingBillBoardData GetBillBoardData()
	{
		return null;
	}

	[Token(Token = "0x6015C5F")]
	[Address(RVA = "0x232D570", Offset = "0x232D570", VA = "0x232D570")]
	public TrainingShootingGameData GetShootingGameData()
	{
		return null;
	}

	[Token(Token = "0x6015C60")]
	[Address(RVA = "0x232D5C8", Offset = "0x232D5C8", VA = "0x232D5C8")]
	public TrainingIceWallPracticeData GetIceWallPracticeData()
	{
		return null;
	}

	[Token(Token = "0x6015C61")]
	[Address(RVA = "0x232D620", Offset = "0x232D620", VA = "0x232D620")]
	public TrainingGrenadePracticeData GetGrenadePracticeData()
	{
		return null;
	}

	[Token(Token = "0x6015C62")]
	[Address(RVA = "0x232D678", Offset = "0x232D678", VA = "0x232D678")]
	public ServerMiniGameData GetMiniGameDataByGameType(MALGAHKKNNN gameType)
	{
		return null;
	}

	[Token(Token = "0x6015C63")]
	[Address(RVA = "0x232D760", Offset = "0x232D760", VA = "0x232D760")]
	public ResourceID GetMiniGameEffectRes(MALGAHKKNNN gameType, int effectId)
	{
		return default(ResourceID);
	}
}
