using System;
using System.Collections.Generic;
using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E1B")]
public class AkEvent : AkDragDropTriggerHandler
{
	[Serializable]
	[Token(Token = "0x2003E1C")]
	public class CallbackData
	{
		[Token(Token = "0x401A4DF")]
		[FieldOffset(Offset = "0x8")]
		public CallbackFlags Flags;

		[Token(Token = "0x401A4E0")]
		[FieldOffset(Offset = "0xC")]
		public string FunctionName;

		[Token(Token = "0x401A4E1")]
		[FieldOffset(Offset = "0x10")]
		public GameObject GameObject;

		[Token(Token = "0x601940B")]
		[Address(RVA = "0x35D62F4", Offset = "0x35D62F4", VA = "0x35D62F4")]
		public CallbackData()
		{
		}

		[Token(Token = "0x601940C")]
		[Address(RVA = "0x35D60F0", Offset = "0x35D60F0", VA = "0x35D60F0")]
		public void CallFunction(AkEventCallbackMsg eventCallbackMsg)
		{
		}
	}

	[Token(Token = "0x401A4D2")]
	[FieldOffset(Offset = "0x18")]
	public AkActionOnEventType actionOnEventType;

	[Token(Token = "0x401A4D3")]
	[FieldOffset(Offset = "0x1C")]
	public AkCurveInterpolation curveInterpolation;

	[Token(Token = "0x401A4D4")]
	[FieldOffset(Offset = "0x20")]
	public bool enableActionOnEvent;

	[Token(Token = "0x401A4D5")]
	[FieldOffset(Offset = "0x24")]
	public Event data;

	[Token(Token = "0x401A4D6")]
	[FieldOffset(Offset = "0x28")]
	public bool useCallbacks;

	[Token(Token = "0x401A4D7")]
	[FieldOffset(Offset = "0x2C")]
	public List<CallbackData> Callbacks;

	[Token(Token = "0x401A4D8")]
	[FieldOffset(Offset = "0x30")]
	public uint playingId;

	[Token(Token = "0x401A4D9")]
	[FieldOffset(Offset = "0x34")]
	public GameObject soundEmitterObject;

	[Token(Token = "0x401A4DA")]
	[FieldOffset(Offset = "0x38")]
	public float transitionDuration;

	[Token(Token = "0x401A4DB")]
	[FieldOffset(Offset = "0x3C")]
	private AkEventCallbackMsg EventCallbackMsg;

	[Token(Token = "0x401A4DC")]
	[FieldOffset(Offset = "0x40")]
	private int eventIdInternal;

	[Token(Token = "0x401A4DD")]
	[FieldOffset(Offset = "0x44")]
	private byte[] valueGuidInternal;

	[Token(Token = "0x401A4DE")]
	[FieldOffset(Offset = "0x48")]
	private AkEventCallbackData m_callbackDataInternal;

	[Token(Token = "0x17001B82")]
	protected override BaseType WwiseType
	{
		[Token(Token = "0x6019402")]
		[Address(RVA = "0x35D5FC8", Offset = "0x35D5FC8", VA = "0x35D5FC8", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B83")]
	public int eventID
	{
		[Token(Token = "0x6019408")]
		[Address(RVA = "0x35D623C", Offset = "0x35D623C", VA = "0x35D623C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B84")]
	public byte[] valueGuid
	{
		[Token(Token = "0x6019409")]
		[Address(RVA = "0x35D6250", Offset = "0x35D6250", VA = "0x35D6250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B85")]
	public AkEventCallbackData m_callbackData
	{
		[Token(Token = "0x601940A")]
		[Address(RVA = "0x35D62EC", Offset = "0x35D62EC", VA = "0x35D62EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019401")]
	[Address(RVA = "0x35BF0C0", Offset = "0x35BF0C0", VA = "0x35BF0C0")]
	public AkEvent()
	{
	}

	[Token(Token = "0x6019403")]
	[Address(RVA = "0x35BFA94", Offset = "0x35BFA94", VA = "0x35BFA94", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6019404")]
	[Address(RVA = "0x35D5FD8", Offset = "0x35D5FD8", VA = "0x35D5FD8")]
	private void Callback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	[Token(Token = "0x6019405")]
	[Address(RVA = "0x35C0434", Offset = "0x35C0434", VA = "0x35C0434", Slot = "4")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[Token(Token = "0x6019406")]
	[Address(RVA = "0x35D61E8", Offset = "0x35D61E8", VA = "0x35D61E8")]
	public void Stop(int _transitionDuration)
	{
	}

	[Token(Token = "0x6019407")]
	[Address(RVA = "0x35D61F0", Offset = "0x35D61F0", VA = "0x35D61F0")]
	public void Stop(int _transitionDuration, AkCurveInterpolation _curveInterpolation)
	{
	}
}
