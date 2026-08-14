using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200246D")]
internal class UIHUDUGC_RoundScoreBannerController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E21E")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_RoundScoreBannerView m_View;

	[Token(Token = "0x400E21F")]
	[FieldOffset(Offset = "0x2C")]
	private TwoTeamRoundScoreBannerHudEntity m_ViewData;

	[Token(Token = "0x400E220")]
	[FieldOffset(Offset = "0x30")]
	private uint m_SelfTeamIndex;

	[Token(Token = "0x600CF63")]
	[Address(RVA = "0x2E25B90", Offset = "0x2E25B90", VA = "0x2E25B90")]
	public UIHUDUGC_RoundScoreBannerController()
	{
	}

	[Token(Token = "0x600CF64")]
	[Address(RVA = "0x2E25C14", Offset = "0x2E25C14", VA = "0x2E25C14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF65")]
	[Address(RVA = "0x2E25CB8", Offset = "0x2E25CB8", VA = "0x2E25CB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF66")]
	[Address(RVA = "0x2E25DAC", Offset = "0x2E25DAC", VA = "0x2E25DAC", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF67")]
	[Address(RVA = "0x2E260D8", Offset = "0x2E260D8", VA = "0x2E260D8", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF68")]
	[Address(RVA = "0x2E2614C", Offset = "0x2E2614C", VA = "0x2E2614C")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600CF69")]
	[Address(RVA = "0x2E2647C", Offset = "0x2E2647C", VA = "0x2E2647C")]
	private void _003CSetEntityID_003Em__0(bool b, bool b1)
	{
	}

	[Token(Token = "0x600CF6A")]
	[Address(RVA = "0x2E26480", Offset = "0x2E26480", VA = "0x2E26480")]
	private void _003CSetEntityID_003Em__1(bool b, bool b1)
	{
	}

	[Token(Token = "0x600CF6B")]
	[Address(RVA = "0x2E26484", Offset = "0x2E26484", VA = "0x2E26484")]
	private void _003CSetEntityID_003Em__2(int i, int i1)
	{
	}

	[Token(Token = "0x600CF6C")]
	[Address(RVA = "0x2E26488", Offset = "0x2E26488", VA = "0x2E26488")]
	private void _003CSetEntityID_003Em__3(string s, string s1)
	{
	}

	[Token(Token = "0x600CF6D")]
	[Address(RVA = "0x2E2648C", Offset = "0x2E2648C", VA = "0x2E2648C")]
	private void _003CSetEntityID_003Em__4(int i, int i1)
	{
	}

	[Token(Token = "0x600CF6E")]
	[Address(RVA = "0x2E26490", Offset = "0x2E26490", VA = "0x2E26490")]
	private void _003CSetEntityID_003Em__5(string s, string s1)
	{
	}

	[Token(Token = "0x600CF6F")]
	[Address(RVA = "0x2E26494", Offset = "0x2E26494", VA = "0x2E26494")]
	private void _003CSetEntityID_003Em__6(int i, int i1)
	{
	}

	[Token(Token = "0x600CF70")]
	[Address(RVA = "0x2E26498", Offset = "0x2E26498", VA = "0x2E26498")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
