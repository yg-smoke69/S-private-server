using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002836")]
public class UIHudResponseChatBtnController : UIBaseController
{
	[Token(Token = "0x400F817")]
	[FieldOffset(Offset = "0x28")]
	private UIHudResponseChatBtnView m_View;

	[Token(Token = "0x400F818")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DisappearCallID;

	[Token(Token = "0x400F819")]
	[FieldOffset(Offset = "0x30")]
	private uint m_ResponseChatID;

	[Token(Token = "0x400F81A")]
	[FieldOffset(Offset = "0x38")]
	private IHAAMHPPLMG m_PlayerID;

	[Token(Token = "0x600FAD3")]
	[Address(RVA = "0x13F21FC", Offset = "0x13F21FC", VA = "0x13F21FC")]
	public UIHudResponseChatBtnController()
	{
	}

	[Token(Token = "0x600FAD4")]
	[Address(RVA = "0x13F22DC", Offset = "0x13F22DC", VA = "0x13F22DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FAD5")]
	[Address(RVA = "0x13F2380", Offset = "0x13F2380", VA = "0x13F2380", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FAD6")]
	[Address(RVA = "0x13F2584", Offset = "0x13F2584", VA = "0x13F2584", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FAD7")]
	[Address(RVA = "0x13F26B8", Offset = "0x13F26B8", VA = "0x13F26B8")]
	private void OnRecvQuickChatMsg(object[] data)
	{
	}

	[Token(Token = "0x600FAD8")]
	[Address(RVA = "0x13F2B88", Offset = "0x13F2B88", VA = "0x13F2B88")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600FAD9")]
	[Address(RVA = "0x13F30E4", Offset = "0x13F30E4", VA = "0x13F30E4")]
	private void _003COnRecvQuickChatMsg_003Em__0()
	{
	}

	[Token(Token = "0x600FADA")]
	[Address(RVA = "0x13F3114", Offset = "0x13F3114", VA = "0x13F3114")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FADB")]
	[Address(RVA = "0x13F311C", Offset = "0x13F311C", VA = "0x13F311C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
