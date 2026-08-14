using System.Collections.Generic;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002815")]
public class UIHudQuickChatContainerController : UIBaseController
{
	[Token(Token = "0x400F76F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudQuickChatContainerView m_View;

	[Token(Token = "0x400F770")]
	[FieldOffset(Offset = "0x2C")]
	private List<QuickChatShowItem> m_ShowQueue;

	[Token(Token = "0x400F771")]
	[FieldOffset(Offset = "0x30")]
	private Queue<QuickChatView> m_LabelPool;

	[Token(Token = "0x400F772")]
	[FieldOffset(Offset = "0x34")]
	private uint m_UpdateCallID;

	[Token(Token = "0x400F773")]
	[FieldOffset(Offset = "0x38")]
	private int m_BGOrigHeight;

	[Token(Token = "0x400F774")]
	[FieldOffset(Offset = "0x3C")]
	private StringBuilder m_SoundResource;

	[Token(Token = "0x400F775")]
	[FieldOffset(Offset = "0x40")]
	private List<PraiseKeyData> m_PraiseKeyDataList;

	[Token(Token = "0x400F776")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsGuildWarMode;

	[Token(Token = "0x400F777")]
	[FieldOffset(Offset = "0x48")]
	private uint m_uMutliThumbHideDelayCallID;

	[Token(Token = "0x400F778")]
	[FieldOffset(Offset = "0x4C")]
	private int m_nMutliThumbTimes;

	[Token(Token = "0x600F986")]
	[Address(RVA = "0x1FC6764", Offset = "0x1FC6764", VA = "0x1FC6764")]
	public UIHudQuickChatContainerController()
	{
	}

	[Token(Token = "0x600F987")]
	[Address(RVA = "0x1FC6874", Offset = "0x1FC6874", VA = "0x1FC6874", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F988")]
	[Address(RVA = "0x1FC7054", Offset = "0x1FC7054", VA = "0x1FC7054", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F989")]
	[Address(RVA = "0x1FC71FC", Offset = "0x1FC71FC", VA = "0x1FC71FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F98A")]
	[Address(RVA = "0x1FC72A0", Offset = "0x1FC72A0", VA = "0x1FC72A0")]
	private void OnRecvQuickChat(object[] data)
	{
	}

	[Token(Token = "0x600F98B")]
	[Address(RVA = "0x1FC902C", Offset = "0x1FC902C", VA = "0x1FC902C")]
	private void UpdateMutliThumb()
	{
	}

	[Token(Token = "0x600F98C")]
	[Address(RVA = "0x1FC956C", Offset = "0x1FC956C", VA = "0x1FC956C")]
	private void WaitAndHideMutliThumbTimes()
	{
	}

	[Token(Token = "0x600F98D")]
	[Address(RVA = "0x1FC9628", Offset = "0x1FC9628", VA = "0x1FC9628")]
	private void UpdateQuickChatShow()
	{
	}

	[Token(Token = "0x600F98E")]
	[Address(RVA = "0x1FC9988", Offset = "0x1FC9988", VA = "0x1FC9988")]
	private void UpdateQuickChatHelpPurchaseShow(object[] data)
	{
	}

	[Token(Token = "0x600F98F")]
	[Address(RVA = "0x1FC92C4", Offset = "0x1FC92C4", VA = "0x1FC92C4")]
	private void ResetPositionAndScrollToBottom()
	{
	}

	[Token(Token = "0x600F990")]
	[Address(RVA = "0x1FC6EA4", Offset = "0x1FC6EA4", VA = "0x1FC6EA4")]
	private string GetGuildWarTeamIconSpriteNameByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600F991")]
	[Address(RVA = "0x1FCA214", Offset = "0x1FCA214", VA = "0x1FCA214")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F992")]
	[Address(RVA = "0x1FCA21C", Offset = "0x1FCA21C", VA = "0x1FCA21C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
