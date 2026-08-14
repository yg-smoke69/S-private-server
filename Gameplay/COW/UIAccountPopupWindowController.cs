using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002495")]
public class UIAccountPopupWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002496")]
	private enum State
	{
		[Token(Token = "0x400E2C9")]
		Register,
		[Token(Token = "0x400E2CA")]
		Login
	}

	[Token(Token = "0x400E2C5")]
	[FieldOffset(Offset = "0x48")]
	private UIAccountPopupWindowView m_View;

	[Token(Token = "0x400E2C6")]
	[FieldOffset(Offset = "0x4C")]
	private State _State;

	[Token(Token = "0x400E2C7")]
	[FieldOffset(Offset = "0x50")]
	private bool m_SavePassward;

	[Token(Token = "0x600D0FC")]
	[Address(RVA = "0x29FECBC", Offset = "0x29FECBC", VA = "0x29FECBC")]
	public UIAccountPopupWindowController()
	{
	}

	[Token(Token = "0x600D0FD")]
	[Address(RVA = "0x29FECCC", Offset = "0x29FECCC", VA = "0x29FECCC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D0FE")]
	[Address(RVA = "0x29FED74", Offset = "0x29FED74", VA = "0x29FED74", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D0FF")]
	[Address(RVA = "0x2A00010", Offset = "0x2A00010", VA = "0x2A00010", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D100")]
	[Address(RVA = "0x2A00140", Offset = "0x2A00140", VA = "0x2A00140")]
	private void OnLeftButtonClick()
	{
	}

	[Token(Token = "0x600D101")]
	[Address(RVA = "0x2A00194", Offset = "0x2A00194", VA = "0x2A00194")]
	private void OnRightButtonClick()
	{
	}

	[Token(Token = "0x600D102")]
	[Address(RVA = "0x29FF0FC", Offset = "0x29FF0FC", VA = "0x29FF0FC")]
	private void ToggleState(State state)
	{
	}

	[Token(Token = "0x600D103")]
	[Address(RVA = "0x29FFCD0", Offset = "0x29FFCD0", VA = "0x29FFCD0")]
	public void RefreshRegionLabel()
	{
	}

	[Token(Token = "0x600D104")]
	[Address(RVA = "0x2A001E8", Offset = "0x2A001E8", VA = "0x2A001E8", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D105")]
	[Address(RVA = "0x2A0027C", Offset = "0x2A0027C", VA = "0x2A0027C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D106")]
	[Address(RVA = "0x2A0031C", Offset = "0x2A0031C", VA = "0x2A0031C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D107")]
	[Address(RVA = "0x2A00324", Offset = "0x2A00324", VA = "0x2A00324")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
