using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200224D")]
public class UIHudMatchResultItemRewardController : UIPopupWindowController
{
	[Token(Token = "0x400D6CE")]
	[FieldOffset(Offset = "0x48")]
	private UIHudMatchResultItemRewardView m_View;

	[Token(Token = "0x600BAB7")]
	[Address(RVA = "0x19B91FC", Offset = "0x19B91FC", VA = "0x19B91FC")]
	public UIHudMatchResultItemRewardController()
	{
	}

	[Token(Token = "0x600BAB8")]
	[Address(RVA = "0x19B9204", Offset = "0x19B9204", VA = "0x19B9204")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BAB9")]
	[Address(RVA = "0x19B92AC", Offset = "0x19B92AC", VA = "0x19B92AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BABA")]
	[Address(RVA = "0x19B9408", Offset = "0x19B9408", VA = "0x19B9408", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600BABB")]
	[Address(RVA = "0x19B9548", Offset = "0x19B9548", VA = "0x19B9548", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600BABC")]
	[Address(RVA = "0x19B96F0", Offset = "0x19B96F0", VA = "0x19B96F0")]
	public void ShowRewards(List<CommonRewardItemInfo> debrisList, List<CommonRewardItemInfo> commonList)
	{
	}

	[Token(Token = "0x600BABD")]
	[Address(RVA = "0x19B9CE0", Offset = "0x19B9CE0", VA = "0x19B9CE0", Slot = "34")]
	public override int GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x600BABE")]
	[Address(RVA = "0x19B9D38", Offset = "0x19B9D38", VA = "0x19B9D38")]
	private void OnClickSkipMaskBtn()
	{
	}

	[Token(Token = "0x600BABF")]
	[Address(RVA = "0x19B9D9C", Offset = "0x19B9D9C", VA = "0x19B9D9C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BAC0")]
	[Address(RVA = "0x19B9DA4", Offset = "0x19B9DA4", VA = "0x19B9DA4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600BAC1")]
	[Address(RVA = "0x19B9DAC", Offset = "0x19B9DAC", VA = "0x19B9DAC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600BAC2")]
	[Address(RVA = "0x19B9DB4", Offset = "0x19B9DB4", VA = "0x19B9DB4")]
	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return default(int);
	}
}
