using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029A3")]
public class UIMatchMakingWatingController : UIPopupWindowController
{
	[Token(Token = "0x4010033")]
	[FieldOffset(Offset = "0x48")]
	private UIMatchMakingWaitingView m_View;

	[Token(Token = "0x4010034")]
	[FieldOffset(Offset = "0x4C")]
	private float m_Time;

	[Token(Token = "0x4010035")]
	[FieldOffset(Offset = "0x50")]
	public Action OnCancel;

	[Token(Token = "0x6010BA1")]
	[Address(RVA = "0x28174B4", Offset = "0x28174B4", VA = "0x28174B4")]
	public UIMatchMakingWatingController()
	{
	}

	[Token(Token = "0x6010BA2")]
	[Address(RVA = "0x28174BC", Offset = "0x28174BC", VA = "0x28174BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010BA3")]
	[Address(RVA = "0x2817560", Offset = "0x2817560", VA = "0x2817560", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010BA4")]
	[Address(RVA = "0x2817828", Offset = "0x2817828", VA = "0x2817828", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010BA5")]
	[Address(RVA = "0x281795C", Offset = "0x281795C", VA = "0x281795C")]
	private void Update()
	{
	}

	[Token(Token = "0x6010BA6")]
	[Address(RVA = "0x2817B34", Offset = "0x2817B34", VA = "0x2817B34")]
	private void OnSimulateClickBtnCancel(object[] data)
	{
	}

	[Token(Token = "0x6010BA7")]
	[Address(RVA = "0x2817B9C", Offset = "0x2817B9C", VA = "0x2817B9C")]
	protected void OnBtnCancel()
	{
	}

	[Token(Token = "0x6010BA8")]
	[Address(RVA = "0x2817C1C", Offset = "0x2817C1C", VA = "0x2817C1C", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x6010BA9")]
	[Address(RVA = "0x2817D6C", Offset = "0x2817D6C", VA = "0x2817D6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010BAA")]
	[Address(RVA = "0x2817D74", Offset = "0x2817D74", VA = "0x2817D74")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6010BAB")]
	[Address(RVA = "0x2817D7C", Offset = "0x2817D7C", VA = "0x2817D7C")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}
}
