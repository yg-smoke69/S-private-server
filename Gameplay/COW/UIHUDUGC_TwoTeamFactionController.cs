using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002480")]
internal class UIHUDUGC_TwoTeamFactionController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E272")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_TwoTeamFactionView m_View;

	[Token(Token = "0x400E273")]
	[FieldOffset(Offset = "0x2C")]
	private TwoTeamFactionHudEntity m_ViewData;

	[Token(Token = "0x600D035")]
	[Address(RVA = "0x2925F54", Offset = "0x2925F54", VA = "0x2925F54")]
	public UIHUDUGC_TwoTeamFactionController()
	{
	}

	[Token(Token = "0x600D036")]
	[Address(RVA = "0x2925FD8", Offset = "0x2925FD8", VA = "0x2925FD8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D037")]
	[Address(RVA = "0x292607C", Offset = "0x292607C", VA = "0x292607C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D038")]
	[Address(RVA = "0x2926138", Offset = "0x2926138", VA = "0x2926138", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600D039")]
	[Address(RVA = "0x292640C", Offset = "0x292640C", VA = "0x292640C", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600D03A")]
	[Address(RVA = "0x2926480", Offset = "0x2926480", VA = "0x2926480")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600D03B")]
	[Address(RVA = "0x29269B4", Offset = "0x29269B4", VA = "0x29269B4")]
	private void _003CSetEntityID_003Em__0(bool b, bool b1)
	{
	}

	[Token(Token = "0x600D03C")]
	[Address(RVA = "0x29269B8", Offset = "0x29269B8", VA = "0x29269B8")]
	private void _003CSetEntityID_003Em__1(bool b, bool b1)
	{
	}

	[Token(Token = "0x600D03D")]
	[Address(RVA = "0x29269BC", Offset = "0x29269BC", VA = "0x29269BC")]
	private void _003CSetEntityID_003Em__2(string s, string s1)
	{
	}

	[Token(Token = "0x600D03E")]
	[Address(RVA = "0x29269C0", Offset = "0x29269C0", VA = "0x29269C0")]
	private void _003CSetEntityID_003Em__3(string s, string s1)
	{
	}

	[Token(Token = "0x600D03F")]
	[Address(RVA = "0x29269C4", Offset = "0x29269C4", VA = "0x29269C4")]
	private void _003CSetEntityID_003Em__4(string s, string s1)
	{
	}

	[Token(Token = "0x600D040")]
	[Address(RVA = "0x29269C8", Offset = "0x29269C8", VA = "0x29269C8")]
	private void _003CSetEntityID_003Em__5(string s, string s1)
	{
	}

	[Token(Token = "0x600D041")]
	[Address(RVA = "0x29269CC", Offset = "0x29269CC", VA = "0x29269CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
