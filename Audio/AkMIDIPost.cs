using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D8B")]
public class AkMIDIPost : AkMIDIEvent
{
	[Token(Token = "0x401A278")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr swigCPtr;

	[Token(Token = "0x17001AB1")]
	public uint uOffset
	{
		[Token(Token = "0x601906E")]
		[Address(RVA = "0x36B77A4", Offset = "0x36B77A4", VA = "0x36B77A4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601906D")]
		[Address(RVA = "0x36B7714", Offset = "0x36B7714", VA = "0x36B7714")]
		set
		{
		}
	}

	[Token(Token = "0x6019067")]
	[Address(RVA = "0x36B733C", Offset = "0x36B733C", VA = "0x36B733C")]
	internal AkMIDIPost(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6019068")]
	[Address(RVA = "0x36B73E4", Offset = "0x36B73E4", VA = "0x36B73E4")]
	public AkMIDIPost()
	{
	}

	[Token(Token = "0x6019069")]
	[Address(RVA = "0x36B7474", Offset = "0x36B7474", VA = "0x36B7474")]
	internal static IntPtr getCPtr(AkMIDIPost obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x601906A")]
	[Address(RVA = "0x36B74CC", Offset = "0x36B74CC", VA = "0x36B74CC", Slot = "5")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x601906B")]
	[Address(RVA = "0x36B7574", Offset = "0x36B7574", VA = "0x36B7574", Slot = "1")]
	~AkMIDIPost()
	{
	}

	[Token(Token = "0x601906C")]
	[Address(RVA = "0x36B75E0", Offset = "0x36B75E0", VA = "0x36B75E0", Slot = "6")]
	public override void Dispose()
	{
	}

	[Token(Token = "0x601906F")]
	[Address(RVA = "0x36B782C", Offset = "0x36B782C", VA = "0x36B782C")]
	public AKRESULT PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6019070")]
	[Address(RVA = "0x36B7A70", Offset = "0x36B7A70", VA = "0x36B7A70")]
	public void Clone(AkMIDIPost other)
	{
	}

	[Token(Token = "0x6019071")]
	[Address(RVA = "0x36B7B48", Offset = "0x36B7B48", VA = "0x36B7B48")]
	public static int GetSizeOf()
	{
		return default(int);
	}
}
