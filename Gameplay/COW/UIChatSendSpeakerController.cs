using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002514")]
public class UIChatSendSpeakerController : UIPopupWindowController
{
	[Token(Token = "0x400E60D")]
	[FieldOffset(Offset = "0x48")]
	private UIChatSendSpeakerView m_View;

	[Token(Token = "0x400E60E")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChat m_Model;

	[Token(Token = "0x400E60F")]
	[FieldOffset(Offset = "0x50")]
	private uint m_WorldCDCallID;

	[Token(Token = "0x400E610")]
	[FieldOffset(Offset = "0x54")]
	private StringBuilder m_WorldCDText;

	[Token(Token = "0x600D73F")]
	[Address(RVA = "0x207A258", Offset = "0x207A258", VA = "0x207A258")]
	public UIChatSendSpeakerController()
	{
	}

	[Token(Token = "0x600D740")]
	[Address(RVA = "0x207A260", Offset = "0x207A260", VA = "0x207A260")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D741")]
	[Address(RVA = "0x207A304", Offset = "0x207A304", VA = "0x207A304", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D742")]
	[Address(RVA = "0x207B030", Offset = "0x207B030", VA = "0x207B030", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D743")]
	[Address(RVA = "0x207A934", Offset = "0x207A934", VA = "0x207A934")]
	private void OnValueChange()
	{
	}

	[Token(Token = "0x600D744")]
	[Address(RVA = "0x207B114", Offset = "0x207B114", VA = "0x207B114")]
	private void OnSendEnter()
	{
	}

	[Token(Token = "0x600D745")]
	[Address(RVA = "0x207B4A8", Offset = "0x207B4A8", VA = "0x207B4A8")]
	protected char OnInputValidate(string text, int charIndex, char addedChar)
	{
		return default(char);
	}

	[Token(Token = "0x600D746")]
	[Address(RVA = "0x207ACF0", Offset = "0x207ACF0", VA = "0x207ACF0")]
	private void RefreshDefaultInputValue()
	{
	}

	[Token(Token = "0x600D747")]
	[Address(RVA = "0x207B548", Offset = "0x207B548", VA = "0x207B548")]
	private void ResetDefaultInputValue()
	{
	}

	[Token(Token = "0x600D748")]
	[Address(RVA = "0x207BBD8", Offset = "0x207BBD8", VA = "0x207BBD8")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600D749")]
	[Address(RVA = "0x207BBDC", Offset = "0x207BBDC", VA = "0x207BBDC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D74A")]
	[Address(RVA = "0x207BBE4", Offset = "0x207BBE4", VA = "0x207BBE4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
