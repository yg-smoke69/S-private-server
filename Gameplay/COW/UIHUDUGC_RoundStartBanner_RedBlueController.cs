using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200246E")]
internal class UIHUDUGC_RoundStartBanner_RedBlueController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E221")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_RoundStartBanner_RedBlueView m_View;

	[Token(Token = "0x400E222")]
	[FieldOffset(Offset = "0x2C")]
	private TwoTeamRoundStartBannerHudEntity m_ViewData;

	[Token(Token = "0x400E223")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x600CF71")]
	[Address(RVA = "0x2E26868", Offset = "0x2E26868", VA = "0x2E26868")]
	public UIHUDUGC_RoundStartBanner_RedBlueController()
	{
	}

	[Token(Token = "0x600CF72")]
	[Address(RVA = "0x2E268EC", Offset = "0x2E268EC", VA = "0x2E268EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF73")]
	[Address(RVA = "0x2E26990", Offset = "0x2E26990", VA = "0x2E26990", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF74")]
	[Address(RVA = "0x2E26A4C", Offset = "0x2E26A4C", VA = "0x2E26A4C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600CF75")]
	[Address(RVA = "0x2E26B38", Offset = "0x2E26B38", VA = "0x2E26B38", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF76")]
	[Address(RVA = "0x2E26AB8", Offset = "0x2E26AB8", VA = "0x2E26AB8", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF77")]
	[Address(RVA = "0x2E26E24", Offset = "0x2E26E24", VA = "0x2E26E24")]
	private string GetLocText(string text, object[] parmas)
	{
		return null;
	}

	[Token(Token = "0x600CF78")]
	[Address(RVA = "0x2E27038", Offset = "0x2E27038", VA = "0x2E27038")]
	private void ShowRoundNum()
	{
	}

	[Token(Token = "0x600CF79")]
	[Address(RVA = "0x2E27180", Offset = "0x2E27180", VA = "0x2E27180")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CF7A")]
	[Address(RVA = "0x2E27208", Offset = "0x2E27208", VA = "0x2E27208")]
	private void OnRoundNumTextChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CF7B")]
	[Address(RVA = "0x2E27288", Offset = "0x2E27288", VA = "0x2E27288")]
	private void OnRoundNumParamsChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CF7C")]
	[Address(RVA = "0x2E27308", Offset = "0x2E27308", VA = "0x2E27308")]
	private void OnDescTextChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CF7D")]
	[Address(RVA = "0x2E27420", Offset = "0x2E27420", VA = "0x2E27420")]
	private void OnLeftColorChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CF7E")]
	[Address(RVA = "0x2E27504", Offset = "0x2E27504", VA = "0x2E27504")]
	private void OnRightColorChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CF7F")]
	[Address(RVA = "0x2E275E8", Offset = "0x2E275E8", VA = "0x2E275E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CF80")]
	[Address(RVA = "0x2E275F0", Offset = "0x2E275F0", VA = "0x2E275F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
