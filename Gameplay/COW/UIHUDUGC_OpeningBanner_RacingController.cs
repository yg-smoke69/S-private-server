using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002465")]
internal class UIHUDUGC_OpeningBanner_RacingController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002466")]
	public class OpeningBanner_Racing
	{
		[Token(Token = "0x400E20D")]
		[FieldOffset(Offset = "0x8")]
		public int ShowTimeMs;

		[Token(Token = "0x600CF22")]
		[Address(RVA = "0x2E227FC", Offset = "0x2E227FC", VA = "0x2E227FC")]
		public OpeningBanner_Racing()
		{
		}
	}

	[Token(Token = "0x400E20A")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_OpeningBanner_RacingView m_View;

	[Token(Token = "0x400E20B")]
	[FieldOffset(Offset = "0x2C")]
	private OpeningBanner_Racing m_ViewData;

	[Token(Token = "0x400E20C")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCallID;

	[Token(Token = "0x600CF18")]
	[Address(RVA = "0x2E225F4", Offset = "0x2E225F4", VA = "0x2E225F4")]
	public UIHUDUGC_OpeningBanner_RacingController()
	{
	}

	[Token(Token = "0x600CF19")]
	[Address(RVA = "0x2E22678", Offset = "0x2E22678", VA = "0x2E22678")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF1A")]
	[Address(RVA = "0x2E2271C", Offset = "0x2E2271C", VA = "0x2E2271C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF1B")]
	[Address(RVA = "0x2E22804", Offset = "0x2E22804", VA = "0x2E22804", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CF1C")]
	[Address(RVA = "0x2E2290C", Offset = "0x2E2290C", VA = "0x2E2290C")]
	public void SetStateByParams(bool isShow, List<FIMGICJHBNI> args)
	{
	}

	[Token(Token = "0x600CF1D")]
	[Address(RVA = "0x2E22AF0", Offset = "0x2E22AF0", VA = "0x2E22AF0")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600CF1E")]
	[Address(RVA = "0x2E22C80", Offset = "0x2E22C80", VA = "0x2E22C80", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF1F")]
	[Address(RVA = "0x2E22D5C", Offset = "0x2E22D5C", VA = "0x2E22D5C", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF20")]
	[Address(RVA = "0x2E22E30", Offset = "0x2E22E30", VA = "0x2E22E30")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CF21")]
	[Address(RVA = "0x2E22E38", Offset = "0x2E22E38", VA = "0x2E22E38")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
