using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200246F")]
internal class UIHUDUGC_RoundStartBanner_YellowController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E224")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_RoundStartBanner_YellowView m_View;

	[Token(Token = "0x400E225")]
	[FieldOffset(Offset = "0x2C")]
	private NormalRoundStartBannerHudEntity m_ViewData;

	[Token(Token = "0x400E226")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x600CF81")]
	[Address(RVA = "0x2E278D0", Offset = "0x2E278D0", VA = "0x2E278D0")]
	public UIHUDUGC_RoundStartBanner_YellowController()
	{
	}

	[Token(Token = "0x600CF82")]
	[Address(RVA = "0x2E27954", Offset = "0x2E27954", VA = "0x2E27954")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF83")]
	[Address(RVA = "0x2E279F8", Offset = "0x2E279F8", VA = "0x2E279F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF84")]
	[Address(RVA = "0x2E27AB4", Offset = "0x2E27AB4", VA = "0x2E27AB4", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF85")]
	[Address(RVA = "0x2E27D44", Offset = "0x2E27D44", VA = "0x2E27D44", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF86")]
	[Address(RVA = "0x2E27DB8", Offset = "0x2E27DB8", VA = "0x2E27DB8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600CF87")]
	[Address(RVA = "0x2E27E24", Offset = "0x2E27E24", VA = "0x2E27E24")]
	private string GetLocText(string text, object[] parmas)
	{
		return null;
	}

	[Token(Token = "0x600CF88")]
	[Address(RVA = "0x2E28038", Offset = "0x2E28038", VA = "0x2E28038")]
	private void ShowRoundNum()
	{
	}

	[Token(Token = "0x600CF89")]
	[Address(RVA = "0x2E28180", Offset = "0x2E28180", VA = "0x2E28180")]
	private bool IsBlack(Color c)
	{
		return default(bool);
	}

	[Token(Token = "0x600CF8A")]
	[Address(RVA = "0x2E28280", Offset = "0x2E28280", VA = "0x2E28280")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CF8B")]
	[Address(RVA = "0x2E28308", Offset = "0x2E28308", VA = "0x2E28308")]
	private void OnRoundNumTextChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CF8C")]
	[Address(RVA = "0x2E28388", Offset = "0x2E28388", VA = "0x2E28388")]
	private void OnRoundNumParamsChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CF8D")]
	[Address(RVA = "0x2E28408", Offset = "0x2E28408", VA = "0x2E28408")]
	private void OnDescTextChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CF8E")]
	[Address(RVA = "0x2E28520", Offset = "0x2E28520", VA = "0x2E28520")]
	private void OnThemeColorChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CF8F")]
	[Address(RVA = "0x2E28734", Offset = "0x2E28734", VA = "0x2E28734")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CF90")]
	[Address(RVA = "0x2E2873C", Offset = "0x2E2873C", VA = "0x2E2873C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
