using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace AK.Wwise;

[Serializable]
[Token(Token = "0x2003DFF")]
public class Event : BaseType
{
	[Token(Token = "0x401A47E")]
	[FieldOffset(Offset = "0x10")]
	public WwiseEventReference WwiseObjectReference;

	[Token(Token = "0x17001B6A")]
	public override WwiseObjectReference ObjectReference
	{
		[Token(Token = "0x601938D")]
		[Address(RVA = "0x35BCFE0", Offset = "0x35BCFE0", VA = "0x35BCFE0", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601938E")]
		[Address(RVA = "0x35BCFE8", Offset = "0x35BCFE8", VA = "0x35BCFE8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17001B6B")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x601938F")]
		[Address(RVA = "0x35BD084", Offset = "0x35BD084", VA = "0x35BD084", Slot = "6")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x601938C")]
	[Address(RVA = "0x35BCFD8", Offset = "0x35BCFD8", VA = "0x35BCFD8")]
	public Event()
	{
	}

	[Token(Token = "0x6019390")]
	[Address(RVA = "0x35BD08C", Offset = "0x35BD08C", VA = "0x35BD08C")]
	private void VerifyPlayingID(uint playingId)
	{
	}

	[Token(Token = "0x6019391")]
	[Address(RVA = "0x35BD090", Offset = "0x35BD090", VA = "0x35BD090")]
	public uint Post(GameObject gameObject)
	{
		return default(uint);
	}

	[Token(Token = "0x6019392")]
	[Address(RVA = "0x35BD148", Offset = "0x35BD148", VA = "0x35BD148")]
	public uint Post(GameObject gameObject, CallbackFlags flags, AkCallbackManager.EventCallback callback, [Optional] object cookie)
	{
		return default(uint);
	}

	[Token(Token = "0x6019393")]
	[Address(RVA = "0x35BD240", Offset = "0x35BD240", VA = "0x35BD240")]
	public uint Post(GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, [Optional] object cookie)
	{
		return default(uint);
	}

	[Token(Token = "0x6019394")]
	[Address(RVA = "0x35BD324", Offset = "0x35BD324", VA = "0x35BD324")]
	public void Stop(GameObject gameObject, int transitionDuration = 0, AkCurveInterpolation curveInterpolation = AkCurveInterpolation.AkCurveInterpolation_Linear)
	{
	}

	[Token(Token = "0x6019395")]
	[Address(RVA = "0x35BD34C", Offset = "0x35BD34C", VA = "0x35BD34C")]
	public void ExecuteAction(GameObject gameObject, AkActionOnEventType actionOnEventType, int transitionDuration, AkCurveInterpolation curveInterpolation)
	{
	}

	[Token(Token = "0x6019396")]
	[Address(RVA = "0x35BD424", Offset = "0x35BD424", VA = "0x35BD424")]
	public void PostMIDI(GameObject gameObject, AkMIDIPostArray array)
	{
	}

	[Token(Token = "0x6019397")]
	[Address(RVA = "0x35BD488", Offset = "0x35BD488", VA = "0x35BD488")]
	public void PostMIDI(GameObject gameObject, AkMIDIPostArray array, int count)
	{
	}

	[Token(Token = "0x6019398")]
	[Address(RVA = "0x35BD500", Offset = "0x35BD500", VA = "0x35BD500")]
	public void StopMIDI(GameObject gameObject)
	{
	}

	[Token(Token = "0x6019399")]
	[Address(RVA = "0x35BD5B4", Offset = "0x35BD5B4", VA = "0x35BD5B4")]
	public void StopMIDI()
	{
	}
}
