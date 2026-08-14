using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004060")]
public class NetworkClient
{
	[Token(Token = "0x401B174")]
	[FieldOffset(Offset = "0x8")]
	protected NetworkSession m_Session;

	[Token(Token = "0x401B175")]
	[FieldOffset(Offset = "0xC")]
	protected NetworkMessageDispatcher m_MessageDispatcher;

	[Token(Token = "0x601A34E")]
	[Address(RVA = "0x2968E08", Offset = "0x2968E08", VA = "0x2968E08")]
	public NetworkClient()
	{
	}

	[Token(Token = "0x601A34F")]
	[Address(RVA = "0x296D484", Offset = "0x296D484", VA = "0x296D484")]
	public void SetEnableSimpleInvokeExceptionInfo(bool b)
	{
	}

	[Token(Token = "0x601A350")]
	[Address(RVA = "0x296D4B4", Offset = "0x296D4B4", VA = "0x296D4B4")]
	public bool Connect(string serverAddr, int port)
	{
		return default(bool);
	}

	[Token(Token = "0x601A351")]
	[Address(RVA = "0x296D540", Offset = "0x296D540", VA = "0x296D540")]
	public void Close(bool isSendNotification = true)
	{
	}

	[Token(Token = "0x601A352")]
	[Address(RVA = "0x296D8D0", Offset = "0x296D8D0", VA = "0x296D8D0")]
	public bool IsConnected()
	{
		return default(bool);
	}

	[Token(Token = "0x601A353")]
	public void RegisterHandler<T>(uint cmd, NetworkMessageDispatcher.NetworkMessageHandler<T> handler)
	{
	}

	[Token(Token = "0x601A354")]
	public void UnregisterHandler<T>(uint cmd, NetworkMessageDispatcher.NetworkMessageHandler<T> handler)
	{
	}

	[Token(Token = "0x601A355")]
	[Address(RVA = "0x2968E80", Offset = "0x2968E80", VA = "0x2968E80")]
	protected void RegisterSession(NetworkSession sess)
	{
	}
}
