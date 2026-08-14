using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E04")]
internal class PCMatchResultScoreConfigDataManager : SingletonModule<PCMatchResultScoreConfigDataManager>
{
	[Token(Token = "0x4011A11")]
	private const string overrideFileName = "scorelist.json";

	[Token(Token = "0x4011A12")]
	[FieldOffset(Offset = "0xC")]
	private MatchResultScoreListConfig m_ScoreListConfig;

	[Token(Token = "0x170013FA")]
	public MatchResultScoreListConfig ScoreList
	{
		[Token(Token = "0x6013478")]
		[Address(RVA = "0x28CCFB0", Offset = "0x28CCFB0", VA = "0x28CCFB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6013477")]
	[Address(RVA = "0x28CA3E4", Offset = "0x28CA3E4", VA = "0x28CA3E4")]
	public PCMatchResultScoreConfigDataManager()
	{
	}

	[Token(Token = "0x6013479")]
	[Address(RVA = "0x28CD008", Offset = "0x28CD008", VA = "0x28CD008", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601347A")]
	[Address(RVA = "0x28CD3C0", Offset = "0x28CD3C0", VA = "0x28CD3C0")]
	public uint GetScorePerKillByGroup(uint group)
	{
		return default(uint);
	}

	[Token(Token = "0x601347B")]
	[Address(RVA = "0x28CD4A4", Offset = "0x28CD4A4", VA = "0x28CD4A4")]
	public uint GetScoreByRankAndGroup(uint group, uint rank)
	{
		return default(uint);
	}

	[Token(Token = "0x601347C")]
	[Address(RVA = "0x28CD60C", Offset = "0x28CD60C", VA = "0x28CD60C", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
