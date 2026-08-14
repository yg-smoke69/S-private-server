using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D95")]
public class AkOutputSettings : _Attribute
{
	[Token(Token = "0x401A2EA")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A2EB")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001ACD")]
	public uint audioDeviceShareset
	{
		[Token(Token = "0x60190C8")]
		[Address(RVA = "0x36BDC44", Offset = "0x36BDC44", VA = "0x36BDC44")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60190C7")]
		[Address(RVA = "0x36BDBB4", Offset = "0x36BDBB4", VA = "0x36BDBB4")]
		set
		{
		}
	}

	[Token(Token = "0x17001ACE")]
	public uint idDevice
	{
		[Token(Token = "0x60190CA")]
		[Address(RVA = "0x36BDD5C", Offset = "0x36BDD5C", VA = "0x36BDD5C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60190C9")]
		[Address(RVA = "0x36BDCCC", Offset = "0x36BDCCC", VA = "0x36BDCCC")]
		set
		{
		}
	}

	[Token(Token = "0x17001ACF")]
	public AkPanningRule ePanningRule
	{
		[Token(Token = "0x60190CC")]
		[Address(RVA = "0x36BDE74", Offset = "0x36BDE74", VA = "0x36BDE74")]
		get
		{
			return default(AkPanningRule);
		}
		[Token(Token = "0x60190CB")]
		[Address(RVA = "0x36BDDE4", Offset = "0x36BDDE4", VA = "0x36BDDE4")]
		set
		{
		}
	}

	[Token(Token = "0x17001AD0")]
	public AkChannelConfig channelConfig
	{
		[Token(Token = "0x60190CE")]
		[Address(RVA = "0x36BDF9C", Offset = "0x36BDF9C", VA = "0x36BDF9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60190CD")]
		[Address(RVA = "0x36BDEFC", Offset = "0x36BDEFC", VA = "0x36BDEFC")]
		set
		{
		}
	}

	[Token(Token = "0x60190BD")]
	[Address(RVA = "0x36AF3F0", Offset = "0x36AF3F0", VA = "0x36AF3F0")]
	internal AkOutputSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60190BE")]
	[Address(RVA = "0x36BD660", Offset = "0x36BD660", VA = "0x36BD660")]
	public AkOutputSettings()
	{
	}

	[Token(Token = "0x60190BF")]
	[Address(RVA = "0x36BD6FC", Offset = "0x36BD6FC", VA = "0x36BD6FC")]
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning)
	{
	}

	[Token(Token = "0x60190C0")]
	[Address(RVA = "0x36BD7D4", Offset = "0x36BD7D4", VA = "0x36BD7D4")]
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig)
	{
	}

	[Token(Token = "0x60190C1")]
	[Address(RVA = "0x36BD898", Offset = "0x36BD898", VA = "0x36BD898")]
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice)
	{
	}

	[Token(Token = "0x60190C2")]
	[Address(RVA = "0x36BD944", Offset = "0x36BD944", VA = "0x36BD944")]
	public AkOutputSettings(string in_szDeviceShareSet)
	{
	}

	[Token(Token = "0x60190C3")]
	[Address(RVA = "0x36AF2C4", Offset = "0x36AF2C4", VA = "0x36AF2C4")]
	internal static IntPtr getCPtr(AkOutputSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60190C4")]
	[Address(RVA = "0x36BD9E8", Offset = "0x36BD9E8", VA = "0x36BD9E8", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60190C5")]
	[Address(RVA = "0x36BDA14", Offset = "0x36BDA14", VA = "0x36BDA14", Slot = "1")]
	~AkOutputSettings()
	{
	}

	[Token(Token = "0x60190C6")]
	[Address(RVA = "0x36BDA88", Offset = "0x36BDA88", VA = "0x36BDA88", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
