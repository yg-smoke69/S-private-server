using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002463")]
internal class UIHUDUGC_OpeningBanner_AnnihilateController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002464")]
	public class OpeningBanner_Annihilate
	{
		[Token(Token = "0x400E209")]
		[FieldOffset(Offset = "0x8")]
		public int ShowTimeMs;

		[Token(Token = "0x600CF17")]
		[Address(RVA = "0x2E21F44", Offset = "0x2E21F44", VA = "0x2E21F44")]
		public OpeningBanner_Annihilate()
		{
		}
	}

	[Token(Token = "0x400E206")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_OpeningBanner_AnnihilateView m_View;

	[Token(Token = "0x400E207")]
	[FieldOffset(Offset = "0x2C")]
	private OpeningBanner_Annihilate m_ViewData;

	[Token(Token = "0x400E208")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCallID;

	[Token(Token = "0x600CF0D")]
	[Address(RVA = "0x2E21D3C", Offset = "0x2E21D3C", VA = "0x2E21D3C")]
	public UIHUDUGC_OpeningBanner_AnnihilateController()
	{
	}

	[Token(Token = "0x600CF0E")]
	[Address(RVA = "0x2E21DC0", Offset = "0x2E21DC0", VA = "0x2E21DC0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF0F")]
	[Address(RVA = "0x2E21E64", Offset = "0x2E21E64", VA = "0x2E21E64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF10")]
	[Address(RVA = "0x2E21F4C", Offset = "0x2E21F4C", VA = "0x2E21F4C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CF11")]
	[Address(RVA = "0x2E22054", Offset = "0x2E22054", VA = "0x2E22054")]
	public void SetStateByParams(bool isShow, List<FIMGICJHBNI> args)
	{
	}

	[Token(Token = "0x600CF12")]
	[Address(RVA = "0x2E22238", Offset = "0x2E22238", VA = "0x2E22238")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600CF13")]
	[Address(RVA = "0x2E223C8", Offset = "0x2E223C8", VA = "0x2E223C8", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF14")]
	[Address(RVA = "0x2E224A4", Offset = "0x2E224A4", VA = "0x2E224A4", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF15")]
	[Address(RVA = "0x2E22578", Offset = "0x2E22578", VA = "0x2E22578")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CF16")]
	[Address(RVA = "0x2E22580", Offset = "0x2E22580", VA = "0x2E22580")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
