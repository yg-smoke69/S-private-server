using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20012C0")]
internal class MobileMatchGameClient : MatchGameClient
{
	[Token(Token = "0x40083A7")]
	[FieldOffset(Offset = "0x30")]
	private MobileReplayManager m_ReplayMgr;

	[Token(Token = "0x6007A31")]
	[Address(RVA = "0x22770B8", Offset = "0x22770B8", VA = "0x22770B8")]
	public MobileMatchGameClient(ISessionHanlder sessionHanlder)
	{
	}

	[Token(Token = "0x6007A32")]
	[Address(RVA = "0x2277238", Offset = "0x2277238", VA = "0x2277238", Slot = "9")]
	public override void OnConnected(bool result)
	{
	}

	[Token(Token = "0x6007A33")]
	[Address(RVA = "0x22772CC", Offset = "0x22772CC", VA = "0x22772CC", Slot = "10")]
	public override void OnDisconnected(DisconnectedReason reason)
	{
	}

	[Token(Token = "0x6007A34")]
	[Address(RVA = "0x2277360", Offset = "0x2277360", VA = "0x2277360", Slot = "11")]
	public override void OnPingSent(int lastSentTime)
	{
	}

	[Token(Token = "0x6007A35")]
	[Address(RVA = "0x22773F4", Offset = "0x22773F4", VA = "0x22773F4", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6007A36")]
	[Address(RVA = "0x2277494", Offset = "0x2277494", VA = "0x2277494", Slot = "8")]
	public override bool Send(uint messageID, UDPClientMessageBase msg, byte sendOption = 0, bool cacheMsgAnyWay = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A37")]
	[Address(RVA = "0x2277564", Offset = "0x2277564", VA = "0x2277564", Slot = "12")]
	protected override void HandleRecvPacket()
	{
	}

	[Token(Token = "0x6007A38")]
	[Address(RVA = "0x22787E0", Offset = "0x22787E0", VA = "0x22787E0")]
	public void _003C_003EiFixBaseProxy_OnConnected(bool P0)
	{
	}

	[Token(Token = "0x6007A39")]
	[Address(RVA = "0x22787E8", Offset = "0x22787E8", VA = "0x22787E8")]
	public void _003C_003EiFixBaseProxy_OnDisconnected(DisconnectedReason P0)
	{
	}

	[Token(Token = "0x6007A3A")]
	[Address(RVA = "0x22787F0", Offset = "0x22787F0", VA = "0x22787F0")]
	public void _003C_003EiFixBaseProxy_OnPingSent(int P0)
	{
	}

	[Token(Token = "0x6007A3B")]
	[Address(RVA = "0x22787F8", Offset = "0x22787F8", VA = "0x22787F8")]
	public void _003C_003EiFixBaseProxy_Update()
	{
	}

	[Token(Token = "0x6007A3C")]
	[Address(RVA = "0x2278800", Offset = "0x2278800", VA = "0x2278800")]
	public bool _003C_003EiFixBaseProxy_Send(uint P0, UDPClientMessageBase P1, byte P2, bool P3)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A3D")]
	[Address(RVA = "0x2278824", Offset = "0x2278824", VA = "0x2278824")]
	public void _003C_003EiFixBaseProxy_HandleRecvPacket()
	{
	}
}
