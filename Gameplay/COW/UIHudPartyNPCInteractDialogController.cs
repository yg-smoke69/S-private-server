using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200227E")]
internal class UIHudPartyNPCInteractDialogController : UIBaseController
{
	[Token(Token = "0x400D7E9")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPartyNPCInteractDialogView m_View;

	[Token(Token = "0x400D7EA")]
	[FieldOffset(Offset = "0x2C")]
	private OENEFEGDAFP m_CurNode;

	[Token(Token = "0x400D7EB")]
	[FieldOffset(Offset = "0x30")]
	private uint m_CurChatNPCID;

	[Token(Token = "0x400D7EC")]
	[FieldOffset(Offset = "0x34")]
	private List<UIHudPartyNPCInteractReactItemController> m_ResponseCtrlList;

	[Token(Token = "0x600BD1D")]
	[Address(RVA = "0x1844240", Offset = "0x1844240", VA = "0x1844240")]
	public UIHudPartyNPCInteractDialogController()
	{
	}

	[Token(Token = "0x600BD1E")]
	[Address(RVA = "0x18442F8", Offset = "0x18442F8", VA = "0x18442F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BD1F")]
	[Address(RVA = "0x18443A0", Offset = "0x18443A0", VA = "0x18443A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BD20")]
	[Address(RVA = "0x1844590", Offset = "0x1844590", VA = "0x1844590", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600BD21")]
	[Address(RVA = "0x18446C4", Offset = "0x18446C4", VA = "0x18446C4")]
	public void HideSelf()
	{
	}

	[Token(Token = "0x600BD22")]
	[Address(RVA = "0x1844B94", Offset = "0x1844B94", VA = "0x1844B94")]
	public void StartInteractWithNPC(uint NPCID)
	{
	}

	[Token(Token = "0x600BD23")]
	[Address(RVA = "0x184540C", Offset = "0x184540C", VA = "0x184540C")]
	public void OnPlayerReact(object[] data)
	{
	}

	[Token(Token = "0x600BD24")]
	[Address(RVA = "0x1844CA8", Offset = "0x1844CA8", VA = "0x1844CA8")]
	private void SetUIForNode(OENEFEGDAFP node)
	{
	}

	[Token(Token = "0x600BD25")]
	[Address(RVA = "0x18457E8", Offset = "0x18457E8", VA = "0x18457E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BD26")]
	[Address(RVA = "0x18457F0", Offset = "0x18457F0", VA = "0x18457F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
