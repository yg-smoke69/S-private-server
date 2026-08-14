using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2003DD1")]
public class AkCommonCommSettings : AkSettingsValidationHandler
{
	[Token(Token = "0x401A421")]
	[FieldOffset(Offset = "0x8")]
	public uint m_PoolSize;

	[Token(Token = "0x401A422")]
	[FieldOffset(Offset = "0x0")]
	public static ushort DefaultDiscoveryBroadcastPort;

	[Token(Token = "0x401A423")]
	[FieldOffset(Offset = "0xC")]
	public ushort m_DiscoveryBroadcastPort;

	[Token(Token = "0x401A424")]
	[FieldOffset(Offset = "0xE")]
	public ushort m_CommandPort;

	[Token(Token = "0x401A425")]
	[FieldOffset(Offset = "0x10")]
	public ushort m_NotificationPort;

	[Token(Token = "0x401A426")]
	[FieldOffset(Offset = "0x12")]
	public bool m_InitializeSystemComms;

	[Token(Token = "0x401A427")]
	[FieldOffset(Offset = "0x14")]
	public string m_NetworkName;

	[Token(Token = "0x601928D")]
	[Address(RVA = "0x35CFF88", Offset = "0x35CFF88", VA = "0x35CFF88")]
	public AkCommonCommSettings()
	{
	}

	[Token(Token = "0x601928E")]
	[Address(RVA = "0x35D0038", Offset = "0x35D0038", VA = "0x35D0038", Slot = "5")]
	public virtual void CopyTo(AkCommunicationSettings settings)
	{
	}
}
