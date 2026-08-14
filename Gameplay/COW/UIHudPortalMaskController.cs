using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023E2")]
public class UIHudPortalMaskController : UIBaseController
{
	[Token(Token = "0x400DF02")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPortalMaskView m_View;

	[Token(Token = "0x400DF03")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsToBlack;

	[Token(Token = "0x400DF04")]
	[FieldOffset(Offset = "0x30")]
	private Action m_OnBackCallBack;

	[Token(Token = "0x600CA8B")]
	[Address(RVA = "0x1FBA0D8", Offset = "0x1FBA0D8", VA = "0x1FBA0D8")]
	public UIHudPortalMaskController()
	{
	}

	[Token(Token = "0x600CA8C")]
	[Address(RVA = "0x1FBA15C", Offset = "0x1FBA15C", VA = "0x1FBA15C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA8D")]
	[Address(RVA = "0x1FBA200", Offset = "0x1FBA200", VA = "0x1FBA200", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA8E")]
	[Address(RVA = "0x1FBA364", Offset = "0x1FBA364", VA = "0x1FBA364")]
	public void StartMask([Optional] Action black_call_back, float dur = 1f)
	{
	}

	[Token(Token = "0x600CA8F")]
	[Address(RVA = "0x1FBA4E8", Offset = "0x1FBA4E8", VA = "0x1FBA4E8")]
	private void OnTweenEnd()
	{
	}

	[Token(Token = "0x600CA90")]
	[Address(RVA = "0x1FBA5BC", Offset = "0x1FBA5BC", VA = "0x1FBA5BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
