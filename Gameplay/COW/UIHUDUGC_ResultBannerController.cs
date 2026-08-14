using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200246B")]
internal class UIHUDUGC_ResultBannerController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E219")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_ResultBannerView m_View;

	[Token(Token = "0x400E21A")]
	[FieldOffset(Offset = "0x2C")]
	private ResultBannerHudEntity m_ViewData;

	[Token(Token = "0x600CF4A")]
	[Address(RVA = "0x2E242D4", Offset = "0x2E242D4", VA = "0x2E242D4")]
	public UIHUDUGC_ResultBannerController()
	{
	}

	[Token(Token = "0x600CF4B")]
	[Address(RVA = "0x2E24358", Offset = "0x2E24358", VA = "0x2E24358")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF4C")]
	[Address(RVA = "0x2E243FC", Offset = "0x2E243FC", VA = "0x2E243FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF4D")]
	[Address(RVA = "0x2E244B8", Offset = "0x2E244B8", VA = "0x2E244B8", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF4E")]
	[Address(RVA = "0x2E24684", Offset = "0x2E24684", VA = "0x2E24684", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF4F")]
	[Address(RVA = "0x2E246F8", Offset = "0x2E246F8", VA = "0x2E246F8")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600CF50")]
	[Address(RVA = "0x2E248D8", Offset = "0x2E248D8", VA = "0x2E248D8")]
	private void _003CSetEntityID_003Em__0(bool b, bool b1)
	{
	}

	[Token(Token = "0x600CF51")]
	[Address(RVA = "0x2E248DC", Offset = "0x2E248DC", VA = "0x2E248DC")]
	private void _003CSetEntityID_003Em__1(bool b, bool b1)
	{
	}

	[Token(Token = "0x600CF52")]
	[Address(RVA = "0x2E248E0", Offset = "0x2E248E0", VA = "0x2E248E0")]
	private void _003CSetEntityID_003Em__2(int i, int i1)
	{
	}

	[Token(Token = "0x600CF53")]
	[Address(RVA = "0x2E248E4", Offset = "0x2E248E4", VA = "0x2E248E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
