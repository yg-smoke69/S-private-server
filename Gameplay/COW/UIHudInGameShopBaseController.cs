using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200277E")]
internal class UIHudInGameShopBaseController : UIBaseController
{
	[Token(Token = "0x400F3E6")]
	[FieldOffset(Offset = "0x28")]
	protected UIHudInGameShopView m_View;

	[Token(Token = "0x400F3E7")]
	[FieldOffset(Offset = "0x2C")]
	protected int m_TokenCount;

	[Token(Token = "0x400F3E8")]
	[FieldOffset(Offset = "0x30")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x170011C9")]
	public bool PurchaseCountDownFinish
	{
		[Token(Token = "0x600F252")]
		[Address(RVA = "0x229AEAC", Offset = "0x229AEAC", VA = "0x229AEAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600F243")]
	[Address(RVA = "0x229988C", Offset = "0x229988C", VA = "0x229988C")]
	public UIHudInGameShopBaseController()
	{
	}

	[Token(Token = "0x600F244")]
	[Address(RVA = "0x2299910", Offset = "0x2299910", VA = "0x2299910", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F245")]
	[Address(RVA = "0x229A1A4", Offset = "0x229A1A4", VA = "0x229A1A4")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x600F246")]
	[Address(RVA = "0x229A238", Offset = "0x229A238", VA = "0x229A238", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F247")]
	[Address(RVA = "0x229A3FC", Offset = "0x229A3FC", VA = "0x229A3FC", Slot = "31")]
	protected virtual void OnInitSpecialUIElement()
	{
	}

	[Token(Token = "0x600F248")]
	[Address(RVA = "0x229A450", Offset = "0x229A450", VA = "0x229A450", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F249")]
	[Address(RVA = "0x229A714", Offset = "0x229A714", VA = "0x229A714", Slot = "32")]
	protected virtual void OnTokenChanged(object[] data)
	{
	}

	[Token(Token = "0x600F24A")]
	[Address(RVA = "0x229A848", Offset = "0x229A848", VA = "0x229A848")]
	public void SetTokenType(UIHudInGameShopItemViewExt.CoinIconType coinType)
	{
	}

	[Token(Token = "0x600F24B")]
	[Address(RVA = "0x229A9A8", Offset = "0x229A9A8", VA = "0x229A9A8", Slot = "33")]
	protected virtual void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600F24C")]
	[Address(RVA = "0x229AA04", Offset = "0x229AA04", VA = "0x229AA04", Slot = "34")]
	protected virtual void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600F24D")]
	[Address(RVA = "0x229AA58", Offset = "0x229AA58", VA = "0x229AA58", Slot = "35")]
	protected virtual void OnBuySameBtnClick()
	{
	}

	[Token(Token = "0x600F24E")]
	[Address(RVA = "0x229AAAC", Offset = "0x229AAAC", VA = "0x229AAAC", Slot = "36")]
	protected virtual void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600F24F")]
	[Address(RVA = "0x229AB00", Offset = "0x229AB00", VA = "0x229AB00")]
	public void SetCountdownTime(float secs)
	{
	}

	[Token(Token = "0x600F250")]
	[Address(RVA = "0x229AD98", Offset = "0x229AD98", VA = "0x229AD98")]
	private void Update()
	{
	}

	[Token(Token = "0x600F251")]
	[Address(RVA = "0x229AE58", Offset = "0x229AE58", VA = "0x229AE58", Slot = "37")]
	protected virtual void OnPurchaseTimeOut()
	{
	}

	[Token(Token = "0x600F253")]
	[Address(RVA = "0x229AF24", Offset = "0x229AF24", VA = "0x229AF24")]
	public bool IsAutoHideFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x600F254")]
	[Address(RVA = "0x229AF9C", Offset = "0x229AF9C", VA = "0x229AF9C")]
	public void ManullyStopTimerTick()
	{
	}

	[Token(Token = "0x600F255")]
	[Address(RVA = "0x229B014", Offset = "0x229B014", VA = "0x229B014")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F256")]
	[Address(RVA = "0x229B01C", Offset = "0x229B01C", VA = "0x229B01C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F257")]
	[Address(RVA = "0x229B024", Offset = "0x229B024", VA = "0x229B024")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
