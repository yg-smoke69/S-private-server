using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003DA0")]
public class AkReflectionPathInfo : _Attribute
{
	[Token(Token = "0x401A30D")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A30E")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001AEB")]
	public AkVector imageSource
	{
		[Token(Token = "0x6019153")]
		[Address(RVA = "0x36C52A8", Offset = "0x36C52A8", VA = "0x36C52A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019152")]
		[Address(RVA = "0x36C5208", Offset = "0x36C5208", VA = "0x36C5208")]
		set
		{
		}
	}

	[Token(Token = "0x17001AEC")]
	public uint numPathPoints
	{
		[Token(Token = "0x6019155")]
		[Address(RVA = "0x36C5408", Offset = "0x36C5408", VA = "0x36C5408")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6019154")]
		[Address(RVA = "0x36C5378", Offset = "0x36C5378", VA = "0x36C5378")]
		set
		{
		}
	}

	[Token(Token = "0x17001AED")]
	public uint numReflections
	{
		[Token(Token = "0x6019157")]
		[Address(RVA = "0x36C5520", Offset = "0x36C5520", VA = "0x36C5520")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6019156")]
		[Address(RVA = "0x36C5490", Offset = "0x36C5490", VA = "0x36C5490")]
		set
		{
		}
	}

	[Token(Token = "0x17001AEE")]
	public float level
	{
		[Token(Token = "0x6019159")]
		[Address(RVA = "0x36C5638", Offset = "0x36C5638", VA = "0x36C5638")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019158")]
		[Address(RVA = "0x36C55A8", Offset = "0x36C55A8", VA = "0x36C55A8")]
		set
		{
		}
	}

	[Token(Token = "0x17001AEF")]
	public bool isOccluded
	{
		[Token(Token = "0x601915B")]
		[Address(RVA = "0x36C5750", Offset = "0x36C5750", VA = "0x36C5750")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601915A")]
		[Address(RVA = "0x36C56C0", Offset = "0x36C56C0", VA = "0x36C56C0")]
		set
		{
		}
	}

	[Token(Token = "0x601914C")]
	[Address(RVA = "0x36C4F20", Offset = "0x36C4F20", VA = "0x36C4F20")]
	internal AkReflectionPathInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x601914D")]
	[Address(RVA = "0x36C4F48", Offset = "0x36C4F48", VA = "0x36C4F48")]
	public AkReflectionPathInfo()
	{
	}

	[Token(Token = "0x601914E")]
	[Address(RVA = "0x36C4FE4", Offset = "0x36C4FE4", VA = "0x36C4FE4")]
	internal static IntPtr getCPtr(AkReflectionPathInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x601914F")]
	[Address(RVA = "0x36C503C", Offset = "0x36C503C", VA = "0x36C503C", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6019150")]
	[Address(RVA = "0x36C5068", Offset = "0x36C5068", VA = "0x36C5068", Slot = "1")]
	~AkReflectionPathInfo()
	{
	}

	[Token(Token = "0x6019151")]
	[Address(RVA = "0x36C50DC", Offset = "0x36C50DC", VA = "0x36C50DC", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x601915C")]
	[Address(RVA = "0x36C57D8", Offset = "0x36C57D8", VA = "0x36C57D8")]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[Token(Token = "0x601915D")]
	[Address(RVA = "0x36C5854", Offset = "0x36C5854", VA = "0x36C5854")]
	public AkVector GetPathPoint(uint idx)
	{
		return null;
	}

	[Token(Token = "0x601915E")]
	[Address(RVA = "0x36C592C", Offset = "0x36C592C", VA = "0x36C592C")]
	public AkAcousticSurface GetAcousticSurface(uint idx)
	{
		return null;
	}

	[Token(Token = "0x601915F")]
	[Address(RVA = "0x36C59EC", Offset = "0x36C59EC", VA = "0x36C59EC")]
	public float GetDiffraction(uint idx)
	{
		return default(float);
	}

	[Token(Token = "0x6019160")]
	[Address(RVA = "0x36C5A7C", Offset = "0x36C5A7C", VA = "0x36C5A7C")]
	public void Clone(AkReflectionPathInfo other)
	{
	}
}
