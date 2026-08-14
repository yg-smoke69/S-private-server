using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AK.Wwise;

[Serializable]
[Token(Token = "0x2003E00")]
public class RTPC : BaseType
{
	[Token(Token = "0x401A47F")]
	[FieldOffset(Offset = "0x10")]
	public WwiseRtpcReference WwiseObjectReference;

	[Token(Token = "0x17001B6C")]
	public override WwiseObjectReference ObjectReference
	{
		[Token(Token = "0x601939B")]
		[Address(RVA = "0x35BD668", Offset = "0x35BD668", VA = "0x35BD668", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601939C")]
		[Address(RVA = "0x35BD670", Offset = "0x35BD670", VA = "0x35BD670", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17001B6D")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x601939D")]
		[Address(RVA = "0x35BD70C", Offset = "0x35BD70C", VA = "0x35BD70C", Slot = "6")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x601939A")]
	[Address(RVA = "0x35BD660", Offset = "0x35BD660", VA = "0x35BD660")]
	public RTPC()
	{
	}

	[Token(Token = "0x601939E")]
	[Address(RVA = "0x35BD714", Offset = "0x35BD714", VA = "0x35BD714")]
	public void SetValue(GameObject gameObject, float value)
	{
	}

	[Token(Token = "0x601939F")]
	[Address(RVA = "0x35BD7D0", Offset = "0x35BD7D0", VA = "0x35BD7D0")]
	public float GetValue(GameObject gameObject)
	{
		return default(float);
	}

	[Token(Token = "0x60193A0")]
	[Address(RVA = "0x35BD904", Offset = "0x35BD904", VA = "0x35BD904")]
	public void SetGlobalValue(float value)
	{
	}

	[Token(Token = "0x60193A1")]
	[Address(RVA = "0x35BD9B8", Offset = "0x35BD9B8", VA = "0x35BD9B8")]
	public float GetGlobalValue()
	{
		return default(float);
	}
}
