using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F97")]
internal class NetworkStats : SingletonModule<NetworkStats>
{
	[Token(Token = "0x401ACAB")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003CTotalPacketSent_003Ek__BackingField;

	[Token(Token = "0x401ACAC")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003CTotalRUDPPacketSent_003Ek__BackingField;

	[Token(Token = "0x401ACAD")]
	[FieldOffset(Offset = "0x20")]
	private ulong _003CTotalRUDPPacketResent_003Ek__BackingField;

	[Token(Token = "0x17001C42")]
	public ulong TotalPacketSent
	{
		[Token(Token = "0x6019E00")]
		[Address(RVA = "0x2979E28", Offset = "0x2979E28", VA = "0x2979E28")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6019E01")]
		[Address(RVA = "0x2979E30", Offset = "0x2979E30", VA = "0x2979E30")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C43")]
	public ulong TotalRUDPPacketSent
	{
		[Token(Token = "0x6019E02")]
		[Address(RVA = "0x2979E40", Offset = "0x2979E40", VA = "0x2979E40")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6019E03")]
		[Address(RVA = "0x2979E48", Offset = "0x2979E48", VA = "0x2979E48")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C44")]
	public ulong TotalRUDPPacketResent
	{
		[Token(Token = "0x6019E04")]
		[Address(RVA = "0x2979E58", Offset = "0x2979E58", VA = "0x2979E58")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6019E05")]
		[Address(RVA = "0x2979E60", Offset = "0x2979E60", VA = "0x2979E60")]
		private set
		{
		}
	}

	[Token(Token = "0x6019DFF")]
	[Address(RVA = "0x2979D98", Offset = "0x2979D98", VA = "0x2979D98")]
	public NetworkStats()
	{
	}

	[Token(Token = "0x6019E06")]
	[Address(RVA = "0x2979E70", Offset = "0x2979E70", VA = "0x2979E70")]
	public void PacketSent(bool isReliable)
	{
	}

	[Token(Token = "0x6019E07")]
	[Address(RVA = "0x2979EA0", Offset = "0x2979EA0", VA = "0x2979EA0")]
	public void PacketResent()
	{
	}

	[Token(Token = "0x6019E08")]
	[Address(RVA = "0x2979EE0", Offset = "0x2979EE0", VA = "0x2979EE0")]
	public void Clear()
	{
	}

	[Token(Token = "0x6019E09")]
	[Address(RVA = "0x2979EFC", Offset = "0x2979EFC", VA = "0x2979EFC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6019E0A")]
	[Address(RVA = "0x2979F00", Offset = "0x2979F00", VA = "0x2979F00", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
