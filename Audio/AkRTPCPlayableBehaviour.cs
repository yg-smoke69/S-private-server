using System;
using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
[Token(Token = "0x2003E34")]
public class AkRTPCPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x401A564")]
	[FieldOffset(Offset = "0x8")]
	private float RTPCValue;

	[Token(Token = "0x401A565")]
	[FieldOffset(Offset = "0xC")]
	private bool _003CsetRTPCGlobally_003Ek__BackingField;

	[Token(Token = "0x401A566")]
	[FieldOffset(Offset = "0xD")]
	private bool _003CoverrideTrackObject_003Ek__BackingField;

	[Token(Token = "0x401A567")]
	[FieldOffset(Offset = "0x10")]
	private GameObject _003CrtpcObject_003Ek__BackingField;

	[Token(Token = "0x401A568")]
	[FieldOffset(Offset = "0x14")]
	private RTPC _003Cparameter_003Ek__BackingField;

	[Token(Token = "0x17001B95")]
	public bool setRTPCGlobally
	{
		[Token(Token = "0x60194A0")]
		[Address(RVA = "0x36C3DC8", Offset = "0x36C3DC8", VA = "0x36C3DC8")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x601949F")]
		[Address(RVA = "0x36C3DB0", Offset = "0x36C3DB0", VA = "0x36C3DB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001B96")]
	public bool overrideTrackObject
	{
		[Token(Token = "0x60194A2")]
		[Address(RVA = "0x36C3DD0", Offset = "0x36C3DD0", VA = "0x36C3DD0")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x60194A1")]
		[Address(RVA = "0x36C3DA8", Offset = "0x36C3DA8", VA = "0x36C3DA8")]
		set
		{
		}
	}

	[Token(Token = "0x17001B97")]
	public GameObject rtpcObject
	{
		[Token(Token = "0x60194A4")]
		[Address(RVA = "0x36C3DD8", Offset = "0x36C3DD8", VA = "0x36C3DD8")]
		private get
		{
			return null;
		}
		[Token(Token = "0x60194A3")]
		[Address(RVA = "0x36C3DB8", Offset = "0x36C3DB8", VA = "0x36C3DB8")]
		set
		{
		}
	}

	[Token(Token = "0x17001B98")]
	public RTPC parameter
	{
		[Token(Token = "0x60194A6")]
		[Address(RVA = "0x36C3DE0", Offset = "0x36C3DE0", VA = "0x36C3DE0")]
		private get
		{
			return null;
		}
		[Token(Token = "0x60194A5")]
		[Address(RVA = "0x36C3DC0", Offset = "0x36C3DC0", VA = "0x36C3DC0")]
		set
		{
		}
	}

	[Token(Token = "0x601949E")]
	[Address(RVA = "0x36C3BB8", Offset = "0x36C3BB8", VA = "0x36C3BB8")]
	public AkRTPCPlayableBehaviour()
	{
	}

	[Token(Token = "0x60194A7")]
	[Address(RVA = "0x36C3DE8", Offset = "0x36C3DE8", VA = "0x36C3DE8", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}
}
