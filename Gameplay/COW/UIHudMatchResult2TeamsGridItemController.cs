using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20027B2")]
public class UIHudMatchResult2TeamsGridItemController : UIBaseController
{
	[Token(Token = "0x400F4F6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudMatchResult2TeamsGridItemView m_View;

	[Token(Token = "0x400F4F7")]
	[FieldOffset(Offset = "0x30")]
	private ulong m_UserAccountId;

	[Token(Token = "0x400F4F8")]
	[FieldOffset(Offset = "0x38")]
	protected GameObject m_Self;

	[Token(Token = "0x400F4F9")]
	[FieldOffset(Offset = "0x3C")]
	protected UIButton m_SimpleProfileInfo;

	[Token(Token = "0x400F4FA")]
	[FieldOffset(Offset = "0x40")]
	protected UISprite m_HeadIcon;

	[Token(Token = "0x400F4FB")]
	[FieldOffset(Offset = "0x44")]
	protected GameObject m_InfoContainer;

	[Token(Token = "0x400F4FC")]
	[FieldOffset(Offset = "0x48")]
	protected UILabel m_Nickname;

	[Token(Token = "0x400F4FD")]
	[FieldOffset(Offset = "0x4C")]
	protected UILabel m_ClanName;

	[Token(Token = "0x400F4FE")]
	[FieldOffset(Offset = "0x50")]
	protected UILabel m_Kill;

	[Token(Token = "0x400F4FF")]
	[FieldOffset(Offset = "0x54")]
	protected UILabel m_Death;

	[Token(Token = "0x400F500")]
	[FieldOffset(Offset = "0x58")]
	protected UILabel m_Assist;

	[Token(Token = "0x400F501")]
	[FieldOffset(Offset = "0x5C")]
	protected UILabel m_Damage;

	[Token(Token = "0x400F502")]
	[FieldOffset(Offset = "0x60")]
	protected UILabel m_Evaluation;

	[Token(Token = "0x400F503")]
	[FieldOffset(Offset = "0x64")]
	protected GameObject m_Mvp;

	[Token(Token = "0x400F504")]
	[FieldOffset(Offset = "0x68")]
	protected UIButton m_AddFriendBtn;

	[Token(Token = "0x400F505")]
	[FieldOffset(Offset = "0x6C")]
	protected UILabel m_BDLabel;

	[Token(Token = "0x400F506")]
	[FieldOffset(Offset = "0x70")]
	protected UILabel m_BPLabel;

	[Token(Token = "0x400F507")]
	[FieldOffset(Offset = "0x74")]
	protected UIEffectSprite m_BannerBG;

	[Token(Token = "0x400F508")]
	[FieldOffset(Offset = "0x78")]
	protected GameObject m_FakeBannerBG;

	[Token(Token = "0x600F507")]
	[Address(RVA = "0x10012E4", Offset = "0x10012E4", VA = "0x10012E4")]
	public UIHudMatchResult2TeamsGridItemController()
	{
	}

	[Token(Token = "0x600F508")]
	[Address(RVA = "0x1002620", Offset = "0x1002620", VA = "0x1002620")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F509")]
	[Address(RVA = "0x1001B1C", Offset = "0x1001B1C", VA = "0x1001B1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F50A")]
	[Address(RVA = "0x1001BEC", Offset = "0x1001BEC", VA = "0x1001BEC", Slot = "31")]
	protected virtual void InitComponents()
	{
	}

	[Token(Token = "0x600F50B")]
	[Address(RVA = "0x10014D8", Offset = "0x10014D8", VA = "0x10014D8")]
	protected void SetDefaultActive()
	{
	}

	[Token(Token = "0x600F50C")]
	[Address(RVA = "0x1000EF8", Offset = "0x1000EF8", VA = "0x1000EF8")]
	public void SetUIData(TeammateStats p, bool localPlayer, bool isFriend, bool hideScore = false, bool hideFriend = false)
	{
	}

	[Token(Token = "0x600F50D")]
	[Address(RVA = "0x1002E10", Offset = "0x1002E10", VA = "0x1002E10")]
	public void SetUIData(string nickname, string teamname, uint headicon, uint kill, uint dead, uint assist, uint damage, uint banner)
	{
	}

	[Token(Token = "0x600F50E")]
	[Address(RVA = "0x10026C4", Offset = "0x10026C4", VA = "0x10026C4")]
	private void SetNameIcon(TeammateStats p)
	{
	}

	[Token(Token = "0x600F50F")]
	[Address(RVA = "0x1001964", Offset = "0x1001964", VA = "0x1001964", Slot = "32")]
	protected virtual void SetScores(TeammateStats p)
	{
	}

	[Token(Token = "0x600F510")]
	[Address(RVA = "0x1002A1C", Offset = "0x1002A1C", VA = "0x1002A1C")]
	private void SetLocalPlayer()
	{
	}

	[Token(Token = "0x600F511")]
	[Address(RVA = "0x1003130", Offset = "0x1003130", VA = "0x1003130")]
	private void Highlight(UILabel label)
	{
	}

	[Token(Token = "0x600F512")]
	[Address(RVA = "0x100115C", Offset = "0x100115C", VA = "0x100115C")]
	public void SetMvp()
	{
	}

	[Token(Token = "0x600F513")]
	[Address(RVA = "0x100325C", Offset = "0x100325C", VA = "0x100325C")]
	private void OnAddFriend()
	{
	}

	[Token(Token = "0x600F514")]
	[Address(RVA = "0x1002AEC", Offset = "0x1002AEC", VA = "0x1002AEC")]
	private void UpdateBannerData(uint bannerID)
	{
	}

	[Token(Token = "0x600F515")]
	[Address(RVA = "0x1003484", Offset = "0x1003484", VA = "0x1003484")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
