using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002825")]
public class UIHudRedEnvelopeReceiveController : UIBaseController
{
	[Token(Token = "0x400F7BE")]
	[FieldOffset(Offset = "0x28")]
	private UIHudRedEnvelopeReceiveWindowView m_View;

	[Token(Token = "0x400F7BF")]
	[FieldOffset(Offset = "0x2C")]
	private uint lastLvlObjID;

	[Token(Token = "0x600FA26")]
	[Address(RVA = "0x13DC4EC", Offset = "0x13DC4EC", VA = "0x13DC4EC")]
	public UIHudRedEnvelopeReceiveController()
	{
	}

	[Token(Token = "0x600FA27")]
	[Address(RVA = "0x13DC570", Offset = "0x13DC570", VA = "0x13DC570")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FA28")]
	[Address(RVA = "0x13DC618", Offset = "0x13DC618", VA = "0x13DC618", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FA29")]
	[Address(RVA = "0x13DC9E0", Offset = "0x13DC9E0", VA = "0x13DC9E0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FA2A")]
	[Address(RVA = "0x13DCB7C", Offset = "0x13DCB7C", VA = "0x13DCB7C")]
	private void ShowReceiveWindow(object[] param)
	{
	}

	[Token(Token = "0x600FA2B")]
	[Address(RVA = "0x13DCEA4", Offset = "0x13DCEA4", VA = "0x13DCEA4")]
	private void UpdateUI(LevelRedEnvelope levelRed)
	{
	}

	[Token(Token = "0x600FA2C")]
	[Address(RVA = "0x13DD4B8", Offset = "0x13DD4B8", VA = "0x13DD4B8")]
	private void OnRedEnvelopeReceived(object[] param)
	{
	}

	[Token(Token = "0x600FA2D")]
	[Address(RVA = "0x13DD7F0", Offset = "0x13DD7F0", VA = "0x13DD7F0")]
	private void OnClickOpenButton()
	{
	}

	[Token(Token = "0x600FA2E")]
	[Address(RVA = "0x13DD910", Offset = "0x13DD910", VA = "0x13DD910")]
	private void OnClickReceiveInfo()
	{
	}

	[Token(Token = "0x600FA2F")]
	[Address(RVA = "0x13DE2F4", Offset = "0x13DE2F4", VA = "0x13DE2F4")]
	private void OnClickCloseButton()
	{
	}

	[Token(Token = "0x600FA30")]
	[Address(RVA = "0x13DE360", Offset = "0x13DE360", VA = "0x13DE360")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FA31")]
	[Address(RVA = "0x13DE368", Offset = "0x13DE368", VA = "0x13DE368")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
