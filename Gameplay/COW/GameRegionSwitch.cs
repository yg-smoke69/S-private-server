using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200028C")]
public class GameRegionSwitch : SingletonModule<GameRegionSwitch>
{
	[Token(Token = "0x40017F6")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, SwitchDesc> m_Switchs;

	[Token(Token = "0x40017F7")]
	[FieldOffset(Offset = "0x10")]
	public bool Initalized;

	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x26F7370", Offset = "0x26F7370", VA = "0x26F7370")]
	public GameRegionSwitch()
	{
	}

	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x26F7434", Offset = "0x26F7434", VA = "0x26F7434", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x26F74F4", Offset = "0x26F74F4", VA = "0x26F74F4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x26F7548", Offset = "0x26F7548", VA = "0x26F7548")]
	public void RequestRegionSwith(uint httpOption)
	{
	}

	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x26F7770", Offset = "0x26F7770", VA = "0x26F7770")]
	public void ProcessRegionSwitch(CSGetAllSwitchsRes switchsRes)
	{
	}

	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x26F8068", Offset = "0x26F8068", VA = "0x26F8068")]
	public SwitchDesc GetSwitchDesc(ESwitch.SwitchFunc func)
	{
		return null;
	}

	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x26F82B8", Offset = "0x26F82B8", VA = "0x26F82B8")]
	public bool IsGiftStoreShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x26F8338", Offset = "0x26F8338", VA = "0x26F8338")]
	public bool IsCatapultEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0x26F7F28", Offset = "0x26F7F28", VA = "0x26F7F28")]
	public bool IsOpen(ESwitch.SwitchFunc switchfunc, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x26F83B8", Offset = "0x26F83B8", VA = "0x26F83B8")]
	public bool IsGachaEntranceOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x26F843C", Offset = "0x26F843C", VA = "0x26F843C")]
	public bool IsNewPlayerEntranceOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x26F84BC", Offset = "0x26F84BC", VA = "0x26F84BC")]
	public bool IsShareButtonOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x26F8514", Offset = "0x26F8514", VA = "0x26F8514")]
	public bool IsSignATureFuncOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x26F8598", Offset = "0x26F8598", VA = "0x26F8598")]
	public bool IsBroadcastAutoFetchFuncOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x26F8618", Offset = "0x26F8618", VA = "0x26F8618")]
	public bool IsFriendRelationshipFuncOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x26F8698", Offset = "0x26F8698", VA = "0x26F8698")]
	public bool IsWorkshopRoomRelatedFuncOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x26F8718", Offset = "0x26F8718", VA = "0x26F8718")]
	public bool IsWorkshopFuncOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x26F8770", Offset = "0x26F8770", VA = "0x26F8770")]
	public bool IsTreasureBoxProbabilityFuncOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x26F87D8", Offset = "0x26F87D8", VA = "0x26F87D8")]
	public bool IsMysteryShopProbabilityFuncOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x26F8840", Offset = "0x26F8840", VA = "0x26F8840")]
	public bool IsMysteryBonusProbabilityFuncOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x26F88A8", Offset = "0x26F88A8", VA = "0x26F88A8")]
	public bool IsInInGameBonusProbabilityFuncOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x26F8910", Offset = "0x26F8910", VA = "0x26F8910")]
	public bool IsHeroicMarkMasterFuncOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x26F8990", Offset = "0x26F8990", VA = "0x26F8990")]
	public bool IsUGCCreateRoomFreeOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x26F89F8", Offset = "0x26F89F8", VA = "0x26F89F8")]
	public bool IsBRMultiKillOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x26F8A60", Offset = "0x26F8A60", VA = "0x26F8A60")]
	public bool IsUGCCommentOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x26F8AC8", Offset = "0x26F8AC8", VA = "0x26F8AC8")]
	private void _003CRequestRegionSwith_003Em__0(HttpErrorCode errorCode, object res)
	{
	}
}
