using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025EA")]
internal class UIElitePassChallengeRewardPreviewWndController : UIPopupWindowController
{
	[Token(Token = "0x400EA60")]
	[FieldOffset(Offset = "0x48")]
	private UIElitePassChallengeRewardPreviewWndView m_View;

	[Token(Token = "0x600DF7B")]
	[Address(RVA = "0x2A51C0C", Offset = "0x2A51C0C", VA = "0x2A51C0C")]
	public UIElitePassChallengeRewardPreviewWndController()
	{
	}

	[Token(Token = "0x600DF7C")]
	[Address(RVA = "0x2A51C14", Offset = "0x2A51C14", VA = "0x2A51C14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DF7D")]
	[Address(RVA = "0x2A51CBC", Offset = "0x2A51CBC", VA = "0x2A51CBC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DF7E")]
	[Address(RVA = "0x2A4BA50", Offset = "0x2A4BA50", VA = "0x2A4BA50")]
	public void SetRewardView(List<BaseItemInfo> itemList)
	{
	}

	[Token(Token = "0x600DF7F")]
	[Address(RVA = "0x2A51D78", Offset = "0x2A51D78", VA = "0x2A51D78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
