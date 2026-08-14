using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2001F83")]
public class UIBigEventChatMsgItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400C5C6")]
	[FieldOffset(Offset = "0x28")]
	private UIBigEventChatMsgItemView m_View;

	[Token(Token = "0x400C5C7")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C5C8")]
	[FieldOffset(Offset = "0x30")]
	private MessageInfo m_MsgInfo;

	[Token(Token = "0x400C5C9")]
	[FieldOffset(Offset = "0x34")]
	private FastBigEventMsg m_BigEventMsgInfo;

	[Token(Token = "0x400C5CA")]
	[FieldOffset(Offset = "0x38")]
	private EBigEventChatMsgType m_CurType;

	[Token(Token = "0x400C5CB")]
	[FieldOffset(Offset = "0x3C")]
	private EChannel.ChannelType m_Channel;

	[Token(Token = "0x400C5CC")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsSelf;

	[Token(Token = "0x400C5CD")]
	[FieldOffset(Offset = "0x41")]
	private bool m_BtnGiveClicked;

	[Token(Token = "0x400C5CE")]
	private const uint MAX_SUB_GROUP_CNT = 2u;

	[Token(Token = "0x400C5CF")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_SenderID;

	[Token(Token = "0x6009C86")]
	[Address(RVA = "0x1412D60", Offset = "0x1412D60", VA = "0x1412D60")]
	public UIBigEventChatMsgItemController()
	{
	}

	[Token(Token = "0x6009C87")]
	[Address(RVA = "0x1412DEC", Offset = "0x1412DEC", VA = "0x1412DEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009C88")]
	[Address(RVA = "0x1412E94", Offset = "0x1412E94", VA = "0x1412E94", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009C89")]
	[Address(RVA = "0x14131B8", Offset = "0x14131B8", VA = "0x14131B8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009C8A")]
	[Address(RVA = "0x14078D0", Offset = "0x14078D0", VA = "0x14078D0")]
	public void SetViewData(MessageInfo msgInfo, bool isSelf, EChannel.ChannelType channel, ulong senderID = 0uL)
	{
	}

	[Token(Token = "0x6009C8B")]
	[Address(RVA = "0x141321C", Offset = "0x141321C", VA = "0x141321C")]
	private void SetJumpsuit2BView(string serializedInfo)
	{
	}

	[Token(Token = "0x6009C8C")]
	[Address(RVA = "0x1413738", Offset = "0x1413738", VA = "0x1413738")]
	private void OnBtnJoinClick()
	{
	}

	[Token(Token = "0x6009C8D")]
	[Address(RVA = "0x1413D30", Offset = "0x1413D30", VA = "0x1413D30")]
	private void OnBtnGiveClick()
	{
	}

	[Token(Token = "0x6009C8E")]
	[Address(RVA = "0x1413E20", Offset = "0x1413E20", VA = "0x1413E20")]
	private void SendGiveMsg()
	{
	}

	[Token(Token = "0x6009C8F")]
	[Address(RVA = "0x1413FA0", Offset = "0x1413FA0", VA = "0x1413FA0")]
	private void OnBtnNavigateClick()
	{
	}

	[Token(Token = "0x6009C90")]
	[Address(RVA = "0x1413FF4", Offset = "0x1413FF4", VA = "0x1413FF4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009C91")]
	[Address(RVA = "0x1414068", Offset = "0x1414068", VA = "0x1414068", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009C92")]
	[Address(RVA = "0x14140CC", Offset = "0x14140CC", VA = "0x14140CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009C93")]
	[Address(RVA = "0x14140D4", Offset = "0x14140D4", VA = "0x14140D4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
