using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200236D")]
internal class UIHUDTeamBattleScoreBoardItemController : UIBaseController
{
	[Token(Token = "0x400DC8C")]
	[FieldOffset(Offset = "0x28")]
	protected TeamScoreBoardItemView m_View;

	[Token(Token = "0x400DC8D")]
	[FieldOffset(Offset = "0x2C")]
	protected Player m_Player;

	[Token(Token = "0x400DC8E")]
	[FieldOffset(Offset = "0x30")]
	protected PFLCPEHBBLN m_ActiveSkill;

	[Token(Token = "0x400DC8F")]
	[FieldOffset(Offset = "0x34")]
	protected AvatarSkillData m_SamoActiveSkillData;

	[Token(Token = "0x400DC90")]
	[FieldOffset(Offset = "0x38")]
	private List<UILabel> m_InfoLabelList;

	[Token(Token = "0x400DC91")]
	[FieldOffset(Offset = "0x3C")]
	private bool hasReported;

	[Token(Token = "0x400DC92")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_IsSelf;

	[Token(Token = "0x400DC93")]
	[FieldOffset(Offset = "0x40")]
	private UIDetailTipsInGameController m_DetailTips;

	[Token(Token = "0x400DC94")]
	[FieldOffset(Offset = "0x44")]
	private List<int> m_InfoTypeList;

	[Token(Token = "0x170010D4")]
	protected List<int> InfoTypeList
	{
		[Token(Token = "0x600C5F5")]
		[Address(RVA = "0x22191D4", Offset = "0x22191D4", VA = "0x22191D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600C5F3")]
	[Address(RVA = "0x2219074", Offset = "0x2219074", VA = "0x2219074")]
	public UIHUDTeamBattleScoreBoardItemController()
	{
	}

	[Token(Token = "0x600C5F4")]
	[Address(RVA = "0x221912C", Offset = "0x221912C", VA = "0x221912C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C5F6")]
	[Address(RVA = "0x22192AC", Offset = "0x22192AC", VA = "0x22192AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C5F7")]
	[Address(RVA = "0x221972C", Offset = "0x221972C", VA = "0x221972C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C5F8")]
	[Address(RVA = "0x2219854", Offset = "0x2219854", VA = "0x2219854")]
	private void OnReportCheatSent(object[] param)
	{
	}

	[Token(Token = "0x600C5F9")]
	[Address(RVA = "0x22199D0", Offset = "0x22199D0", VA = "0x22199D0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C5FA")]
	[Address(RVA = "0x2219B04", Offset = "0x2219B04", VA = "0x2219B04")]
	public void ShowReportButton(bool show)
	{
	}

	[Token(Token = "0x600C5FB")]
	[Address(RVA = "0x2219CAC", Offset = "0x2219CAC", VA = "0x2219CAC")]
	public void InitData(List<int> list, Player player, bool isLocalSelf)
	{
	}

	[Token(Token = "0x600C5FC")]
	[Address(RVA = "0x221A9B8", Offset = "0x221A9B8", VA = "0x221A9B8")]
	public int GetPlayerTeamIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600C5FD")]
	[Address(RVA = "0x221AAB8", Offset = "0x221AAB8", VA = "0x221AAB8", Slot = "31")]
	protected virtual void OnInitData(Player player)
	{
	}

	[Token(Token = "0x600C5FE")]
	[Address(RVA = "0x221A928", Offset = "0x221A928", VA = "0x221A928")]
	public void ShowSelf(bool isShow)
	{
	}

	[Token(Token = "0x600C5FF")]
	[Address(RVA = "0x221A338", Offset = "0x221A338", VA = "0x221A338")]
	public void RefreshData(Player player)
	{
	}

	[Token(Token = "0x600C600")]
	[Address(RVA = "0x221B478", Offset = "0x221B478", VA = "0x221B478")]
	public void RefreshData(int index, string msg)
	{
	}

	[Token(Token = "0x600C601")]
	[Address(RVA = "0x2219E08", Offset = "0x2219E08", VA = "0x2219E08")]
	public void SetInfoTypeList(List<int> list)
	{
	}

	[Token(Token = "0x600C602")]
	[Address(RVA = "0x2219E68", Offset = "0x2219E68", VA = "0x2219E68")]
	public void SetIsSelf(bool isSelf)
	{
	}

	[Token(Token = "0x600C603")]
	[Address(RVA = "0x2219F9C", Offset = "0x2219F9C", VA = "0x2219F9C")]
	private void SetDeadBG(bool isDead)
	{
	}

	[Token(Token = "0x600C604")]
	[Address(RVA = "0x221A034", Offset = "0x221A034", VA = "0x221A034")]
	private void InitInfoTxtByType()
	{
	}

	[Token(Token = "0x600C605")]
	[Address(RVA = "0x221B62C", Offset = "0x221B62C", VA = "0x221B62C", Slot = "32")]
	public virtual void UpdatePlayerData(Player player)
	{
	}

	[Token(Token = "0x600C606")]
	[Address(RVA = "0x221AB50", Offset = "0x221AB50", VA = "0x221AB50")]
	private void UpdateInfoData(UILabel infoTxt, Player player, int index)
	{
	}

	[Token(Token = "0x600C607")]
	[Address(RVA = "0x221A62C", Offset = "0x221A62C", VA = "0x221A62C")]
	private void SetSkillData()
	{
	}

	[Token(Token = "0x600C608")]
	[Address(RVA = "0x221A41C", Offset = "0x221A41C", VA = "0x221A41C")]
	private void UpdatePlayerActiveSkillData(Player player)
	{
	}

	[Token(Token = "0x600C609")]
	[Address(RVA = "0x221BD0C", Offset = "0x221BD0C", VA = "0x221BD0C")]
	private void OnSkillBtnPress(GameObject go, bool value)
	{
	}

	[Token(Token = "0x600C60A")]
	[Address(RVA = "0x221C1BC", Offset = "0x221C1BC", VA = "0x221C1BC")]
	protected void Update()
	{
	}

	[Token(Token = "0x600C60B")]
	[Address(RVA = "0x221C67C", Offset = "0x221C67C", VA = "0x221C67C", Slot = "33")]
	protected virtual void OnKillChange(int kill)
	{
	}

	[Token(Token = "0x600C60C")]
	[Address(RVA = "0x221C6D8", Offset = "0x221C6D8", VA = "0x221C6D8", Slot = "34")]
	protected virtual void OnDeadChange(int dead)
	{
	}

	[Token(Token = "0x600C60D")]
	[Address(RVA = "0x221C734", Offset = "0x221C734", VA = "0x221C734", Slot = "35")]
	protected virtual void OnDamageChange(uint damage)
	{
	}

	[Token(Token = "0x600C60E")]
	[Address(RVA = "0x221C790", Offset = "0x221C790", VA = "0x221C790")]
	private void OnPlayerAliveStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600C60F")]
	[Address(RVA = "0x221C9D4", Offset = "0x221C9D4", VA = "0x221C9D4")]
	protected void OnClickReportBtn()
	{
	}

	[Token(Token = "0x600C610")]
	[Address(RVA = "0x221CD58", Offset = "0x221CD58", VA = "0x221CD58")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C611")]
	[Address(RVA = "0x221CD60", Offset = "0x221CD60", VA = "0x221CD60")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C612")]
	[Address(RVA = "0x221CD68", Offset = "0x221CD68", VA = "0x221CD68")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
