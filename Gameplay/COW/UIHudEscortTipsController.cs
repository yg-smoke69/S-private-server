using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002744")]
internal class UIHudEscortTipsController : UIBaseController
{
	[Token(Token = "0x400F246")]
	[FieldOffset(Offset = "0x28")]
	private UIHudEscortTipsView m_View;

	[Token(Token = "0x400F247")]
	[FieldOffset(Offset = "0x2C")]
	private TweenAlpha m_FadeInAlpha;

	[Token(Token = "0x400F248")]
	[FieldOffset(Offset = "0x30")]
	private TweenAlpha m_FadeOutAlpha;

	[Token(Token = "0x400F249")]
	[FieldOffset(Offset = "0x34")]
	private uint m_ShowDelayCallID;

	[Token(Token = "0x400F24A")]
	[FieldOffset(Offset = "0x38")]
	private uint m_HideDelayCallID;

	[Token(Token = "0x400F24B")]
	[FieldOffset(Offset = "0x3C")]
	private float m_ShowTime;

	[Token(Token = "0x400F24C")]
	[FieldOffset(Offset = "0x40")]
	private Color Team1Color;

	[Token(Token = "0x400F24D")]
	[FieldOffset(Offset = "0x50")]
	private Color Team2Color;

	[Token(Token = "0x600EF7E")]
	[Address(RVA = "0x1B94788", Offset = "0x1B94788", VA = "0x1B94788")]
	public UIHudEscortTipsController()
	{
	}

	[Token(Token = "0x600EF7F")]
	[Address(RVA = "0x1B948A8", Offset = "0x1B948A8", VA = "0x1B948A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF80")]
	[Address(RVA = "0x1B94950", Offset = "0x1B94950", VA = "0x1B94950", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF81")]
	[Address(RVA = "0x1B94B28", Offset = "0x1B94B28", VA = "0x1B94B28", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EF82")]
	[Address(RVA = "0x1B94D68", Offset = "0x1B94D68", VA = "0x1B94D68")]
	private void ShowTips()
	{
	}

	[Token(Token = "0x600EF83")]
	[Address(RVA = "0x1B94F48", Offset = "0x1B94F48", VA = "0x1B94F48")]
	private void HideTips()
	{
	}

	[Token(Token = "0x600EF84")]
	[Address(RVA = "0x1B94FCC", Offset = "0x1B94FCC", VA = "0x1B94FCC")]
	public void SetData(string content, IHAAMHPPLMG playerid)
	{
	}

	[Token(Token = "0x600EF85")]
	[Address(RVA = "0x1B95320", Offset = "0x1B95320", VA = "0x1B95320")]
	private void SetTeamColor(IHAAMHPPLMG playerid)
	{
	}

	[Token(Token = "0x600EF86")]
	[Address(RVA = "0x1B94B94", Offset = "0x1B94B94", VA = "0x1B94B94")]
	public void ClearData()
	{
	}

	[Token(Token = "0x600EF87")]
	[Address(RVA = "0x1B954B8", Offset = "0x1B954B8", VA = "0x1B954B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EF88")]
	[Address(RVA = "0x1B954C0", Offset = "0x1B954C0", VA = "0x1B954C0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
