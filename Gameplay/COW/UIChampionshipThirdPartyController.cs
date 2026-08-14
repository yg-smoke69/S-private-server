using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002030")]
public class UIChampionshipThirdPartyController : UIChampionshipController
{
	[Token(Token = "0x400CA0A")]
	[FieldOffset(Offset = "0xF1")]
	private bool m_ShowNewSeasonAnim;

	[Token(Token = "0x600A352")]
	[Address(RVA = "0x2622A98", Offset = "0x2622A98", VA = "0x2622A98")]
	public UIChampionshipThirdPartyController()
	{
	}

	[Token(Token = "0x600A353")]
	[Address(RVA = "0x2622AA0", Offset = "0x2622AA0", VA = "0x2622AA0")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A354")]
	[Address(RVA = "0x2622B44", Offset = "0x2622B44", VA = "0x2622B44", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A355")]
	[Address(RVA = "0x2622CC0", Offset = "0x2622CC0", VA = "0x2622CC0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A356")]
	[Address(RVA = "0x2622DF4", Offset = "0x2622DF4", VA = "0x2622DF4", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600A357")]
	[Address(RVA = "0x26231FC", Offset = "0x26231FC", VA = "0x26231FC", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600A358")]
	[Address(RVA = "0x2622E9C", Offset = "0x2622E9C", VA = "0x2622E9C")]
	private void TryPlayNewSeasonAnim()
	{
	}

	[Token(Token = "0x600A359")]
	[Address(RVA = "0x2623260", Offset = "0x2623260", VA = "0x2623260", Slot = "45")]
	protected override void AutoShowNotice()
	{
	}

	[Token(Token = "0x600A35A")]
	[Address(RVA = "0x26232D0", Offset = "0x26232D0", VA = "0x26232D0")]
	private void OnChampionshipAnimDone(object[] param)
	{
	}

	[Token(Token = "0x600A35B")]
	[Address(RVA = "0x262334C", Offset = "0x262334C", VA = "0x262334C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A35C")]
	[Address(RVA = "0x2623354", Offset = "0x2623354", VA = "0x2623354")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A35D")]
	[Address(RVA = "0x262335C", Offset = "0x262335C", VA = "0x262335C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600A35E")]
	[Address(RVA = "0x2623364", Offset = "0x2623364", VA = "0x2623364")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600A35F")]
	[Address(RVA = "0x262336C", Offset = "0x262336C", VA = "0x262336C")]
	public void _003C_003EiFixBaseProxy_AutoShowNotice()
	{
	}
}
