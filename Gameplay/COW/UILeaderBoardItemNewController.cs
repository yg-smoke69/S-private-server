using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028F3")]
public class UILeaderBoardItemNewController : UIEasyListItemController
{
	[Token(Token = "0x20028F4")]
	public enum DisplayType
	{
		[Token(Token = "0x400FBE3")]
		PersonKills,
		[Token(Token = "0x400FBE4")]
		PersonWins,
		[Token(Token = "0x400FBE5")]
		PersonBagdges,
		[Token(Token = "0x400FBE6")]
		GuildHonor,
		[Token(Token = "0x400FBE7")]
		GuildRegionHonor,
		[Token(Token = "0x400FBE8")]
		TeamScore,
		[Token(Token = "0x400FBE9")]
		TeamKills,
		[Token(Token = "0x400FBEA")]
		CSPersonKills,
		[Token(Token = "0x400FBEB")]
		CSPersonWins
	}

	[Token(Token = "0x20028F5")]
	public enum RankFormat
	{
		[Token(Token = "0x400FBED")]
		Normal,
		[Token(Token = "0x400FBEE")]
		TopPercent
	}

	[Token(Token = "0x400FBD4")]
	[FieldOffset(Offset = "0x38")]
	private RankFormat m_RankFormat;

	[Token(Token = "0x400FBD5")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_MaxSize;

	[Token(Token = "0x400FBD6")]
	[FieldOffset(Offset = "0x40")]
	private DisplayType m_DisplayType;

	[Token(Token = "0x400FBD7")]
	[FieldOffset(Offset = "0x44")]
	private UILeaderBoardItemNewView m_View;

	[Token(Token = "0x400FBD8")]
	[FieldOffset(Offset = "0x48")]
	private LeaderBoardInfo m_info;

	[Token(Token = "0x400FBD9")]
	[FieldOffset(Offset = "0x4C")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400FBDA")]
	[FieldOffset(Offset = "0x50")]
	private UITeamBaseProfileController m_TeamBaseProfileUI;

	[Token(Token = "0x400FBDB")]
	[FieldOffset(Offset = "0x54")]
	private UIWidget m_ProfileWidget;

	[Token(Token = "0x400FBDC")]
	[FieldOffset(Offset = "0x58")]
	private int m_BGWidth;

	[Token(Token = "0x400FBDD")]
	[FieldOffset(Offset = "0x60")]
	private ulong m_AccountID;

	[Token(Token = "0x400FBDE")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsSelf;

	[Token(Token = "0x400FBDF")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<uint, string> m_RankCupIcon;

	[Token(Token = "0x400FBE0")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<uint, string> m_RankBG;

	[Token(Token = "0x400FBE1")]
	[FieldOffset(Offset = "0x74")]
	private bool m_CanTouch;

	[Token(Token = "0x60102F1")]
	[Address(RVA = "0x1A89248", Offset = "0x1A89248", VA = "0x1A89248")]
	public UILeaderBoardItemNewController()
	{
	}

	[Token(Token = "0x60102F2")]
	[Address(RVA = "0x1A894C8", Offset = "0x1A894C8", VA = "0x1A894C8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60102F3")]
	[Address(RVA = "0x1A8956C", Offset = "0x1A8956C", VA = "0x1A8956C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60102F4")]
	[Address(RVA = "0x1A89714", Offset = "0x1A89714", VA = "0x1A89714")]
	public void HideAllUIs()
	{
	}

	[Token(Token = "0x60102F5")]
	[Address(RVA = "0x1A89AAC", Offset = "0x1A89AAC", VA = "0x1A89AAC", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60102F6")]
	[Address(RVA = "0x1A89D34", Offset = "0x1A89D34", VA = "0x1A89D34", Slot = "33")]
	public override void OnItemBtnClick2()
	{
	}

	[Token(Token = "0x60102F7")]
	[Address(RVA = "0x1A8A9A8", Offset = "0x1A8A9A8", VA = "0x1A8A9A8", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x60102F8")]
	[Address(RVA = "0x1A89CC8", Offset = "0x1A89CC8", VA = "0x1A89CC8")]
	private bool IsShowHighLightType()
	{
		return default(bool);
	}

	[Token(Token = "0x60102F9")]
	[Address(RVA = "0x1A8A1EC", Offset = "0x1A8A1EC", VA = "0x1A8A1EC")]
	private Vector2 GetProfileHalfSize(Transform baseProfileTopLeft, float w, float h)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x60102FA")]
	[Address(RVA = "0x1A8A4A0", Offset = "0x1A8A4A0", VA = "0x1A8A4A0")]
	private Vector3 GetProfileCenterPos(Transform baseProfileTopLeft, float w, float h)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60102FB")]
	[Address(RVA = "0x1A8A73C", Offset = "0x1A8A73C", VA = "0x1A8A73C")]
	private bool IsInProfileRange(Vector3 centerPos, Vector2 size)
	{
		return default(bool);
	}

	[Token(Token = "0x60102FC")]
	[Address(RVA = "0x1A8AA64", Offset = "0x1A8AA64", VA = "0x1A8AA64")]
	private void SetItemData(LeaderBoardInfo info)
	{
	}

	[Token(Token = "0x60102FD")]
	[Address(RVA = "0x1A8CDFC", Offset = "0x1A8CDFC", VA = "0x1A8CDFC")]
	public void HideBG()
	{
	}

	[Token(Token = "0x60102FE")]
	[Address(RVA = "0x1A8CEAC", Offset = "0x1A8CEAC", VA = "0x1A8CEAC")]
	public void SetIsSelf(bool isSelf)
	{
	}

	[Token(Token = "0x60102FF")]
	[Address(RVA = "0x1A8ABC4", Offset = "0x1A8ABC4", VA = "0x1A8ABC4")]
	private void SetRankUI()
	{
	}

	[Token(Token = "0x6010300")]
	[Address(RVA = "0x1A8B28C", Offset = "0x1A8B28C", VA = "0x1A8B28C")]
	private void SetPersonKills()
	{
	}

	[Token(Token = "0x6010301")]
	[Address(RVA = "0x1A8B5D8", Offset = "0x1A8B5D8", VA = "0x1A8B5D8")]
	private void SetPersonWins()
	{
	}

	[Token(Token = "0x6010302")]
	[Address(RVA = "0x1A8B930", Offset = "0x1A8B930", VA = "0x1A8B930")]
	private void SetCSPersonKills()
	{
	}

	[Token(Token = "0x6010303")]
	[Address(RVA = "0x1A8BCF4", Offset = "0x1A8BCF4", VA = "0x1A8BCF4")]
	private void SetCSPersonWins()
	{
	}

	[Token(Token = "0x6010304")]
	[Address(RVA = "0x1A8C0C4", Offset = "0x1A8C0C4", VA = "0x1A8C0C4")]
	private void SetPersonBadges()
	{
	}

	[Token(Token = "0x6010305")]
	[Address(RVA = "0x1A8C4B0", Offset = "0x1A8C4B0", VA = "0x1A8C4B0")]
	private void SetGuildHonor()
	{
	}

	[Token(Token = "0x6010306")]
	[Address(RVA = "0x1A8C6D4", Offset = "0x1A8C6D4", VA = "0x1A8C6D4")]
	private void SetGuildRegionHonor()
	{
	}

	[Token(Token = "0x6010307")]
	[Address(RVA = "0x1A8CF0C", Offset = "0x1A8CF0C", VA = "0x1A8CF0C")]
	private void SetPersonBaseProfile(Transform attachPoint, bool isBR = false)
	{
	}

	[Token(Token = "0x6010308")]
	[Address(RVA = "0x1A8D1D4", Offset = "0x1A8D1D4", VA = "0x1A8D1D4")]
	private void SetGuildLogo(UISprite logoSprite)
	{
	}

	[Token(Token = "0x6010309")]
	[Address(RVA = "0x1A8CABC", Offset = "0x1A8CABC", VA = "0x1A8CABC")]
	private void SetTeamScore()
	{
	}

	[Token(Token = "0x601030A")]
	[Address(RVA = "0x1A8CC08", Offset = "0x1A8CC08", VA = "0x1A8CC08")]
	private void SetTeamKills()
	{
	}

	[Token(Token = "0x601030B")]
	[Address(RVA = "0x1A8D4AC", Offset = "0x1A8D4AC", VA = "0x1A8D4AC")]
	private void SetTeamBaseProfile(Transform attachPoint)
	{
	}

	[Token(Token = "0x601030C")]
	[Address(RVA = "0x1A8D7A8", Offset = "0x1A8D7A8", VA = "0x1A8D7A8", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x601030D")]
	[Address(RVA = "0x1A8D8AC", Offset = "0x1A8D8AC", VA = "0x1A8D8AC")]
	public void SetRankFormat(RankFormat format, uint maxSize)
	{
	}

	[Token(Token = "0x601030E")]
	[Address(RVA = "0x1A8D928", Offset = "0x1A8D928", VA = "0x1A8D928")]
	public void SetDisplayType(DisplayType displayType)
	{
	}

	[Token(Token = "0x601030F")]
	[Address(RVA = "0x1A8D988", Offset = "0x1A8D988", VA = "0x1A8D988")]
	public void SetItemTouch(bool flag)
	{
	}

	[Token(Token = "0x6010310")]
	[Address(RVA = "0x1A8D9E8", Offset = "0x1A8D9E8", VA = "0x1A8D9E8")]
	public void SetBGInfo(int bgWidth)
	{
	}

	[Token(Token = "0x6010311")]
	[Address(RVA = "0x1A8DA48", Offset = "0x1A8DA48", VA = "0x1A8DA48")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010312")]
	[Address(RVA = "0x1A8DA50", Offset = "0x1A8DA50", VA = "0x1A8DA50")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010313")]
	[Address(RVA = "0x1A8DA58", Offset = "0x1A8DA58", VA = "0x1A8DA58")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}

	[Token(Token = "0x6010314")]
	[Address(RVA = "0x1A8DA60", Offset = "0x1A8DA60", VA = "0x1A8DA60")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
