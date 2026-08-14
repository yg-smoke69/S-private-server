using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D4A")]
public class AkCommunicationSettings : _Attribute
{
	[Token(Token = "0x4019FED")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x4019FEE")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x170019EF")]
	public uint uPoolSize
	{
		[Token(Token = "0x6018840")]
		[Address(RVA = "0x35D1510", Offset = "0x35D1510", VA = "0x35D1510")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601883F")]
		[Address(RVA = "0x35D01B0", Offset = "0x35D01B0", VA = "0x35D01B0")]
		set
		{
		}
	}

	[Token(Token = "0x170019F0")]
	public ushort uDiscoveryBroadcastPort
	{
		[Token(Token = "0x6018842")]
		[Address(RVA = "0x35D1598", Offset = "0x35D1598", VA = "0x35D1598")]
		get
		{
			return default(ushort);
		}
		[Token(Token = "0x6018841")]
		[Address(RVA = "0x35D0240", Offset = "0x35D0240", VA = "0x35D0240")]
		set
		{
		}
	}

	[Token(Token = "0x170019F1")]
	public ushort uCommandPort
	{
		[Token(Token = "0x6018844")]
		[Address(RVA = "0x35D1620", Offset = "0x35D1620", VA = "0x35D1620")]
		get
		{
			return default(ushort);
		}
		[Token(Token = "0x6018843")]
		[Address(RVA = "0x35D02D0", Offset = "0x35D02D0", VA = "0x35D02D0")]
		set
		{
		}
	}

	[Token(Token = "0x170019F2")]
	public ushort uNotificationPort
	{
		[Token(Token = "0x6018846")]
		[Address(RVA = "0x35D16A8", Offset = "0x35D16A8", VA = "0x35D16A8")]
		get
		{
			return default(ushort);
		}
		[Token(Token = "0x6018845")]
		[Address(RVA = "0x35D0360", Offset = "0x35D0360", VA = "0x35D0360")]
		set
		{
		}
	}

	[Token(Token = "0x170019F3")]
	public bool bInitSystemLib
	{
		[Token(Token = "0x6018848")]
		[Address(RVA = "0x35D1730", Offset = "0x35D1730", VA = "0x35D1730")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6018847")]
		[Address(RVA = "0x35D03F0", Offset = "0x35D03F0", VA = "0x35D03F0")]
		set
		{
		}
	}

	[Token(Token = "0x170019F4")]
	public string szAppNetworkName
	{
		[Token(Token = "0x601884A")]
		[Address(RVA = "0x35D17B8", Offset = "0x35D17B8", VA = "0x35D17B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018849")]
		[Address(RVA = "0x35D0480", Offset = "0x35D0480", VA = "0x35D0480")]
		set
		{
		}
	}

	[Token(Token = "0x6018839")]
	[Address(RVA = "0x35D12C4", Offset = "0x35D12C4", VA = "0x35D12C4")]
	internal AkCommunicationSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x601883A")]
	[Address(RVA = "0x35C992C", Offset = "0x35C992C", VA = "0x35C992C")]
	public AkCommunicationSettings()
	{
	}

	[Token(Token = "0x601883B")]
	[Address(RVA = "0x35D12EC", Offset = "0x35D12EC", VA = "0x35D12EC")]
	internal static IntPtr getCPtr(AkCommunicationSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x601883C")]
	[Address(RVA = "0x35D1344", Offset = "0x35D1344", VA = "0x35D1344", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x601883D")]
	[Address(RVA = "0x35D1370", Offset = "0x35D1370", VA = "0x35D1370", Slot = "1")]
	~AkCommunicationSettings()
	{
	}

	[Token(Token = "0x601883E")]
	[Address(RVA = "0x35D13E4", Offset = "0x35D13E4", VA = "0x35D13E4", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
