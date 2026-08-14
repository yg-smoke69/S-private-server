using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D66")]
public class AkChannelConfig : _Attribute
{
	[Token(Token = "0x401A1A0")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1A1")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A2D")]
	public uint uNumChannels
	{
		[Token(Token = "0x6018ECC")]
		[Address(RVA = "0x35CE4EC", Offset = "0x35CE4EC", VA = "0x35CE4EC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018ECB")]
		[Address(RVA = "0x35CE45C", Offset = "0x35CE45C", VA = "0x35CE45C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A2E")]
	public uint eConfigType
	{
		[Token(Token = "0x6018ECE")]
		[Address(RVA = "0x35CE604", Offset = "0x35CE604", VA = "0x35CE604")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018ECD")]
		[Address(RVA = "0x35CE574", Offset = "0x35CE574", VA = "0x35CE574")]
		set
		{
		}
	}

	[Token(Token = "0x17001A2F")]
	public uint uChannelMask
	{
		[Token(Token = "0x6018ED0")]
		[Address(RVA = "0x35CE71C", Offset = "0x35CE71C", VA = "0x35CE71C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018ECF")]
		[Address(RVA = "0x35CE68C", Offset = "0x35CE68C", VA = "0x35CE68C")]
		set
		{
		}
	}

	[Token(Token = "0x6018EC4")]
	[Address(RVA = "0x35C14B0", Offset = "0x35C14B0", VA = "0x35C14B0")]
	internal AkChannelConfig(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018EC5")]
	[Address(RVA = "0x35CE148", Offset = "0x35CE148", VA = "0x35CE148")]
	public AkChannelConfig()
	{
	}

	[Token(Token = "0x6018EC6")]
	[Address(RVA = "0x35CE1E4", Offset = "0x35CE1E4", VA = "0x35CE1E4")]
	public AkChannelConfig(uint in_uNumChannels, uint in_uChannelMask)
	{
	}

	[Token(Token = "0x6018EC7")]
	[Address(RVA = "0x35C1384", Offset = "0x35C1384", VA = "0x35C1384")]
	internal static IntPtr getCPtr(AkChannelConfig obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018EC8")]
	[Address(RVA = "0x35CE290", Offset = "0x35CE290", VA = "0x35CE290", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018EC9")]
	[Address(RVA = "0x35CE2BC", Offset = "0x35CE2BC", VA = "0x35CE2BC", Slot = "1")]
	~AkChannelConfig()
	{
	}

	[Token(Token = "0x6018ECA")]
	[Address(RVA = "0x35CE330", Offset = "0x35CE330", VA = "0x35CE330", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6018ED1")]
	[Address(RVA = "0x35CE7A4", Offset = "0x35CE7A4", VA = "0x35CE7A4")]
	public void Clear()
	{
	}

	[Token(Token = "0x6018ED2")]
	[Address(RVA = "0x35CE82C", Offset = "0x35CE82C", VA = "0x35CE82C")]
	public void SetStandard(uint in_uChannelMask)
	{
	}

	[Token(Token = "0x6018ED3")]
	[Address(RVA = "0x35CE8BC", Offset = "0x35CE8BC", VA = "0x35CE8BC")]
	public void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask)
	{
	}

	[Token(Token = "0x6018ED4")]
	[Address(RVA = "0x35CE954", Offset = "0x35CE954", VA = "0x35CE954")]
	public void SetAnonymous(uint in_uNumChannels)
	{
	}

	[Token(Token = "0x6018ED5")]
	[Address(RVA = "0x35CE9E4", Offset = "0x35CE9E4", VA = "0x35CE9E4")]
	public void SetAmbisonic(uint in_uNumChannels)
	{
	}

	[Token(Token = "0x6018ED6")]
	[Address(RVA = "0x35CEA74", Offset = "0x35CEA74", VA = "0x35CEA74")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6018ED7")]
	[Address(RVA = "0x35CEAFC", Offset = "0x35CEAFC", VA = "0x35CEAFC")]
	public uint Serialize()
	{
		return default(uint);
	}

	[Token(Token = "0x6018ED8")]
	[Address(RVA = "0x35CEB84", Offset = "0x35CEB84", VA = "0x35CEB84")]
	public void Deserialize(uint in_uChannelConfig)
	{
	}

	[Token(Token = "0x6018ED9")]
	[Address(RVA = "0x35CEC14", Offset = "0x35CEC14", VA = "0x35CEC14")]
	public AkChannelConfig RemoveLFE()
	{
		return null;
	}

	[Token(Token = "0x6018EDA")]
	[Address(RVA = "0x35CECD0", Offset = "0x35CECD0", VA = "0x35CECD0")]
	public AkChannelConfig RemoveCenter()
	{
		return null;
	}

	[Token(Token = "0x6018EDB")]
	[Address(RVA = "0x35CED8C", Offset = "0x35CED8C", VA = "0x35CED8C")]
	public bool IsChannelConfigSupported()
	{
		return default(bool);
	}
}
