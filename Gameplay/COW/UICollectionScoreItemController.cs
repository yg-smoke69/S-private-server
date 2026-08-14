using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002574")]
internal class UICollectionScoreItemController : UIBaseController
{
	[Token(Token = "0x400E7C8")]
	[FieldOffset(Offset = "0x28")]
	private UICollectionScoreItemView m_View;

	[Token(Token = "0x400E7C9")]
	[FieldOffset(Offset = "0x2C")]
	private WeaponScoreName m_ScoreName;

	[Token(Token = "0x400E7CA")]
	[FieldOffset(Offset = "0x30")]
	private Color COLOR_SCORE_RED;

	[Token(Token = "0x400E7CB")]
	[FieldOffset(Offset = "0x40")]
	private Color COLOR_SCORE_GREEN;

	[Token(Token = "0x400E7CC")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> m_UpIconList;

	[Token(Token = "0x400E7CD")]
	[FieldOffset(Offset = "0x54")]
	private List<GameObject> m_DownIconList;

	[Token(Token = "0x600DAEF")]
	[Address(RVA = "0x2CD5248", Offset = "0x2CD5248", VA = "0x2CD5248")]
	public UICollectionScoreItemController()
	{
	}

	[Token(Token = "0x600DAF0")]
	[Address(RVA = "0x2CD63D8", Offset = "0x2CD63D8", VA = "0x2CD63D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DAF1")]
	[Address(RVA = "0x2CD5480", Offset = "0x2CD5480", VA = "0x2CD5480", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DAF2")]
	[Address(RVA = "0x2CD647C", Offset = "0x2CD647C", VA = "0x2CD647C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DAF3")]
	[Address(RVA = "0x2CD6680", Offset = "0x2CD6680", VA = "0x2CD6680")]
	public void SetEventNotCare()
	{
	}

	[Token(Token = "0x600DAF4")]
	[Address(RVA = "0x2CD6878", Offset = "0x2CD6878", VA = "0x2CD6878")]
	public void SetUIData(WeaponScoreName name, uint wpid, uint skinId = 0u)
	{
	}

	[Token(Token = "0x600DAF5")]
	[Address(RVA = "0x2CD6908", Offset = "0x2CD6908", VA = "0x2CD6908")]
	public void SetUIData(uint wpid, uint skinId = 0u)
	{
	}

	[Token(Token = "0x600DAF6")]
	[Address(RVA = "0x2CD78EC", Offset = "0x2CD78EC", VA = "0x2CD78EC")]
	private void EnapblePropertyScoreTweenAlpha(object[] data)
	{
	}

	[Token(Token = "0x600DAF7")]
	[Address(RVA = "0x2CD7384", Offset = "0x2CD7384", VA = "0x2CD7384")]
	private void SetAllScoreTweenAlpha(object[] data)
	{
	}

	[Token(Token = "0x600DAF8")]
	[Address(RVA = "0x2CD7B30", Offset = "0x2CD7B30", VA = "0x2CD7B30")]
	private void OnWeaponSkinChanged(object[] data)
	{
	}

	[Token(Token = "0x600DAF9")]
	[Address(RVA = "0x2CD7C58", Offset = "0x2CD7C58", VA = "0x2CD7C58")]
	public void SetArrowOffSet(int x)
	{
	}

	[Token(Token = "0x600DAFA")]
	[Address(RVA = "0x2CD81AC", Offset = "0x2CD81AC", VA = "0x2CD81AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DAFB")]
	[Address(RVA = "0x2CD81B4", Offset = "0x2CD81B4", VA = "0x2CD81B4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
