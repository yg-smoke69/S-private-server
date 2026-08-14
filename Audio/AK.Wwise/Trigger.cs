using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AK.Wwise;

[Serializable]
[Token(Token = "0x2003E03")]
public class Trigger : BaseType
{
	[Token(Token = "0x401A482")]
	[FieldOffset(Offset = "0x10")]
	public WwiseTriggerReference WwiseObjectReference;

	[Token(Token = "0x17001B74")]
	public override WwiseObjectReference ObjectReference
	{
		[Token(Token = "0x60193AF")]
		[Address(RVA = "0x35BDCC0", Offset = "0x35BDCC0", VA = "0x35BDCC0", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60193B0")]
		[Address(RVA = "0x35BDCC8", Offset = "0x35BDCC8", VA = "0x35BDCC8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17001B75")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x60193B1")]
		[Address(RVA = "0x35BDD64", Offset = "0x35BDD64", VA = "0x35BDD64", Slot = "6")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x60193AE")]
	[Address(RVA = "0x35BDCB8", Offset = "0x35BDCB8", VA = "0x35BDCB8")]
	public Trigger()
	{
	}

	[Token(Token = "0x60193B2")]
	[Address(RVA = "0x35BDD6C", Offset = "0x35BDD6C", VA = "0x35BDD6C")]
	public void Post(GameObject gameObject)
	{
	}
}
