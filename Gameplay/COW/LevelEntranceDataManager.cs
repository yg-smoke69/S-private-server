using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000169")]
public class LevelEntranceDataManager : SingletonModule<LevelEntranceDataManager>
{
	[Token(Token = "0x200016A")]
	public enum EntranceIdType
	{
		[Token(Token = "0x4000924")]
		NewPlayerSignin = 1,
		[Token(Token = "0x4000925")]
		Avatar,
		[Token(Token = "0x4000926")]
		LowLoadOut,
		[Token(Token = "0x4000927")]
		EPContainer,
		[Token(Token = "0x4000928")]
		Manual,
		[Token(Token = "0x4000929")]
		Collection,
		[Token(Token = "0x400092A")]
		HighLoadOut,
		[Token(Token = "0x400092B")]
		Gacha,
		[Token(Token = "0x400092C")]
		Pet,
		[Token(Token = "0x400092D")]
		Championship,
		[Token(Token = "0x400092E")]
		LobbyClan,
		[Token(Token = "0x400092F")]
		RankMatch,
		[Token(Token = "0x4000930")]
		NormalSignIn,
		[Token(Token = "0x4000931")]
		BindAccount,
		[Token(Token = "0x4000932")]
		RankLadder,
		[Token(Token = "0x4000933")]
		Task
	}

	[Token(Token = "0x200016B")]
	public enum EntranceUnlockType
	{
		[Token(Token = "0x4000935")]
		Level = 1,
		[Token(Token = "0x4000936")]
		Day
	}

	[Token(Token = "0x200016C")]
	public enum LockStatusType
	{
		[Token(Token = "0x4000938")]
		NoLock,
		[Token(Token = "0x4000939")]
		Locked,
		[Token(Token = "0x400093A")]
		Hided
	}

	[Token(Token = "0x200016D")]
	private sealed class _003CGetEntranceDataByEntranceId_003Ec__AnonStorey0
	{
		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x8")]
		internal uint entranceId;

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xEBCF08", Offset = "0xEBCF08", VA = "0xEBCF08")]
		public _003CGetEntranceDataByEntranceId_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xEBD2C0", Offset = "0xEBD2C0", VA = "0xEBD2C0")]
		internal bool _003C_003Em__0(LevelEntranceData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0xC")]
	public List<LevelEntranceData> m_EntranceDataList;

	[Token(Token = "0x6000866")]
	[Address(RVA = "0xEBC9F0", Offset = "0xEBC9F0", VA = "0xEBC9F0")]
	public LevelEntranceDataManager()
	{
	}

	[Token(Token = "0x6000867")]
	[Address(RVA = "0xEBCA80", Offset = "0xEBCA80", VA = "0xEBCA80", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0xEBCBA4", Offset = "0xEBCBA4", VA = "0xEBCBA4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0xEBCC64", Offset = "0xEBCC64", VA = "0xEBCC64")]
	public uint GetLockStatusByEntranceId(uint entranceId, uint curLevel)
	{
		return default(uint);
	}

	[Token(Token = "0x600086A")]
	[Address(RVA = "0xEBCD10", Offset = "0xEBCD10", VA = "0xEBCD10")]
	public LevelEntranceData GetEntranceDataByEntranceId(uint entranceId)
	{
		return null;
	}

	[Token(Token = "0x600086B")]
	[Address(RVA = "0xEBCF10", Offset = "0xEBCF10", VA = "0xEBCF10")]
	public LevelEntranceData GetEntranceDataByUnlockLevel(uint unlockLevel)
	{
		return null;
	}

	[Token(Token = "0x600086C")]
	[Address(RVA = "0xEBD10C", Offset = "0xEBD10C", VA = "0xEBD10C")]
	public LevelEntranceData GetEntranceDataByAnnounceLevel(uint announceLevel)
	{
		return null;
	}
}
