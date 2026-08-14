using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029A2")]
public class UIMatchMakingWaitingOptimizedController : UIBaseController
{
	[Token(Token = "0x4010030")]
	[FieldOffset(Offset = "0x28")]
	private UIMatchMakingWaitingOptimizedView m_View;

	[Token(Token = "0x4010031")]
	[FieldOffset(Offset = "0x2C")]
	private float m_Time;

	[Token(Token = "0x4010032")]
	[FieldOffset(Offset = "0x30")]
	public Action OnCancel;

	[Token(Token = "0x6010B97")]
	[Address(RVA = "0x2815FC8", Offset = "0x2815FC8", VA = "0x2815FC8")]
	public UIMatchMakingWaitingOptimizedController()
	{
	}

	[Token(Token = "0x6010B98")]
	[Address(RVA = "0x281604C", Offset = "0x281604C", VA = "0x281604C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B99")]
	[Address(RVA = "0x28160F0", Offset = "0x28160F0", VA = "0x28160F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B9A")]
	[Address(RVA = "0x2816564", Offset = "0x2816564", VA = "0x2816564", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010B9B")]
	[Address(RVA = "0x2816720", Offset = "0x2816720", VA = "0x2816720")]
	private void Update()
	{
	}

	[Token(Token = "0x6010B9C")]
	[Address(RVA = "0x28168F8", Offset = "0x28168F8", VA = "0x28168F8")]
	protected void OnBtnCancel()
	{
	}

	[Token(Token = "0x6010B9D")]
	[Address(RVA = "0x2816978", Offset = "0x2816978", VA = "0x2816978")]
	public void SetEstimateTime(uint time)
	{
	}

	[Token(Token = "0x6010B9E")]
	[Address(RVA = "0x2816AF8", Offset = "0x2816AF8", VA = "0x2816AF8")]
	public void ShowCancelBtn(object[] data)
	{
	}

	[Token(Token = "0x6010B9F")]
	[Address(RVA = "0x2816CF0", Offset = "0x2816CF0", VA = "0x2816CF0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010BA0")]
	[Address(RVA = "0x2816CF8", Offset = "0x2816CF8", VA = "0x2816CF8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
