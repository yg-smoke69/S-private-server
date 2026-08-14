using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2001DC1")]
internal class ServiceConnectionHandler : _Attribute
{
	[Token(Token = "0x2001DC2")]
	protected class ReconnectInfo
	{
		[Token(Token = "0x400BC75")]
		[FieldOffset(Offset = "0x8")]
		public bool NeedReconnected;

		[Token(Token = "0x400BC76")]
		[FieldOffset(Offset = "0xC")]
		public float NextReconnectTime;

		[Token(Token = "0x400BC77")]
		[FieldOffset(Offset = "0x10")]
		public int ReconnectCount;

		[Token(Token = "0x6008DFF")]
		[Address(RVA = "0x20DF79C", Offset = "0x20DF79C", VA = "0x20DF79C")]
		public ReconnectInfo()
		{
		}

		[Token(Token = "0x6008E00")]
		[Address(RVA = "0x20DFAEC", Offset = "0x20DFAEC", VA = "0x20DFAEC")]
		public void TryReconnect()
		{
		}

		[Token(Token = "0x6008E01")]
		[Address(RVA = "0x20E0058", Offset = "0x20E0058", VA = "0x20E0058")]
		public void Reset(bool isDeep)
		{
		}
	}

	[Token(Token = "0x400BC6E")]
	[FieldOffset(Offset = "0x8")]
	protected ServiceClient m_Client;

	[Token(Token = "0x400BC6F")]
	[FieldOffset(Offset = "0xC")]
	protected string m_Addr;

	[Token(Token = "0x400BC70")]
	[FieldOffset(Offset = "0x10")]
	protected int m_Port;

	[Token(Token = "0x400BC71")]
	[FieldOffset(Offset = "0x14")]
	protected bool m_IsConfirmed;

	[Token(Token = "0x400BC72")]
	[FieldOffset(Offset = "0x18")]
	protected ReconnectInfo m_ReconnectInfo;

	[Token(Token = "0x400BC73")]
	[FieldOffset(Offset = "0x1C")]
	protected bool m_NeedLogout;

	[Token(Token = "0x400BC74")]
	[FieldOffset(Offset = "0x20")]
	protected DisconnectedReason m_DisconnectByServerReason;

	[Token(Token = "0x6008DF0")]
	[Address(RVA = "0x20DF614", Offset = "0x20DF614", VA = "0x20DF614")]
	public ServiceConnectionHandler(string token)
	{
	}

	[Token(Token = "0x6008DF1")]
	[Address(RVA = "0x20DF7A4", Offset = "0x20DF7A4", VA = "0x20DF7A4")]
	public bool Connect(string addr, int port)
	{
		return default(bool);
	}

	[Token(Token = "0x6008DF2")]
	[Address(RVA = "0x20DFE1C", Offset = "0x20DFE1C", VA = "0x20DFE1C")]
	public void Update(float gameTime)
	{
	}

	[Token(Token = "0x6008DF3")]
	[Address(RVA = "0x20E03C4", Offset = "0x20E03C4", VA = "0x20E03C4")]
	public void Close()
	{
	}

	[Token(Token = "0x6008DF4")]
	[Address(RVA = "0x20E0434", Offset = "0x20E0434", VA = "0x20E0434")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6008DF5")]
	[Address(RVA = "0x20E04AC", Offset = "0x20E04AC", VA = "0x20E04AC", Slot = "7")]
	public virtual void OnConnected(bool result)
	{
	}

	[Token(Token = "0x6008DF6")]
	[Address(RVA = "0x20E061C", Offset = "0x20E061C", VA = "0x20E061C", Slot = "8")]
	public virtual void OnPingSent(int lastSentTime)
	{
	}

	[Token(Token = "0x6008DF7")]
	[Address(RVA = "0x20E0678", Offset = "0x20E0678", VA = "0x20E0678", Slot = "9")]
	public virtual void OnDisconnected(DisconnectedReason reason)
	{
	}

	[Token(Token = "0x6008DF8")]
	[Address(RVA = "0x20E0A94", Offset = "0x20E0A94", VA = "0x20E0A94", Slot = "10")]
	protected virtual void OnServerConfirmed(TCPEmptyMessage res)
	{
	}

	[Token(Token = "0x6008DF9")]
	[Address(RVA = "0x20E0CB8", Offset = "0x20E0CB8", VA = "0x20E0CB8")]
	public bool IsConfirmed()
	{
		return default(bool);
	}

	[Token(Token = "0x6008DFA")]
	[Address(RVA = "0x20E0D10", Offset = "0x20E0D10", VA = "0x20E0D10")]
	public bool Send(EProtocol.Proto cmdType, ProtoReq message, byte regionID = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6008DFB")]
	[Address(RVA = "0x20E0DF4", Offset = "0x20E0DF4", VA = "0x20E0DF4")]
	public bool NeedLogout()
	{
		return default(bool);
	}

	[Token(Token = "0x6008DFC")]
	[Address(RVA = "0x20E0E4C", Offset = "0x20E0E4C", VA = "0x20E0E4C")]
	public DisconnectedReason GetDisconnectionReason()
	{
		return default(DisconnectedReason);
	}

	[Token(Token = "0x6008DFD")]
	[Address(RVA = "0x20E0EA4", Offset = "0x20E0EA4", VA = "0x20E0EA4", Slot = "11")]
	public virtual EServiceHandler GetServiceHandlerName()
	{
		return default(EServiceHandler);
	}

	[Token(Token = "0x6008DFE")]
	[Address(RVA = "0x20E0EFC", Offset = "0x20E0EFC", VA = "0x20E0EFC")]
	public void OnApplicationPause(bool paused)
	{
	}
}
