using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D72")]
public class AkEmitterSettings : _Attribute
{
	[Token(Token = "0x401A1CA")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1CB")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A4A")]
	public uint reflectAuxBusID
	{
		[Token(Token = "0x6018F32")]
		[Address(RVA = "0x35D49D8", Offset = "0x35D49D8", VA = "0x35D49D8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F31")]
		[Address(RVA = "0x35D4948", Offset = "0x35D4948", VA = "0x35D4948")]
		set
		{
		}
	}

	[Token(Token = "0x17001A4B")]
	public float reflectionMaxPathLength
	{
		[Token(Token = "0x6018F34")]
		[Address(RVA = "0x35D4AF0", Offset = "0x35D4AF0", VA = "0x35D4AF0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018F33")]
		[Address(RVA = "0x35D4A60", Offset = "0x35D4A60", VA = "0x35D4A60")]
		set
		{
		}
	}

	[Token(Token = "0x17001A4C")]
	public float reflectionsAuxBusGain
	{
		[Token(Token = "0x6018F36")]
		[Address(RVA = "0x35D4C08", Offset = "0x35D4C08", VA = "0x35D4C08")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018F35")]
		[Address(RVA = "0x35D4B78", Offset = "0x35D4B78", VA = "0x35D4B78")]
		set
		{
		}
	}

	[Token(Token = "0x17001A4D")]
	public uint reflectionsOrder
	{
		[Token(Token = "0x6018F38")]
		[Address(RVA = "0x35D4D20", Offset = "0x35D4D20", VA = "0x35D4D20")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F37")]
		[Address(RVA = "0x35D4C90", Offset = "0x35D4C90", VA = "0x35D4C90")]
		set
		{
		}
	}

	[Token(Token = "0x17001A4E")]
	public uint reflectorFilterMask
	{
		[Token(Token = "0x6018F3A")]
		[Address(RVA = "0x35D4E38", Offset = "0x35D4E38", VA = "0x35D4E38")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F39")]
		[Address(RVA = "0x35D4DA8", Offset = "0x35D4DA8", VA = "0x35D4DA8")]
		set
		{
		}
	}

	[Token(Token = "0x17001A4F")]
	public float roomReverbAuxBusGain
	{
		[Token(Token = "0x6018F3C")]
		[Address(RVA = "0x35D4F50", Offset = "0x35D4F50", VA = "0x35D4F50")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018F3B")]
		[Address(RVA = "0x35D4EC0", Offset = "0x35D4EC0", VA = "0x35D4EC0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A50")]
	public uint diffractionMaxEdges
	{
		[Token(Token = "0x6018F3E")]
		[Address(RVA = "0x35D5068", Offset = "0x35D5068", VA = "0x35D5068")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F3D")]
		[Address(RVA = "0x35D4FD8", Offset = "0x35D4FD8", VA = "0x35D4FD8")]
		set
		{
		}
	}

	[Token(Token = "0x17001A51")]
	public uint diffractionMaxPaths
	{
		[Token(Token = "0x6018F40")]
		[Address(RVA = "0x35D5180", Offset = "0x35D5180", VA = "0x35D5180")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F3F")]
		[Address(RVA = "0x35D50F0", Offset = "0x35D50F0", VA = "0x35D50F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A52")]
	public float diffractionMaxPathLength
	{
		[Token(Token = "0x6018F42")]
		[Address(RVA = "0x35D5298", Offset = "0x35D5298", VA = "0x35D5298")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018F41")]
		[Address(RVA = "0x35D5208", Offset = "0x35D5208", VA = "0x35D5208")]
		set
		{
		}
	}

	[Token(Token = "0x17001A53")]
	public byte useImageSources
	{
		[Token(Token = "0x6018F44")]
		[Address(RVA = "0x35D53B0", Offset = "0x35D53B0", VA = "0x35D53B0")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6018F43")]
		[Address(RVA = "0x35D5320", Offset = "0x35D5320", VA = "0x35D5320")]
		set
		{
		}
	}

	[Token(Token = "0x6018F2B")]
	[Address(RVA = "0x35D4660", Offset = "0x35D4660", VA = "0x35D4660")]
	internal AkEmitterSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018F2C")]
	[Address(RVA = "0x35D4688", Offset = "0x35D4688", VA = "0x35D4688")]
	public AkEmitterSettings()
	{
	}

	[Token(Token = "0x6018F2D")]
	[Address(RVA = "0x35D4724", Offset = "0x35D4724", VA = "0x35D4724")]
	internal static IntPtr getCPtr(AkEmitterSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018F2E")]
	[Address(RVA = "0x35D477C", Offset = "0x35D477C", VA = "0x35D477C", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018F2F")]
	[Address(RVA = "0x35D47A8", Offset = "0x35D47A8", VA = "0x35D47A8", Slot = "1")]
	~AkEmitterSettings()
	{
	}

	[Token(Token = "0x6018F30")]
	[Address(RVA = "0x35D481C", Offset = "0x35D481C", VA = "0x35D481C", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
