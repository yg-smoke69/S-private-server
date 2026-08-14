using System;
using System.Reflection;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.TimelineEvents;

[Serializable]
[Token(Token = "0x2000A4D")]
public class TimelineEventBehaviour : PlayableBehaviour
{
	[Token(Token = "0x2000A4E")]
	private sealed class _003CGetInvocationInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x4005BA4")]
		[FieldOffset(Offset = "0x8")]
		internal string methodName;

		[Token(Token = "0x4005BA5")]
		[FieldOffset(Offset = "0xC")]
		internal bool methodWitharg;

		[Token(Token = "0x600500A")]
		[Address(RVA = "0x28A8718", Offset = "0x28A8718", VA = "0x28A8718")]
		public _003CGetInvocationInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600500B")]
		[Address(RVA = "0x28A8D14", Offset = "0x28A8D14", VA = "0x28A8D14")]
		internal bool _003C_003Em__0(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4005B9D")]
	[FieldOffset(Offset = "0x8")]
	public string HandlerKey;

	[Token(Token = "0x4005B9E")]
	[FieldOffset(Offset = "0xC")]
	public bool IsMethodWithParam;

	[Token(Token = "0x4005B9F")]
	[FieldOffset(Offset = "0xD")]
	public bool InvokeEventsInEditMode;

	[Token(Token = "0x4005BA0")]
	[FieldOffset(Offset = "0x10")]
	public GameObject TargetObject;

	[Token(Token = "0x4005BA1")]
	[FieldOffset(Offset = "0x14")]
	public string ArgValue;

	[Token(Token = "0x4005BA2")]
	[FieldOffset(Offset = "0x18")]
	public EAnimAudioBusType AudioBus;

	[Token(Token = "0x4005BA3")]
	[FieldOffset(Offset = "0x1C")]
	private EventInvocationInfo invocationInfo;

	[Token(Token = "0x6005005")]
	[Address(RVA = "0x28A82F8", Offset = "0x28A82F8", VA = "0x28A82F8")]
	public TimelineEventBehaviour()
	{
	}

	[Token(Token = "0x6005006")]
	[Address(RVA = "0x28A8300", Offset = "0x28A8300", VA = "0x28A8300", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005007")]
	[Address(RVA = "0x28A83D4", Offset = "0x28A83D4", VA = "0x28A83D4")]
	private void UpdateDelegates()
	{
	}

	[Token(Token = "0x6005008")]
	[Address(RVA = "0x28A8428", Offset = "0x28A8428", VA = "0x28A8428")]
	private EventInvocationInfo GetInvocationInfo(bool isEnabled, string methodKey, EventInvocationInfo currentInfo, bool methodWitharg)
	{
		return null;
	}

	[Token(Token = "0x6005009")]
	[Address(RVA = "0x28A8720", Offset = "0x28A8720", VA = "0x28A8720")]
	private void GetBehaviourAndMethod(bool isEnabled, string key, ref Behaviour targetBehaviour, ref string methodName)
	{
	}
}
