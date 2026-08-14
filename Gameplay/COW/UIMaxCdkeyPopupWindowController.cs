using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029B9")]
public class UIMaxCdkeyPopupWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x40100C9")]
	[FieldOffset(Offset = "0x48")]
	private UIMaxCdkeyPopupWindowView m_View;

	[Token(Token = "0x40100CA")]
	[FieldOffset(Offset = "0x4C")]
	private string websiteUrl;

	[Token(Token = "0x6010C46")]
	[Address(RVA = "0x26914CC", Offset = "0x26914CC", VA = "0x26914CC")]
	public UIMaxCdkeyPopupWindowController()
	{
	}

	[Token(Token = "0x6010C47")]
	[Address(RVA = "0x26914D4", Offset = "0x26914D4", VA = "0x26914D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010C48")]
	[Address(RVA = "0x2691578", Offset = "0x2691578", VA = "0x2691578", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010C49")]
	[Address(RVA = "0x2691898", Offset = "0x2691898", VA = "0x2691898", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010C4A")]
	[Address(RVA = "0x26919C8", Offset = "0x26919C8", VA = "0x26919C8")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x6010C4B")]
	[Address(RVA = "0x2691DEC", Offset = "0x2691DEC", VA = "0x2691DEC")]
	private void OnUrlClick()
	{
	}

	[Token(Token = "0x6010C4C")]
	[Address(RVA = "0x2691EFC", Offset = "0x2691EFC", VA = "0x2691EFC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010C4D")]
	[Address(RVA = "0x2692504", Offset = "0x2692504", VA = "0x2692504", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010C4E")]
	[Address(RVA = "0x2692598", Offset = "0x2692598", VA = "0x2692598")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010C4F")]
	[Address(RVA = "0x26925A0", Offset = "0x26925A0", VA = "0x26925A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
