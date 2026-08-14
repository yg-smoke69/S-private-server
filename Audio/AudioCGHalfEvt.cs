using System;
using System.Collections.Generic;
using COW;
using Il2CppDummyDll;

[Token(Token = "0x2002D58")]
public class AudioCGHalfEvt : AnimAudioEvt
{
	[Token(Token = "0x2002D59")]
	public enum e_PlayStep
	{
		[Token(Token = "0x4011654")]
		start,
		[Token(Token = "0x4011655")]
		end
	}

	[Token(Token = "0x2002D5A")]
	public enum e_AudioCGHalfFunc
	{
		[Token(Token = "0x4011657")]
		PlayAnimAudioBackGroundEvt,
		[Token(Token = "0x4011658")]
		PlayAnimAudioLoopBackGroundEvt,
		[Token(Token = "0x4011659")]
		PlayAnimOneShotEvt,
		[Token(Token = "0x401165A")]
		StopEvtShot,
		[Token(Token = "0x401165B")]
		PlayAnimOnlyOneShotEvt,
		[Token(Token = "0x401165C")]
		ResumeAudioVolume,
		[Token(Token = "0x401165D")]
		ReduceAudioVolume,
		[Token(Token = "0x401165E")]
		DispatchAnimEvent
	}

	[Serializable]
	[Token(Token = "0x2002D5B")]
	public class AudioCGHalfEvtData
	{
		[Token(Token = "0x401165F")]
		[FieldOffset(Offset = "0x8")]
		public e_PlayStep E_PlayStep;

		[Token(Token = "0x4011660")]
		[FieldOffset(Offset = "0xC")]
		public e_AudioCGHalfFunc E_AudioFunc;

		[Token(Token = "0x4011661")]
		[FieldOffset(Offset = "0x10")]
		public float FloatParam;

		[Token(Token = "0x4011662")]
		[FieldOffset(Offset = "0x14")]
		public string StrParam;

		[Token(Token = "0x6012F9E")]
		[Address(RVA = "0x2ECDFDC", Offset = "0x2ECDFDC", VA = "0x2ECDFDC")]
		public AudioCGHalfEvtData()
		{
		}
	}

	[Token(Token = "0x4011652")]
	[FieldOffset(Offset = "0x1C")]
	private List<AudioCGHalfEvtData> m_eventDatas;

	[Token(Token = "0x6012F99")]
	[Address(RVA = "0x2ECD98C", Offset = "0x2ECD98C", VA = "0x2ECD98C")]
	public AudioCGHalfEvt()
	{
	}

	[Token(Token = "0x6012F9A")]
	[Address(RVA = "0x2ECD994", Offset = "0x2ECD994", VA = "0x2ECD994")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6012F9B")]
	[Address(RVA = "0x2ECDBC8", Offset = "0x2ECDBC8", VA = "0x2ECDBC8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6012F9C")]
	[Address(RVA = "0x2ECDD5C", Offset = "0x2ECDD5C", VA = "0x2ECDD5C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6012F9D")]
	[Address(RVA = "0x2ECDB28", Offset = "0x2ECDB28", VA = "0x2ECDB28")]
	private void ToDoFunc(AudioCGHalfEvtData data)
	{
	}
}
