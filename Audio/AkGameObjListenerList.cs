using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2003E24")]
public class AkGameObjListenerList : AkAudioListener.BaseListenerList
{
	[NonSerialized]
	[Token(Token = "0x401A523")]
	[FieldOffset(Offset = "0x10")]
	private AkGameObj akGameObj;

	[Token(Token = "0x401A524")]
	[FieldOffset(Offset = "0x14")]
	public List<AkAudioListener> initialListenerList;

	[Token(Token = "0x401A525")]
	[FieldOffset(Offset = "0x18")]
	public bool useDefaultListeners;

	[Token(Token = "0x601943F")]
	[Address(RVA = "0x35D9408", Offset = "0x35D9408", VA = "0x35D9408")]
	public AkGameObjListenerList()
	{
	}

	[Token(Token = "0x6019440")]
	[Address(RVA = "0x35DB2CC", Offset = "0x35DB2CC", VA = "0x35DB2CC")]
	public void SetUseDefaultListeners(bool useDefault)
	{
	}

	[Token(Token = "0x6019441")]
	[Address(RVA = "0x35D9E98", Offset = "0x35D9E98", VA = "0x35D9E98")]
	public void Init(AkGameObj akGameObj)
	{
	}

	[Token(Token = "0x6019442")]
	[Address(RVA = "0x35DB518", Offset = "0x35DB518", VA = "0x35DB518", Slot = "4")]
	public override bool Add(AkAudioListener listener)
	{
		return default(bool);
	}

	[Token(Token = "0x6019443")]
	[Address(RVA = "0x35DB640", Offset = "0x35DB640", VA = "0x35DB640", Slot = "5")]
	public override bool Remove(AkAudioListener listener)
	{
		return default(bool);
	}
}
