using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026BA")]
public class UIGrowthFundAdController : UIPopupWindowController
{
	[Token(Token = "0x20026BB")]
	public enum EAdType
	{
		[Token(Token = "0x400EF0C")]
		NewbieAndGrowthFund = 1,
		[Token(Token = "0x400EF0D")]
		GrowthFundNotBought,
		[Token(Token = "0x400EF0E")]
		GrowthFundHasBought,
		[Token(Token = "0x400EF0F")]
		NewbieOnly
	}

	[Token(Token = "0x400EF05")]
	[FieldOffset(Offset = "0x48")]
	private UIGrowthFundAdView m_View;

	[Token(Token = "0x400EF06")]
	public const string SHOW_GROWTH_AD = "show_growth_ad";

	[Token(Token = "0x400EF07")]
	public const string SHOW_NEWBIE = "show_newbie";

	[Token(Token = "0x400EF08")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_DelayCall;

	[Token(Token = "0x400EF09")]
	[FieldOffset(Offset = "0x50")]
	private EAdType m_Type;

	[Token(Token = "0x400EF0A")]
	[FieldOffset(Offset = "0x54")]
	private UIModelPayment m_Payment;

	[Token(Token = "0x600E9DE")]
	[Address(RVA = "0x2022A14", Offset = "0x2022A14", VA = "0x2022A14")]
	public UIGrowthFundAdController()
	{
	}

	[Token(Token = "0x600E9DF")]
	[Address(RVA = "0x2022A1C", Offset = "0x2022A1C", VA = "0x2022A1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E9E0")]
	[Address(RVA = "0x2022AC4", Offset = "0x2022AC4", VA = "0x2022AC4", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600E9E1")]
	[Address(RVA = "0x2022B1C", Offset = "0x2022B1C", VA = "0x2022B1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E9E2")]
	[Address(RVA = "0x2023014", Offset = "0x2023014", VA = "0x2023014", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E9E3")]
	[Address(RVA = "0x2023130", Offset = "0x2023130", VA = "0x2023130")]
	private void OnFinish()
	{
	}

	[Token(Token = "0x600E9E4")]
	[Address(RVA = "0x2023424", Offset = "0x2023424", VA = "0x2023424")]
	private void OnBtnClose()
	{
	}

	[Token(Token = "0x600E9E5")]
	[Address(RVA = "0x20234F0", Offset = "0x20234F0", VA = "0x20234F0")]
	private void OnSingleBtn()
	{
	}

	[Token(Token = "0x600E9E6")]
	[Address(RVA = "0x20238C8", Offset = "0x20238C8", VA = "0x20238C8")]
	private void OnGotoNavigation()
	{
	}

	[Token(Token = "0x600E9E7")]
	[Address(RVA = "0x202355C", Offset = "0x202355C", VA = "0x202355C")]
	private void OnGotoNewbie()
	{
	}

	[Token(Token = "0x600E9E8")]
	[Address(RVA = "0x20239FC", Offset = "0x20239FC", VA = "0x20239FC")]
	public void SetData(bool needGrowthFund = true, bool needNewbie = false)
	{
	}

	[Token(Token = "0x600E9E9")]
	[Address(RVA = "0x2025400", Offset = "0x2025400", VA = "0x2025400")]
	public void UpdateUrl(string url)
	{
	}

	[Token(Token = "0x600E9EA")]
	[Address(RVA = "0x2025BE0", Offset = "0x2025BE0", VA = "0x2025BE0")]
	private void _003COnFinish_003Em__0()
	{
	}

	[Token(Token = "0x600E9EB")]
	[Address(RVA = "0x2025CA8", Offset = "0x2025CA8", VA = "0x2025CA8")]
	private void _003CUpdateUrl_003Em__1(Texture texture)
	{
	}

	[Token(Token = "0x600E9EC")]
	[Address(RVA = "0x2025DDC", Offset = "0x2025DDC", VA = "0x2025DDC")]
	private void _003CUpdateUrl_003Em__2(Texture texture)
	{
	}

	[Token(Token = "0x600E9ED")]
	[Address(RVA = "0x2025F10", Offset = "0x2025F10", VA = "0x2025F10")]
	private void _003CUpdateUrl_003Em__3(Texture texture)
	{
	}

	[Token(Token = "0x600E9EE")]
	[Address(RVA = "0x2026044", Offset = "0x2026044", VA = "0x2026044")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600E9EF")]
	[Address(RVA = "0x202604C", Offset = "0x202604C", VA = "0x202604C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E9F0")]
	[Address(RVA = "0x2026054", Offset = "0x2026054", VA = "0x2026054")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
