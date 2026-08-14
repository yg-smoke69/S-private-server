using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200246C")]
public class UIHUDUGC_RoundNumController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E21B")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_RoundNumView m_View;

	[Token(Token = "0x400E21C")]
	[FieldOffset(Offset = "0x2C")]
	private RoundNumHudEntity m_ViewData;

	[Token(Token = "0x400E21D")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x600CF54")]
	[Address(RVA = "0x2E24B40", Offset = "0x2E24B40", VA = "0x2E24B40")]
	public UIHUDUGC_RoundNumController()
	{
	}

	[Token(Token = "0x600CF55")]
	[Address(RVA = "0x2E24BC4", Offset = "0x2E24BC4", VA = "0x2E24BC4", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF56")]
	[Address(RVA = "0x2E24E54", Offset = "0x2E24E54", VA = "0x2E24E54", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF57")]
	[Address(RVA = "0x2E24EC8", Offset = "0x2E24EC8", VA = "0x2E24EC8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF58")]
	[Address(RVA = "0x2E24F6C", Offset = "0x2E24F6C", VA = "0x2E24F6C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF59")]
	[Address(RVA = "0x2E25028", Offset = "0x2E25028", VA = "0x2E25028", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CF5A")]
	[Address(RVA = "0x2E25094", Offset = "0x2E25094", VA = "0x2E25094")]
	private string GetText(string key, object[] param)
	{
		return null;
	}

	[Token(Token = "0x600CF5B")]
	[Address(RVA = "0x2E25410", Offset = "0x2E25410", VA = "0x2E25410")]
	private void ShowRoundNum()
	{
	}

	[Token(Token = "0x600CF5C")]
	[Address(RVA = "0x2E255A8", Offset = "0x2E255A8", VA = "0x2E255A8")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CF5D")]
	[Address(RVA = "0x2E25630", Offset = "0x2E25630", VA = "0x2E25630")]
	private void OnLocSwitchChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CF5E")]
	[Address(RVA = "0x2E256B0", Offset = "0x2E256B0", VA = "0x2E256B0")]
	private void OnTextKeyChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CF5F")]
	[Address(RVA = "0x2E25730", Offset = "0x2E25730", VA = "0x2E25730")]
	private void OnTextKey_ParamsChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CF60")]
	[Address(RVA = "0x2E257B0", Offset = "0x2E257B0", VA = "0x2E257B0")]
	private void OnThemeColorChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CF61")]
	[Address(RVA = "0x2E25968", Offset = "0x2E25968", VA = "0x2E25968")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CF62")]
	[Address(RVA = "0x2E25970", Offset = "0x2E25970", VA = "0x2E25970")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
