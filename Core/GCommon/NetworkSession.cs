using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200407C")]
public class NetworkSession
{
	[Token(Token = "0x401B1D9")]
	protected const int CONNECT_NONE = 1;

	[Token(Token = "0x401B1DA")]
	protected const int CONNECT_PENDING = 2;

	[Token(Token = "0x401B1DB")]
	protected const int CONNECT_OK = 3;

	[Token(Token = "0x401B1DC")]
	[FieldOffset(Offset = "0x8")]
	protected int m_ConnectState;

	[Token(Token = "0x401B1DD")]
	[FieldOffset(Offset = "0xC")]
	protected bool m_Closed;

	[Token(Token = "0x401B1DE")]
	[FieldOffset(Offset = "0x10")]
	protected int m_JoinTimeout;

	[Token(Token = "0x401B1DF")]
	[FieldOffset(Offset = "0x14")]
	protected ISessionHanlder m_SessionHandler;

	[Token(Token = "0x401B1E0")]
	[FieldOffset(Offset = "0x18")]
	protected Thread m_SendThread;

	[Token(Token = "0x401B1E1")]
	[FieldOffset(Offset = "0x1C")]
	protected Thread m_RecvThread;

	[Token(Token = "0x401B1E2")]
	[FieldOffset(Offset = "0x20")]
	protected AutoResetEvent m_SendSignalEvent;

	[Token(Token = "0x401B1E3")]
	[FieldOffset(Offset = "0x24")]
	protected AutoResetEvent m_RecvSignalEvent;

	[Token(Token = "0x401B1E4")]
	[FieldOffset(Offset = "0x28")]
	protected AutoResetEvent m_NotifySendEvent;

	[Token(Token = "0x401B1E5")]
	[FieldOffset(Offset = "0x2C")]
	protected object m_CloseRequiredLock;

	[Token(Token = "0x401B1E6")]
	[FieldOffset(Offset = "0x30")]
	protected bool m_HasCloseRequired;

	[Token(Token = "0x401B1E7")]
	[FieldOffset(Offset = "0x34")]
	protected DisconnectedReason m_DisconnectedReason;

	[Token(Token = "0x601A3A5")]
	[Address(RVA = "0x2979A1C", Offset = "0x2979A1C", VA = "0x2979A1C")]
	public NetworkSession([Optional] ISessionHanlder cb)
	{
	}

	[Token(Token = "0x601A3A6")]
	[Address(RVA = "0x2979AB0", Offset = "0x2979AB0", VA = "0x2979AB0", Slot = "4")]
	public virtual bool IsConnected()
	{
		return default(bool);
	}

	[Token(Token = "0x601A3A7")]
	[Address(RVA = "0x296D530", Offset = "0x296D530", VA = "0x296D530")]
	public bool Connect(string serverAddr, int port)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3A8")]
	[Address(RVA = "0x2968FD8", Offset = "0x2968FD8", VA = "0x2968FD8")]
	public void Update()
	{
	}

	[Token(Token = "0x601A3A9")]
	[Address(RVA = "0x296D550", Offset = "0x296D550", VA = "0x296D550")]
	public void Close(bool isSendNotification = true)
	{
	}

	[Token(Token = "0x601A3AA")]
	[Address(RVA = "0x2979AC4", Offset = "0x2979AC4", VA = "0x2979AC4")]
	protected void RequestCloseSession(DisconnectedReason reason = DisconnectedReason.Unknown)
	{
	}

	[Token(Token = "0x601A3AB")]
	[Address(RVA = "0x2979B80", Offset = "0x2979B80", VA = "0x2979B80", Slot = "5")]
	protected virtual bool OnConnect(string serverAddr, int port)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3AC")]
	[Address(RVA = "0x2979B88", Offset = "0x2979B88", VA = "0x2979B88", Slot = "6")]
	protected virtual void OnUpdate()
	{
	}

	[Token(Token = "0x601A3AD")]
	[Address(RVA = "0x2979B8C", Offset = "0x2979B8C", VA = "0x2979B8C", Slot = "7")]
	protected virtual void OnClose()
	{
	}

	[Token(Token = "0x601A3AE")]
	[Address(RVA = "0x2979B90", Offset = "0x2979B90", VA = "0x2979B90")]
	protected void CreateRecvThread(ThreadStart threadFunc)
	{
	}

	[Token(Token = "0x601A3AF")]
	[Address(RVA = "0x2979C94", Offset = "0x2979C94", VA = "0x2979C94")]
	protected void CreateSendThread(ThreadStart threadFunc)
	{
	}
}
