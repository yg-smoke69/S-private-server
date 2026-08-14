using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2001DC4")]
internal class ServiceConnectionManager : SingletonModule<ServiceConnectionManager>
{
	[Token(Token = "0x400BC7C")]
	[FieldOffset(Offset = "0xC")]
	private LobbyServiceConnectionHandler m_LobbyServiceConnection;

	[Token(Token = "0x400BC7D")]
	[FieldOffset(Offset = "0x10")]
	private ChatServiceConnectionHandler m_ChatServiceConnection;

	[Token(Token = "0x6008E02")]
	[Address(RVA = "0x20E0F74", Offset = "0x20E0F74", VA = "0x20E0F74")]
	public ServiceConnectionManager()
	{
	}

	[Token(Token = "0x6008E03")]
	[Address(RVA = "0x20E1004", Offset = "0x20E1004", VA = "0x20E1004", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6008E04")]
	[Address(RVA = "0x20E1058", Offset = "0x20E1058", VA = "0x20E1058", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6008E05")]
	[Address(RVA = "0x20E1140", Offset = "0x20E1140", VA = "0x20E1140")]
	public bool ConnectToLobbyService(string url)
	{
		return default(bool);
	}

	[Token(Token = "0x6008E06")]
	[Address(RVA = "0x20E1360", Offset = "0x20E1360", VA = "0x20E1360")]
	public bool ConnectToChatService(string url)
	{
		return default(bool);
	}

	[Token(Token = "0x6008E07")]
	[Address(RVA = "0x20E1580", Offset = "0x20E1580", VA = "0x20E1580")]
	public bool IsServiceConnected()
	{
		return default(bool);
	}

	[Token(Token = "0x6008E08")]
	[Address(RVA = "0x20E15F0", Offset = "0x20E15F0", VA = "0x20E15F0")]
	public bool IsChatServiceConnected()
	{
		return default(bool);
	}

	[Token(Token = "0x6008E09")]
	[Address(RVA = "0x20E1678", Offset = "0x20E1678", VA = "0x20E1678")]
	public bool SendMessageToLobby(EProtocol.Proto cmdType, uint subCmdType, object message, byte regionID = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6008E0A")]
	[Address(RVA = "0x20E1A9C", Offset = "0x20E1A9C", VA = "0x20E1A9C")]
	public bool SendMessageToChatChannel(EProtocol.Proto cmdType, uint subCmdType, object message, byte regionID = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6008E0B")]
	[Address(RVA = "0x20E1C08", Offset = "0x20E1C08", VA = "0x20E1C08")]
	public void Update(float gameTime)
	{
	}

	[Token(Token = "0x6008E0C")]
	[Address(RVA = "0x20E1C8C", Offset = "0x20E1C8C", VA = "0x20E1C8C")]
	public bool NeedLogout()
	{
		return default(bool);
	}

	[Token(Token = "0x6008E0D")]
	[Address(RVA = "0x20E1CFC", Offset = "0x20E1CFC", VA = "0x20E1CFC")]
	public DisconnectedReason GetDisconnectionReason()
	{
		return default(DisconnectedReason);
	}

	[Token(Token = "0x6008E0E")]
	[Address(RVA = "0x20E10B8", Offset = "0x20E10B8", VA = "0x20E10B8")]
	public void Close()
	{
	}

	[Token(Token = "0x6008E0F")]
	[Address(RVA = "0x20E1D6C", Offset = "0x20E1D6C", VA = "0x20E1D6C")]
	public void DebugDisconnect(DisconnectedReason reason)
	{
	}

	[Token(Token = "0x6008E10")]
	[Address(RVA = "0x20E1DEC", Offset = "0x20E1DEC", VA = "0x20E1DEC")]
	public void OnApplicationPause(bool paused)
	{
	}
}
