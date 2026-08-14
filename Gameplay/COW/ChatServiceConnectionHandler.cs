using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2000D5A")]
internal class ChatServiceConnectionHandler : ServiceConnectionHandler
{
	[Token(Token = "0x4006B89")]
	[FieldOffset(Offset = "0x24")]
	private UIModelChat m_ChatModel;

	[Token(Token = "0x4006B8A")]
	[FieldOffset(Offset = "0x28")]
	private ulong m_ReservationReachLimitTime;

	[Token(Token = "0x600663B")]
	[Address(RVA = "0x17231A4", Offset = "0x17231A4", VA = "0x17231A4")]
	public ChatServiceConnectionHandler(string token)
	{
	}

	[Token(Token = "0x600663C")]
	[Address(RVA = "0x1723364", Offset = "0x1723364", VA = "0x1723364", Slot = "11")]
	public override EServiceHandler GetServiceHandlerName()
	{
		return default(EServiceHandler);
	}

	[Token(Token = "0x600663D")]
	[Address(RVA = "0x17233BC", Offset = "0x17233BC", VA = "0x17233BC")]
	private void OnRecvChannelMessage(MessageNotify res)
	{
	}

	[Token(Token = "0x600663E")]
	[Address(RVA = "0x1724414", Offset = "0x1724414", VA = "0x1724414")]
	private void OnRecvChatNty(MessageNotify res)
	{
	}

	[Token(Token = "0x600663F")]
	[Address(RVA = "0x1724708", Offset = "0x1724708", VA = "0x1724708", Slot = "10")]
	protected override void OnServerConfirmed(TCPEmptyMessage res)
	{
	}

	[Token(Token = "0x6006640")]
	[Address(RVA = "0x1724780", Offset = "0x1724780", VA = "0x1724780", Slot = "9")]
	public override void OnDisconnected(DisconnectedReason reason)
	{
	}

	[Token(Token = "0x6006641")]
	[Address(RVA = "0x17247F8", Offset = "0x17247F8", VA = "0x17247F8")]
	private void LeaveAllChannels()
	{
	}

	[Token(Token = "0x6006642")]
	[Address(RVA = "0x1723E9C", Offset = "0x1723E9C", VA = "0x1723E9C")]
	private void JoinChannels()
	{
	}

	[Token(Token = "0x6006643")]
	[Address(RVA = "0x1724DA4", Offset = "0x1724DA4", VA = "0x1724DA4")]
	public EServiceHandler _003C_003EiFixBaseProxy_GetServiceHandlerName()
	{
		return default(EServiceHandler);
	}

	[Token(Token = "0x6006644")]
	[Address(RVA = "0x1724DAC", Offset = "0x1724DAC", VA = "0x1724DAC")]
	public void _003C_003EiFixBaseProxy_OnServerConfirmed(TCPEmptyMessage P0)
	{
	}

	[Token(Token = "0x6006645")]
	[Address(RVA = "0x1724DB4", Offset = "0x1724DB4", VA = "0x1724DB4")]
	public void _003C_003EiFixBaseProxy_OnDisconnected(DisconnectedReason P0)
	{
	}
}
