using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024AD")]
public class UIAvatarLimitExpireController : UIPopupWindowController
{
	[Token(Token = "0x400E341")]
	[FieldOffset(Offset = "0x48")]
	private UIAvatarLimitExpireView m_View;

	[Token(Token = "0x600D202")]
	[Address(RVA = "0x2A87C3C", Offset = "0x2A87C3C", VA = "0x2A87C3C")]
	public UIAvatarLimitExpireController()
	{
	}

	[Token(Token = "0x600D203")]
	[Address(RVA = "0x2A87C44", Offset = "0x2A87C44", VA = "0x2A87C44", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D204")]
	[Address(RVA = "0x2A87DF8", Offset = "0x2A87DF8", VA = "0x2A87DF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D205")]
	[Address(RVA = "0x2A87E9C", Offset = "0x2A87E9C", VA = "0x2A87E9C")]
	public void SetExpireInfo(List<uint> expireAvatars)
	{
	}

	[Token(Token = "0x600D206")]
	[Address(RVA = "0x2A88260", Offset = "0x2A88260", VA = "0x2A88260", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D207")]
	[Address(RVA = "0x2A882C4", Offset = "0x2A882C4", VA = "0x2A882C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D208")]
	[Address(RVA = "0x2A882CC", Offset = "0x2A882CC", VA = "0x2A882CC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
