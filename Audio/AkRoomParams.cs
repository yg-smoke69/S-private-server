using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003DA2")]
public class AkRoomParams : _Attribute
{
	[Token(Token = "0x401A34F")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A350")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001AF0")]
	public AkVector Up
	{
		[Token(Token = "0x6019168")]
		[Address(RVA = "0x36C65A0", Offset = "0x36C65A0", VA = "0x36C65A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019167")]
		[Address(RVA = "0x36C7B98", Offset = "0x36C7B98", VA = "0x36C7B98")]
		set
		{
		}
	}

	[Token(Token = "0x17001AF1")]
	public AkVector Front
	{
		[Token(Token = "0x601916A")]
		[Address(RVA = "0x36C6670", Offset = "0x36C6670", VA = "0x36C6670")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019169")]
		[Address(RVA = "0x36C7C38", Offset = "0x36C7C38", VA = "0x36C7C38")]
		set
		{
		}
	}

	[Token(Token = "0x17001AF2")]
	public uint ReverbAuxBus
	{
		[Token(Token = "0x601916C")]
		[Address(RVA = "0x36C7CD8", Offset = "0x36C7CD8", VA = "0x36C7CD8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601916B")]
		[Address(RVA = "0x36C6740", Offset = "0x36C6740", VA = "0x36C6740")]
		set
		{
		}
	}

	[Token(Token = "0x17001AF3")]
	public float ReverbLevel
	{
		[Token(Token = "0x601916E")]
		[Address(RVA = "0x36C7D60", Offset = "0x36C7D60", VA = "0x36C7D60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601916D")]
		[Address(RVA = "0x36C67D0", Offset = "0x36C67D0", VA = "0x36C67D0")]
		set
		{
		}
	}

	[Token(Token = "0x17001AF4")]
	public float WallOcclusion
	{
		[Token(Token = "0x6019170")]
		[Address(RVA = "0x36C7DE8", Offset = "0x36C7DE8", VA = "0x36C7DE8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601916F")]
		[Address(RVA = "0x36C6860", Offset = "0x36C6860", VA = "0x36C6860")]
		set
		{
		}
	}

	[Token(Token = "0x17001AF5")]
	public float RoomGameObj_AuxSendLevelToSelf
	{
		[Token(Token = "0x6019172")]
		[Address(RVA = "0x36C7E70", Offset = "0x36C7E70", VA = "0x36C7E70")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019171")]
		[Address(RVA = "0x36C68F0", Offset = "0x36C68F0", VA = "0x36C68F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001AF6")]
	public bool RoomGameObj_KeepRegistered
	{
		[Token(Token = "0x6019174")]
		[Address(RVA = "0x36C7EF8", Offset = "0x36C7EF8", VA = "0x36C7EF8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6019173")]
		[Address(RVA = "0x36C6980", Offset = "0x36C6980", VA = "0x36C6980")]
		set
		{
		}
	}

	[Token(Token = "0x6019161")]
	[Address(RVA = "0x36C794C", Offset = "0x36C794C", VA = "0x36C794C")]
	internal AkRoomParams(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6019162")]
	[Address(RVA = "0x36C6504", Offset = "0x36C6504", VA = "0x36C6504")]
	public AkRoomParams()
	{
	}

	[Token(Token = "0x6019163")]
	[Address(RVA = "0x36C7974", Offset = "0x36C7974", VA = "0x36C7974")]
	internal static IntPtr getCPtr(AkRoomParams obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6019164")]
	[Address(RVA = "0x36C79CC", Offset = "0x36C79CC", VA = "0x36C79CC", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6019165")]
	[Address(RVA = "0x36C79F8", Offset = "0x36C79F8", VA = "0x36C79F8", Slot = "1")]
	~AkRoomParams()
	{
	}

	[Token(Token = "0x6019166")]
	[Address(RVA = "0x36C7A6C", Offset = "0x36C7A6C", VA = "0x36C7A6C", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
