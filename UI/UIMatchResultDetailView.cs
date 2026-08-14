using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003AAF")]
public class UIMatchResultDetailView : MonoBehaviour
{
	[Token(Token = "0x4018F28")]
	[FieldOffset(Offset = "0xC")]
	private UILabel _goldCount_MatchLabel;

	[Token(Token = "0x4018F29")]
	[FieldOffset(Offset = "0x10")]
	private UILabel _expValue_MatchLabel;

	[Token(Token = "0x4018F2A")]
	[FieldOffset(Offset = "0x14")]
	private UILabel _goldCount_DailyLabel;

	[Token(Token = "0x4018F2B")]
	[FieldOffset(Offset = "0x18")]
	private UILabel _expValue_DailyLabel;

	[Token(Token = "0x4018F2C")]
	[FieldOffset(Offset = "0x1C")]
	private UILabel _goldCount_ClanLabel;

	[Token(Token = "0x4018F2D")]
	[FieldOffset(Offset = "0x20")]
	private UILabel _expValue_ClanLabel;

	[Token(Token = "0x4018F2E")]
	[FieldOffset(Offset = "0x24")]
	private UILabel _honorValue_ClanLabel;

	[Token(Token = "0x4018F2F")]
	[FieldOffset(Offset = "0x28")]
	private UILabel _goldCount_EventLabel;

	[Token(Token = "0x4018F30")]
	[FieldOffset(Offset = "0x2C")]
	private UILabel _expValue_EventLabel;

	[Token(Token = "0x4018F31")]
	[FieldOffset(Offset = "0x30")]
	private UILabel _goldCount_CardLabel;

	[Token(Token = "0x4018F32")]
	[FieldOffset(Offset = "0x34")]
	private UILabel _expValue_CardLabel;

	[Token(Token = "0x4018F33")]
	[FieldOffset(Offset = "0x38")]
	private UILabel _goldCount_RankLabel;

	[Token(Token = "0x4018F34")]
	[FieldOffset(Offset = "0x3C")]
	private UILabel _expValue_RankLabel;

	[Token(Token = "0x4018F35")]
	[FieldOffset(Offset = "0x40")]
	private UILabel m_GoldDailyLimitLabel;

	[Token(Token = "0x4018F36")]
	[FieldOffset(Offset = "0x44")]
	private UILabel m_DebrisDailyLimitLabel;

	[Token(Token = "0x4018F37")]
	[FieldOffset(Offset = "0x48")]
	private UILabel m_ExpOtherBonusLabel;

	[Token(Token = "0x4018F38")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject _matchObj;

	[Token(Token = "0x4018F39")]
	[FieldOffset(Offset = "0x50")]
	private GameObject _dailyObj;

	[Token(Token = "0x4018F3A")]
	[FieldOffset(Offset = "0x54")]
	private GameObject _clanObj;

	[Token(Token = "0x4018F3B")]
	[FieldOffset(Offset = "0x58")]
	private GameObject _eventObj;

	[Token(Token = "0x4018F3C")]
	[FieldOffset(Offset = "0x5C")]
	private GameObject _cardObj;

	[Token(Token = "0x4018F3D")]
	[FieldOffset(Offset = "0x60")]
	private GameObject _rankObj;

	[Token(Token = "0x4018F3E")]
	[FieldOffset(Offset = "0x64")]
	private GameObject m_DailyLimitObj;

	[Token(Token = "0x4018F3F")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_ExpBonusObj;

	[Token(Token = "0x4018F40")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite BG;

	[Token(Token = "0x4018F41")]
	[FieldOffset(Offset = "0x70")]
	public UIGrid grid;

	[Token(Token = "0x60173D8")]
	[Address(RVA = "0x148B75C", Offset = "0x148B75C", VA = "0x148B75C")]
	public UIMatchResultDetailView()
	{
	}

	[Token(Token = "0x60173D9")]
	[Address(RVA = "0x148B764", Offset = "0x148B764", VA = "0x148B764")]
	public void Open(MatchResultDetailInfo info, Vector3 pos)
	{
	}

	[Token(Token = "0x60173DA")]
	[Address(RVA = "0x148BF64", Offset = "0x148BF64", VA = "0x148BF64")]
	public void Close()
	{
	}
}
